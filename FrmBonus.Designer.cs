namespace frmBureauDeChange
{
    partial class FrmBonus
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
            this.cboMonnaieSource = new System.Windows.Forms.ComboBox();
            this.cboMonnaieCible = new System.Windows.Forms.ComboBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboMonnaieSource
            // 
            this.cboMonnaieSource.FormattingEnabled = true;
            this.cboMonnaieSource.Location = new System.Drawing.Point(12, 12);
            this.cboMonnaieSource.Name = "cboMonnaieSource";
            this.cboMonnaieSource.Size = new System.Drawing.Size(255, 28);
            this.cboMonnaieSource.TabIndex = 0;
            // 
            // cboMonnaieCible
            // 
            this.cboMonnaieCible.FormattingEnabled = true;
            this.cboMonnaieCible.Location = new System.Drawing.Point(319, 12);
            this.cboMonnaieCible.Name = "cboMonnaieCible";
            this.cboMonnaieCible.Size = new System.Drawing.Size(280, 28);
            this.cboMonnaieCible.TabIndex = 1;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(370, 187);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(306, 26);
            this.txtMontant.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Veillez entrer un montant a convertir :";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(12, 303);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(136, 32);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecommencer.Location = new System.Drawing.Point(12, 357);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(136, 32);
            this.btnRecommencer.TabIndex = 5;
            this.btnRecommencer.Text = "recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(12, 406);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(136, 32);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(438, 357);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(307, 75);
            this.lblResultat.TabIndex = 7;
            // 
            // FrmBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.cboMonnaieCible);
            this.Controls.Add(this.cboMonnaieSource);
            this.Name = "FrmBonus";
            this.Text = "FrmBonus";
            this.Load += new System.EventHandler(this.FrmBonus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMonnaieSource;
        private System.Windows.Forms.ComboBox cboMonnaieCible;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblResultat;
    }
}