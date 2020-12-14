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
using Washer.Models;

namespace Washer.Forme
{
    public partial class frm_DodajKorisnika : Form
    {
        public KonekcijaNaBazu konekcija = new KonekcijaNaBazu();
        public frm_DodajKorisnika()
        {
            InitializeComponent();
        }

        private void btn_Spasi_Click(object sender, EventArgs e)
        {
            Korisnici korisnik = new Korisnici();

            korisnik.JMBG = txt_JMBG.Text;
            korisnik.Ime = txt_Ime.Text;
            korisnik.Prezime = txt_Prezime.Text;
            korisnik.BrLicne = txt_BrojLicne.Text;

            konekcija.Korisnici.Add(korisnik);
            konekcija.SaveChanges();
            Close();
        }

        private void frm_DodajKorisnika_Load(object sender, EventArgs e)
        {

        }
    }
}
