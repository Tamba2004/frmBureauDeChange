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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void bureauDeChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGuichetAutomatiqueBancaire Guichets = new FrmGuichetAutomatiqueBancaire();
            Guichets.MdiParent = this;
            Guichets.Show();
        }

        private void gestionDesPaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionBureauDeChange GestPays = new FrmGestionBureauDeChange();
            GestPays.MdiParent = this;
            GestPays.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result; 
            result = MessageBox.Show("Voulez-vous vraiment quitter l'application ?",
                                          "Confirmation",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

             if (result == DialogResult.Yes)
             {
                Application.Exit();
             }
        }

        private void bonusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBonus Bonus = new FrmBonus();
            Bonus.MdiParent = this;
            Bonus.Show();
        }
    }
}
