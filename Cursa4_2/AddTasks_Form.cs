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
    public partial class AddTasks_Form : Form
    {
        Tasks _task;

        public AddTasks_Form()
        {
            InitializeComponent();
        }

        public AddTasks_Form(Guid EmpID, Tasks task = null):this()
        {
            _task = (task == null) ? new Tasks() : task;
            _task.Id_Employers = EmpID;
            //Binding
            tbCode.DataBindings.Add("Text",_task,"Code");
            tbName.DataBindings.Add("Text", _task, "Name");
            tbTask.DataBindings.Add("Text", _task, "Task");
            dtpSD.DataBindings.Add("Value", _task, "Start_Date");
            dtpDead.DataBindings.Add("Value", _task, "Deadline");
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length == 0 || tbCode.Text.Length == 0 || tbTask.Text.Length == 0)
            {
                MessageBox.Show("Введіть, будь ласка, усі дані");
                return;
            }
            else
            _task.Modify();
            Tasks.data.Add(_task);
            Close();
        }
    }
}
