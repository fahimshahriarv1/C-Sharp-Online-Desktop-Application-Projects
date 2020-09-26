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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApplication1
{
    
    public partial class NewsLine : Form
    {

        String ch1, ch2, ch3;

        IFirebaseClient client;
        public NewsLine()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }
        DataTable dt=new DataTable();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "HUU9yGA9b4sSxzsZD2JAytEuzVFmuGvNFBuirJjq",
            BasePath = "https://sudentteacher.firebaseio.com/"

        };
        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                Form2 fm = new Form2(Convert.ToString(selectedRow.Cells["Post"].Value), selectedrowindex);
                fm.ShowDialog();
            }
        }

        private async void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLogged fm = new StudentLogged();
            fm.Show();
            this.Hide();
        }

        private async void dataGridView1_MouseHover(object sender, EventArgs e)
        {
           
        }

       

            
        private async void NewsLine_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse res = null;
            res = await client.GetTaskAsync("NewsLineCnt/");

            countClass cc = res.ResultAs<countClass>();
            long x = Convert.ToInt64(cc.cnt.ToString());

            dt.Columns.Add("Post");
            dt.Columns.Add("Date");
            dt.Columns.Add("Time");
            dataGridView1.DataSource = dt;
            int i = 0;

            while(true)
            {
                i++;
                if (i > x)
                    break;
                FirebaseResponse res1 = null;
                res1 = await client.GetTaskAsync("NewsLine/3rdyear/1stsemester/CSE/post" + i.ToString());
                postOnlinedData d = res1.ResultAs<postOnlinedData>();
                DataRow r = dt.NewRow();
                r["Post"] = d.post;
                r["Date"] = d.Date;
                r["Time"] = d.Time;
                dt.Rows.Add(r);
            }

        }
    }
}
