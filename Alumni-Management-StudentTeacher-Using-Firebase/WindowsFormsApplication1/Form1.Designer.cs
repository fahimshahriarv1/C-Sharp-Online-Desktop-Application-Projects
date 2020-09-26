namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.desigBox = new System.Windows.Forms.TextBox();
            this.hstudtBox = new System.Windows.Forms.TextBox();
            this.sl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mailbox = new System.Windows.Forms.TextBox();
            this.phnBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.orgbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2003-04",
            "2004-05",
            "2005-06",
            "2006-07",
            "2007-08",
            "2008-09",
            "2009-10",
            "2010-11",
            "2011-12",
            "2012-13"});
            this.comboBox1.Location = new System.Drawing.Point(184, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(184, 50);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(121, 20);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "session";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "designation";
            // 
            // desigBox
            // 
            this.desigBox.Location = new System.Drawing.Point(184, 122);
            this.desigBox.Name = "desigBox";
            this.desigBox.Size = new System.Drawing.Size(288, 20);
            this.desigBox.TabIndex = 5;
            // 
            // hstudtBox
            // 
            this.hstudtBox.Location = new System.Drawing.Point(184, 160);
            this.hstudtBox.Name = "hstudtBox";
            this.hstudtBox.Size = new System.Drawing.Size(288, 20);
            this.hstudtBox.TabIndex = 6;
            // 
            // sl
            // 
            this.sl.Location = new System.Drawing.Point(184, 18);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(121, 20);
            this.sl.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SL no";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "h Study";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(184, 197);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(288, 66);
            this.AddressBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pre Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "mail id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "phn no";
            // 
            // mailbox
            // 
            this.mailbox.Location = new System.Drawing.Point(184, 269);
            this.mailbox.Name = "mailbox";
            this.mailbox.Size = new System.Drawing.Size(288, 20);
            this.mailbox.TabIndex = 14;
            // 
            // phnBox
            // 
            this.phnBox.Location = new System.Drawing.Point(184, 295);
            this.phnBox.Name = "phnBox";
            this.phnBox.Size = new System.Drawing.Size(288, 20);
            this.phnBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 25);
            this.button2.TabIndex = 17;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // orgbox
            // 
            this.orgbox.Location = new System.Drawing.Point(184, 331);
            this.orgbox.Name = "orgbox";
            this.orgbox.Size = new System.Drawing.Size(288, 20);
            this.orgbox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "org";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.orgbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phnBox);
            this.Controls.Add(this.mailbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sl);
            this.Controls.Add(this.hstudtBox);
            this.Controls.Add(this.desigBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "info puttt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox desigBox;
        private System.Windows.Forms.TextBox hstudtBox;
        private System.Windows.Forms.TextBox sl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mailbox;
        private System.Windows.Forms.TextBox phnBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox orgbox;
        private System.Windows.Forms.Label label9;
    }
}