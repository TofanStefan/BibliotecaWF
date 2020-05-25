using System;
using System.Collections.Generic;
using EvidentaBiblioteca;

namespace NivelAccesDate
{
    public interface IStocareDate
    {
        void AdaugaCarte(Carte book,bool append);
        void AdaugaPersoana(Persoana book, bool append);

        List<Carte> GetCarti();
        List<Persoana> GetPersoane();
        void WriteFiles(List<Carte> Book, List<Persoana> Pers, bool append);
        void WriteSettings(int[] values);
        string GetSettings();
        void deletePersFile();
       void deleteBooksFile();
    }
}
