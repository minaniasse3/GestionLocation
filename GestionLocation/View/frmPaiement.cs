using GestionLocation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionLocation.View
{
    public partial class frmPaiement : Form
    {
       BdAppartementContext db = new BdAppartementContext();
        private Paiement paiementSelectionne = null;


        public frmPaiement()
        {
            InitializeComponent();
        }

        private void frmPaiement_Load(object sender, EventArgs e)
        {
            ChargerModesPaiement();
            ChargerContrats();
        }

        private void ChargerModesPaiement()
        {
            var modes = db.ModePaiements.ToList();
            cbbModePaiement.DataSource = modes;
            cbbModePaiement.DisplayMember = "LibelleModePaiement";
            cbbModePaiement.ValueMember = "IdModePaiement";
        }

        private void ChargerContrats()
        {
            var contrats = db.ContratLocations.ToList();
            cbbContratLocation.DataSource = contrats;
            cbbContratLocation.DisplayMember = "Numero";
            cbbContratLocation.ValueMember = "IdContrat";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text) || string.IsNullOrWhiteSpace(txtMontant.Text) ||
                cbbModePaiement.SelectedValue == null || cbbContratLocation.SelectedValue == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Paiement paiement = new Paiement
            {
                DatePaiment = txtDatePaiement.Value,
                Montant = float.Parse(txtMontant.Text),
                NumeroFacture = txtNumero.Text,
                IdModePaiement = (int)cbbModePaiement.SelectedValue,
                IdContrat = (int)cbbContratLocation.SelectedValue
            };

            db.Paiements.Add(paiement);
            db.SaveChanges();
            MessageBox.Show("Paiement enregistré avec succès !");
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (paiementSelectionne == null)
            {
                MessageBox.Show("Veuillez sélectionner un paiement à modifier !");
                return;
            }

            paiementSelectionne.DatePaiment = txtDatePaiement.Value;
            paiementSelectionne.Montant = float.Parse(txtMontant.Text);
            paiementSelectionne.NumeroFacture = txtNumero.Text;
            paiementSelectionne.IdModePaiement = (int)cbbModePaiement.SelectedValue;
            paiementSelectionne.IdContrat = (int)cbbContratLocation.SelectedValue;

            db.SaveChanges();
            MessageBox.Show("Paiement modifié !");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (paiementSelectionne == null)
            {
                MessageBox.Show("Veuillez sélectionner un paiement à supprimer !");
                return;
            }

            db.Paiements.Remove(paiementSelectionne);
            db.SaveChanges();
            MessageBox.Show("Paiement supprimé !");
        }
    }
}
