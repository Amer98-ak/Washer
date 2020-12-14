namespace Washer.Forme
{
    partial class frm_PrikaziKorisnike
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
            this.dgv_Korisnici = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Korisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Korisnici
            // 
            this.dgv_Korisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Korisnici.Location = new System.Drawing.Point(12, 12);
            this.dgv_Korisnici.Name = "dgv_Korisnici";
            this.dgv_Korisnici.Size = new System.Drawing.Size(752, 150);
            this.dgv_Korisnici.TabIndex = 3;
            this.dgv_Korisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Korisnici_CellContentClick);
            // 
            // frm_PrikaziKorisnike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 181);
            this.Controls.Add(this.dgv_Korisnici);
            this.Name = "frm_PrikaziKorisnike";
            this.Text = "frm_PrikaziKorisnike";
            this.Load += new System.EventHandler(this.frm_PrikaziKorisnike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Korisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Korisnici;
    }
}