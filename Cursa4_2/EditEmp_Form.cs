using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
namespace Cursa4_2
{
    public partial class EditEmp_Form : Form
    {
        public Employers emp;
        public Jobtitle j;
        
        public EditEmp_Form(Employers Emp = null)
        {
            InitializeComponent();
            label10.Text = (Emp == null) ? "Реєстрація нового працівника" : "Редагування картки працівника";
            combobGender.SelectedIndex = 0;
            emp = (Emp == null) ? new Employers() : Emp;
            JTFill();
            Binding();
        }

        private void JTFill()
        {
            Jobtitle.Select("select * from JOB_TITLE",
                (r)=>{
                    Jobtitle jt = new Jobtitle(r);
                    if (jt.ID == emp.JT.ID) jt = emp.JT;
                        combobJobtitle.Items.Add(jt);
                });
            if (combobJobtitle.Items.Count > 0)
                combobJobtitle.SelectedIndex = (emp.ID == Guid.Empty)? 0 : combobJobtitle.Items.IndexOf(emp.JT);
        }
  
        private void Binding()
        {
            tbName.DataBindings.Add("Text", emp, "Name");
            dtBirthday.DataBindings.Add("Text", emp, "Birthday");
            dtAssigment.DataBindings.Add("Text", emp, "Date_of_assigment");
            tbCode.DataBindings.Add("Text", emp, "Code");
            dtDismissal.DataBindings.Add("Text", emp, "Date_of_dismissal");
            tbContract.DataBindings.Add("Text", emp, "Contract");
            tbSkills.DataBindings.Add("Text", emp, "Skills");
            combobGender.DataBindings.Add("Text", emp, "Gender");
            combobJobtitle.DataBindings.Add("SelectedItem", emp, "JT");
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            emp.Modify();
            this.DialogResult = DialogResult.OK;
        }

        public static Employers AddUpdate(Employers Emp = null)
        {
            Employers res;
            using (EditEmp_Form f = new EditEmp_Form(Emp))
            {
                res = (f.ShowDialog() == DialogResult.OK) ? f.emp : null;
            }
            return res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new AddJobtitle_Form()).ShowDialog();
            //Обновляем список должностей
            //Текущая должность не обновляется из-за условия в JTFill!!!
            combobJobtitle.Items.Clear();
            JTFill();
        }
    }
}
