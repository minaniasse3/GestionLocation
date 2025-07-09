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
        MetierGestionLocation.Service1Client service = new MetierGestionLocation.Service1Client();
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
            
            // Récupérer la liste des appartements
            var appartements = service.GetListeAppartement(null,null,null);
            
            // Créer une liste de propriétaires pour avoir accès aux noms
            var proprietaires = service.GetListeProprietaires().ToDictionary(p => p.IdPersonne, p => p.NomPrenom);
            
            // Créer la source de données avec les informations nécessaires
            dgAppartement.DataSource = appartements.Select(a => new { 
                a.IdAppartement, 
                a.AdresseAppartement, 
                a.Surface, 
                a.NombrePiece, 
                a.Capacite, 
                a.Disponible, 
                a.IdPropriataire,
                NomProprietaire = a.IdPropriataire.HasValue ? proprietaires[a.IdPropriataire.Value] : string.Empty
            }).ToList();
            
            txtAdresse.Focus();
        }

        private List<ListSelectionViewModel> LoadCbbProprietaire()
        {
            var liste = service.GetListeProprietaires().ToList();

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
            MetierGestionLocation.Appartement a = new MetierGestionLocation.Appartement();
            a.Capacite = float.Parse(txtCapacite.Text);
            a.Disponible= cbbDisponible.SelectedText=="Oui"?true:false;
            a.Surface = float.Parse(txtSurface.Text);
            a.NombrePiece = int.Parse(txtNombrePiece.Text);
            a.AdresseAppartement = txtAdresse.Text;
            a.IdPropriataire = int.Parse(cbbProprietaire.SelectedValue.ToString());
            service.AddAppartement(a);
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAppartement.CurrentRow.Cells[0].Value.ToString());
            var a = service.GetAppartementById(id);
            txtAdresse.Text =a.AdresseAppartement;
            cbbProprietaire.SelectedValue = a.IdPropriataire.ToString();
            txtSurface.Text = a.Surface.ToString();
            txtNombrePiece.Text = a.NombrePiece!=null ? a.NombrePiece.ToString():string.Empty;
            txtCapacite.Text = a.Capacite!=null? a.Capacite.ToString():string.Empty;
            cbbDisponible.SelectedValue = a.Disponible;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAppartement.CurrentRow.Cells[0].Value.ToString());
            var a = service.GetAppartementById(id);
            a.Capacite = float.Parse(txtCapacite.Text);
            a.Disponible = cbbDisponible.SelectedText == "Oui" ? true : false;
            a.Surface = float.Parse(txtSurface.Text);
            a.NombrePiece = int.Parse(txtNombrePiece.Text);
            a.AdresseAppartement = txtAdresse.Text;
            a.IdPropriataire = int.Parse(cbbProprietaire.SelectedValue.ToString());
            service.UpdateAppartement(a);
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAppartement.CurrentRow.Cells[0].Value.ToString());
            var a = service.GetAppartementById(id);
            service.DeleteAppartement(a);
            ResetForm();
        }

        private void btnContrat_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAppartement.CurrentRow.Cells[0].Value.ToString());
            var a = service.GetAppartementById(id);
            frmContratLocation frm = new frmContratLocation();
            frm.Appartement = a.AdresseAppartement;
            frm.Show();
        }

        private void dgAppartement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
