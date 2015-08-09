namespace Cursa4_2
{
    partial class AddTasks_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTasks_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDead = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpSD = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTask = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Редагування завдань:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Додати/Редагувати...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDead
            // 
            this.dtpDead.Location = new System.Drawing.Point(109, 322);
            this.dtpDead.Name = "dtpDead";
            this.dtpDead.Size = new System.Drawing.Size(200, 20);
            this.dtpDead.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Кінець";
            // 
            // dtpSD
            // 
            this.dtpSD.Location = new System.Drawing.Point(109, 290);
            this.dtpSD.Name = "dtpSD";
            this.dtpSD.Size = new System.Drawing.Size(200, 20);
            this.dtpSD.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Початок";
            // 
            // tbTask
            // 
            this.tbTask.Location = new System.Drawing.Point(117, 109);
            this.tbTask.Multiline = true;
            this.tbTask.Name = "tbTask";
            this.tbTask.Size = new System.Drawing.Size(366, 175);
            this.tbTask.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Завдання";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(117, 77);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(366, 20);
            this.tbName.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Назва";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(117, 45);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(366, 20);
            this.tbCode.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Код";
            // 
            // AddTasks_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 410);
            this.Controls.Add(this.dtpDead);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpSD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTask);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTasks_Form";
            this.Text = "AddTasks_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDead;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpSD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label5;
    }
}