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
    public partial class Form2 : Form
    {


        public string Post=null;
        int postn;


        protected override void OnClosed(EventArgs e)
        {
            
            this.Hide();
        }
        public Form2(String s,int x)
        {
            InitializeComponent();
            textBox1.Text = s;
            postn = x;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
