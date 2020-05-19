using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataU
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }
        public Error(string line)
        {
            InitializeComponent();

            labelEroare.Text = line;
            labelEroare.Left = (this.Width - labelEroare.Width) / 2;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
