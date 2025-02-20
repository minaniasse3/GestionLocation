namespace GestionLocation
{
    partial class frmMDI
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
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDeconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appartementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locataireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.parametreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.seDeconnecterToolStripMenuItem.Text = "Se Deconnecter";
            this.seDeconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // parametreToolStripMenuItem
            // 
            this.parametreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proprietaireToolStripMenuItem,
            this.appartementToolStripMenuItem,
            this.locataireToolStripMenuItem});
            this.parametreToolStripMenuItem.Name = "parametreToolStripMenuItem";
            this.parametreToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.parametreToolStripMenuItem.Text = "&Parametre";
            this.parametreToolStripMenuItem.Click += new System.EventHandler(this.parametreToolStripMenuItem_Click);
            // 
            // proprietaireToolStripMenuItem
            // 
            this.proprietaireToolStripMenuItem.Name = "proprietaireToolStripMenuItem";
            this.proprietaireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.proprietaireToolStripMenuItem.Text = "Proprietaire";
            this.proprietaireToolStripMenuItem.Click += new System.EventHandler(this.proprietaireToolStripMenuItem_Click_1);
            // 
            // appartementToolStripMenuItem
            // 
            this.appartementToolStripMenuItem.Name = "appartementToolStripMenuItem";
            this.appartementToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.appartementToolStripMenuItem.Text = "Appartement";
            this.appartementToolStripMenuItem.Click += new System.EventHandler(this.appartementToolStripMenuItem_Click);
            // 
            // locataireToolStripMenuItem
            // 
            this.locataireToolStripMenuItem.Name = "locataireToolStripMenuItem";
            this.locataireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.locataireToolStripMenuItem.Text = "Locataire";
            this.locataireToolStripMenuItem.Click += new System.EventHandler(this.locataireToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "Application Gestion Location";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDeconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proprietaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appartementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locataireToolStripMenuItem;
    }
}