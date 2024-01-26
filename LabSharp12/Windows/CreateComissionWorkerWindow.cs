using LabSharp11.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSharp12.Windows
{
    public partial class CreateComissionWorkerWindow : Form
    {
        public event EventHandler<ComissionWorker> WorkerCreated;
        public CreateComissionWorkerWindow()
        {
            InitializeComponent();
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            if (!decimal.TryParse(BaseSalaryTB.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var baseSalary))
            {
                MessageBox.Show("Поле 'Оклад' заполнено неверно. Ожидается ввод вида '##.##'");
                return;
            }
            if (!decimal.TryParse(ComissionTB.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var comission))
            {
                MessageBox.Show("Поле 'Процент с продаж' заполнено неверно. Ожидается ввод вида '##.##'");
                return;
            }
            Sex sex = SexMaleRadio.Checked
                ? Sex.Male
                : Sex.Female;

            var worker = new ComissionWorker(WorkerNameTB.Text, baseSalary, comission, sex);
            WorkerCreated.Invoke(this, worker);
        }
    }
}
