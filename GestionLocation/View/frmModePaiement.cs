﻿using GestionLocation.Model;
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
    public partial class frmModePaiement : Form
    {
        MetierGestionLocation.Service1Client service = new MetierGestionLocation.Service1Client();
        BdAppartementContext db = new BdAppartementContext();

        private void ResetForm()
        {
            txtLibelleModePaiement.Text = string.Empty;
            dgModePaiement.DataSource = db.ModePaiements.Select(a => new { a.IdModePaiement,a.LibelleModePaiement }).ToList();
            txtLibelleModePaiement.Focus();
        }
        public frmModePaiement()
        {
            InitializeComponent();
        }

        private void frmModePaiement_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MetierGestionLocation.ModePaiement a = new MetierGestionLocation.ModePaiement();
            a.LibelleModePaiement = txtLibelleModePaiement.Text;
            //db.ModePaiements.Add(a);
            //db.SaveChanges();
            service.AddModePaiement(a);
            ResetForm();
            MessageBox.Show("Mode de paiement ajouté !");
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgModePaiement.CurrentRow.Cells[0].Value.ToString());
            var a = service.GetModePaiementById(id);
            a.LibelleModePaiement = txtLibelleModePaiement.Text;
            //db.SaveChanges();
            service.UpdateModePaiement(a);
            ResetForm();
            MessageBox.Show("Mode de paiement modifié !");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgModePaiement.CurrentRow.Cells[0].Value.ToString());
            var a = service.GetModePaiementById(id); 
            //db.ModePaiements.Remove(a);
            service.DeleteModePaiement(a);
            db.SaveChanges();
            ResetForm();
            MessageBox.Show("Mode de paiement supprimé !");
        }
      

        private void dgModePaiement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgModePaiement.CurrentRow.Cells[0].Value.ToString());
            var a = db.ModePaiements.Find(id);
            txtLibelleModePaiement.Text = a.LibelleModePaiement;
        }
    }
}
