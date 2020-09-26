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
    class StudentData
    {
        public string id { get; set; }
        public string pass { get; set; }
        public string mailid { get; set; }
        public string name { get; set; }
        public string pAddress { get; set; }
        public string phn { get; set; }
        public string picid { get; set; }

        public StudentData()
        {
            this.id = null;
            this.pass = null;
        }

    }
    
}