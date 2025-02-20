using GestionLocation.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionLocation
{
    public partial class frmSeConnecter : Form
    {
        public frmSeConnecter()
        {
            InitializeComponent();
        }

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
            frmMDI f = new frmMDI();
            f.Show();
            this.Hide();
        }
    }
}
