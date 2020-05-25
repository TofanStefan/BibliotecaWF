using EvidentaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
namespace InterfataU
{
    public partial class People : Form
    {
        const string id = "ID", titlu = "TITLU", autor = "AUTOR", exemplare = "BUC", nume = "NUME",status="STATUS";
        private int ID_;
        public People()
        {
            InitializeComponent();
            FormatTabel();
            PanelDesign();
            printPers();
        }
        private void PanelDesign()
        {
            panel1.BackColor = Color.FromArgb(50, Color.White);
            panel2.BackColor = Color.FromArgb(124, Color.Black);
            panel2.Visible = false;
            userIcon.BackColor = Color.FromArgb(0, Color.Black);
            bttn_AddPers.BackColor = Color.FromArgb(0, Color.Black);
            bttnCancel.BackColor = Color.FromArgb(0, Color.Black);
        }
        private void FormatTabel()
        {
            string antetTabel_pers = string.Format("{0,-6}{1,-29}{2,-10}", id, nume, status);
            string antetTabel_books = string.Format("{0,-3}{1,-20}{2}", id, titlu, autor);
            string antetTabel_books_left = string.Format("{0,-3}{1,-20}{2,-17}{3}", id, titlu, autor, exemplare);
            AntetBooks.Text = antetTabel_books;
            AntetBooks.Enabled = false;
            AntetPers.Text = antetTabel_pers;
            AntetPers.Enabled = false;
            AntetBooks_Left.Text = antetTabel_books_left;
            AntetBooks_Left.Enabled = false;
            lblAdd_Books.ForeColor = Color.Black;
            lbl_Librarie.ForeColor = Color.Black;
            lbl_Books.ForeColor = Color.Black;
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            designChange_AddPers();
            listBox_Book.Items.Clear();
        }

        private void listBox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (bttnAdd_Book_Left.Visible == false)
                if (listBox_Name.SelectedIndex >= 0)
                {

                    ID_ = listBox_Name.SelectedIndex;
                    Lists.Pers[ID_].Abateri_();
                    string line = "    Aceasta persoana are " + Lists.Pers[ID_].Abateri+"/"+Persoana.nrAbateri+ " abateri.";
                    textBoxAbateri.Text = line;

                    Print_Books_Pers();
                }

                else
                {
                    listBox_Book.Items.Clear();
                    textBoxAbateri.Text = string.Empty;
                }


        }
        private void bttnCancel_Books_Click(object sender, EventArgs e)
        {
            designRevert_AddBooks();
            listBox_Book.Items.Clear();
        }

        private void bttnAdd_Book_Click(object sender, EventArgs e)
        {
            if (listBox_Name.SelectedIndex >= 0 && bttnAdd_Book_Left.Visible == false)
            {
                int id = listBox_Name.SelectedIndex;
                designChange_AddBooks();
                printBooks();
                this.ID_ = id;

            }

        }

