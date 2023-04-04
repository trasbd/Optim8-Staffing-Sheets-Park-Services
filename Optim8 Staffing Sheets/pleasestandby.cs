using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Optim8_Staffing_Sheets
{
    public partial class pleasestandby : Form
    {
        public pleasestandby()
        {
            InitializeComponent();

            this.ShowDialog();
            Thread.Sleep(5000);


        }

        private void pleasestandby_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
