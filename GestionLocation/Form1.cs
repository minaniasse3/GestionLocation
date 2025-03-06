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

            //Helper.WriteLogSystem("frmSeConnecter-btnSeConnecter_Click", "Bienvenue");
            GMailer.sendMail("mamecoumbakasse5@gmail.com", "text", "test envoie email");
            //frmMDI f = new frmMDI();
            //f.Show();
            //this.Hide();
            try
            {
                var luser = db.Utilisateurs.Where(a => a.Identiant.ToLower() == txtIdentifiant.Text.ToLower()).FirstOrDefault();
                if (luser != null)
                {
                    string hash = luser.MotDePasse;
                    using (MD5 md5Hash = MD5.Create())
                    {
                        if ((CryptApp.VerifyMd5Hash(md5Hash, txtMotdepasse.Text, hash)) || (luser.MotDePasse == null))
                        {
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
                                var le = db.Admins.Find((luser.IdPersonne));
                                if (le!=null)
                                {
                                    f.profil = "Admin";
                                }
                                else
                                {
                                    var leGes = db.Gestionnaires.Find(luser.IdPersonne);
                                    if (le != null)
                                    {
                                        f.profil = "Gestionnaire";
                                    }
                                }
                                f.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Identifiant ou mot de passe incorrecte !");

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrecte !");

                }

            }
            catch (Exception ex)
            {
                // todo: log
            }



        }
    }
}
