namespace GestionLocation.View
{
    partial class frmContratLocation
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
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnRevoquer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.Montant = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgLocataire = new System.Windows.Forms.DataGridView();
            this.lblAppartement = new System.Windows.Forms.Label();
            this.txtDateDebut = new System.Windows.Forms.DateTimePicker();
            this.txtDateFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbAppartement = new System.Windows.Forms.ComboBox();
            this.cbbLocataire = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbStatut = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocataire)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(277, 50);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(111, 23);
            this.btnChoisir.TabIndex = 38;
            this.btnChoisir.Text = "&Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            // 
            // btnRevoquer
            // 
            this.btnRevoquer.Location = new System.Drawing.Point(280, 566);
            this.btnRevoquer.Name = "btnRevoquer";
            this.btnRevoquer.Size = new System.Drawing.Size(111, 23);
            this.btnRevoquer.TabIndex = 40;
            this.btnRevoquer.Text = "&Revoquer";
            this.btnRevoquer.UseVisualStyleBackColor = true;
            this.btnRevoquer.Click += new System.EventHandler(this.btnRevoquer_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(144, 566);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(111, 23);
            this.btnValider.TabIndex = 39;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(8, 566);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(111, 23);
            this.btnEnregistrer.TabIndex = 37;
            this.btnEnregistrer.Text = "&Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(12, 320);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(325, 22);
            this.txtMontant.TabIndex = 34;
            // 
            // Montant
            // 
            this.Montant.AutoSize = true;
            this.Montant.Location = new System.Drawing.Point(9, 300);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(54, 16);
            this.Montant.TabIndex = 36;
            this.Montant.Text = "Montant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Date de fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Date de debut";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 89);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(325, 22);
            this.txtNumero.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Numero";
            // 
            // dgLocataire
            // 
            this.dgLocataire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocataire.Location = new System.Drawing.Point(429, 12);
            this.dgLocataire.Name = "dgLocataire";
            this.dgLocataire.RowHeadersWidth = 51;
            this.dgLocataire.RowTemplate.Height = 24;
            this.dgLocataire.Size = new System.Drawing.Size(1455, 648);
            this.dgLocataire.TabIndex = 28;
            // 
            // lblAppartement
            // 
            this.lblAppartement.AutoSize = true;
            this.lblAppartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppartement.Location = new System.Drawing.Point(12, 6);
            this.lblAppartement.Name = "lblAppartement";
            this.lblAppartement.Size = new System.Drawing.Size(0, 25);
            this.lblAppartement.TabIndex = 41;
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateDebut.Location = new System.Drawing.Point(12, 165);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(325, 22);
            this.txtDateDebut.TabIndex = 42;
            // 
            // txtDateFin
            // 
            this.txtDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateFin.Location = new System.Drawing.Point(12, 243);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(325, 22);
            this.txtDateFin.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Appartement";
            // 
            // cbbAppartement
            // 
            this.cbbAppartement.FormattingEnabled = true;
            this.cbbAppartement.Location = new System.Drawing.Point(12, 392);
            this.cbbAppartement.Name = "cbbAppartement";
            this.cbbAppartement.Size = new System.Drawing.Size(320, 24);
            this.cbbAppartement.TabIndex = 46;
            // 
            // cbbLocataire
            // 
            this.cbbLocataire.FormattingEnabled = true;
            this.cbbLocataire.Location = new System.Drawing.Point(17, 458);
            this.cbbLocataire.Name = "cbbLocataire";
            this.cbbLocataire.Size = new System.Drawing.Size(320, 24);
            this.cbbLocataire.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Locataire";
            // 
            // cbbStatut
            // 
            this.cbbStatut.FormattingEnabled = true;
            this.cbbStatut.Location = new System.Drawing.Point(17, 522);
            this.cbbStatut.Name = "cbbStatut";
            this.cbbStatut.Size = new System.Drawing.Size(320, 24);
            this.cbbStatut.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Statut";
            // 
            // frmContratLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 672);
            this.ControlBox = false;
            this.Controls.Add(this.cbbStatut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbLocataire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbAppartement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateFin);
            this.Controls.Add(this.txtDateDebut);
            this.Controls.Add(this.lblAppartement);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnRevoquer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgLocataire);
            this.Name = "frmContratLocation";
            this.Text = "Contrat de Location";
            this.Load += new System.EventHandler(this.frmContratLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLocataire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnRevoquer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label Montant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgLocataire;
        private System.Windows.Forms.Label lblAppartement;
        private System.Windows.Forms.DateTimePicker txtDateDebut;
        private System.Windows.Forms.DateTimePicker txtDateFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbAppartement;
        private System.Windows.Forms.ComboBox cbbLocataire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbStatut;
        private System.Windows.Forms.Label label6;
    }
}