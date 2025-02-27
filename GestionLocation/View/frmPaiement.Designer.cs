namespace GestionLocation.View
{
    partial class frmPaiement
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
            this.cbbModePaiement = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatePaiement = new System.Windows.Forms.DateTimePicker();
            this.lblAppartement = new System.Windows.Forms.Label();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.Montant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPaiement = new System.Windows.Forms.DataGridView();
            this.cbbContratLocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaiement)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbModePaiement
            // 
            this.cbbModePaiement.FormattingEnabled = true;
            this.cbbModePaiement.Location = new System.Drawing.Point(7, 329);
            this.cbbModePaiement.Name = "cbbModePaiement";
            this.cbbModePaiement.Size = new System.Drawing.Size(320, 24);
            this.cbbModePaiement.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Mode de paiement";
            // 
            // txtDatePaiement
            // 
            this.txtDatePaiement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDatePaiement.Location = new System.Drawing.Point(12, 175);
            this.txtDatePaiement.Name = "txtDatePaiement";
            this.txtDatePaiement.Size = new System.Drawing.Size(325, 22);
            this.txtDatePaiement.TabIndex = 59;
            // 
            // lblAppartement
            // 
            this.lblAppartement.AutoSize = true;
            this.lblAppartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppartement.Location = new System.Drawing.Point(12, 16);
            this.lblAppartement.Name = "lblAppartement";
            this.lblAppartement.Size = new System.Drawing.Size(0, 25);
            this.lblAppartement.TabIndex = 58;
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(277, 60);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(111, 23);
            this.btnChoisir.TabIndex = 55;
            this.btnChoisir.Text = "&Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(284, 483);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(111, 23);
            this.btnSupprimer.TabIndex = 57;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(148, 483);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(111, 23);
            this.btnModifier.TabIndex = 56;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 483);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(111, 23);
            this.btnEnregistrer.TabIndex = 54;
            this.btnEnregistrer.Text = "&Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(7, 258);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(325, 22);
            this.txtMontant.TabIndex = 51;
            // 
            // Montant
            // 
            this.Montant.AutoSize = true;
            this.Montant.Location = new System.Drawing.Point(4, 238);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(54, 16);
            this.Montant.TabIndex = 53;
            this.Montant.Text = "Montant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Date Paiement";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 99);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(325, 22);
            this.txtNumero.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Numero";
            // 
            // dgPaiement
            // 
            this.dgPaiement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaiement.Location = new System.Drawing.Point(465, 22);
            this.dgPaiement.Name = "dgPaiement";
            this.dgPaiement.RowHeadersWidth = 51;
            this.dgPaiement.RowTemplate.Height = 24;
            this.dgPaiement.Size = new System.Drawing.Size(647, 648);
            this.dgPaiement.TabIndex = 47;
            // 
            // cbbContratLocation
            // 
            this.cbbContratLocation.FormattingEnabled = true;
            this.cbbContratLocation.Location = new System.Drawing.Point(6, 419);
            this.cbbContratLocation.Name = "cbbContratLocation";
            this.cbbContratLocation.Size = new System.Drawing.Size(320, 24);
            this.cbbContratLocation.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Contrat Location";
            // 
            // frmPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 672);
            this.ControlBox = false;
            this.Controls.Add(this.cbbContratLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbModePaiement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatePaiement);
            this.Controls.Add(this.lblAppartement);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPaiement);
            this.Name = "frmPaiement";
            this.Text = "Paiement";
            this.Load += new System.EventHandler(this.frmPaiement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPaiement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbModePaiement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDatePaiement;
        private System.Windows.Forms.Label lblAppartement;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label Montant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPaiement;
        private System.Windows.Forms.ComboBox cbbContratLocation;
        private System.Windows.Forms.Label label3;
    }
}