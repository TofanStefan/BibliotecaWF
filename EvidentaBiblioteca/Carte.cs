using System;
using System.Collections.Generic;
using System.Text;

namespace EvidentaBiblioteca
{

    public class Carte
    {
        DateTime dataAdaugarii;
        DateTime dataModificarii;
        DateTime dataImprumutarii;
        DateTime dataReturnarii;
        public static int timpDeReturnare;//setare utilizator
        const char delimitator_fisier = ';';
        const char delimitator_fisier_secundar = ' ';
        static int ID_ = 0;
        string titlu;
        string autor;
        int exemplare;
        int id;
        List<string> CheckBoxes = new List<string>();
        //Constructor default
        public Carte()
        {
            titlu = "null";
            autor = "null";
            exemplare = 0;
            id = -1;
            dataAdaugarii = DateTime.Now;
            dataModificarii = DateTime.Now;

        }
        //Constructor cu date
        public Carte(string titlu, string autor, int exemplare)
        {
            this.titlu = titlu;
            this.autor = autor;
            this.exemplare = exemplare;
            //Increment object ID
            this.id = ID_ + 1;
            //Increment static ID
            ID_++;
            dataAdaugarii = DateTime.Now;
            dataModificarii = DateTime.Now;
        }
        public Carte(string titlu, string autor, int exemplare, List<string> checkBoxes)
        {
            dataAdaugarii = DateTime.Now;
            dataModificarii = DateTime.Now;
            CheckBoxes = checkBoxes;
            this.titlu = titlu;
            this.autor = autor;
            this.exemplare = exemplare;
            //Increment object ID
            this.id = ID_ + 1;
            //Increment static ID
            ID_++;

        }
        //Constructor fisier
        public Carte(string linie)
        {
            string[] date, chbx;
            date = linie.Split(delimitator_fisier);
            titlu = date[0];
            autor = date[1];
            exemplare = Convert.ToInt32(date[2]);
            chbx = date[3].Split(' ');
            foreach (string cuvant in chbx)
                CheckBoxes.Add(cuvant);
            this.id = ID_ + 1;
            ID_++;
            string dataM = date[5];
            string dataA = date[4];
            DateTime.TryParse(dataA, out dataAdaugarii);
            DateTime.TryParse(dataM, out dataModificarii);
        }
        ///Proprietate ---> informatia dupa un format comercial 
        public string Info {
            get
            {

                return String.Format("| Titlu: {0,-30} | Autor: {1,-30} | Exemplare: {2,-10} | Janra: {3,-30} ", titlu, autor, exemplare, List_To_String_CHB(';'));
                // ("||{0}|| scrisa de ||{1}|| <<->> {2} exemplare <<->>{3} .";
            }
        }
        public string List_To_String_CHB(char x)
        { string line = string.Empty;
            foreach (var tip in CheckBoxes)
                line = line + " " + tip;
            char[] array = line.ToCharArray();
            array[0] = x;
            line = new string(array);
            return line;
        }
        public bool ExistsCheckBox(string line)
        {
            foreach (var x in CheckBoxes)
                if (x == line)
                    return true;
            return false;
        }
        public string Save_format_txt(char x)
        {
            string line;
            string chbOption = List_To_String_CHB(x);
            if (x != '.')
                return line = titlu + x + autor + x + exemplare + chbOption + x + dataAdaugarii.ToString() + x + dataModificarii.ToString();
            return line = titlu + x + autor + x + exemplare + chbOption;
        }
        public void Optiuni(List<string> list)
        {
            this.CheckBoxes = list;
        }
        public void StartDate()
        {
            dataImprumutarii = DateTime.Now;
            dataReturnarii = dataImprumutarii;
            dataReturnarii.AddDays(timpDeReturnare);
        }
        public int daysLeft()
        {
            return (dataReturnarii - dataImprumutarii).Days;

        }
        public DateTime GetDataA
        {
            get { return dataAdaugarii; }
        }
        public DateTime GetDataM
        {
            get { return dataModificarii; }
            set { dataModificarii = value; }
        }
        public bool Disponibil
        {
            get
            {
                if (exemplare == 0) return false;
                     return true;
            }                    
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public static int _ID_
        {
            set { ID_ = value; }
            get { return ID_; }
        }
        public string Titlu
        {
            get { return titlu; }
            set { titlu = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int Exemplare
        {
            get { return exemplare; }
            set { exemplare = value; }
        }


    }
}
