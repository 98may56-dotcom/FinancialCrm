namespace FinancialCrm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvCariler;
        private System.Windows.Forms.Panel pnlDetay;
        private System.Windows.Forms.Label lblCariAdi;
        private System.Windows.Forms.TextBox txtCariAdi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblDurum;

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
            this.dgvCariler = new System.Windows.Forms.DataGridView();
            this.pnlDetay = new System.Windows.Forms.Panel();
            this.lblCariAdi = new System.Windows.Forms.Label();
            this.txtCariAdi = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).BeginInit();
            this.pnlDetay.SuspendLayout();
            this.SuspendLayout();
            //
            // dgvCariler
            //
            this.dgvCariler.AllowUserToAddRows = false;
            this.dgvCariler.AllowUserToDeleteRows = false;
            this.dgvCariler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCariler.ReadOnly = true;
            this.dgvCariler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCariler.MultiSelect = false;
            this.dgvCariler.AutoGenerateColumns = false;
            this.dgvCariler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCariler.Location = new System.Drawing.Point(0, 0);
            this.dgvCariler.Name = "dgvCariler";
            this.dgvCariler.RowHeadersWidth = 25;
            this.dgvCariler.Size = new System.Drawing.Size(900, 380);
            this.dgvCariler.TabIndex = 0;
            this.dgvCariler.SelectionChanged += new System.EventHandler(this.dgvCariler_SelectionChanged);
            //
            // pnlDetay
            //
            this.pnlDetay.Controls.Add(this.lblDurum);
            this.pnlDetay.Controls.Add(this.btnYenile);
            this.pnlDetay.Controls.Add(this.btnSil);
            this.pnlDetay.Controls.Add(this.btnKaydet);
            this.pnlDetay.Controls.Add(this.btnYeni);
            this.pnlDetay.Controls.Add(this.txtAdres);
            this.pnlDetay.Controls.Add(this.lblAdres);
            this.pnlDetay.Controls.Add(this.txtBakiye);
            this.pnlDetay.Controls.Add(this.lblBakiye);
            this.pnlDetay.Controls.Add(this.txtEposta);
            this.pnlDetay.Controls.Add(this.lblEposta);
            this.pnlDetay.Controls.Add(this.txtTelefon);
            this.pnlDetay.Controls.Add(this.lblTelefon);
            this.pnlDetay.Controls.Add(this.txtCariAdi);
            this.pnlDetay.Controls.Add(this.lblCariAdi);
            this.pnlDetay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetay.Location = new System.Drawing.Point(0, 380);
            this.pnlDetay.Name = "pnlDetay";
            this.pnlDetay.Padding = new System.Windows.Forms.Padding(12);
            this.pnlDetay.Size = new System.Drawing.Size(900, 220);
            this.pnlDetay.TabIndex = 1;
            //
            // lblCariAdi
            //
            this.lblCariAdi.AutoSize = true;
            this.lblCariAdi.Location = new System.Drawing.Point(12, 18);
            this.lblCariAdi.Name = "lblCariAdi";
            this.lblCariAdi.Size = new System.Drawing.Size(58, 13);
            this.lblCariAdi.Text = "Cari Adı:";
            //
            // txtCariAdi
            //
            this.txtCariAdi.Location = new System.Drawing.Point(90, 15);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(300, 20);
            this.txtCariAdi.TabIndex = 0;
            //
            // lblTelefon
            //
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(410, 18);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(50, 13);
            this.lblTelefon.Text = "Telefon:";
            //
            // txtTelefon
            //
            this.txtTelefon.Location = new System.Drawing.Point(475, 15);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 20);
            this.txtTelefon.TabIndex = 1;
            //
            // lblEposta
            //
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(12, 51);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(48, 13);
            this.lblEposta.Text = "Eposta:";
            //
            // txtEposta
            //
            this.txtEposta.Location = new System.Drawing.Point(90, 48);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(300, 20);
            this.txtEposta.TabIndex = 2;
            //
            // lblBakiye
            //
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(410, 51);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(46, 13);
            this.lblBakiye.Text = "Bakiye:";
            //
            // txtBakiye
            //
            this.txtBakiye.Location = new System.Drawing.Point(475, 48);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(150, 20);
            this.txtBakiye.TabIndex = 3;
            //
            // lblAdres
            //
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(12, 84);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(42, 13);
            this.lblAdres.Text = "Adres:";
            //
            // txtAdres
            //
            this.txtAdres.Location = new System.Drawing.Point(90, 81);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(535, 20);
            this.txtAdres.TabIndex = 4;
            //
            // btnYeni
            //
            this.btnYeni.Location = new System.Drawing.Point(90, 118);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(90, 30);
            this.btnYeni.TabIndex = 5;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            //
            // btnKaydet
            //
            this.btnKaydet.Location = new System.Drawing.Point(190, 118);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 30);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            //
            // btnSil
            //
            this.btnSil.Location = new System.Drawing.Point(290, 118);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 30);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            //
            // btnYenile
            //
            this.btnYenile.Location = new System.Drawing.Point(390, 118);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(90, 30);
            this.btnYenile.TabIndex = 8;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            //
            // lblDurum
            //
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDurum.Location = new System.Drawing.Point(90, 158);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 13);
            //
            // Form1
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.dgvCariler);
            this.Controls.Add(this.pnlDetay);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.Text = "FinancialCrm - Cari Yönetimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).EndInit();
            this.pnlDetay.ResumeLayout(false);
            this.pnlDetay.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
