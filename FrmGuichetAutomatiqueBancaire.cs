using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace frmBureauDeChange
{
    public partial class FrmGuichetAutomatiqueBancaire : Form
    {
      
        clsBureau monBureau = new clsBureau("B001", "Bureau Central", "Adresse par défaut", "Ouvert");

        public FrmGuichetAutomatiqueBancaire()
        {
            InitializeComponent();
        }

        private void FrmGuichetAutomatiqueBancaire_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToLongDateString();

            
            monBureau.PaysDisponibles = clsSourcesDesDonnees.RecupererTousLesPays();

            
            foreach (clsPays unPays in monBureau.PaysDisponibles)
            {
                cboPaysChoisis.Items.Add(unPays.Nom + " - " + unPays.Devise);
            }
        }

        private void cboPaysChoisis_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cboPaysChoisis.SelectedIndex;
            clsPays pays = monBureau.PaysDisponibles[i];

            lblValeursActuelles.Text = "1 CAD Dollar = " + pays.Taux + " " + pays.Devise +
                "\n1 " + pays.Devise + " = " + (1 / pays.Taux) + " CAD Dollar";
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (cboPaysChoisis.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir un pays.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtValaConvertir.Text == "")
            {
                MessageBox.Show("Veuillez entrer un montant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = cboPaysChoisis.SelectedIndex;
            clsPays pays = monBureau.PaysDisponibles[i];

            double montant, resultat;
            montant = Convert.ToDouble(txtValaConvertir.Text);

            if (radCADVersMonnaie.Checked)
            {
                resultat = montant * pays.Taux;
                lblValeurConvertir.Text = resultat + " " + pays.Devise;
            }
            else if (radMonnaieVersCAD.Checked)
            {
                resultat = montant / pays.Taux;
                lblValeurConvertir.Text = resultat + " CAD";
            }
            else
            {
                MessageBox.Show("Veuillez choisir un type de conversion.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radCADVersMonnaie_CheckedChanged(object sender, EventArgs e)
        {
            lblMonnaieAConvertir.Text = "CAD";
        }

        private void radMonnaieVersCAD_CheckedChanged(object sender, EventArgs e)
        {
            if (cboPaysChoisis.SelectedIndex != -1)
            {
                int i = cboPaysChoisis.SelectedIndex;
                clsPays pays = monBureau.PaysDisponibles[i];
                lblMonnaieAConvertir.Text = pays.Devise;
            }
            else
            {
                lblMonnaieAConvertir.Text = "";
            }
        }


        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            txtValaConvertir.Text = "";
            lblValeurConvertir.Text = "";
            lblValeursActuelles.Text = "";
            lblMonnaieAConvertir.Text = "";
            cboPaysChoisis.SelectedIndex = -1;
            radCADVersMonnaie.Checked = false;
            radMonnaieVersCAD.Checked = false;
            monBureau.PaysDisponibles = clsSourcesDesDonnees.RecupererTousLesPays();
            cboPaysChoisis.Items.Clear();

            foreach (clsPays unPays in monBureau.PaysDisponibles)
            {
                cboPaysChoisis.Items.Add(unPays.Nom + " - " + unPays.Devise);
            }
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
