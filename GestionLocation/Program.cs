using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionLocation.Model;

namespace GestionLocation
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           CreateAdmin();
            Application.Run(new frmSeConnecter());
        }

        static void CreateAdmin()
        {
            BdAppartementContext db = new BdAppartementContext();
            var admin = db.Admins.FirstOrDefault();
            if (admin == null)
            {
                admin = new Admin();
                admin.NomPrenom = "Administrateur";
                admin.Telephone = "784577474";
                admin.Identifiant = "Admin";
                admin.Email = "admin@yopmail.com";
                admin.CNI = "0101010111";
                db.Admins.Add(admin);
                db.SaveChanges();
            }
        }
    }
}
