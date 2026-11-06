using System;

namespace frmBureauDeChange
{
    public class clsPays
    {
  
        private string nom;
        private string devise;
        private double taux;

        public clsPays()
        {
            nom = "Non defini";
            devise = "Non defini";
            taux = 0;
        }

        public clsPays(string nom, string devise, double taux)
        {
            this.nom = nom;
            this.devise = devise;
            this.taux = taux;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public string Devise
        {
            get => devise;
            set => devise = value;
        }

        public double Taux
        {
            get => taux;
            set => taux = value;
        }

        public string Afficher()
        {
            

            return "Nom pays : " + nom +
                   "\nMonnaie : " + devise +
                   "\nValeur actuelle : 1 CAD Dollar = " + taux + " " + devise ;
        }
    }
}
