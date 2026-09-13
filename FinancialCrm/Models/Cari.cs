using System;

namespace FinancialCrm.Models
{
    public class Cari
    {
        public int Id { get; set; }
        public string CariAdi { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Adres { get; set; }
        public decimal Bakiye { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public bool Aktif { get; set; }
    }
}
