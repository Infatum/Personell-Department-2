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
    public partial class AddJobtitle_Form : Form
    {
        private Jobtitle jt;

        public AddJobtitle_Form()
        {
            InitializeComponent();

            Jobtitle.data.Clear();
            Jobtitle.Select("select * from JOB_TITLE",
                (r) => Jobtitle.data.Add(new Jobtitle(r)));

            bsJT.DataSource = Jobtitle.data;
            lbJobtitle.DataSource = bsJT;
            DepFill();
            Binding();
        }


        private void DepFill()
        {
            Department.Select("select * from DEPARTMENT", (d) => 
                {
                    combobDep.Items.Add(new Department(d));
                });
            if (combobDep.Items.Count > 0)
                combobDep.SelectedIndex = 0;
        }
        
        private void Binding()
        {
            if (jt == null) return;
            // .DataBindings.Add("Text", jt, "Code");
            tbCode.Text = jt.Code.ToString();
            // .DataBindings.Add("Text", jt, "NAME");
            tbJobtitle.Text = jt.Name;
            // .DataBindings.Add("Text", jt, "SALLARY");
            tbSallary.Text = jt.Sallary.ToString();
            // .DataBindings.Add("Text", jt, "Dollar_per_hour");
            tbDollPerHour.Text = jt.Dollar_per_hour.ToString();
        }
        
        private void AntiBinding()
        {
            jt.Code = int.Parse(tbCode.Text);
            jt.Name = tbJobtitle.Text;
            jt.Sallary = decimal.Parse(tbSallary.Text);
            jt.Dollar_per_hour = decimal.Parse(tbDollPerHour.Text);
            jt.Dep = combobDep.SelectedItem as Department;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AntiBinding();
            jt.Modify();
            bsJT.ResetCurrentItem();
        }

        private void bsJT_CurrentChanged(object sender, EventArgs e)
        {
            jt = (bsJT.Current as Jobtitle);
            Binding();
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //jt = new Jobtitle();
        }
    }
}
