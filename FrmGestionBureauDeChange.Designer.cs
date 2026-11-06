namespace frmBureauDeChange
{
    partial class FrmGestionBureauDeChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSuprimer = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtNomMonnaie = new System.Windows.Forms.TextBox();
            this.txtValeurMonnaie = new System.Windows.Forms.TextBox();
            this.txtNomPays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInformations = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPaysChoisi = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(341, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANQUE DE TORONTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(285, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bureau De Changes International";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnAnuler);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.btnSuprimer);
            this.groupBox1.Controls.Add(this.btnSauvegarder);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.txtNomMonnaie);
            this.groupBox1.Controls.Add(this.txtValeurMonnaie);
            this.groupBox1.Controls.Add(this.txtNomPays);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblInformations);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(340, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 361);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations sur pays choisi ";
            // 
            // btnAnuler
            // 
            this.btnAnuler.BackColor = System.Drawing.Color.Black;
            this.btnAnuler.ForeColor = System.Drawing.Color.LightGreen;
            this.btnAnuler.Location = new System.Drawing.Point(535, 296);
            this.btnAnuler.Name = "btnAnuler";
            this.btnAnuler.Size = new System.Drawing.Size(141, 44);
            this.btnAnuler.TabIndex = 11;
            this.btnAnuler.Text = "annuler";
            this.btnAnuler.UseVisualStyleBackColor = false;
            this.btnAnuler.Click += new System.EventHandler(this.btnAnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Black;
            this.btnModifier.ForeColor = System.Drawing.Color.LightGreen;
            this.btnModifier.Location = new System.Drawing.Point(535, 118);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(141, 44);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSuprimer
            // 
            this.btnSuprimer.BackColor = System.Drawing.Color.Black;
            this.btnSuprimer.ForeColor = System.Drawing.Color.LightGreen;
            this.btnSuprimer.Location = new System.Drawing.Point(535, 239);
            this.btnSuprimer.Name = "btnSuprimer";
            this.btnSuprimer.Size = new System.Drawing.Size(141, 44);
            this.btnSuprimer.TabIndex = 9;
            this.btnSuprimer.Text = "Suprimer";
            this.btnSuprimer.UseVisualStyleBackColor = false;
            this.btnSuprimer.Click += new System.EventHandler(this.btnSuprimer_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.BackColor = System.Drawing.Color.Black;
            this.btnSauvegarder.ForeColor = System.Drawing.Color.LightGreen;
            this.btnSauvegarder.Location = new System.Drawing.Point(535, 178);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(141, 44);
            this.btnSauvegarder.TabIndex = 8;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = false;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click_1);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Black;
            this.btnAjouter.ForeColor = System.Drawing.Color.LightGreen;
            this.btnAjouter.Location = new System.Drawing.Point(535, 60);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(141, 44);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtNomMonnaie
            // 
            this.txtNomMonnaie.ForeColor = System.Drawing.Color.Red;
            this.txtNomMonnaie.Location = new System.Drawing.Point(135, 134);
            this.txtNomMonnaie.Name = "txtNomMonnaie";
            this.txtNomMonnaie.Size = new System.Drawing.Size(362, 28);
            this.txtNomMonnaie.TabIndex = 6;
            // 
            // txtValeurMonnaie
            // 
            this.txtValeurMonnaie.ForeColor = System.Drawing.Color.Red;
            this.txtValeurMonnaie.Location = new System.Drawing.Point(135, 186);
            this.txtValeurMonnaie.Name = "txtValeurMonnaie";
            this.txtValeurMonnaie.Size = new System.Drawing.Size(111, 28);
            this.txtValeurMonnaie.TabIndex = 5;
            // 
            // txtNomPays
            // 
            this.txtNomPays.ForeColor = System.Drawing.Color.Red;
            this.txtNomPays.Location = new System.Drawing.Point(135, 71);
            this.txtNomPays.Name = "txtNomPays";
            this.txtNomPays.Size = new System.Drawing.Size(362, 28);
            this.txtNomPays.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "monnaie :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(478, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "valeur :                           par rapport a 1 CAN.Dollar";
            // 
            // lblInformations
            // 
            this.lblInformations.ForeColor = System.Drawing.Color.Red;
            this.lblInformations.Location = new System.Drawing.Point(21, 276);
            this.lblInformations.Name = "lblInformations";
            this.lblInformations.Size = new System.Drawing.Size(429, 52);
            this.lblInformations.TabIndex = 1;
            this.lblInformations.Text = "Informations";
            this.lblInformations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom pays :";
            // 
            // lstPaysChoisi
            // 
            this.lstPaysChoisi.FormattingEnabled = true;
            this.lstPaysChoisi.ItemHeight = 22;
            this.lstPaysChoisi.Location = new System.Drawing.Point(6, 41);
            this.lstPaysChoisi.Name = "lstPaysChoisi";
            this.lstPaysChoisi.Size = new System.Drawing.Size(282, 312);
            this.lstPaysChoisi.TabIndex = 3;
            this.lstPaysChoisi.SelectedIndexChanged += new System.EventHandler(this.lstPaysChoisi_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.lstPaysChoisi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 361);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choisir un pays :";
            // 
            // FrmGestionBureauDeChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1050, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionBureauDeChange";
            this.Text = "FrmGestionBureauDeChange";
            this.Load += new System.EventHandler(this.FrmGestionBureauDeChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPaysChoisi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInformations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomMonnaie;
        private System.Windows.Forms.TextBox txtValeurMonnaie;
        private System.Windows.Forms.TextBox txtNomPays;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSuprimer;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnuler;
    }
}