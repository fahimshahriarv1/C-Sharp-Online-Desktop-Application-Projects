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


    
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "HUU9yGA9b4sSxzsZD2JAytEuzVFmuGvNFBuirJjq",
            BasePath = "https://sudentteacher.firebaseio.com/"

        };
        IFirebaseClient client;
        DataTable dt = new DataTable();
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse res = null;
            res = await client.GetTaskAsync("NewsLineCnt/");

            countClass cc = res.ResultAs<countClass>();
            long x = Convert.ToInt64(cc.cnt.ToString());

            
            int i = 0;
            //MessageBox.Show(comboBox1.SelectedItem.ToString());

            while (true)
            {
                i++;
                FirebaseResponse res1 = null;
                res1 = await client.GetTaskAsync("StudentAll/CSE/"+comboBox1.SelectedItem.ToString()+"/" + i.ToString());
                Data4 d;
                try
                {
                    d= res1.ResultAs<Data4>(); ;
                }
                catch(Exception exs)
                {
                    break;
                }
                
                DataRow r = dt.NewRow();
                r["Name"] = d.name;
                r["Designation"] = d.desig;
                r["organisation"] = d.org;
                r["Address"] = d.add;
                r["Session"] = comboBox1.SelectedItem.ToString();
                r["Mail Id"] = d.mail;
                r["Contact No."] = d.phn;
                r["Higher Study"] = d.hStudy;
                dt.Rows.Add(r);
            }
            
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Designation");
            dt.Columns.Add("Address");
            dt.Columns.Add("Session");
            dt.Columns.Add("Higher Study");
            dt.Columns.Add("Organisation");
            dt.Columns.Add("Mail Id");
            dt.Columns.Add("Contact No.");
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLogged fm = new StudentLogged();
            fm.Show();
            this.Hide();
        }
    }
}
