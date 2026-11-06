namespace frmBureauDeChange
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bureauDeChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesPaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmeToolStripMenuItem
            // 
            this.programmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projetsToolStripMenuItem,
            this.bonusToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.programmeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmeToolStripMenuItem.Name = "programmeToolStripMenuItem";
            this.programmeToolStripMenuItem.Size = new System.Drawing.Size(138, 32);
            this.programmeToolStripMenuItem.Text = "programme";
            // 
            // projetsToolStripMenuItem
            // 
            this.projetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bureauDeChangeToolStripMenuItem,
            this.gestionDesPaysToolStripMenuItem});
            this.projetsToolStripMenuItem.Name = "projetsToolStripMenuItem";
            this.projetsToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.projetsToolStripMenuItem.Text = "projets";
            // 
            // bureauDeChangeToolStripMenuItem
            // 
            this.bureauDeChangeToolStripMenuItem.Name = "bureauDeChangeToolStripMenuItem";
            this.bureauDeChangeToolStripMenuItem.Size = new System.Drawing.Size(289, 36);
            this.bureauDeChangeToolStripMenuItem.Text = "Bureau De Change";
            this.bureauDeChangeToolStripMenuItem.Click += new System.EventHandler(this.bureauDeChangeToolStripMenuItem_Click);
            // 
            // gestionDesPaysToolStripMenuItem
            // 
            this.gestionDesPaysToolStripMenuItem.Name = "gestionDesPaysToolStripMenuItem";
            this.gestionDesPaysToolStripMenuItem.Size = new System.Drawing.Size(289, 36);
            this.gestionDesPaysToolStripMenuItem.Text = "Gestion Des Pays";
            this.gestionDesPaysToolStripMenuItem.Click += new System.EventHandler(this.gestionDesPaysToolStripMenuItem_Click);
            // 
            // bonusToolStripMenuItem
            // 
            this.bonusToolStripMenuItem.Name = "bonusToolStripMenuItem";
            this.bonusToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.bonusToolStripMenuItem.Text = "bonus";
            this.bonusToolStripMenuItem.Click += new System.EventHandler(this.bonusToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1041, 589);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bureauDeChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}