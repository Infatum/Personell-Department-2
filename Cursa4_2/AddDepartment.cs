using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursa4_2
{
    public partial class AddDepartment : Form
    {
        private Department dep;

        public AddDepartment()
        {
            InitializeComponent();

            Department.data.Clear();
            Department.Select("select * from DEPARTMENT where ID_COMPANY='" + Program.Company.ID.ToString() + "'",
                (r) => Department.data.Add(new Department(r)));
            bsDep.DataSource = Department.data;
        }

        private void Binding()
        {
            tbCode.Text = dep.Code.ToString();
            tbName.Text = dep.Name;
        }

        private void AntiBinding()
        {
            dep.Code = int.Parse(tbCode.Text);
            dep.Name = tbName.Text;
        }

        private void bsDep_CurrentChanged(object sender, EventArgs e)
        {
            dep = (bsDep.Current as Department);
            Binding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AntiBinding();
            dep.Company = Program.Company;
            dep.Modify();
            bsDep.ResetCurrentItem();
        }
    }
}
