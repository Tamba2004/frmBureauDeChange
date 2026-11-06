using System;
using System.Collections.Generic;

namespace frmBureauDeChange
{
    public class clsBureau
    {
     
        private string numero;
        private string nomBureau;
        private string adresse;
        private List<clsPays> paysDisponibles;
        private string statut;

        
        public clsBureau()
        {
            numero = "Non defini";
            nomBureau = "Non defini";
            adresse = "Non defini";
            paysDisponibles = new List<clsPays>();
            statut = "Non defini";
        }

      
        public clsBureau(string numero, string nomBureau, string adresse, List<clsPays> paysDisponibles, string statut)
        {
            this.numero = numero;
            this.nomBureau = nomBureau;
            this.adresse = adresse;
            this.paysDisponibles = paysDisponibles;
            this.statut = statut;
        }

    
        public clsBureau(string numero, string nomBureau, string adresse, string statut)
        {
            this.numero = numero;
            this.nomBureau = nomBureau;
            this.adresse = adresse;
            this.paysDisponibles = new List<clsPays>();
            this.statut = statut;
        }

       
        public string Numero
        {
            get => numero;
            
        }

        public string NomBureau
        {
            get => nomBureau;
            set => nomBureau = value;
        }

        public string Adresse
        {
            get => adresse;
            set => adresse = value;
        }

        public List<clsPays> PaysDisponibles
        {
            get => paysDisponibles;
            set => paysDisponibles = value;
        }

        public string Statut
        {
            get => statut;
            set => statut = value;
        }

       
        public clsPays TrouverPays(string nomPays)
        {
            foreach (clsPays unPays in paysDisponibles)
            {
                if (unPays.Nom == nomPays)
                {
                    return unPays;
                }
            }
            return null;
        }
    }
}
