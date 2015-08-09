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
    public partial class MainForm : Form
    {
        public Table t;
        public Company c;
        public Department dep;
        public Jobtitle jt;
        public Tasks ts;

        public MainForm()
        {
            InitializeComponent();

            Program.CS = new FbConnectionStringBuilder();
            Program.CS.UserID = "SYSDBA";
            Program.CS.Password = "masterkey";
            Program.CS.Database = "base.fdb";
            Program.CS.DataSource = "localhost";
            Program.CS.Port = 3050;
            Program.CS.Dialect = 3;
            Program.CS.ServerType = FbServerType.Embedded;
            Program.CS.ClientLibrary = "gds32.dll";
            Program.CS.Charset = "NONE";
            Base.ConnectionString = Program.CS.ToString();
            
            Program.Company = new Company();
            Program.Company.SelectOne(Guid.Parse("1d5ddd7d-c14e-48be-84a1-327e99a03e96"));
            label1.Text = Program.Company.Name;

            Employers.Select("select * from Employers",
                (r)=>Employers.data.Add(new Employers(r)));
            bsEmployers.DataSource = Employers.data;
            lbEmployers.DataSource = bsEmployers;
            
        }
      
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Employers emp = EditEmp_Form.AddUpdate();
            if (emp != null) Employers.data.Add(emp);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            EditEmp_Form.AddUpdate(bsEmployers.Current as Employers);
            bsEmployers_CurrentChanged(null, null);
        }

        private void bsEmployers_CurrentChanged(object sender, EventArgs e)
        {
            tbJobtitle.Text = (bsEmployers.Current as Employers).JT.ToString();
            tbDepartment.Text = (bsEmployers.Current as Employers).JT.Dep.Name;
            SelectTasks();
        }

        private void SelectTasks()
        {
            //Выборка заданий для сотрyдника
            Tasks.data.Clear();
            Tasks.Select("select * from TASKS where ID_EMPLOYER='" + (bsEmployers.Current as Employers).ID.ToString() + "'",
                (t)=>Tasks.data.Add(new Tasks(t)));
            bsTasks.DataSource = Tasks.data;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            (new AddJobtitle_Form()).ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            (new AddDepartment()).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            (new AddTasks_Form((bsEmployers.Current as Employers).ID)).ShowDialog();
            bsTasks.MoveLast();
        }

        private void bsTasks_CurrentChanged(object sender, EventArgs e)
        {
            try{
                tbCode.Text = (bsTasks.Current as Tasks).Code.ToString();
                tbName.Text = (bsTasks.Current as Tasks).Name;
                tbTask.Text = (bsTasks.Current as Tasks).Task;
                dtpSD.Value = (bsTasks.Current as Tasks).Start_Date;
                dtpDead.Value = (bsTasks.Current as Tasks).Deadline;
            }
            catch (NullReferenceException ex)
            {
                tbCode.Text = tbName.Text = tbTask.Text = "";
                dtpSD.Value = dtpDead.Value = DateTime.Now;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            (new AddTasks_Form((bsEmployers.Current as Employers).ID, (bsTasks.Current as Tasks))).ShowDialog();
            bsTasks_CurrentChanged(null, null);
        }
    }
}

