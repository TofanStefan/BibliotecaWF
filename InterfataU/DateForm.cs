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
    public partial class DateForm : Form
    {
        public DateForm()
        {
        }
        public DateForm(int index,bool type,string line)
        {
            InitializeComponent();
            monthCalendar.Enabled = false;
            lblText.Text = line;
            lblText.Left = (this.Width - lblText.Width) / 2;
            if (type == true)
                monthCalendar.SetDate(Lists.Lib[index].GetDataA);
            else
                monthCalendar.SetDate(Lists.Lib[index].GetDataM);

        }



        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
