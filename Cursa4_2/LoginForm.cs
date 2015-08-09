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
    public partial class LoginForm : Form
    {
        
        int tbUserNameKeyDownCount = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            tbLogin.Select();
            tbLogin.Text = "Login";
            User u1 = new User("anna", "anna");
            User u2 = new User("teacher", "teacher");
        }
        private void btEnter_Click(object sender, EventArgs e)
        {
           if (tbLogin.Text == "" || tbLogin.Text == "Login") lbCautionLogin.Visible = true;
                else 
                {
                    if (tbPassword.Text == "" || tbPassword.Text == "Password") label1.Visible = true;
                    else
                    {
                        foreach (User s in User.Users)
                            if (tbLogin.Text == s.Login && tbPassword.Text == s.Password)
                            {
                                this.Hide();
                                (new MainForm()).Show();
                                return;
                            }
                        else
                            {
                                lbWarningWrongData.Visible = true;
                                lbWarningWrongData1.Visible = true;
  
                            }
                    }
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btEnter_Click(this, new EventArgs());
           
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btEnter_Click(this, new EventArgs());
            
        }
       
        private void tbLogin_TextChanged(object sender, EventArgs e)
        {   
            lbCautionLogin.Visible = false;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void tbLogin_Leave(object sender, EventArgs e)
        {
            if (tbLogin.Text == "")
                tbLogin.Text = "Login";
        }
         private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.UseSystemPasswordChar = true;
            }   
        }

        private void ttbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.UseSystemPasswordChar = false;  
            }
        }

        private void tbLogin_Enter(object sender, EventArgs e)
        {
            if (tbLogin.Text == "Login")
                tbLogin.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}

