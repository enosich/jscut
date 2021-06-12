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
using Gecko;

namespace jscut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            string curDir = Directory.GetCurrentDirectory();
            geckoWebBrowser1.Navigate(String.Format("file:///{0}/jscut/jscut.html", curDir));
        }

        private void geckoWebBrowser1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
