using GestionLocation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;


namespace GestionLocation.View
{
    public partial class frmLocataire : Form
    {
        public frmLocataire()
        {
            InitializeComponent();
        }
        MetierGestionLocation.Service1Client service = new MetierGestionLocation.Service1Client();
        BdAppartementContext db = new BdAppartementContext();
        private void ResetForm()
        {
            txtCNI.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNomPrenom.Text = string.Empty;
            txtTel.Text = string.Empty;
            dgLocataire.DataSource = db.locataires.Select(a => new { a.IdPersonne, a.NomPrenom, a.Telephone, a.CNI, a.Email}).ToList();
            txtNomPrenom.Focus();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MetierGestionLocation.Locataire L = new MetierGestionLocation.Locataire();
            L.NomPrenom = txtNomPrenom.Text;
            L.Telephone = txtTel.Text;
            L.Email = txtEmail.Text;
            L.CNI = txtCNI.Text;
            service.AddLocataire(L);
            //db.locataires.Add(L);
            //db.SaveChanges();
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgLocataire.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = dgLocataire.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgLocataire.CurrentRow.Cells[3].Value.ToString();
            txtCNI.Text = dgLocataire.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgLocataire.CurrentRow.Cells[0].Value.ToString());
            var p = service.GetLocataireById(id);//db.locataires.Find(id);
            p.NomPrenom = txtNomPrenom.Text;
            p.Telephone = txtTel.Text;
            p.Email = txtEmail.Text;
            p.CNI = txtCNI.Text;
            //db.SaveChanges();
            service.UpdateLocataire(p);
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgLocataire.CurrentRow.Cells[0].Value.ToString());
            var p = service.GetLocataireById(id);
            service.DeleteLocataire(p); 
            ResetForm();
        }

        private void frmLocataire_Load(object sender, EventArgs e)
        {
            ResetForm();

        }

        
    }
}
