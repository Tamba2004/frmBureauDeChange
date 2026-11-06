namespace frmBureauDeChange
{
    partial class FrmGuichetAutomatiqueBancaire
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblValeurConvertir = new System.Windows.Forms.Label();
            this.txtValaConvertir = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblMonnaieAConvertir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radMonnaieVersCAD = new System.Windows.Forms.RadioButton();
            this.radCADVersMonnaie = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblValeursActuelles = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboPaysChoisis = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.btnFermer);
            this.groupBox1.Controls.Add(this.btnRecommencer);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 571);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programme De Change Avec Le Dollar Canadien";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(608, 502);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(154, 43);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click_1);
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(12, 502);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(154, 43);
            this.btnRecommencer.TabIndex = 5;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.SpringGreen;
            this.groupBox5.Controls.Add(this.lblValeurConvertir);
            this.groupBox5.Controls.Add(this.txtValaConvertir);
            this.groupBox5.Controls.Add(this.btnConvertir);
            this.groupBox5.Controls.Add(this.lblMonnaieAConvertir);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(12, 354);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(752, 128);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "applique la convertion";
            // 
            // lblValeurConvertir
            // 
            this.lblValeurConvertir.AutoSize = true;
            this.lblValeurConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeurConvertir.Location = new System.Drawing.Point(214, 85);
            this.lblValeurConvertir.Name = "lblValeurConvertir";
            this.lblValeurConvertir.Size = new System.Drawing.Size(167, 22);
            this.lblValeurConvertir.TabIndex = 5;
            this.lblValeurConvertir.Text = "Valeur convertion";
            // 
            // txtValaConvertir
            // 
            this.txtValaConvertir.Location = new System.Drawing.Point(218, 40);
            this.txtValaConvertir.Name = "txtValaConvertir";
            this.txtValaConvertir.Size = new System.Drawing.Size(100, 28);
            this.txtValaConvertir.TabIndex = 4;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(51, 80);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(141, 33);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir >>";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblMonnaieAConvertir
            // 
            this.lblMonnaieAConvertir.AutoSize = true;
            this.lblMonnaieAConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonnaieAConvertir.Location = new System.Drawing.Point(324, 46);
            this.lblMonnaieAConvertir.Name = "lblMonnaieAConvertir";
            this.lblMonnaieAConvertir.Size = new System.Drawing.Size(85, 22);
            this.lblMonnaieAConvertir.TabIndex = 1;
            this.lblMonnaieAConvertir.Text = "devise 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "entrez le montant : ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SpringGreen;
            this.groupBox4.Controls.Add(this.radMonnaieVersCAD);
            this.groupBox4.Controls.Add(this.radCADVersMonnaie);
            this.groupBox4.Location = new System.Drawing.Point(12, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 115);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Types De Conversions";
            // 
            // radMonnaieVersCAD
            // 
            this.radMonnaieVersCAD.AutoSize = true;
            this.radMonnaieVersCAD.ForeColor = System.Drawing.Color.Black;
            this.radMonnaieVersCAD.Location = new System.Drawing.Point(20, 83);
            this.radMonnaieVersCAD.Name = "radMonnaieVersCAD";
            this.radMonnaieVersCAD.Size = new System.Drawing.Size(170, 26);
            this.radMonnaieVersCAD.TabIndex = 1;
            this.radMonnaieVersCAD.TabStop = true;
            this.radMonnaieVersCAD.Text = "Monnaie->CAD";
            this.radMonnaieVersCAD.UseVisualStyleBackColor = true;
            this.radMonnaieVersCAD.CheckedChanged += new System.EventHandler(this.radMonnaieVersCAD_CheckedChanged);
            // 
            // radCADVersMonnaie
            // 
            this.radCADVersMonnaie.AutoSize = true;
            this.radCADVersMonnaie.ForeColor = System.Drawing.Color.Black;
            this.radCADVersMonnaie.Location = new System.Drawing.Point(20, 38);
            this.radCADVersMonnaie.Name = "radCADVersMonnaie";
            this.radCADVersMonnaie.Size = new System.Drawing.Size(170, 26);
            this.radCADVersMonnaie.TabIndex = 0;
            this.radCADVersMonnaie.TabStop = true;
            this.radCADVersMonnaie.Text = "CAD->Monnaie";
            this.radCADVersMonnaie.UseVisualStyleBackColor = true;
            this.radCADVersMonnaie.CheckedChanged += new System.EventHandler(this.radCADVersMonnaie_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SpringGreen;
            this.groupBox3.Controls.Add(this.lblValeursActuelles);
            this.groupBox3.Location = new System.Drawing.Point(338, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Les Valeurs Actuelles";
            // 
            // lblValeursActuelles
            // 
            this.lblValeursActuelles.Location = new System.Drawing.Point(6, 24);
            this.lblValeursActuelles.Name = "lblValeursActuelles";
            this.lblValeursActuelles.Size = new System.Drawing.Size(418, 88);
            this.lblValeursActuelles.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboPaysChoisis);
            this.groupBox2.Location = new System.Drawing.Point(6, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choisi votre pays ";
            // 
            // cboPaysChoisis
            // 
            this.cboPaysChoisis.ForeColor = System.Drawing.Color.Red;
            this.cboPaysChoisis.FormattingEnabled = true;
            this.cboPaysChoisis.Location = new System.Drawing.Point(6, 27);
            this.cboPaysChoisis.Name = "cboPaysChoisis";
            this.cboPaysChoisis.Size = new System.Drawing.Size(299, 30);
            this.cboPaysChoisis.TabIndex = 0;
            this.cboPaysChoisis.SelectedIndexChanged += new System.EventHandler(this.cboPaysChoisis_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(6, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(756, 44);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date Et Lieu De L echange";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bureau De Changes International";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "BANQUE DE TORONTO";
            // 
            // FrmGuichetAutomatiqueBancaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGuichetAutomatiqueBancaire";
            this.Text = "FrmGuichetAutomatiqueBancaire";
            this.Load += new System.EventHandler(this.FrmGuichetAutomatiqueBancaire_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboPaysChoisis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblValeursActuelles;
        private System.Windows.Forms.RadioButton radMonnaieVersCAD;
        private System.Windows.Forms.RadioButton radCADVersMonnaie;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblMonnaieAConvertir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValaConvertir;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblValeurConvertir;
    }
}