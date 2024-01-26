using LabSharp11.Entities;
using LabSharp11.Simulation;
using LabSharp11.Store;
using LabSharp11.StoreWriters;
using LabSharp12.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSharp12.Windows
{
    public partial class CompanyWindow : Form
    {
        private SimulationStore _store;
        private JsonStoreWriter _jsonStoreWriter;
        private readonly CompanySimulator _simulator;
        public CompanyWindow()
        {
            _jsonStoreWriter = new JsonStoreWriter("./appconfig.json");
            InitializeComponent();
            Log.Init(new AppLogger(LogTB));
            _simulator = new CompanySimulator(new WorkerSimulator());
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            var store = _jsonStoreWriter.Restore();
            if (store == null)
            {
                CreateCompany();
            }
            else
            {
                _store = store;
                UpdateCompanyUI();
            }
        }

        private void UpdateCompanyUI()
        {
            CompanyNameLabel.Text = _store.Company.Name;
            DateLabel.Text = _store.Today.ToString("dd.MM.yyyy");
            DayOfWeekLabel.Text = DateTimeFormatInfo.CurrentInfo.GetDayName(_store.Today.DayOfWeek);
            UpdateWorkers();
        }

        private void UpdateWorkers()
        {
            (Worker Model, WorkerVm Vm)[] workerVms = _store.Company.Workers.Select(x => (x, WorkerVm.CreateFromEntity(x))).ToArray();
            WorkersDataGrid.Rows.Clear();
            for (int i = 0; i < workerVms.Length; i++)
            {
                WorkerVm worker = workerVms[i].Vm;
                WorkersDataGrid.Rows.Add();
                WorkersDataGrid[0, i].Value = worker.WorkerName;
                WorkersDataGrid[1, i].Value = worker.WorkerType;
                WorkersDataGrid[2, i].Value = worker.Description;
                WorkersDataGrid[3, i].Value = worker.CurrentSalary;
                WorkersDataGrid[4, i].Value = new DeleteButtonArgs("Удалить", workerVms[i].Model);
            }
        }

        private void CreateCompany()
        {
            var createCompanyWindow = new CreateCompanyWindow();
            this.Hide();
            createCompanyWindow.Show();
            createCompanyWindow.CompanyCreated += (_, company) =>
            {
                _store = new SimulationStore()
                {
                    Company = company,
                    Today = DateOnly.FromDateTime(DateTime.Now)
                };
                createCompanyWindow.Close();
                this.Show();
                UpdateCompanyUI();
            };
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            _jsonStoreWriter.Save(_store);
        }

        private void CreateHourlyWorker(object sender, EventArgs e)
        {
            var createForm = new CreateHourlyWorkerWindow();
            createForm.Show();
            createForm.WorkerCreated += (_, worker) =>
            {
                _store.Company.HireWorker(worker);
                UpdateCompanyUI();
                createForm.Hide();
            };
        }

        private void CreateComissionWorker(object sender, EventArgs e)
        {
            var createForm = new CreateComissionWorkerWindow();
            createForm.Show();
            createForm.WorkerCreated += (_, worker) =>
            {
                _store.Company.HireWorker(worker);
                UpdateCompanyUI();
                createForm.Hide();
            };
        }

        private void FireWorker(Worker worker)
        {
            _store.Company.FireWorker(worker);
            UpdateCompanyUI();
        }

        private void SimulateOneDay(object sender, EventArgs e)
        {
            Log.Clear();
            _simulator.Simulate(_store.Company, _store.Today, 1);
            _store.Today = _store.Today.AddDays(1);
            UpdateCompanyUI();
        }

        private void WorkersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            if (WorkersDataGrid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell cell && cell.Value is DeleteButtonArgs args)
            {
                FireWorker(args.Worker);
            }
        }
    }
    public record DeleteButtonArgs(string Label, Worker Worker)
    {
        public override string ToString()
        {
            return this.Label;
        }
    }
    public record WorkerVm
    {
        public required string WorkerName { get; init; }
        public required string WorkerType { get; init; }
        public required string Description { get; init; }
        public required string CurrentSalary { get; init; }

        internal static WorkerVm CreateFromEntity(Worker x)
        {
            return x switch
            {
                HourlyWorker hourlyWorker => new WorkerVm
                {
                    WorkerName = hourlyWorker.Name,
                    WorkerType = "Почасовая",
                    Description = $"Отработано часов: {hourlyWorker.WorkHours}",
                    CurrentSalary = hourlyWorker.CalculateSalary().ToString() + " руб"

                },
                ComissionWorker commissionWorker => new WorkerVm
                {
                    WorkerName = commissionWorker.Name,
                    WorkerType = "Комиссионная",
                    Description = $"Продано товара на: {commissionWorker.SoldPrice} руб",
                    CurrentSalary = commissionWorker.CalculateSalary().ToString() + " руб"
                },
                _ => throw new UnreachableException()
            };
        }
    }
}
