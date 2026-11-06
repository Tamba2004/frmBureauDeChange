using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace frmBureauDeChange
{
    public partial class FrmGestionBureauDeChange : Form
    {
        clsBureau monBureau = new clsBureau("B001", "Bureau Central", "Adresse par défaut", "Ouvert");
        int indiceCourant;
        string mode;

        public FrmGestionBureauDeChange()
        {
            InitializeComponent();
        }

        private void RechargerListBox()
        {
            lstPaysChoisi.Items.Clear();
            foreach (clsPays pays in monBureau.PaysDisponibles)
            {
                lstPaysChoisi.Items.Add(pays.Nom);
            }
        }

        private void AfficherInfosPays1()
        {
            if (monBureau.PaysDisponibles.Count > 0)
            {
                clsPays pays = monBureau.PaysDisponibles[indiceCourant];
                txtNomPays.Text = pays.Nom;
                txtNomMonnaie.Text = pays.Devise;
                txtValeurMonnaie.Text = pays.Taux.ToString();
                lblInformations.Text = "Pays " + (indiceCourant + 1) + " sur un total de " + monBureau.PaysDisponibles.Count;
            }
        }

        private void FrmGestionBureauDeChange_Load(object sender, EventArgs e)
        {
            monBureau.PaysDisponibles = clsSourcesDesDonnees.RecupererTousLesPays();

            if (monBureau.PaysDisponibles.Count == 0)
            {
                btnAjouter.Visible = true;
                btnModifier.Visible = btnSauvegarder.Visible = btnSuprimer.Visible = btnAnuler.Visible = false;
                lblInformations.Text = "Collection vide. Cliquez sur Ajouter pour commencer.";
                txtNomPays.Text = txtNomMonnaie.Text = txtValeurMonnaie.Text = "";
                btnAjouter.Focus();
            }
            else
            {
                RechargerListBox();
                indiceCourant = 0;
                AfficherInfosPays1();
            }
        }

        private void lstPaysChoisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPaysChoisi.SelectedIndex != -1)
            {
                indiceCourant = lstPaysChoisi.SelectedIndex;
                AfficherInfosPays1();

                btnAjouter.Visible = true;
                btnModifier.Visible = true;
                btnSuprimer.Visible = true;
                btnSauvegarder.Visible = false;
                btnAnuler.Visible = false;
            }
        }

        private void SauvegarderDansFichier()
        {
            clsSourcesDesDonnees.EcrireLesPaysDansFichier(monBureau.PaysDisponibles);
        }

        private void FrmGestionBureauDeChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            SauvegarderDansFichier();
        }

       

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            mode = "ajout";
            txtNomPays.Text = txtNomMonnaie.Text = txtValeurMonnaie.Text = "";
            txtNomPays.Focus();

            btnSauvegarder.Visible = btnAnuler.Visible = true;
            btnAjouter.Visible = btnModifier.Visible = btnSuprimer.Visible = false;

            lblInformations.Text = "Ajout d'un nouveau pays. Remplissez les champs et cliquez sur Sauvegarder.";
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lstPaysChoisi.SelectedIndex != -1)
            {
                mode = "modif";
                txtNomPays.Focus();

                btnSauvegarder.Visible = btnAnuler.Visible = true;
                btnAjouter.Visible = btnModifier.Visible = btnSuprimer.Visible = false;

                lblInformations.Text = "Modification du pays sélectionné. Faites vos changements, puis sauvegardez.";
            }
        }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            if (lstPaysChoisi.SelectedIndex != -1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce pays ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    monBureau.PaysDisponibles.RemoveAt(indiceCourant);
                    SauvegarderDansFichier();
                    RechargerListBox();

                    if (monBureau.PaysDisponibles.Count > 0)
                    {
                        indiceCourant = 0;
                        lstPaysChoisi.SelectedIndex = indiceCourant;
                    }
                    else
                    {
                        txtNomPays.Text = txtNomMonnaie.Text = txtValeurMonnaie.Text = "";
                        lblInformations.Text = "Tous les pays ont été supprimés";
                    }

                    btnModifier.Visible = btnSuprimer.Visible = btnSauvegarder.Visible = btnAnuler.Visible = false;
                    btnAjouter.Visible = true;
                }
            }
        }

        private void btnAnuler_Click(object sender, EventArgs e)
        {
            if (monBureau.PaysDisponibles.Count > 0)
            {
                AfficherInfosPays1();
            }
            else
            {
                txtNomPays.Text = txtNomMonnaie.Text = txtValeurMonnaie.Text = "";
                lblInformations.Text = "Annulation effectuée";
            }

            btnSauvegarder.Visible = btnAnuler.Visible = false;
            btnAjouter.Visible = btnModifier.Visible = btnSuprimer.Visible = true;
        }

        private void btnSauvegarder_Click_1(object sender, EventArgs e)
        {
            if (txtNomPays.Text == "" || txtNomMonnaie.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement.");
                return;
            }

            clsPays nouveauPays = new clsPays(txtNomPays.Text, txtNomMonnaie.Text, Convert.ToDouble(txtValeurMonnaie.Text));

            if (mode == "ajout")
            {
                monBureau.PaysDisponibles.Add(nouveauPays);
                indiceCourant = monBureau.PaysDisponibles.Count - 1;
                lblInformations.Text = "Nouveau pays ajouté avec succès.";
            }
            else if (mode == "modif")
            {
                monBureau.PaysDisponibles[indiceCourant] = nouveauPays;
                lblInformations.Text = "Pays modifié avec succès.";
            }

            SauvegarderDansFichier();
            RechargerListBox();
            lstPaysChoisi.SelectedIndex = indiceCourant;

            btnSauvegarder.Visible = btnAnuler.Visible = false;
            btnAjouter.Visible = btnModifier.Visible = btnSuprimer.Visible = true;
        }
    }
}
