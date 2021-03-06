﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EvidentaBiblioteca
{
    public class Persoana : Carte
    {  
        public static int maxImprumut = 3; //Setari utilizator  
        public static int nrAbateri = 3;   //Setari utilizator
        public int Abateri { get; set; } = 0;
        const char principalSeparator = ';';
        const char secondarySeparator = ',';
        const char bookSeparator = ' ';
        const char bookSeparator2 = '.';
        public static int _ID = 1; // ID persoana static 
        int id=0; // id persoana obiect curent 
        public string Status { get; set; }
        public int ID_Carte { get; set; } = 0; //id carte imprumutata  (pentru afisare)
        string numePers { get; set; }
        List<Carte> imprumut = new List<Carte>();
        //CONSTRUCTOR CE PRIMESTE NUMELE PERSOANEI
        public Persoana(string nume,string status)
        {
            id = _ID;
            numePers = nume;
            this.Status = status;
            _ID++;
        }
        public Persoana(string line)
        {
            id = _ID;
            _ID++;
            string[] separateByPrincipalSeparator = line.Split(principalSeparator);
            numePers =separateByPrincipalSeparator[0];
            Status=separateByPrincipalSeparator[1] ;
            int index = 0;
            if (separateByPrincipalSeparator.Length > 3)
            {
                string[] separateByBookSeparator = separateByPrincipalSeparator[2].Split(secondarySeparator);
                string[] bookItems;
                string[] chkBoxes;
                foreach (string book in separateByBookSeparator)
                {
                    index++;
                    if (index <= maxImprumut)
                    {
                        bookItems = book.Split(bookSeparator2);
                        chkBoxes = bookItems[3].Split(bookSeparator);
                        List<string> checkBoxes = new List<string>(chkBoxes);
                        Carte current = new Carte(bookItems[0], bookItems[1], Convert.ToInt32(bookItems[2]), checkBoxes);
                        Adaugare(current);
                    }
                }
                Abateri = Convert.ToInt32(separateByPrincipalSeparator[3]);
            }
            else
            {
                Abateri = Convert.ToInt32(separateByPrincipalSeparator[2]);

            }


        }
        public void Abateri_()
        {
                foreach (var book in imprumut)
                    if (book.daysLeft() <= 0)
                        Abateri++;
        }
        public string ReturnTxtFormat()
        {
            string line = string.Empty;
            string format;
            int index = 1; 
            foreach (Carte book in imprumut)
            {
                format = book.Save_format_txt('.');
                if (index == 1)
                    line = line + ";";
                if (index < imprumut.Count)
                    line = line + format+",";
                else
                   line = line + format;
                index++;
            }
            string finalLine = numePers + ';' + Status+ line+';'+this.Abateri;
            return finalLine;
        }
        public Carte BookAtIndex(int value) => imprumut[value];
        public int MaxImprumut => maxImprumut;
        public int Count => imprumut.Count();
        //Proprietate Nume
        public string Nume
        {
            get { return numePers; }
            set { numePers = value; }
        }
   
        //ID obiect
        public int ID_Pers
        {
            get { return this.id; }
            set { this.id = value; }
        }
  
      
        //Adaugare carte imprumutata obiect 
        public void Adaugare(Carte x)
        {
            ID_Carte++;
            imprumut.Add(x);

        }
        public string InfoP(int index)
        {
            return imprumut[index].Info;
        }
        //Verificare  existenta carte imprumutata obiect 
        public bool dublura(Carte x)
        {
            foreach (var book in imprumut)
                if (string.Equals(book.Titlu, x.Titlu) && string.Equals(book.Autor, x.Autor))
                    return true;
            return false;
        }

         /// Sterge carte si modifica ID
         public void Remove_Book_At_Index (int index)
        {
            imprumut.RemoveAt(index);
            ID_Carte--;

        }

        //Returneaza o colectie cu cartile imprumutate
        public List<string> ConvertTo_String()
        {
            string line;
            List<string> books = new List<string>();
            foreach (var book in imprumut)
            {
                string result = book.Titlu;
                if (book.Titlu.Length > 18)
                {
                    result = book.Titlu.Substring(0, 16) + "..";

                }
                int index = imprumut.IndexOf(book);
                line= string.Format("{0,-3}{1,-20}{2}", index+1, result, book.Autor);
                books.Add(line);
            }
            
            return books; 

        }
    }
}
