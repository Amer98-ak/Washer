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

namespace Washer.Forme
{
    public partial class frm_PrikaziKorisnike : Form
    {
        KonekcijaNaBazu konekcija = new KonekcijaNaBazu();
        public frm_PrikaziKorisnike()
        {
            InitializeComponent();
        }

        private void frm_PrikaziKorisnike_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgv_Korisnici.DataSource = null;
            dgv_Korisnici.DataSource = konekcija.Korisnici.ToList();
        }

        private void dgv_Korisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
