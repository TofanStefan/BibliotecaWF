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
using System.Text.RegularExpressions;
using NivelAccesDate;
using System.Resources;
using System.IO;
using System.Configuration;

namespace InterfataU
{
    public partial class Librarie : Form
    {
        //Constante pt antet tabel
        
        const string id = "ID", titlu = "Titlu", autor = "Autor", exemplare = "Exemplare";
        public static IStocareDate adminCarti = StocareFactory.GetAdministratorStocare();
        private const string FileBook = "Biblioteca.txt";
        private const string FilePers = "Persoana.txt";
        private const string DIRECTORY_PATH = "DirectoryPath";
        private const string EMPTY = "empty";
        private string _Path = string.Empty;
        //Constructor
        public Librarie()
        {
            InitializeComponent();
            string antetTabel = id.PadRight(10 - id.Length) + titlu +"\t\t        " + autor+ "\t\t" + exemplare;
            Antet.Text = antetTabel;
            Antet.Enabled = false;
            Lists.Lib = adminCarti.GetCarti();

            ListBox.ContextMenuStrip = contextMenuStrip1;
            showBooks();
            
        }
        //Add book Form
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var objUI = new AddForm();
            objUI.ShowDialog();
            showBooks();
        }
        //Update book Form
        private void ListBox_DoubleClick (object sender, EventArgs e)
        {
           if (ListBox.SelectedIndex >= 0)
            {

                int id = ListBox.SelectedIndex;
                var objUI = new AddForm();
                objUI.Update(id);
                objUI.ShowDialog();
                Update_Text_File();
                showBooks();
                objUI.UndoButton();
            }

        }
        //Delete book
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex >= 0)
            {
                int index_listBox = ListBox.SelectedIndex;
                ListBox.Items.RemoveAt(index_listBox);
                Lists.Lib.RemoveAt(index_listBox);
                Carte._ID_-= 1;

                if (index_listBox < Lists.Lib.Count)
                {
                    for (int i = index_listBox; i < Lists.Lib.Count; i++)
                        Lists.Lib[i].ID -= 1;
                    showBooks();

                }  
                    Update_Text_File();
            }
        }
        //Opens Form with people and resets books after closing it
        private void btnPeople_Click(object sender, EventArgs e)
        {
            var objUs = new People();
            objUs.ShowDialog();
            Update_Text_File_Pers();
            Update_Text_File();
            showBooks();

            
        }

        //Save file into chose directory
        private void SaveFile_Click(object sender, EventArgs e)
        {
            var ErrorMessage = new Error("No selected directory");
            if (IsSelected() == false)
                ErrorMessage.ShowDialog();
            else
            {
                var SaveFile = new SavedInstance();
                SaveFile.ShowDialog();
                //Save to config the path if rbtn is Yes
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings[DIRECTORY_PATH].Value = _Path;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                bool value = SaveFile.CheckedRdb();
                //Create files and write 
                Create_And_Or_Write();
                if (value!=true)
                {
                    config.AppSettings.Settings[DIRECTORY_PATH].Value = EMPTY;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    this._Path = string.Empty;
                }
            }
        }
        public void Create_And_Or_Write()
        {
            var file = new AdministrareStudenti_FisierText(this._Path, FileBook, FilePers);
            file.WriteFiles(Lists.Lib, Lists.Pers, true);

        }
        // Returns true if directory is selected
        public bool IsSelected()
        {
            if (ConfigurationManager.AppSettings[DIRECTORY_PATH] != EMPTY) {
                if (this._Path==string.Empty)
                    _Path = ConfigurationManager.AppSettings[DIRECTORY_PATH];
                return true;
            }
            if (this._Path != string.Empty)
                return true;
            return false;

        }
        //Dublura found == true /not found == false / Add Book
        static public bool CheckDublura(Carte current)
        {
            if (Lists.Lib.Count <= 0)
                return false;
            else
            {
                foreach(Carte book in Lists.Lib)
                {
                    if (string.Equals(current.Autor, book.Autor) && string.Equals(current.Titlu, book.Titlu))
                        return true;
                }
                return false;

            }
        }
        //Dublura found == true /not found == false / Update book
        static public bool CheckDublura(Carte current, int id)
        {
            if (Lists.Lib.Count <= 0)
                return false;
            else
            {
                foreach (Carte book in Lists.Lib)
                {
                    if(Lists.Lib.IndexOf(book)!=id)
                         if (string.Equals(current.Autor, book.Autor) && string.Equals(current.Titlu, book.Titlu))
                                return true;
                }
                return false;

            }
        }

        // updates path of directory
        private void btnFile_Click(object sender, EventArgs e)
        {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        this._Path = fbd.SelectedPath;
                    }
                }
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text == string.Empty)
                showBooks();
            else
            {
                ListBox.Items.Clear();
                int index = 1;
                foreach (var book in Lists.Lib)
                    if (book.Titlu.ToLower().Contains(SearchBox.Text.ToLower()))
                    {
                        string result = book.Titlu;
   
                        if (book.Titlu.Length > 18)
                        {
                            result = book.Titlu.Substring(0, 17) + "..";

                        }
                        string line = string.Format("{0,-4}", index++);
                        line += string.Format("{0,-20}", result);
                        line += string.Format("{0,-20}", book.Autor);
                        line += string.Format("{0,-20}", book.Exemplare.ToString());
                        ListBox.Items.Add(line);
                    }
                       
            }
        }

        //Prints books in ListBox after clearing it
        public void showBooks()
        {
            ListBox.Items.Clear();
            foreach (Carte book in Lists.Lib)
            {
                string result = book.Titlu;
                if (book.Titlu.Length > 18)
                {
                    result = book.Titlu.Substring(0, 17)+"..";
                   
                }
                string line = string.Format("{0,-4}", book.ID.ToString());
                line += string.Format("{0,-20}", result);
                line += string.Format("{0,-20}", book.Autor);
                line += string.Format("{0,-20}", book.Exemplare.ToString());
                ListBox.Items.Add(line);
            }

        }
        public string FormatLB(Carte book)
        {

            string result = book.Titlu;
            if (book.Titlu.Length > 18)
            {
                result = book.Titlu.Substring(0, 17) + "..";

            }
            string line = string.Format("{0,-4}", book.ID.ToString());
            line += string.Format("{0,-20}", result);
            line += string.Format("{0,-20}", book.Autor);
            line += string.Format("{0,-20}", book.Exemplare.ToString());
            return line;

        }

        private void dataAdaugariiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ListBox.SelectedIndex>=0)
            {
                var date = new DateForm(ListBox.SelectedIndex,true,"Data adaugarii..");
                date.ShowDialog();
            }
        }

        private void dataModificariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex >= 0)
            {
                var date = new DateForm(ListBox.SelectedIndex,false, "Data ultimei modificarii..");
                date.ShowDialog();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void filtreazaDupaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var obj = new SortByDate();
            obj.ShowDialog();
            var dates = obj.GetDates;
            if (dates.Count!=0)
            {
                ListBox.Items.Clear();
                foreach (var book in Lists.Lib)
                {
                    if (DateTime.Compare(dates[0], book.GetDataA) <= 0 && DateTime.Compare(dates[1], book.GetDataA) >= 0)
                        ListBox.Items.Add(FormatLB(book));
                }
            }
        }


        //Add line to txt file
        public static void AppendFile(Carte x, bool append)
        {
            adminCarti.AdaugaCarte(x, append);
        }
        //Delete file content and rewrite
        public void Update_Text_File()
        {
            if (Lists.Lib.Count > 0)
            {
                adminCarti.AdaugaCarte(Lists.Lib[0], false);
                for (int i = 1; i < Lists.Lib.Count; i++)
                    adminCarti.AdaugaCarte(Lists.Lib[i], true);
            }
        }
        public void Update_Text_File_Pers()
        {
            if (Lists.Pers.Count > 0)
            {
                adminCarti.AdaugaPersoana(Lists.Pers[0], false);
                for (int i = 1; i < Lists.Pers.Count; i++)
                    adminCarti.AdaugaPersoana(Lists.Pers[i], true);
            }
        }
    }
    //Static class for lists
    public static class Lists
    {
        public static List<Carte> Lib = new List<Carte>();
        public static List<Persoana> Pers = new List<Persoana>();
    }
}
