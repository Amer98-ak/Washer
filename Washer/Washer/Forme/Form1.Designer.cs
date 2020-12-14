namespace Washer
{
    partial class Form1
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
            this.btn_Rezerviraj = new System.Windows.Forms.Button();
            this.btn_DodajKorisnika = new System.Windows.Forms.Button();
            this.btn_PrikaziKorisnike = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Rezerviraj
            // 
            this.btn_Rezerviraj.BackColor = System.Drawing.Color.White;
            this.btn_Rezerviraj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rezerviraj.Location = new System.Drawing.Point(14, 259);
            this.btn_Rezerviraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Rezerviraj.Name = "btn_Rezerviraj";
            this.btn_Rezerviraj.Size = new System.Drawing.Size(171, 53);
            this.btn_Rezerviraj.TabIndex = 0;
            this.btn_Rezerviraj.Text = "Rezerviraj";
            this.btn_Rezerviraj.UseVisualStyleBackColor = false;
            this.btn_Rezerviraj.Click += new System.EventHandler(this.btn_Rezerviraj_Click);
            // 
            // btn_DodajKorisnika
            // 
            this.btn_DodajKorisnika.BackColor = System.Drawing.Color.White;
            this.btn_DodajKorisnika.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DodajKorisnika.Location = new System.Drawing.Point(14, 189);
            this.btn_DodajKorisnika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DodajKorisnika.Name = "btn_DodajKorisnika";
            this.btn_DodajKorisnika.Size = new System.Drawing.Size(171, 53);
            this.btn_DodajKorisnika.TabIndex = 1;
            this.btn_DodajKorisnika.Text = "Dodaj korisnika";
            this.btn_DodajKorisnika.UseVisualStyleBackColor = false;
            this.btn_DodajKorisnika.Click += new System.EventHandler(this.btn_DodajKorisnika_Click);
            // 
            // btn_PrikaziKorisnike
            // 
            this.btn_PrikaziKorisnike.BackColor = System.Drawing.Color.White;
            this.btn_PrikaziKorisnike.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrikaziKorisnike.Location = new System.Drawing.Point(14, 329);
            this.btn_PrikaziKorisnike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PrikaziKorisnike.Name = "btn_PrikaziKorisnike";
            this.btn_PrikaziKorisnike.Size = new System.Drawing.Size(171, 53);
            this.btn_PrikaziKorisnike.TabIndex = 2;
            this.btn_PrikaziKorisnike.Text = "Prikaži Korisnike";
            this.btn_PrikaziKorisnike.UseVisualStyleBackColor = false;
            this.btn_PrikaziKorisnike.Click += new System.EventHandler(this.btn_PrikaziKorisnike_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(200, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 367);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Washer.Properties.Resources.slika;
            this.pictureBox2.Location = new System.Drawing.Point(219, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(436, 367);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Washer.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(667, 395);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PrikaziKorisnike);
            this.Controls.Add(this.btn_DodajKorisnika);
            this.Controls.Add(this.btn_Rezerviraj);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Rezerviraj;
        private System.Windows.Forms.Button btn_DodajKorisnika;
        private System.Windows.Forms.Button btn_PrikaziKorisnike;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

