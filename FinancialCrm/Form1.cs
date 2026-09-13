using System;
using System.Globalization;
using System.Windows.Forms;
using FinancialCrm.Data;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class Form1 : Form
    {
        private int? _seciliCariId;

        public Form1()
        {
            InitializeComponent();
            ConfigureGridColumns();
        }

        private void ConfigureGridColumns()
        {
            dgvCariler.Columns.Clear();
            dgvCariler.Columns.Add("Id", "Id");
            dgvCariler.Columns.Add("CariAdi", "Cari Adı");
            dgvCariler.Columns.Add("Telefon", "Telefon");
            dgvCariler.Columns.Add("Eposta", "Eposta");
            dgvCariler.Columns.Add("Adres", "Adres");
            dgvCariler.Columns.Add("Bakiye", "Bakiye");
            dgvCariler.Columns["Id"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YenileListe();
        }

        private void YenileListe()
        {
            try
            {
                dgvCariler.Rows.Clear();
                foreach (var cari in CariRepository.GetAll())
                {
                    dgvCariler.Rows.Add(
                        cari.Id,
                        cari.CariAdi,
                        cari.Telefon,
                        cari.Eposta,
                        cari.Adres,
                        cari.Bakiye.ToString("N2", CultureInfo.GetCultureInfo("tr-TR")));
                }
                lblDurum.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblDurum.Text = "Liste yüklenemedi: " + ex.Message;
            }
        }

        private void dgvCariler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCariler.CurrentRow == null)
                return;

            _seciliCariId = Convert.ToInt32(dgvCariler.CurrentRow.Cells["Id"].Value);
            txtCariAdi.Text = Convert.ToString(dgvCariler.CurrentRow.Cells["CariAdi"].Value);
            txtTelefon.Text = Convert.ToString(dgvCariler.CurrentRow.Cells["Telefon"].Value);
            txtEposta.Text = Convert.ToString(dgvCariler.CurrentRow.Cells["Eposta"].Value);
            txtAdres.Text = Convert.ToString(dgvCariler.CurrentRow.Cells["Adres"].Value);
            txtBakiye.Text = Convert.ToString(dgvCariler.CurrentRow.Cells["Bakiye"].Value);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            _seciliCariId = null;
            txtCariAdi.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();
            txtAdres.Clear();
            txtBakiye.Clear();
            lblDurum.Text = string.Empty;
            dgvCariler.ClearSelection();
            txtCariAdi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCariAdi.Text))
            {
                lblDurum.Text = "Cari adı boş olamaz.";
                txtCariAdi.Focus();
                return;
            }

            decimal bakiye = 0;
            if (!string.IsNullOrWhiteSpace(txtBakiye.Text) &&
                !decimal.TryParse(txtBakiye.Text, NumberStyles.Number, CultureInfo.GetCultureInfo("tr-TR"), out bakiye))
            {
                lblDurum.Text = "Bakiye alanı geçerli bir sayı olmalı.";
                txtBakiye.Focus();
                return;
            }

            var cari = new Cari
            {
                CariAdi = txtCariAdi.Text.Trim(),
                Telefon = txtTelefon.Text.Trim(),
                Eposta = txtEposta.Text.Trim(),
                Adres = txtAdres.Text.Trim(),
                Bakiye = bakiye
            };

            try
            {
                if (_seciliCariId == null)
                {
                    CariRepository.Insert(cari);
                    lblDurum.Text = "Cari eklendi.";
                }
                else
                {
                    cari.Id = _seciliCariId.Value;
                    CariRepository.Update(cari);
                    lblDurum.Text = "Cari güncellendi.";
                }

                YenileListe();
                btnYeni_Click(sender, e);
            }
            catch (Exception ex)
            {
                lblDurum.Text = "Kaydedilemedi: " + ex.Message;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_seciliCariId == null)
            {
                lblDurum.Text = "Silmek için önce listeden bir cari seçin.";
                return;
            }

            var sonuc = MessageBox.Show(
                "Seçili cariyi silmek istediğinize emin misiniz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (sonuc != DialogResult.Yes)
                return;

            try
            {
                CariRepository.Delete(_seciliCariId.Value);
                lblDurum.Text = "Cari silindi.";
                YenileListe();
                btnYeni_Click(sender, e);
            }
            catch (Exception ex)
            {
                lblDurum.Text = "Silinemedi: " + ex.Message;
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            YenileListe();
        }
    }
}
