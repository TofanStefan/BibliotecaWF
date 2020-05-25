using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvidentaBiblioteca;
namespace InterfataU
{
    public partial class Settings : Form
    {
        int[] values=new int[3];
        public Settings()
        {
            InitializeComponent();
            toolTip.SetToolTip( pictureBox1,"Numarul maxim de carti imprumutate pe persoana");
            toolTip.SetToolTip(pictureBox2, "Numarul maxim de abateri(persoana nu returneaza cartea la timp)");
            toolTip.SetToolTip( pictureBox3,"Timpul alocat imprumutului");
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string[] firstCmb, secondCmb, thirdCmb;
            firstCmb = cmbMaxImprumut.Text.Split(' ');
            secondCmb = cmbReturnTime.Text.Split(' ');
            thirdCmb = cmbAbateri.Text.Split(' ');
            int MaxImprumut, ReturnTime, Abateri;
            MaxImprumut = Convert.ToInt32(firstCmb[1]);
            ReturnTime = Convert.ToInt32(secondCmb[0]);
            Abateri = Convert.ToInt32(thirdCmb[0]);

            Carte.timpDeReturnare = values[1];
            this.values[0] = MaxImprumut;
            this.values[1] = ReturnTime;
            values[2] = Abateri;
            Persoana.maxImprumut = values[0];
            Persoana.nrAbateri = values[2];
            Librarie.adminCarti.WriteSettings(values);
            this.Close();
        }
        public int[] returnValues => values;
    }
}
