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
    public partial class frm_Administrator : Form
    {
        KonekcijaNaBazu konekcija = new KonekcijaNaBazu();

        public frm_Administrator()
        {
            InitializeComponent();
        }

        private void btn_prijava_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Username.Text) ||
                string.IsNullOrEmpty(textLozinka.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
            }
            else if (!DaLiPostoji(txt_Username.Text, textLozinka.Text))
            {
                txt_Username.Clear();
                textLozinka.Clear();
            }
            else
            {
                Hide();
                Form frm = new Form1();
                frm.Show();
            }
        }

        private bool DaLiPostoji(string text1, string text2)
        {
            foreach (var admin in konekcija.Admin)
            {
                if (admin.Username == text1 && admin.Password == text2)
                    return true;
            }
            MessageBox.Show("Korsnik nije pronadjen");
            return false;
        }

        private void frm_Administrator_Load(object sender, EventArgs e)
        {

        }

        //private const int CP_NOCLOSE_BUTTON = 0x200;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams myCp = base.CreateParams;
        //        myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
        //        return myCp;
        //    }
        //}
    }
}
