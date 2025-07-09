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
    public partial class frmContratLocation : Form
    {
        public frmContratLocation()
        {
            InitializeComponent();
        }

        MetierGestionLocation.Service1Client service = new MetierGestionLocation.Service1Client();
        BdAppartementContext db = new BdAppartementContext();
        private ContratLocation contratActuel;
        private void ResetForm()
        {
            txtNumero.Text = string.Empty;
            txtDateDebut.Text = string.Empty;
            txtDateFin.Text = string.Empty;
            txtMontant.Text = string.Empty;
            cbbAppartement.DataSource = LoadCbbAppartement().ToList();
            cbbLocataire.DataSource = LoadCbbLocataire().ToList();
            cbbAppartement.DisplayMember = "Text";
            cbbAppartement.ValueMember = "Value";
            cbbAppartement.SelectedIndex = -1;
            cbbLocataire.DisplayMember = "Text";
            cbbLocataire.ValueMember = "Value";
            cbbLocataire.SelectedIndex = -1;
            dgLocataire.DataSource = db.ContratLocations.Select(a => new { a.IdContrat,a.IdAppartement, a.Appartement.AdresseAppartement, a.Numero, a.DateDebut, a.DateFin, a.Montant, a.IdLocataire, a.Locataire.NomPrenom, }).ToList();
            txtNumero.Focus();
        }


        public string Appartement;

    

        private void frmContratLocation_Load(object sender, EventArgs e)
        {
            lblAppartement.Text = Appartement;
            ChargerStatuts();
            ResetForm();
        }

        private List<ListSelectionViewModel> LoadCbbAppartement()
        {
            var liste = service.GetListeAppartement(null, null, null).ToList();

            List<ListSelectionViewModel> list = new List<ListSelectionViewModel>();
            ListSelectionViewModel a = new ListSelectionViewModel();
            a.Text = "Selectionnez...";
            a.Value = string.Empty;
            list.Add(a);

            foreach (var item in liste)
            {
                ListSelectionViewModel b = new ListSelectionViewModel();
                b.Text = item.AdresseAppartement;
                b.Value = item.IdAppartement.ToString();
                list.Add(b);
            }
            return list;
        }

        private List<ListSelectionViewModel> LoadCbbLocataire()
        {
            var liste = service.GetListeLocataires().ToList();

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

        private void ChargerStatuts()
        {
            cbbStatut.Items.AddRange(new string[] { "Selectionnez...","En attente", "Validé", "Révoqué" });
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            contratActuel = new ContratLocation
            {
                Numero = txtNumero.Text,
                DateDebut = txtDateDebut.Value,
                DateFin = txtDateFin.Value,
                Montant = float.Parse(txtMontant.Text),
                Statut = cbbStatut.SelectedItem.ToString(),
                IdAppartement = (int)cbbAppartement.SelectedValue,
                IdLocataire = (int)cbbLocataire.SelectedValue,
                DateCreation = DateTime.Now
            };

            db.ContratLocations.Add(contratActuel);
            db.SaveChanges();
            MessageBox.Show("Contrat enregistré avec succès !");
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (contratActuel == null)
            {
                MessageBox.Show("Veuillez d'abord enregistrer un contrat.");
                return;
            }

            contratActuel.Statut = "Validé";
            db.SaveChanges();
            MessageBox.Show("Contrat validé !");
        }

        private void btnRevoquer_Click(object sender, EventArgs e)
        {
            if (contratActuel == null)
            {
                MessageBox.Show("Veuillez d'abord enregistrer un contrat.");
                return;
            }

            contratActuel.Statut = "Révoqué";
            db.SaveChanges();
            MessageBox.Show("Contrat révoqué !");
        }

       
    }
}
