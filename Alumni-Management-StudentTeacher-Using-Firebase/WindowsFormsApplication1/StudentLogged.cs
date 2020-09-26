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
    public partial class StudentLogged : Form
    {
        public StudentLogged()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
                Application.Exit();
        }
        private void StudentLogged_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewsLine fm = new NewsLine();
            fm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Courses fm = new Courses();
            this.Hide();
            fm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Welcome fm = new Welcome();
            this.Hide();
            fm.Show();
           
        }

        private void studentInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentInfo s = new StudentInfo();
            s.Show();
        }

        private void postOnlineB_Click(object sender, EventArgs e)
        {

            postOnline p = new postOnline();
            this.Hide();
            p.Show();

        }
    }
}
