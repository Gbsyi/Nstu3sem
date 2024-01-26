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
    public partial class CreateHourlyWorkerWindow : Form
    {
        public event EventHandler<HourlyWorker> WorkerCreated;
        
        public CreateHourlyWorkerWindow()
        {
            InitializeComponent();
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            if (!int.TryParse(StandardWorkHoursTB.Text, out var standardWorkHours))
            {
                MessageBox.Show("Поле 'Норма отработаных часов в день' заполнено неверно. Ожидается число");
                return;
            }
            if (!decimal.TryParse(SalaryPerHourTB.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var salaryPerHour))
            {
                MessageBox.Show("Поле 'Ставка в час' заполнено неверно. Ожидается ввод вида '##.##'");
                return;
            }
            if (!decimal.TryParse(OvertimeMultiplierTB.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var overtimeMultiplier))
            {
                MessageBox.Show("Поле 'Множитель переработки' заполнено неверно. Ожидается ввод вида '##.##'");
                return;
            }

            Sex sex = SexMaleRadio.Checked
                ? Sex.Male
                : Sex.Female;
            
            var worker = new HourlyWorker(standardWorkHours, WorkerNameTB.Text, salaryPerHour, overtimeMultiplier, sex);
            
            WorkerCreated.Invoke(this, worker);
        }
    }
}
