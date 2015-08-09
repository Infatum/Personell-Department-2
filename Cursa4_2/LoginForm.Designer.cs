namespace Cursa4_2
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbWarningWrongData = new System.Windows.Forms.Label();
            this.lbCautionLogin = new System.Windows.Forms.Label();
            this.lbWarningWrongData1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ласкаво просимо до Windows Personel Department";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(84, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Будь ласка, авторізуйтесь:";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(84, 171);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(324, 23);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(84, 200);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(324, 23);
            this.tbPassword.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "ОК...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(150, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Регістрація...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbWarningWrongData
            // 
            this.lbWarningWrongData.AutoSize = true;
            this.lbWarningWrongData.ForeColor = System.Drawing.Color.Red;
            this.lbWarningWrongData.Location = new System.Drawing.Point(415, 180);
            this.lbWarningWrongData.Name = "lbWarningWrongData";
            this.lbWarningWrongData.Size = new System.Drawing.Size(10, 13);
            this.lbWarningWrongData.TabIndex = 4;
            this.lbWarningWrongData.Text = "!";
            // 
            // lbCautionLogin
            // 
            this.lbCautionLogin.AutoSize = true;
            this.lbCautionLogin.ForeColor = System.Drawing.Color.Red;
            this.lbCautionLogin.Location = new System.Drawing.Point(84, 230);
            this.lbCautionLogin.Name = "lbCautionLogin";
            this.lbCautionLogin.Size = new System.Drawing.Size(276, 13);
            this.lbCautionLogin.TabIndex = 5;
            this.lbCautionLogin.Text = "Невірний пароль або логін, будь ласка спробуйте ще";
            // 
            // lbWarningWrongData1
            // 
            this.lbWarningWrongData1.AutoSize = true;
            this.lbWarningWrongData1.ForeColor = System.Drawing.Color.Red;
            this.lbWarningWrongData1.Location = new System.Drawing.Point(414, 210);
            this.lbWarningWrongData1.Name = "lbWarningWrongData1";
            this.lbWarningWrongData1.Size = new System.Drawing.Size(10, 13);
            this.lbWarningWrongData1.TabIndex = 4;
            this.lbWarningWrongData1.Text = "!";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 389);
            this.Controls.Add(this.lbCautionLogin);
            this.Controls.Add(this.lbWarningWrongData1);
            this.Controls.Add(this.lbWarningWrongData);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbWarningWrongData;
        private System.Windows.Forms.Label lbCautionLogin;
        private System.Windows.Forms.Label lbWarningWrongData1;
    }
}