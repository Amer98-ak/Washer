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
using Washer.Forme;

namespace Washer
{
    public partial class Form1 : Form
    {
        KonekcijaNaBazu konekcija = new KonekcijaNaBazu();
        Admin admin = new Admin();

        public Form1()
        {            
            InitializeComponent();
        }

        private void btn_Rezerviraj_Click(object sender, EventArgs e)
        {
            Form form = new Rezervacija2();
            form.ShowDialog();
        }

        private void btn_DodajKorisnika_Click(object sender, EventArgs e)
        {
            Form form = new frm_DodajKorisnika();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_PrikaziKorisnike_Click(object sender, EventArgs e)
        {
            Form frm = new frm_PrikaziKorisnike();
            frm.ShowDialog();
        }

        /*-----------------------------------------------------------*/
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

    
}
