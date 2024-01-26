using LabSharp11.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSharp12.Windows
{
    public partial class CreateCompanyWindow : Form
    {
        public event EventHandler<Company> CompanyCreated;

        public CreateCompanyWindow()
        {
            InitializeComponent();
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            var company = new Company(NameTB.Text);

            CompanyCreated.Invoke(this, company);
        }
    }
}
