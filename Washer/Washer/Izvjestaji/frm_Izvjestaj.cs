using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Washer.EF;
using Microsoft.Reporting.WinForms;
using Washer.Models;

namespace Washer.Forme
{
    public partial class frm_Izvjestaj : Form
    {
        KonekcijaNaBazu _konekcija;
        public Rezervacije rezervacija;
        public frm_Izvjestaj()
        {
            InitializeComponent();
            _konekcija = new KonekcijaNaBazu();
        }
        public frm_Izvjestaj(Rezervacije rezervacija) : this()
        {
            this.rezervacija = rezervacija;
        }

        private void frm_Izvjestaj_Load(object sender, EventArgs e)
        {

            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Ime", rezervacija.Korisnik.Ime));
            rpc.Add(new ReportParameter("Prezime", rezervacija.Korisnik.Prezime));
            rpc.Add(new ReportParameter("DatumOd", rezervacija.DatumOd));
            rpc.Add(new ReportParameter("DatumDo", rezervacija.DatumDo));
            rpc.Add(new ReportParameter("Cijena", rezervacija.Cijena.ToString()));
            rpc.Add(new ReportParameter("TrenutniDatum", DateTime.Now.ToString()));

            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();  

        }
    }
}
