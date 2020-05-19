using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvidentaBiblioteca;

namespace InterfataU
{
    public partial class AddForm : Form
    {
        private int id=-1;
        List<string> checkBoxes = new List<string>();
        public AddForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            
            CodEroare valid = Validare(txtTitlu.Text, txtAutor.Text);
            if (valid != CodEroare.CORECT)
                MarcheazaIncorect(valid);

            else
            {
               
                Carte current = new Carte(txtTitlu.Text, txtAutor.Text, (int)nrExemp.Value,checkBoxes);

                if (Librarie.CheckDublura(current) == true)
                    MessageError.Visible = true;
                else
                {
                    Lists.Lib.Add(current);
                    Librarie.AppendFile(current, true);
                    Reset();
                }
            }
        }

        private void Reset()
        {
            lblAutor.ForeColor = default;
            lblTitlu.ForeColor = default;
            txtTitlu.Text = string.Empty;
            txtAutor.Text = string.Empty;
            MessageError.Visible = false;
            foreach (var tip in groupBox.Controls)
                if (tip is CheckBox)
                {
                    var tipCarte = tip as CheckBox;
                    if (tipCarte.Checked == true)
                        tipCarte.Checked = false;
                }

            nrExemp.Value = 0;
        }
        private CodEroare Validare(string titlu, string autor)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (titlu == string.Empty)
            {
                rezultatValidare |= CodEroare.TITLU_INCORECT;
            }
            if (autor == string.Empty)
            {
                rezultatValidare |= CodEroare.AUTOR_INCORECT;
            }
            if(ValidareBoxes()==false)
                rezultatValidare |= CodEroare.CASUTA_NESELECTATA;


            return rezultatValidare;
        }
        private void MarcheazaIncorect(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.AUTOR_INCORECT) == CodEroare.AUTOR_INCORECT)
                lblAutor.ForeColor = Color.Red;
            else
                lblAutor.ForeColor = default;



            if ((codValidare & CodEroare.TITLU_INCORECT) == CodEroare.TITLU_INCORECT)
                lblTitlu.ForeColor = Color.Red;
            else
                lblTitlu.ForeColor = default;

            if ((codValidare & CodEroare.CASUTA_NESELECTATA) == CodEroare.CASUTA_NESELECTATA)
            {
                var ErrorMessege = new Error("Selectati cel putin o casuta.");
                ErrorMessege.ShowDialog();
            }



        }

        private void Apply_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void Update(int id)
        {
            txtAutor.Text = Lists.Lib[id].Autor;
            txtTitlu.Text = Lists.Lib[id].Titlu;
            nrExemp.Value = Lists.Lib[id].Exemplare;
            foreach (var tip in groupBox.Controls)
                if (tip is CheckBox)
                {
                    var tipCarte = tip as CheckBox;
                    if  (Lists.Lib[id].ExistsCheckBox((tipCarte.Text)))
                        tipCarte.Checked = true;
                }

            bttnUpdate.Visible = true;
            bttnAdd.Visible = false;
            this.id = id;
        }
        public void UndoButton()
        {
            bttnUpdate.Visible = false;
            bttnAdd.Visible = true;

        }
        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (this.id == -1)
                return;
            Carte current = new Carte( txtTitlu.Text, txtAutor.Text, (int)nrExemp.Value);
            CodEroare valid = Validare(txtTitlu.Text, txtAutor.Text);
            bool value = Librarie.CheckDublura(current, id);
            if (valid != CodEroare.CORECT) 
                MarcheazaIncorect(valid);
            if (value == true)
                MessageError.Visible = true;

            else
            {

                Lists.Lib[id].Autor = txtAutor.Text;
                Lists.Lib[id].Titlu = txtTitlu.Text;
                Lists.Lib[id].Exemplare = (int)nrExemp.Value;
                Lists.Lib[id].Optiuni(ReturnCheckBoxes());
                Lists.Lib[id].GetDataM = DateTime.Now;

                Reset();
                this.Hide();
            }
        }
        private bool ValidareBoxes()
        {
            foreach(var tip in groupBox.Controls)
                if (tip is CheckBox)
                {
                    var tipCarte = tip as CheckBox;
                    if (tipCarte.Checked == true)
                        checkBoxes.Add(tipCarte.Text);
                }
            if(checkBoxes.Count!=0)
                return true;
            return false;

        }

        private List<string> ReturnCheckBoxes()
        {
            List<string> options = new List<string>();
            foreach (var tip in groupBox.Controls)
                if (tip is CheckBox)
                {
                    var tipCarte = tip as CheckBox;
                    if (tipCarte.Checked == true)
                        options.Add(tipCarte.Text);
                }
            return options;     

        }
        private void chkActiune_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
