using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class postOnline : Form
    {
        

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "HUU9yGA9b4sSxzsZD2JAytEuzVFmuGvNFBuirJjq",
            BasePath = "https://sudentteacher.firebaseio.com/"

        };

        IFirebaseClient client;

        public postOnline()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
        }

        private async void postButton_Click(object sender, EventArgs e)
        {
            SetResponse res = null;
            FirebaseResponse res1 = null;

            //newslineCount d = new newslineCount();
            postOnlinedData d = new postOnlinedData();
            d.post = textBox1.Text;
            d.Time= DateTime.Now.ToString("h:mm:ss tt");
            d.Date= DateTime.Now.ToString("yyyy-MM-dd tt");

           // MessageBox.Show(d.Date);

            res1 = await client.GetTaskAsync("NewsLineCnt/cnt");
            newslineCount d1 = res1.ResultAs<newslineCount>();
            //MessageBox.Show(d1.cnt);
            int x = Int32.Parse(d1.cnt);
            x++;
            d1.cnt = x.ToString();
            res = await client.SetTaskAsync("NewsLine/3rdyear/1stsemester/CSE/post"+x.ToString(), d);
            res = await client.SetTaskAsync("NewsLineCnt/cnt", d1);

            MessageBox.Show("Post Successfull");
            this.Hide();
            StudentLogged st = new StudentLogged();
            st.Show();


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogged st = new StudentLogged();
            st.Show();
        }
    }
}