        private void bttnAdd_Book_Left_Click(object sender, EventArgs e)
        {
            if (listBox_Name.SelectedIndex >= 0)
            {

                int id = listBox_Name.SelectedIndex;
                if (Lists.Lib[id].Disponibil == true)
                {
                    if (Lists.Pers[ID_].MaxImprumut != Lists.Pers[ID_].Count)
                    {
                        if (Lists.Pers[ID_].dublura(Lists.Lib[id]) == false)
                        {
                            Lists.Lib[id].Exemplare -= 1;
                            Lists.Lib[id].StartDate();
                            Lists.Pers[ID_].Adaugare(Lists.Lib[id]);
                            string result = Lists.Lib[id].Titlu;
                            if (Lists.Lib[id].Titlu.Length > 19)
                                result = Lists.Lib[id].Titlu.Substring(0, 17) + "..";
                            string line = string.Format("{0,-3}{1,-20}{2}", Lists.Pers[ID_].ID_Carte, result, Lists.Lib[id].Autor);
                            listBox_Book.Items.Add(line);
                            printBooks();
                        }
                        else
                        {

                            string line = "Aceasta persoana a imprumutat deja aceasta carte";
                            Error eroare = new Error(line);
                            eroare.ShowDialog();

                        }

                    }
                    else
                    {

                        string line = "Aceasta persoana a ajuns la numarul maxim de \r carti imprumutate";
                        Error eroare = new Error(line);
                        eroare.ShowDialog();
                    }
                }

                else
                {

                    string line = "Aceasta carte este momentan indisponibila";
                    Error eroare = new Error(line);
                    eroare.ShowDialog();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox_Name.SelectedIndex >= 0)
            {
                int index = listBox_Name.SelectedIndex;
                listBox_Name.Items.RemoveAt(index);
                Lists.Pers.RemoveAt(index);
                Persoana._ID = Persoana._ID - 1;
                if (index < Lists.Pers.Count)
                {
                    for (int i = index; i < Lists.Pers.Count; i++)
                        Lists.Pers[i].ID_Pers -= 1;
                    listBox_Name.Items.Clear();
                    printPers();
                }
            }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            designRevert_AddPers();
            listBox_Name.Items.Clear();
            printPers();
        }



        private void printBooks()
        {
            listBox_Name.Items.Clear();
            string line;
            foreach (Carte book in Lists.Lib)
            {

                string result = book.Titlu;
                string autor = book.Autor;
                if (book.Titlu.Length > 19)
                    result = book.Titlu.Substring(0, 17) + "..";
                if (book.Autor.Length > 16)
                    autor = book.Autor.Substring(0, 14) + "..";
                line = string.Format("{0,-3}{1,-20}{2,-17}{3}", book.ID, result, autor, book.Exemplare.ToString());

                listBox_Name.Items.Add(line);
            }
        }
        private void printPers()
        {
            foreach (Persoana person in Lists.Pers)
            {
                string linie = string.Format("{0,-6}{1,-29}{2,-10}", person.ID_Pers, person.Nume, person.Status);
                listBox_Name.Items.Add(linie);
            }
        }

        private void btnDelete_Book_Click(object sender, EventArgs e)
        {
            if (listBox_Book.SelectedIndex >= 0)
            {
                int index = listBox_Book.SelectedIndex;
                listBox_Book.Items.RemoveAt(index);
                Lists.Lib[returnIndex(Lists.Pers[ID_].BookAtIndex(index))].Exemplare += 1;
                Lists.Pers[ID_].Remove_Book_At_Index(index);
                Print_Books_Pers();
                if(bttnAdd_Book_Left.Visible==true)
                printBooks();
           
            }
        }

        private int returnIndex(Carte current)
        {
            foreach (var book in Lists.Lib)
                if (book.Autor == current.Autor && book.Titlu == current.Titlu)
                    return Lists.Lib.IndexOf(book);
            return -1;
        }

        private void designChange_AddBooks()
        {
            listBox_Name.Items.Clear();
            lbl_Librarie.Visible = false;
            AntetPers.Visible = false;
            bttnDelete.Visible = false;
            bttnCancel_Books.Visible = true;
            AntetBooks_Left.Visible = true;
            lblAdd_Books.Visible = true;
            bttnAdd_Book_Left.Visible = true;


        }


        private void designRevert_AddBooks()
        {
            listBox_Name.Items.Clear();
            printPers();
            lbl_Librarie.Visible = true;
            AntetPers.Visible = true;
            bttnCancel_Books.Visible = false;
            bttnDelete.Visible = true;
            AntetBooks_Left.Visible = false;
            lblAdd_Books.Visible = false;
            bttnAdd_Book_Left.Visible = false;

        }

        private void listBox_Book_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox_Book.SelectedIndex>=0)
            {

            }
        }

        private void designChange_AddPers()
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

   
        private void designRevert_AddPers()
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }
        private void Print_Books_Pers()
        {
            listBox_Book.Items.Clear();
            List<string> print = new List<string>();
            print = Lists.Pers[ID_].ConvertTo_String();
            foreach (var line in print)
                listBox_Book.Items.Add(line);
        }

        private void Reset_Lbls_TxtBox()
        {
            lbl_Name.ForeColor = Color.White;
            txtBox_Name.Text = string.Empty;
            cmbStatus.Text = string.Empty;

        }
        private void bttn_AddPers_Click(object sender, EventArgs e)
        {


            if (txtBox_Name.Text == string.Empty|| cmbStatus.Text == string.Empty)
            {
                string line = "Camp obligatoriu";
                Error eroare = new Error(line);
                eroare.ShowDialog();
            }
            else
            {
                string toCompare;
                string name = txtBox_Name.Text;
                string status = cmbStatus.Text;
                name = name.ToLower();
                string trim = name.Replace(" ", string.Empty);
                foreach (var pers in Lists.Pers)
                {
                    toCompare = pers.Nume;
                    toCompare = toCompare.Replace(" ", string.Empty);
                    toCompare = toCompare.ToLower();

                    if (string.Equals(toCompare, trim)==true)
                    {

                        string line = "Persoana exista deja";
                        Error eroare = new Error(line);
                        eroare.ShowDialog();
                        return;
                    }
                }
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                name = textInfo.ToTitleCase(name).ToString();
                Persoana current = new Persoana(name, status);
                Lists.Pers.Add(current);
                Reset_Lbls_TxtBox();


            }


        }



    }
}
