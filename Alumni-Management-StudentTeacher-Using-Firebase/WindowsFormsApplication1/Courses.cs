using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Courses : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "HUU9yGA9b4sSxzsZD2JAytEuzVFmuGvNFBuirJjq",
            BasePath = "https://sudentteacher.firebaseio.com/"

        };
        public Courses()
        {
            InitializeComponent();
        }
        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private async void Courses_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(config);
            dt.Columns.Add("Course Code");
            dt.Columns.Add("Course Name");
            dt.Columns.Add("Course Teacher");
            dataGridView1.DataSource = dt;
            int i = 0;

            FirebaseResponse res1 = null;
            res1 = await client.GetTaskAsync("Courses/3rdyear/1stsemester/CSE/");
            Data3 d = res1.ResultAs<Data3>();
            DataRow r = dt.NewRow();
            String[] s;
            s = d._1.Split('#');
            r["Course Code"] = s[0];
            r["Course Name"] = s[1];
            r["Course Teacher"] = s[2];
            dt.Rows.Add(r);

            DataRow r1 = dt.NewRow();
            s = d._2.Split('#');
            r1["Course Code"] = s[0];
            r1["Course Name"] = s[1];
            r1["Course Teacher"] = s[2];
            dt.Rows.Add(r1);

            DataRow r2 = dt.NewRow();
            s = d._3.Split('#');
            r2["Course Code"] = s[0];
            r2["Course Name"] = s[1];
            r2["Course Teacher"] = s[2];
            dt.Rows.Add(r2);


            DataRow r3 = dt.NewRow();
            s = d._4.Split('#');
            r3["Course Code"] = s[0];
            r3["Course Name"] = s[1];
            r3["Course Teacher"] = s[2];
            dt.Rows.Add(r3);

            DataRow r4 = dt.NewRow();
            s = d._5.Split('#');
            r4["Course Code"] = s[0];
            r4["Course Name"] = s[1];
            r4["Course Teacher"] = s[2];
            dt.Rows.Add(r4);

            DataRow r5 = dt.NewRow();
            s = d._6.Split('#');
            r5["Course Code"] = s[0];
            r5["Course Name"] = s[1];
            r5["Course Teacher"] = s[2];
            dt.Rows.Add(r5);

            DataRow r6 = dt.NewRow();
            s = d._7.Split('#');
            r6["Course Code"] = s[0];
            r6["Course Name"] = s[1];
            r6["Course Teacher"] = s[2];
            dt.Rows.Add(r6);

            DataRow r7 = dt.NewRow();
            s = d._8.Split('#');
            r7["Course Code"] = s[0];
            r7["Course Name"] = s[1];
            r7["Course Teacher"] = s[2];
            dt.Rows.Add(r7);

            DataRow r8 = dt.NewRow();
            s = d._9.Split('#');
            r8["Course Code"] = s[0];
            r8["Course Name"] = s[1];
            r8["Course Teacher"] = s[2];
            dt.Rows.Add(r8);

            DataRow r9 = dt.NewRow();
            s = d._91.Split('#');
            r9["Course Code"] = s[0];
            r9["Course Name"] = s[1];
            r9["Course Teacher"] = s[2];
            dt.Rows.Add(r9);


            DataRow r11 = dt.NewRow();
            s = d._92.Split('#');
            r11["Course Code"] = s[0];
            r11["Course Name"] = s[1];
            r11["Course Teacher"] = s[2];
            dt.Rows.Add(r11);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLogged fm = new StudentLogged();
            fm.Show();
            this.Hide();
        }
    }
}
