using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBureauDeChange
{
    public partial class FrmBonus : Form
    {
        public FrmBonus()
        {
            InitializeComponent();
        }
        clsBureau monBureau = new clsBureau("B001", "Bureau Central", "Adresse par défaut", "Ouvert");

        private void FrmBonus_Load(object sender, EventArgs e)
        {
            monBureau.PaysDisponibles = clsSourcesDesDonnees.RecupererTousLesPays();

            cboMonnaieSource.Items.Clear();
            cboMonnaieCible.Items.Clear();

            foreach (clsPays unPays in monBureau.PaysDisponibles)
            {
                string ligne = unPays.Nom + " - " + unPays.Devise;
                cboMonnaieSource.Items.Add(ligne);
                cboMonnaieCible.Items.Add(ligne);
            }

            cboMonnaieSource.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonnaieCible.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (cboMonnaieSource.SelectedIndex == -1 || cboMonnaieCible.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir la monnaie source et la monnaie cible.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMontant.Text == "")
            {
                MessageBox.Show("Veuillez entrer un montant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Source = cboMonnaieSource.SelectedIndex;
            int Cible = cboMonnaieCible.SelectedIndex;

            clsPays paysSource = monBureau.PaysDisponibles[Source];
            clsPays paysCible = monBureau.PaysDisponibles[Cible];

            double montant = Convert.ToDouble(txtMontant.Text);

            double montantCAD = montant / paysSource.Taux;
            double resultat = montantCAD * paysCible.Taux;

            lblResultat.Text = montant + " " + paysSource.Devise + " = " + resultat + " " + paysCible.Devise;
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            txtMontant.Text = "";
            lblResultat.Text = "";
            cboMonnaieSource.SelectedIndex = -1;
            cboMonnaieCible.SelectedIndex = -1;

            monBureau.PaysDisponibles = clsSourcesDesDonnees.RecupererTousLesPays();

            cboMonnaieSource.Items.Clear();
            cboMonnaieCible.Items.Clear();

            foreach (clsPays unPays in monBureau.PaysDisponibles)
            {
                string result = unPays.Nom + " - " + unPays.Devise;
                cboMonnaieSource.Items.Add(result);
                cboMonnaieCible.Items.Add(result);
            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
