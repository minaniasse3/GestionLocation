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
    public partial class frmResetPassword : Form
    {
        public int idUser;
 
        public frmResetPassword()
        {
            InitializeComponent();

        }
        BdAppartementContext db = new BdAppartementContext();

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtMotdepasse.Text == txtConfirmermotdepasse.Text)
            {
                var leUser = db.Utilisateurs.Find(idUser);
                if (leUser != null)
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        leUser.MotDePasse = CryptApp.GetMd5Hash(md5Hash, txtMotdepasse.Text);
                        leUser.Statut = "Enabled";
                        db.SaveChanges();

                    }
                    frmMDI f = new frmMDI();
                    f.Show();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("les mots de passe ne sont pas idantique");
            }
        }
    }
}
