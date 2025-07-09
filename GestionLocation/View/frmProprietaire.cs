using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionLocation.Model;

namespace GestionLocation.View
{
    public partial class frmProprietaire : Form
    {
        public frmProprietaire()
        {
            InitializeComponent();
        }

        

        private void dgProprietaire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        MetierGestionLocation.Service1Client service = new MetierGestionLocation.Service1Client();
        BdAppartementContext db = new BdAppartementContext();

        private void ResetForm()
        {
            txtCNI.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNinea.Text = string.Empty;
            txtNomPrenom.Text = string.Empty;
            txtRccm.Text = string.Empty;
            txtTel.Text = string.Empty;
            dgProprietaire.DataSource = service.GetListeProprietaires().Select(a=> new { a.IdPersonne, a.NomPrenom, a.Telephone, a.CNI, a.Email, a.Ninea, a.Rccm }).ToList();
            txtNomPrenom.Focus();

        }
          
        private void frmProprietaire_Load(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MetierGestionLocation.Proprietaire p = new MetierGestionLocation.Proprietaire();
            p.NomPrenom= txtNomPrenom.Text;
            p.Telephone = txtTel.Text;
            p.Email = txtEmail.Text;
            p.Rccm = txtRccm.Text;
            p.Ninea = txtNinea.Text;
            p.CNI = txtCNI.Text;
            service.AddProprietaire(p);
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgProprietaire.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = dgProprietaire.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgProprietaire.CurrentRow.Cells[3].Value.ToString();
            txtCNI.Text = dgProprietaire.CurrentRow.Cells[4].Value.ToString();
            txtNinea.Text = dgProprietaire.CurrentRow.Cells[5].Value.ToString();
            txtRccm.Text = dgProprietaire.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProprietaire.CurrentRow.Cells[0].Value.ToString());
            var p = service.GetProprietaireById(id);//db.proprietaires.Find(id);
            p.NomPrenom = txtNomPrenom.Text;
            p.Telephone = txtTel.Text;
            p.Email = txtEmail.Text;
            p.Rccm = txtRccm.Text;
            p.Ninea = txtNinea.Text;
            p.CNI = txtCNI.Text;
            service.UpdateProprietaire(p);
            //db.SaveChanges();
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProprietaire.CurrentRow.Cells[0].Value.ToString());
            var p = service.GetProprietaireById(id);//db.proprietaires.Find(id);
            //db.proprietaires.Remove(p);
            service.DeleteProprietaire(p);
            //db.SaveChanges();
            ResetForm();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            frmPrintListeProprietaire f = new frmPrintListeProprietaire();
            f.Show();
            this.Enabled = false;
        }

        public void Activer()
        {
            this.Enabled = true;
        }
    }
}
