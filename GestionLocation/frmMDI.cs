using GestionLocation.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionLocation
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeConnecter f = new frmSeConnecter();
            f.Show();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void frmMDI_Load(object sender, EventArgs e)
        //{
        //    Computer mycomputer = new Computer();
        //    this.Width = mycomputer.Screen.Bounds.Width;
        //    this.Height = mycomputer.Screen.Bounds.Height;
        //    this.Location = new Point(0, 0);

        //}

        private void parametreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            //for each child from set the window state to Maximized
            foreach (Form chform in charr)
            {
                //chform.WindowState = FormWindowState.Maximized;
                chform.Close();
               
            }
        }

        

        private void proprietaireToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fermer();
            frmProprietaire f = new frmProprietaire();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void appartementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmAppartement f = new frmAppartement();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void locataireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmLocataire f = new frmLocataire();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void modePaiementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmModePaiement f = new frmModePaiement();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }

        private void paiementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmPaiement f = new frmPaiement();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        
    }
}
