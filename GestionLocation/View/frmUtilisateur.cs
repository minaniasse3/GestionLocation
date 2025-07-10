using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionLocation.Model;
using GestionLocation.Utils;


namespace GestionLocation.View
{
    public partial class frmUtilisateur : Form
    {
        public frmUtilisateur()
        {
            InitializeComponent();
        }
        MetierGestionLocation.Service1Client service = new MetierGestionLocation.Service1Client();
        BdAppartementContext db = new BdAppartementContext();

        private void btnAjouter_Click(object sender, EventArgs e)
        {
                using (MD5 md5Hash = MD5.Create())
                {
                    MetierGestionLocation.Utilisateur ut = new MetierGestionLocation.Utilisateur();
                    ut.Email = txtEmail.Text;
                    ut.MotDePasse = CryptApp.GetMd5Hash(md5Hash, "P@sser123");
                    ut.NomPrenom = txtNomPrenom.Text;
                    ut.Identifiant = txtIdentifiant.Text; 
                    ut.Telephone = txtTel.Text;
                    ut.Statut = "Enabled";
                    
                    if (service.AddUtilisateur(ut))
                    {
                        ResetForm();
                        MessageBox.Show("Utilisateur ajouté avec succès !");
                        GMailer.sendMail(ut.Email, "Creation compte", string.Format("Bonjour /n votre compte bien cree avec identifiant {0} et mot de passe {1}", ut.Identifiant,"P@sser123"));
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'ajout de l'utilisateur !");
                    }
                }
        }

        private void ResetForm()
        {
            txtEmail.Text = string.Empty;
            txtIdentifiant.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtNomPrenom.Text = string.Empty;
            dgUtilisateur.DataSource = service.GetListeUtilisateurs().Select(a => new { a.IdPersonne, a.NomPrenom, a.Telephone, a.CNI, a.Email }).ToList();
            txtNomPrenom.Focus();
        }

       private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            txtIdentifiant.Text = txtEmail.Text;

        }

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            var p = service.GetUtilisateurById(id);
            if (p != null && service.DeleteUtilisateur(p))
            {
                ResetForm();
                MessageBox.Show("Utilisateur supprimé avec succès !");
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression de l'utilisateur !");
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgUtilisateur.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = dgUtilisateur.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgUtilisateur.CurrentRow.Cells[3].Value.ToString();
            txtIdentifiant.Text = dgUtilisateur.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            var p = service.GetUtilisateurById(id);
            if (p != null)
            {
                p.NomPrenom = txtNomPrenom.Text;
                p.Telephone = txtTel.Text;
                p.Email = txtEmail.Text;
                p.Identifiant = txtIdentifiant.Text;
                
                if (service.UpdateUtilisateur(p))
                {
                    ResetForm();
                    MessageBox.Show("Utilisateur modifié avec succès !");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification de l'utilisateur !");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgUtilisateur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
