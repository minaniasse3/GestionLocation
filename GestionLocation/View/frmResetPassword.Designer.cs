namespace GestionLocation.View
{
    partial class frmResetPassword
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.txtMotdepasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmermotdepasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(408, 295);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(128, 37);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.UseWaitCursor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnQuiter
            // 
            this.btnQuiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiter.Location = new System.Drawing.Point(264, 295);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(119, 37);
            this.btnQuiter.TabIndex = 10;
            this.btnQuiter.Text = "&Quiter";
            this.btnQuiter.UseVisualStyleBackColor = true;
            this.btnQuiter.UseWaitCursor = true;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // txtMotdepasse
            // 
            this.txtMotdepasse.Location = new System.Drawing.Point(268, 128);
            this.txtMotdepasse.Name = "txtMotdepasse";
            this.txtMotdepasse.Size = new System.Drawing.Size(272, 22);
            this.txtMotdepasse.TabIndex = 7;
            this.txtMotdepasse.UseSystemPasswordChar = true;
            this.txtMotdepasse.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mot de passe";
            this.label2.UseWaitCursor = true;
            // 
            // txtConfirmermotdepasse
            // 
            this.txtConfirmermotdepasse.Location = new System.Drawing.Point(268, 234);
            this.txtConfirmermotdepasse.Name = "txtConfirmermotdepasse";
            this.txtConfirmermotdepasse.Size = new System.Drawing.Size(272, 22);
            this.txtConfirmermotdepasse.TabIndex = 6;
            this.txtConfirmermotdepasse.UseSystemPasswordChar = true;
            this.txtConfirmermotdepasse.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Confirmer mot de passe";
            this.label1.UseWaitCursor = true;
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.txtMotdepasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirmermotdepasse);
            this.Controls.Add(this.label1);
            this.Name = "frmResetPassword";
            this.Text = "Changer votre mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.TextBox txtMotdepasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmermotdepasse;
        private System.Windows.Forms.Label label1;
    }
}