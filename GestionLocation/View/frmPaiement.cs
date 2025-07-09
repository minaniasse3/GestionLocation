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
        MetierGestionLocation.Service1Client service = new MetierGestionLocation.Service1Client();
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
            var modes = service.GetListeModePaiements().ToList();
            cbbModePaiement.DataSource = modes;
            cbbModePaiement.DisplayMember = "LibelleModePaiement";
            cbbModePaiement.ValueMember = "IdModePaiement";
        }

        private void ChargerContrats()
        {
            var contrats = service.GetListeContratLocation(null).ToList();
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

            MetierGestionLocation.Paiement paiement = new MetierGestionLocation.Paiement
            {
                DatePaiment = txtDatePaiement.Value,
                Montant = float.Parse(txtMontant.Text),
                NumeroFacture = txtNumero.Text,
                IdModePaiement = (int)cbbModePaiement.SelectedValue,
                IdContrat = (int)cbbContratLocation.SelectedValue
            };

            if (service.AddPaiement(paiement))
            {
                MessageBox.Show("Paiement enregistré avec succès !");
            }
            else
            {
                MessageBox.Show("Erreur lors de l'enregistrement du paiement !");
            }
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

            MetierGestionLocation.Paiement paiement = new MetierGestionLocation.Paiement
            {
                IdPaiement = paiementSelectionne.IdPaiement,
                DatePaiment = txtDatePaiement.Value,
                Montant = float.Parse(txtMontant.Text),
                NumeroFacture = txtNumero.Text,
                IdModePaiement = (int)cbbModePaiement.SelectedValue,
                IdContrat = (int)cbbContratLocation.SelectedValue
            };

            if (service.UpdatePaiement(paiement))
            {
                MessageBox.Show("Paiement modifié !");
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification du paiement !");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (paiementSelectionne == null)
            {
                MessageBox.Show("Veuillez sélectionner un paiement à supprimer !");
                return;
            }

            MetierGestionLocation.Paiement paiement = new MetierGestionLocation.Paiement
            {
                IdPaiement = paiementSelectionne.IdPaiement
            };

            if (service.DeletePaiement(paiement))
            {
                MessageBox.Show("Paiement supprimé !");
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression du paiement !");
            }
        }
    }
}
