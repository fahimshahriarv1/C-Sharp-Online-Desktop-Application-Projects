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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {


        String ch1, ch2, ch3, ch4, ch5, ch6,ch7,ch8;

        private void button2_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            desigBox.Text = "";
            hstudtBox.Text = "";
            AddressBox.Text = "";
            mailbox.Text = "";
            phnBox.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "HUU9yGA9b4sSxzsZD2JAytEuzVFmuGvNFBuirJjq",
            BasePath = "https://sudentteacher.firebaseio.com/"

        };

        IFirebaseClient client;

        private async void button1_Click(object sender, EventArgs e)
        {

            ch2 = nameBox.Text;
            ch3 = desigBox.Text;
            ch4 = hstudtBox.Text;
            ch5 = AddressBox.Text;
            ch6 = mailbox.Text;
            ch7 = phnBox.Text;
            ch8 = orgbox.Text;
            if (ch2 == "")
                ch2 = "n/a";
            if (ch3 == "")
                ch3 = "n/a";
            if (ch4 == "")
                ch4 = "n/a";
            if (ch5 == "")
                ch5 = "n/a";
            if (ch6 == "")
                ch6 = "n/a";
            if (ch7 == "")
                ch7 = "n/a";

            if (ch8 == "")
                ch8 = "n/a";


            client = new FireSharp.FirebaseClient(config);
            Data4 d = new Data4();
            d.name = ch2;
            d.desig = ch3;
            d.hStudy = ch4;
            d.add = ch5;
            d.mail = ch6;
            d.phn = ch7;
            d.org = ch8;
            SetResponse res = null;
            res = await client.SetTaskAsync("StudentAll/"+ch1+sl.Text+"/", d);
            Data4 dd = res.ResultAs<Data4>();

            if (dd.name.Equals(nameBox.Text))
            {
                MessageBox.Show("Successfull..");
                nameBox.Text = "";
                desigBox.Text = "";
                hstudtBox.Text = "";
                AddressBox.Text = "";
                mailbox.Text = "";
                phnBox.Text = "";
                orgbox.Text = "";
                string s = sl.Text;
                int x = Int32.Parse(s);
                x++;
                sl.Text = x.ToString();
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                ch1 = "2003-04/";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ch1 = "2004-05/";
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                ch1 = "2005-06/";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                ch1 = "2006-07/";
            }
            else if(comboBox1.SelectedIndex == 4)
            {
                ch1 = "2007-08/";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                ch1 = "2008-09/";
            }

            else if (comboBox1.SelectedIndex == 6)
            {
                ch1 = "2009-10/";
            }

            else if (comboBox1.SelectedIndex == 7)
            {
                ch1 = "2010-11/";
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                ch1 = "2011-12/";
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                ch1 = "2012-13/";
            }

        }
    }
}
