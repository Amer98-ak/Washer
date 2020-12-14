namespace Washer.Forme
{
    partial class Rezervacija2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Kocke = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_DatumDo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Dodaj = new System.Windows.Forms.Button();
            this.txt_Cijena = new System.Windows.Forms.TextBox();
            this.dtp_DatumOd = new System.Windows.Forms.DateTimePicker();
            this.cmb_Korisnici = new System.Windows.Forms.ComboBox();
            this.dgv_rezervacije = new System.Windows.Forms.DataGridView();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prinataj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_BrojDana = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tablete komad:";
            // 
            // txt_Kocke
            // 
            this.txt_Kocke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Kocke.Location = new System.Drawing.Point(12, 171);
            this.txt_Kocke.Name = "txt_Kocke";
            this.txt_Kocke.Size = new System.Drawing.Size(103, 21);
            this.txt_Kocke.TabIndex = 22;
            this.txt_Kocke.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Do";
            // 
            // dtp_DatumDo
            // 
            this.dtp_DatumDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DatumDo.Location = new System.Drawing.Point(12, 123);
            this.dtp_DatumDo.Name = "dtp_DatumDo";
            this.dtp_DatumDo.Size = new System.Drawing.Size(211, 21);
            this.dtp_DatumDo.TabIndex = 20;
            this.dtp_DatumDo.ValueChanged += new System.EventHandler(this.dtp_DatumDo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ukupna cijena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Od";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Odaberi korisnika";
            // 
            // btn_Dodaj
            // 
            this.btn_Dodaj.BackColor = System.Drawing.Color.White;
            this.btn_Dodaj.Location = new System.Drawing.Point(502, 219);
            this.btn_Dodaj.Name = "btn_Dodaj";
            this.btn_Dodaj.Size = new System.Drawing.Size(81, 25);
            this.btn_Dodaj.TabIndex = 16;
            this.btn_Dodaj.Text = "Dodaj";
            this.btn_Dodaj.UseVisualStyleBackColor = false;
            this.btn_Dodaj.Click += new System.EventHandler(this.btn_Dodaj_Click);
            // 
            // txt_Cijena
            // 
            this.txt_Cijena.Location = new System.Drawing.Point(469, 54);
            this.txt_Cijena.Name = "txt_Cijena";
            this.txt_Cijena.ReadOnly = true;
            this.txt_Cijena.Size = new System.Drawing.Size(81, 20);
            this.txt_Cijena.TabIndex = 15;
            this.txt_Cijena.TextChanged += new System.EventHandler(this.txt_Cijena_TextChanged);
            // 
            // dtp_DatumOd
            // 
            this.dtp_DatumOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DatumOd.Location = new System.Drawing.Point(12, 75);
            this.dtp_DatumOd.Name = "dtp_DatumOd";
            this.dtp_DatumOd.Size = new System.Drawing.Size(211, 21);
            this.dtp_DatumOd.TabIndex = 14;
            this.dtp_DatumOd.ValueChanged += new System.EventHandler(this.dtp_DatumOd_ValueChanged);
            // 
            // cmb_Korisnici
            // 
            this.cmb_Korisnici.FormattingEnabled = true;
            this.cmb_Korisnici.Location = new System.Drawing.Point(12, 27);
            this.cmb_Korisnici.Name = "cmb_Korisnici";
            this.cmb_Korisnici.Size = new System.Drawing.Size(211, 21);
            this.cmb_Korisnici.TabIndex = 13;
            // 
            // dgv_rezervacije
            // 
            this.dgv_rezervacije.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_rezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Korisnik,
            this.DatumOd,
            this.DatumDo,
            this.Ukupno,
            this.Prinataj});
            this.dgv_rezervacije.Location = new System.Drawing.Point(12, 250);
            this.dgv_rezervacije.Name = "dgv_rezervacije";
            this.dgv_rezervacije.RowHeadersWidth = 51;
            this.dgv_rezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rezervacije.Size = new System.Drawing.Size(580, 152);
            this.dgv_rezervacije.TabIndex = 12;
            this.dgv_rezervacije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rezervacije_CellContentClick);
            // 
            // Korisnik
            // 
            this.Korisnik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.MinimumWidth = 6;
            this.Korisnik.Name = "Korisnik";
            // 
            // DatumOd
            // 
            this.DatumOd.DataPropertyName = "DatumOd";
            this.DatumOd.HeaderText = "Datum od";
            this.DatumOd.MinimumWidth = 6;
            this.DatumOd.Name = "DatumOd";
            this.DatumOd.Width = 125;
            // 
            // DatumDo
            // 
            this.DatumDo.DataPropertyName = "DatumDo";
            this.DatumDo.HeaderText = "Datum do";
            this.DatumDo.MinimumWidth = 6;
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.Width = 125;
            // 
            // Ukupno
            // 
            this.Ukupno.DataPropertyName = "Cijena";
            this.Ukupno.HeaderText = "Cijena";
            this.Ukupno.MinimumWidth = 6;
            this.Ukupno.Name = "Ukupno";
            this.Ukupno.Width = 125;
            // 
            // Prinataj
            // 
            this.Prinataj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Prinataj.HeaderText = "Printaj";
            this.Prinataj.MinimumWidth = 6;
            this.Prinataj.Name = "Prinataj";
            this.Prinataj.Text = "Printaj";
            this.Prinataj.UseColumnTextForButtonValue = true;
            this.Prinataj.Width = 42;
            // 
            // txt_BrojDana
            // 
            this.txt_BrojDana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BrojDana.Location = new System.Drawing.Point(12, 219);
            this.txt_BrojDana.Name = "txt_BrojDana";
            this.txt_BrojDana.ReadOnly = true;
            this.txt_BrojDana.Size = new System.Drawing.Size(71, 21);
            this.txt_BrojDana.TabIndex = 24;
            this.txt_BrojDana.TextChanged += new System.EventHandler(this.txt_BrojDana_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Broj dana:";
            // 
            // Rezervacija2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 413);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_BrojDana);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Kocke);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_DatumDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Dodaj);
            this.Controls.Add(this.txt_Cijena);
            this.Controls.Add(this.dtp_DatumOd);
            this.Controls.Add(this.cmb_Korisnici);
            this.Controls.Add(this.dgv_rezervacije);
            this.Name = "Rezervacija2";
            this.Text = "Rezervacija2";
            this.Load += new System.EventHandler(this.Rezervacija2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Kocke;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_DatumDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Dodaj;
        private System.Windows.Forms.TextBox txt_Cijena;
        private System.Windows.Forms.DateTimePicker dtp_DatumOd;
        private System.Windows.Forms.ComboBox cmb_Korisnici;
        private System.Windows.Forms.DataGridView dgv_rezervacije;
        private System.Windows.Forms.TextBox txt_BrojDana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupno;
        private System.Windows.Forms.DataGridViewButtonColumn Prinataj;
    }
}