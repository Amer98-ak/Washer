using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Washer.EF;
using Washer.Models;

namespace Washer.Forme
{
    public partial class Rezervacija2 : Form
    {
        public KonekcijaNaBazu _konekcija;

        public float cijena = 30;
        int BrojDana;

        public Rezervacija2()
        {
            InitializeComponent();
            dgv_rezervacije.AutoGenerateColumns = false;
            _konekcija = new KonekcijaNaBazu();
            BrojDana = 0;
        }
        private void Rezervacija2_Load(object sender, EventArgs e)
        {
            UcitajKorisnikeUCMB();
            OsvjeziCijenu();
            OsvjeziGrid();
        }

        /*_________________________-----------------------------____________________________*/

        private void btn_Dodaj_Click(object sender, EventArgs e)
        {
            if (ValidanDatm())
            {
                if(cmb_Korisnici.SelectedItem as Korisnici != null)
                { 
                    Rezervacije tempR = new Rezervacije();
                    tempR.Korisnik = cmb_Korisnici.SelectedItem as Korisnici;
                    tempR.DatumOd = dtp_DatumOd.Value.ToString();
                    tempR.DatumDo = dtp_DatumDo.Value.ToString();
                    tempR.Cijena = float.Parse(txt_Cijena.Text);
                    _konekcija.Rezervacije.Add(tempR);
                    _konekcija.SaveChanges();

                    OsvjeziGrid();
                }
                else
                {
                    MessageBox.Show("Uplata ne moze biti izvrsena, jer nemate odabranog korisnika!");
                }
            }
        }

        /*_________________________-----------------------------____________________________*/

        private bool ValidanDatm()
        {
            if (dtp_DatumOd.Value.ToBinary() >= dtp_DatumDo.Value.ToBinary())
            {
                MessageBox.Show("Neispravan datum.");
                return false;
            }
            return true;
        }
        private void OsvjeziGrid()
        {
            dgv_rezervacije.DataSource = null;
            dgv_rezervacije.DataSource = _konekcija.Rezervacije.ToList();
        }
        private void UcitajKorisnikeUCMB()
        {
            cmb_Korisnici.DataSource = _konekcija.Korisnici.ToList();
        }
        private void OsvjeziCijenu(string BrKocke = null)
        {
            cijena = 30;
            if(!string.IsNullOrEmpty(txt_Kocke.Text))
            {
                cijena += float.Parse(txt_Kocke.Text) *2 ;
            }
            if(BrojDana!=0 && BrojDana != 1)
            {
                cijena += (BrojDana -1)* 15;
            }
            txt_Cijena.Text = cijena.ToString();
        }

        /*_________________________-----------------------------____________________________*/

        private void dtp_DatumOd_ValueChanged(object sender, EventArgs e)
        {
            if (ValidanDatm())
            {
                txt_BrojDana.Text = (dtp_DatumDo.Value.Day - dtp_DatumOd.Value.Day).ToString();
                BrojDana = dtp_DatumDo.Value.Day - dtp_DatumOd.Value.Day;
                OsvjeziCijenu();
                TXTDani1.Text = dtp_DatumOd.Value.Day.ToString();
            }
        }
        private void dtp_DatumDo_ValueChanged(object sender, EventArgs e)
        {
            if (ValidanDatm())
            {
                txt_BrojDana.Text = (dtp_DatumDo.Value.Day - dtp_DatumOd.Value.Day).ToString();
                BrojDana = dtp_DatumDo.Value.Day - dtp_DatumOd.Value.Day;
                OsvjeziCijenu();
                TXTDani2.Text = dtp_DatumOd.Value.Day.ToString();
            }
        }
        private void txt_BrojDana_TextChanged(object sender, EventArgs e)
        {
            OsvjeziCijenu();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OsvjeziCijenu(txt_Kocke.Text);
        }

        /*_________________________-----------------------------____________________________*/
        
        private void dgv_rezervacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Rezervacije odabranaRez = dgv_rezervacije.SelectedRows[0].DataBoundItem as Rezervacije;

            if(e.ColumnIndex == 4)
            {
                Form forma = new frm_Izvjestaj(odabranaRez);
                forma.Show();
            }
        }
        private void txt_Cijena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
