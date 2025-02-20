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

        BdAppartementContext db = new BdAppartementContext();

        public string Appartement;

    

        private void frmContratLocation_Load(object sender, EventArgs e)
        {
            lblAppartement.Text = Appartement; 
        }
    }
}
