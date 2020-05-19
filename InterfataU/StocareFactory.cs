using NivelAccesDate;
using System.Configuration;

namespace InterfataU
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        private const string NUME_FISIER_PERSOANA = "NumeFisierPersoana";
        public static IStocareDate GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            var numeFisierPersoana = ConfigurationManager.AppSettings[NUME_FISIER_PERSOANA];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                   // case "bin":
                     //   return new AdministrareStudenti_FisierBinar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareStudenti_FisierText(numeFisier + "." + formatSalvare, numeFisierPersoana + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}
