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
using GestionLocation.Report;

namespace GestionLocation.View
{
    public partial class frmPrintListeProprietaire : Form
    {
        public frmPrintListeProprietaire()
        {
            InitializeComponent();
        }
        BdAppartementContext db = new BdAppartementContext();

        private void frmPrintListeProprietaire_Load(object sender, EventArgs e)
        {
            rptListeProprietaire objRpt = new rptListeProprietaire();
            objRpt.SetDataSource(GetTableProprietaire());
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();

        }
        public DataTable GetTableProprietaire()
        {
            DataTable table = new DataTable();
            table.Columns.Add("NomPrenom",typeof(string));
            table.Columns.Add("Telephone", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("CNI", typeof(string));
            table.Columns.Add("Ninea", typeof(string));
            table.Columns.Add("Rccm", typeof(string));
            var app =  db.proprietaires.ToList();
            foreach (var  i in app)
            {
                table.Rows.Add(i.NomPrenom, i.Telephone, i.Email, i.CNI, i.Ninea, i.Rccm);
                
            }
            return table;



        }

        private void frmPrintListeProprietaire_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProprietaire f = new frmProprietaire();
            f.Activer();
        }
    }
}
