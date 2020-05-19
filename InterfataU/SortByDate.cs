using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataU
{
    public partial class SortByDate : Form
    {
        List<DateTime> dates = new List<DateTime>();
        public SortByDate()
        {
            InitializeComponent();
        }

        private void bttnOk_Click(object sender, EventArgs e)
        {
            dates.Add(dateTimeFirst.Value);
            dates.Add(dateTimeLast.Value);
            this.Hide();
        }

        public List<DateTime> GetDates=>dates;
     
    }
}
