using System;
using System.Collections.Generic;
using System.IO;

namespace frmBureauDeChange
{
    public static class clsSourcesDesDonnees
    {
        public static List<clsPays> RecupererTousLesPays()
        {
            List<clsPays> tousLesPays = new List<clsPays>();

            StreamReader monfichier = new StreamReader("PaysInfos1.txt");
            while (monfichier.EndOfStream == false)
            {
                string nom = monfichier.ReadLine();
                string devise = monfichier.ReadLine();
                double taux = Convert.ToDouble(monfichier.ReadLine());

                clsPays unPays = new clsPays(nom, devise, taux);
                tousLesPays.Add(unPays);
            }
            monfichier.Close();

            return tousLesPays;
        }

        public static void EcrireLesPaysDansFichier(List<clsPays> lesPays)
        {

            StreamWriter monfichier = new StreamWriter("PaysInfos1.txt");
            foreach (clsPays unPays in lesPays)
            {
                monfichier.WriteLine(unPays.Nom);
                monfichier.WriteLine(unPays.Devise);
                monfichier.WriteLine(unPays.Taux.ToString());
            }
            monfichier.Close();
        }
    }
}
