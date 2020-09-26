using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class SignUpForm : Form
    {

        String uType = null;
        String imgLoc = null;
        String img = null;
        public SignUpForm()
        {
            InitializeComponent();
        }

        public SignUpForm(String s)
        {
            InitializeComponent();
            //pictureBox1.Image = new Bitmap("D://3-1//Project c#//StudentTeacher//picSource//123.jpg");
            
            uType = s;
            if(s.Equals("Student"))
            {
                label10.Visible = false;
                label8.Visible = false;
                desigBox.Visible = false;
                paddressBox.Visible = false;
                label7.Text = "Year/Semester";
                //label2.Text = "Id";
                label7.Visible = true;
                sessionBox.Visible = true;
                label9.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label10.Visible = true;
                paddressBox.Visible = true;


                phnBox.Visible = true;
                mailBox.Visible = true;
                

                comboBox2.Visible = true;

                sessionBox.Items.Clear();
                sessionBox.Items.Add("2014-15");
                sessionBox.Items.Add("2015-16");
                sessionBox.Items.Add("2016-17");
                sessionBox.Items.Add("2017-18");
                sessionBox.Items.Add("2018-19");

            }
            else if(s.Equals("Teacher"))
            {
                label7.Text = "Designation";
                label7.Visible = true;
                comboBox2.Visible = true;
                label10.Visible = false;
                label8.Visible = false;
                desigBox.Visible = false;
                paddressBox.Visible = false;
                hstudyBox.Visible = false;
                label2.Visible = false;

                label11.Visible = true;
                label12.Visible = false;
                
                phnBox.Visible = true;
                mailBox.Visible = false;
                


                comboBox2.Items.Clear();
                comboBox2.Items.Add("Lecturer");
                comboBox2.Items.Add("Asisstant Professor");
                comboBox2.Items.Add("Associate Professor");
                comboBox2.Items.Add("Professor");
                //label2.Text = "Contact No.";
                
                hstudyBox.Visible = false;

            }
            else if (s.Equals("Alumni"))
            {
                label7.Visible = false;
                comboBox2.Visible = false;
                label2.Text = "Higher Study Info";
                label11.Visible = true;
                label12.Visible = true;
                
                phnBox.Visible = true;
                mailBox.Visible = true;
                sessionBox.Visible = true;
                label9.Visible = true;
                

                sessionBox.Items.Clear();
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

            }

        }

        String ch1, ch2, ch3,ch0;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "HUU9yGA9b4sSxzsZD2JAytEuzVFmuGvNFBuirJjq",
            BasePath = "https://sudentteacher.firebaseio.com/"

        };

        IFirebaseClient client;

        private async void button2_Click(object sender, EventArgs e)
        {

            client = new FireSharp.FirebaseClient(config);
            if (!nameBox.Text.Equals(null) || !unameBox.Text.Equals(null) || !passBox1.Text.Equals(null) || !passBox2.Text.Equals(null) || !hstudyBox.Text.Equals(null) || !desigBox.Text.Equals(null) || !phnBox.Text.Equals(null) || !mailBox.Text.Equals(null) || !idBox.Text.Equals(null) || deptCBox.SelectedIndex == -1 || sessionBox.SelectedIndex == -1||pictureBox1.Image==null)
            {
                if (passBox1.Text.Equals(passBox2.Text))
                {

                    StudentData d = new StudentData();
                    d.id = hstudyBox.Text;
                    d.pass = passBox1.Text;
                    SetResponse res = null;
                    if (uType.Equals("Student"))
                        res = await client.SetTaskAsync("Student" + "Login/" + sessionBox.SelectedItem.ToString() + "/" + ch3 + unameBox.Text, d);
                    else if (uType.Equals("Alumni"))
                    {
                        
                        AlumniData d1 = new AlumniData();
                        d1.name = nameBox.Text;
                        d1.id = idBox.Text;
                        d1.pass = passBox1.Text;
                        d1.hStudy = hstudyBox.Text;
                        d1.desig = desigBox.Text;
                        d1.pAddrees = paddressBox.Text;
                        d1.phn = phnBox.Text;
                        d1.mailid = mailBox.Text;
                        
                        String picSource = "D://3-1//Project c#//StudentTeacher//picSource//" + unameBox.Text + sessionBox.SelectedItem.ToString() + ".jpg";
                        d1.picid = picSource;
                        res = await client.SetTaskAsync("AlumniLogin/" + ch3 + "/" + sessionBox.SelectedItem.ToString() + "/" + unameBox.Text, d1);

                        
                        File.Delete(picSource);
                        //MessageBox.Show(imgLoc + "  " + picSource);
                        System.IO.File.Copy(imgLoc, picSource);

                        //MessageBox.Show(imgLoc+"  "+picSource);


                        
                        
                        
                        
                        String text = "\nName: " + nameBox.Text + "\nId: " + idBox.Text + "\nHigher Study Info: " + hstudyBox.Text+ "\nDesignation: " + desigBox.Text+ "\nPressent Address: " + paddressBox.Text+ "\nContact No.: " + phnBox.Text+ "\nEmai: " + mailBox.Text+ "\nDepartment: " + deptCBox.SelectedItem.ToString()+ "\nSession: " + sessionBox.SelectedItem.ToString();
                        PdfSharp.Pdf.PdfDocument document = new PdfSharp.Pdf.PdfDocument();
                        PdfSharp.Pdf.PdfPage page = document.AddPage();
                        XGraphics gfx = XGraphics.FromPdfPage(page);
                        XFont font = new XFont("Times New Roman", 10, XFontStyle.Bold);
                        PdfSharp.Drawing.Layout.XTextFormatter tf = new PdfSharp.Drawing.Layout.XTextFormatter(gfx);

                        XRect rect = new XRect(40, 100, 250, 220);
                        gfx.DrawRectangle(XBrushes.SeaShell, rect);
                        tf.DrawString(text, font, XBrushes.Black, rect, XStringFormats.TopLeft);


                        string pdfFilename = "D://3-1//Project c#//StudentTeacher//pdfSource//" + sessionBox.SelectedItem.ToString() + unameBox.Text + ".pdf";
                        document.Save(pdfFilename);
                        Process.Start(pdfFilename);



                        if (d1.pass.Equals(passBox1.Text))
                        {
                            MessageBox.Show("Registration Successfull..");
                            this.Hide();
                        }
                    }

                    else if (uType.Equals("Teacher"))
                        res = await client.SetTaskAsync(uType + "Login/" + unameBox.Text, d);

                    

                }
                else
                {
                    MessageBox.Show("Passwords Are Not Identical..");
                }
            }
            else
            {
                MessageBox.Show("Some Fields are Not yet Filled or Selected....");
            }
        }

    private void sessionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "* files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {                  
                    this.pictureBox1.Image = new Bitmap(dlg.FileName);
                    imgLoc = dlg.FileName;
                }
                string[] img=null;
                if (!imgLoc.Equals(null))
                img = imgLoc.Split('\\');
                imgLoc = null;
                for(int i=0;i<img.Length;i++)
                {
                    imgLoc = imgLoc + img[i];
                    if(i<img.Length-1)
                    imgLoc = imgLoc + "//";
                }
               // MessageBox.Show(imgLoc);
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deptCBox.SelectedIndex == 0)
                ch3 = "CSE/";
        }
    }
}
