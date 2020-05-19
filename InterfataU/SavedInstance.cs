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
    public partial class SavedInstance : Form
    {
        public SavedInstance()
        {
            InitializeComponent();
        }
        
        private void bttnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public bool CheckedRdb()
        {
            return rdbYes.Checked;
        }

    }
}
