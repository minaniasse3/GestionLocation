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
    public partial class frmAppartement : Form
    {
        public frmAppartement()
        {
            InitializeComponent();
        }
        BdAppartementContext db=new BdAppartementContext();


        private void ResetForm()
        {
            txtAdresse.Text = string.Empty;
            txtSurface.Text = string.Empty;
            txtNombrePiece.Text = string.Empty;
            txtCapacite.Text = string.Empty;
            cbbDisponible.Text = "Selectionnez... ";
            cbbProprietaire.DataSource = LoadCbbProprietaire().ToList();
            cbbProprietaire.DisplayMember = "Text";
            cbbProprietaire.ValueMember= "Value";
            cbbProprietaire.SelectedIndex = -1;
            dgAppartement.DataSource = db.appartements.Select(a => new { a.IdAppartement,a.AdresseAppartement, a.Surface, a.NombrePiece, a.Capacite, a.Disponible, a.IdPropriataire, a.Proprietaire.NomPrenom, }).ToList();
            txtAdresse.Focus();
        }

        private List<ListSelectionViewModel> LoadCbbProprietaire()
        {
            var liste = db.proprietaires.ToList();


            List<ListSelectionViewModel> list = new List<ListSelectionViewModel>();
            ListSelectionViewModel a = new ListSelectionViewModel();
            a.Text = "Selectionnez...";
            a.Value = string.Empty;
            list.Add(a);

            foreach (var item in liste)
            {
                ListSelectionViewModel b = new ListSelectionViewModel();
                b.Text = item.NomPrenom;
                b.Value = item.IdPersonne.ToString();
                list.Add(b);
            }
            return list;
        }

            private void frmAppartement_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Appartement a = new Appartement();
            a.Capacite = float.Parse(txtCapacite.Text);
            a.Disponible= cbbDisponible.SelectedText=="Oui"?true:false;
            a.Surface = float.Parse(txtSurface.Text);
            a.NombrePiece = int.Parse(txtNombrePiece.Text);
            a.AdresseAppartement = txtAdresse.Text;
            a.IdPropriataire = int.Parse(cbbProprietaire.SelectedValue.ToString());
            db.appartements.Add(a);
            db.SaveChanges();
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAppartement.CurrentRow.Cells[0].Value.ToString());
            var a = db.appartements.Find(id);
            txtAdresse.Text =a.AdresseAppartement;
            cbbProprietaire.SelectedValue = a.Proprietaire.IdPersonne;
            txtSurface.Text = a.Surface.ToString();
            txtNombrePiece.Text = a.NombrePiece!=null ? a.NombrePiece.ToString():string.Empty;
            txtCapacite.Text = a.Capacite!=null? a.Capacite.ToString():string.Empty;
            cbbDisponible.SelectedValue = a.Disponible;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAppartement.CurrentRow.Cells[0].Value.ToString());
            var a = db.appartements.Find(id);
            a.Capacite = float.Parse(txtCapacite.Text);
            a.Disponible = cbbDisponible.SelectedText == "Oui" ? true : false;
            a.Surface = float.Parse(txtSurface.Text);
            a.NombrePiece = int.Parse(txtNombrePiece.Text);
            a.AdresseAppartement = txtAdresse.Text;
            a.IdPropriataire = int.Parse(cbbProprietaire.SelectedValue.ToString());
            db.SaveChanges();
            ResetForm();


        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAppartement.CurrentRow.Cells[0].Value.ToString());
            var a = db.appartements.Find(id);
            db.appartements.Remove(a);
            db.SaveChanges();
            ResetForm();
        }

        private void btnContrat_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAppartement.CurrentRow.Cells[0].Value.ToString());
            var a = db.appartements.Find(id);
            frmContratLocation frm = new frmContratLocation();
            frm.Appartement = string.Format("Adresse");
            frm.Show();
        }

        
    }
}
