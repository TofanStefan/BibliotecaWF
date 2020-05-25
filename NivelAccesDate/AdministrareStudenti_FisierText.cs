using EvidentaBiblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierText implementeaza interfata IStocareData
    
    public class AdministrareStudenti_FisierText : IStocareDate
    {
        const string setari = "Setari.txt";
        string BooksFilePath;
        string PeopleFilePath;
        string NumeFisier { get; set; }
        string NumeFisierPersoana { get; set; }
        public AdministrareStudenti_FisierText(string numeFisier, string numeFisierPersoana)
        {
            this.NumeFisierPersoana = numeFisierPersoana;
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
            Stream FisierText = File.Open(numeFisierPersoana, FileMode.OpenOrCreate);
            FisierText.Close();
            Stream FisierSetari = File.Open(setari, FileMode.OpenOrCreate);
            FisierSetari.Close();

        }
    
        // write settings in txt
        public void WriteSettings(int[]values)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(setari, false))//overwrite
                {

                    string line = values[0].ToString() + ';' + values[1].ToString() + ';' + values[2].ToString();
                    swFisierText.WriteLine(line);
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        // returns string with setting from txt
        public string GetSettings()
        {
            

            try
            {
                using (StreamReader sr = new StreamReader(setari))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        
                    {
                        string result; 
                        result = line;
                        return result;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return string.Empty;

           
        
    }

    
        //User friendly txt files
        public AdministrareStudenti_FisierText(string path, string numeFisierBiblioteca, string numeFisierPersoane)
        {

            string pathFirst = path + "/" + numeFisierBiblioteca;
            string pathSecond = path + "/" + numeFisierPersoane;
            BooksFilePath = pathFirst;
            PeopleFilePath = pathSecond;
            try
            {
                Stream BooksFile = File.Open(pathFirst, FileMode.OpenOrCreate);
                BooksFile.Close();
                Stream PeopleFile = File.Open(pathSecond, FileMode.OpenOrCreate);
                PeopleFile.Close();
            }
            catch (System.IO.DirectoryNotFoundException)
            {


            }
        }
        //Adauga carte append or rewrite // true or false

        public void AdaugaPersoana(Persoana pers, bool append)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisierPersoana, append))
                {
                    swFisierText.WriteLine(pers.ReturnTxtFormat());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        public void AdaugaCarte(Carte book, bool append)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, append))
                {
                    swFisierText.WriteLine(book.Save_format_txt(';')) ;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        //Read file
        
        public List<Carte> GetCarti()
        {
            List<Carte> book = new List<Carte>();
            

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;


                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        book.Add(new Carte(line));
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return book;
        }
        //Write file people and books
        public void WriteFiles (List<Carte> Book, List<Persoana> Pers,bool append)
        {
            #region Write books
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(BooksFilePath, append))
                {
                    foreach(var book in Book)
                    swFisierText.WriteLine(book.Info);
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            #endregion
            #region Write people
            try
            {
                using (StreamWriter wFisierText = new StreamWriter(PeopleFilePath, append))
                {
                    foreach (var pers in Pers)
                    {
                        int count = pers.Count - 1;
                        wFisierText.WriteLine(pers.Nume + " este "+pers.Status+" si a imprumutat urmatoarele Carti: ");
                        
                        if (count >= 0)
                        for(int i=0;i<=count;i++)
                                wFisierText.WriteLine("\t"+pers.InfoP(i));
                        wFisierText.WriteLine("\n");


                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            #endregion
        }

        public List<Persoana> GetPersoane()
        {
            List<Persoana> pers = new List<Persoana>();
            Stream FisierText = File.Open(NumeFisierPersoana, FileMode.OpenOrCreate);
            FisierText.Close();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisierPersoana))
                {
                    string line;


                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        pers.Add(new Persoana(line));
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return pers;
        }
        public void deletePersFile()
        {
            File.Delete(NumeFisierPersoana);
        }
        public void deleteBooksFile()
        {
            File.Delete(NumeFisier);
        }

    }


}
