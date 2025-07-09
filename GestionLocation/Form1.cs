using GestionLocation.Utils;
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
using GestionLocation.View;

namespace GestionLocation
{
    public partial class frmSeConnecter : Form
    {
        public frmSeConnecter()
        {
            InitializeComponent();
        }
        BdAppartementContext db = new BdAppartementContext();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdentifiant.Text))
                {
                    MessageBox.Show("Veuillez saisir un identifiant !");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMotdepasse.Text))
                {
                    MessageBox.Show("Veuillez saisir un mot de passe !");
                    return;
                }

                var luser = db.Utilisateurs.Where(a => a.Identifiant.ToLower() == txtIdentifiant.Text.ToLower()).FirstOrDefault();

                if (luser != null)
                {
                    bool motDePasseValide = false;
                    bool needsHashing = false;

                    if (luser.MotDePasse == null)
                    {
                        motDePasseValide = true;
                    }
                    else
                    {
                        // Vérifier si le mot de passe est déjà hashé (32 caractères hexadécimaux)
                        if (luser.MotDePasse.Length == 32 && IsHexString(luser.MotDePasse))
                        {
                            // Le mot de passe est déjà hashé, vérifier avec MD5
                            using (MD5 md5Hash = MD5.Create())
                            {
                                motDePasseValide = CryptApp.VerifyMd5Hash(md5Hash, txtMotdepasse.Text, luser.MotDePasse);
                            }
                        }
                        else
                        {
                            // Le mot de passe n'est pas hashé, comparer en clair
                            motDePasseValide = (luser.MotDePasse == txtMotdepasse.Text);

                            // Si la connexion est valide, marquer pour hashage
                            if (motDePasseValide)
                            {
                                needsHashing = true;
                            }
                        }
                    }

                    if (motDePasseValide)
                    {
                        // Hasher le mot de passe s'il n'est pas encore hashé
                        if (needsHashing)
                        {
                            try
                            {
                                using (MD5 md5Hash = MD5.Create())
                                {
                                    string hashedPassword = GetMd5Hash(md5Hash, txtMotdepasse.Text);
                                    luser.MotDePasse = hashedPassword;
                                    db.SaveChanges();
                                    MessageBox.Show("Mot de passe sécurisé avec succès !");
                                }
                            }
                            catch (Exception hashEx)
                            {
                                MessageBox.Show($"Erreur lors du hashage : {hashEx.Message}");
                                // Continue quand même avec la connexion
                            }
                        }

                        if (luser.Statut == null)
                        {
                            frmResetPassword f = new frmResetPassword();
                            f.idUser = luser.IdPersonne;
                            f.Show();
                            this.Hide();
                        }
                        else if (luser.Statut == "Enabled")
                        {
                            frmMDI f = new frmMDI();

                            // Déterminer le profil en fonction des données utilisateur
                            if (luser.Identifiant.ToLower() == "admin" || luser.Identifiant.ToLower().Contains("admin"))
                            {
                                f.profil = "Admin";
                            }
                            else
                            {
                                f.profil = "Gestionnaire";
                            }

                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show($"Compte désactivé. Statut: {luser.Statut}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe incorrect !");
                    }
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private bool IsHexString(string input)
        {
            return input.All(c => "0123456789ABCDEFabcdef".Contains(c));
        }

        // Méthode pour créer un hash MD5
        private string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}