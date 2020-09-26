using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApplication1
{

    


    public partial class Welcome : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "HUU9yGA9b4sSxzsZD2JAytEuzVFmuGvNFBuirJjq",
            BasePath = "https://sudentteacher.firebaseio.com/"

        };

        String ch1, ch2, ch3;
        IFirebaseClient client;

        public Welcome()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(deptBox.SelectedIndex==0)
                ch3="CSE/";
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                SignUpForm fm = new SignUpForm(comboBox1.SelectedItem.ToString());
                fm.ShowDialog();
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                if (sessionBox.SelectedIndex == 1)
                {
                    ch1 = "2003-04/";
                    ch2 = "2ndsemester/";
                }
                else if (sessionBox.SelectedIndex == 2)
                {
                    ch1 = "2004-05/";
                    ch2 = "1stsemester/";
                }
                else if (sessionBox.SelectedIndex == 3)
                {
                    ch1 = "2005-06/";
                    ch2 = "2ndsemester/";
                }
                else if (sessionBox.SelectedIndex == 4)
                {
                    ch1 = "2006-07/";
                    ch2 = "1stsemester/";
                }
                else if (sessionBox.SelectedIndex == 5)
                {
                    ch1 = "2007-08/";
                    ch2 = "2ndsemester/";
                }
                else if (sessionBox.SelectedIndex == 6)
                {
                    ch1 = "2008-09/";
                    ch2 = "1stsemester/";
                }
                else if (sessionBox.SelectedIndex == 7)
                {
                    ch1 = "2009-10/";
                    ch2 = "2ndsemester/";
                }
                else if (sessionBox.SelectedIndex == 9)
                {
                    ch1 = "2010-11/";
                    ch2 = "1stsemester/";
                }
                else if (sessionBox.SelectedIndex == 10)
                {
                    ch1 = "2011-12/";
                    ch2 = "2ndsemester/";
                }
                else if (sessionBox.SelectedIndex == 11)
                {
                    ch1 = "2012-14/";
                    ch2 = "2ndsemester/";
                }
                else if (sessionBox.SelectedIndex == 12)
                {
                    ch1 = "2013-14/";
                    ch2 = "1stsemester/";
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            { 
                if (sessionBox.SelectedIndex == 0)
                {
                    ch1 = "2014-15/";
                    ch2 = "2ndsemester/";
                }
                else if (sessionBox.SelectedIndex == 1)
                {
                    ch1 = "2015-16/";
                    ch2 = "1stsemester/";
                }
                else if (sessionBox.SelectedIndex == 2)
                {
                    ch1 = "2016-17/";
                    ch2 = "2ndsemester/";
                }
                else if (sessionBox.SelectedIndex == 3)
                {
                    ch1 = "2017-18/";
                    ch2 = "2ndsemester/";
                }
                else if (sessionBox.SelectedIndex == 4)
                {
                    ch1 = "2018-19/";
                    ch2 = "2ndsemester/";
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Login_Click  (object sender, EventArgs e)
        {
            FirebaseResponse res=null;
            if (comboBox1.SelectedIndex == 2)
            {
                res = await client.GetTaskAsync("StudentLogin/" + ch3 + ch1 + textBox1.Text);
                StudentData d;
                if (res != null)
                {
                    try
                    {
                        d = res.ResultAs<StudentData>();
                        if (d.pass.Equals(textBox3.Text.ToString()))
                        {
                            MessageBox.Show("Welcome");
                            StudentLogged fm = new StudentLogged();
                            fm.Show();
                            this.Visible = false;

                        }
                        else
                            MessageBox.Show("Invalid Login!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid Login!!11");
                    }
                }
                else
                    MessageBox.Show("Invalid Login!!");

            }
            else if (comboBox1.SelectedIndex == 1)
                res = await client.GetTaskAsync("TeacherLogin/" + textBox1.Text);
            else if (comboBox1.SelectedIndex == 0)
                res = await client.GetTaskAsync("AdminLogin/" + textBox1.Text);
            else if (comboBox1.SelectedIndex == 3)
            {
                AlumniData d1;
                ch3 = deptBox.SelectedItem.ToString()+"/";
                ch1 = sessionBox.SelectedItem.ToString()+ "/";
                res = await client.GetTaskAsync("AlumniLogin/"+ch3+ch1+ textBox1.Text);
                if (res != null)
                {
                    try
                    {
                        d1 = res.ResultAs<AlumniData>();
                        if (d1.pass.Equals(textBox3.Text.ToString()))
                        {
                            MessageBox.Show("Welcome");
                            StudentLogged fm = new StudentLogged();
                            fm.Show();
                            this.Visible = false;

                        }
                        else
                            MessageBox.Show("Invalid Login!!1");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid Login!!12");
                    }
                }
                else
                    MessageBox.Show("Invalid Login!!");
            }

            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
               
                sessionBox.Visible = false;
                ch1 = "Admin";
               
                deptBox.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                ch1 = null;
                ch2 = null;
                ch3 = null;
                button1.Visible = false;
                button2.Visible = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                ch1 = "Teacher";
                sessionBox.Visible = false;
                deptBox.Visible = false;
                label5.Visible = false;
             
                label6.Visible = false;
                ch1 = null;
                ch2 = null;
                ch3 = null;
                button1.Visible = true;
                button2.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                ch1 = "Student";
                deptBox.Visible = true;
                sessionBox.Visible = true;
                label5.Visible = true;
                
                label6.Visible = true;
                ch1 = null;
                ch2 = null;
                ch3 = null;
                button1.Visible = true;
                sessionBox.Items.Clear();
                sessionBox.Items.Add("2014-15");
                sessionBox.Items.Add("2015-16");
                sessionBox.Items.Add("2016-17");
                sessionBox.Items.Add("2017-18");
                sessionBox.Items.Add("2018-19");
                button2.Visible = false;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                //ch1 = "Student";
                deptBox.Visible = true;
                sessionBox.Visible = true;
                label5.Visible = true;
                
                label6.Visible = true;
                //ch1 = null;
                ch2 = null;
                
                ch3 = "CSE/";
                button1.Visible = true;
                sessionBox.Items.Clear();
                sessionBox.Items.Add(" ");
                sessionBox.Items.Add(" ");
                sessionBox.Items.Add("2003-04");
                sessionBox.Items.Add("2004-05");
                sessionBox.Items.Add("2005-06");
                sessionBox.Items.Add("2006-07");
                sessionBox.Items.Add("2007-08");
                sessionBox.Items.Add("2008-09");
                sessionBox.Items.Add("2009-10");
                sessionBox.Items.Add("2010-11");
                sessionBox.Items.Add("2011-12");
                sessionBox.Items.Add("2012-13");
                sessionBox.Items.Add("2013-14");
                button2.Visible = false;
            }
        }
    }

}
