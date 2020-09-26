namespace WindowsFormsApplication1
{
    partial class SignUpForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.hstudyBox = new System.Windows.Forms.TextBox();
            this.unameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.deptCBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sessionBox = new System.Windows.Forms.ComboBox();
            this.desigBox = new System.Windows.Forms.TextBox();
            this.paddressBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.phnBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.passBox1 = new System.Windows.Forms.TextBox();
            this.passBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(185, 26);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(232, 20);
            this.nameBox.TabIndex = 0;
            // 
            // hstudyBox
            // 
            this.hstudyBox.Location = new System.Drawing.Point(185, 219);
            this.hstudyBox.Name = "hstudyBox";
            this.hstudyBox.Size = new System.Drawing.Size(232, 20);
            this.hstudyBox.TabIndex = 1;
            // 
            // unameBox
            // 
            this.unameBox.Location = new System.Drawing.Point(185, 61);
            this.unameBox.Name = "unameBox";
            this.unameBox.Size = new System.Drawing.Size(232, 20);
            this.unameBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AccessibleName = "LoginButton";
            this.button1.Location = new System.Drawing.Point(234, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deptCBox
            // 
            this.deptCBox.Items.AddRange(new object[] {
            "CSE",
            "ICT",
            "TE"});
            this.deptCBox.Location = new System.Drawing.Point(185, 403);
            this.deptCBox.Name = "deptCBox";
            this.deptCBox.Size = new System.Drawing.Size(124, 21);
            this.deptCBox.TabIndex = 14;
            this.deptCBox.Text = "Select";
            this.deptCBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.AccessibleName = "LoginButton";
            this.button2.Location = new System.Drawing.Point(385, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Higher Study Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Year/Semester";
            this.label7.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Items.AddRange(new object[] {
            "1-1",
            "1-2",
            "2-1",
            "2-2",
            "3-1",
            "3-2",
            "4-1",
            "4-2",
            "5-1",
            "5-2"});
            this.comboBox2.Location = new System.Drawing.Point(476, 218);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(124, 21);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.Text = "Select";
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Session";
            this.label9.Visible = false;
            // 
            // sessionBox
            // 
            this.sessionBox.Items.AddRange(new object[] {
            "2003-04",
            "2004-05",
            "2005-06",
            "2006-07",
            "2007-08",
            "2008-09",
            "2009-10",
            "2010-11",
            "2011-12",
            "2012-13",
            "2013-14",
            "2014-15",
            "2015-16",
            "2016-17",
            "2017-18",
            "2003-04",
            "2003-04"});
            this.sessionBox.Location = new System.Drawing.Point(464, 403);
            this.sessionBox.Name = "sessionBox";
            this.sessionBox.Size = new System.Drawing.Size(124, 21);
            this.sessionBox.TabIndex = 28;
            this.sessionBox.Text = "Select";
            this.sessionBox.Visible = false;
            this.sessionBox.SelectedIndexChanged += new System.EventHandler(this.sessionBox_SelectedIndexChanged);
            // 
            // desigBox
            // 
            this.desigBox.Location = new System.Drawing.Point(185, 251);
            this.desigBox.Name = "desigBox";
            this.desigBox.Size = new System.Drawing.Size(232, 20);
            this.desigBox.TabIndex = 29;
            // 
            // paddressBox
            // 
            this.paddressBox.Location = new System.Drawing.Point(185, 303);
            this.paddressBox.Name = "paddressBox";
            this.paddressBox.Size = new System.Drawing.Size(232, 20);
            this.paddressBox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Designation";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Present Address";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phnBox
            // 
            this.phnBox.Location = new System.Drawing.Point(185, 335);
            this.phnBox.Name = "phnBox";
            this.phnBox.Size = new System.Drawing.Size(232, 20);
            this.phnBox.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Contact No.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(476, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(185, 365);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(232, 20);
            this.mailBox.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "E-Mail";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "ID";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passBox1
            // 
            this.passBox1.Location = new System.Drawing.Point(185, 137);
            this.passBox1.Name = "passBox1";
            this.passBox1.Size = new System.Drawing.Size(232, 20);
            this.passBox1.TabIndex = 3;
            this.passBox1.UseSystemPasswordChar = true;
            // 
            // passBox2
            // 
            this.passBox2.Location = new System.Drawing.Point(185, 177);
            this.passBox2.Name = "passBox2";
            this.passBox2.Size = new System.Drawing.Size(232, 20);
            this.passBox2.TabIndex = 4;
            this.passBox2.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(96, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Password";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(58, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Confirm Password";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(185, 99);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(232, 20);
            this.idBox.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(194, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ex. Asssitant Manager,ABC Company,Bangladesh";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 489);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.phnBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.paddressBox);
            this.Controls.Add(this.desigBox);
            this.Controls.Add(this.sessionBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deptCBox);
            this.Controls.Add(this.passBox2);
            this.Controls.Add(this.passBox1);
            this.Controls.Add(this.unameBox);
            this.Controls.Add(this.hstudyBox);
            this.Controls.Add(this.nameBox);
            this.Name = "SignUpForm";
            this.Text = "Regisitration";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox hstudyBox;
        private System.Windows.Forms.TextBox unameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox deptCBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sessionBox;
        private System.Windows.Forms.TextBox desigBox;
        private System.Windows.Forms.TextBox paddressBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phnBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox passBox1;
        private System.Windows.Forms.TextBox passBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label4;
    }
}