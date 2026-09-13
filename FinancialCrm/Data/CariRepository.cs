using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FinancialCrm.Models;

namespace FinancialCrm.Data
{
    public static class CariRepository
    {
        public static List<Cari> GetAll()
        {
            const string sql = @"SELECT Id, CariAdi, Telefon, Eposta, Adres, Bakiye, OlusturmaTarihi, Aktif
                                  FROM dbo.Cariler
                                  WHERE Aktif = 1
                                  ORDER BY CariAdi";
            return DbHelper.ExecuteReader(sql, Map);
        }

        public static int Insert(Cari cari)
        {
            const string sql = @"INSERT INTO dbo.Cariler (CariAdi, Telefon, Eposta, Adres, Bakiye)
                                  OUTPUT INSERTED.Id
                                  VALUES (@CariAdi, @Telefon, @Eposta, @Adres, @Bakiye)";

            var id = DbHelper.ExecuteScalar(sql,
                new SqlParameter("@CariAdi", cari.CariAdi),
                new SqlParameter("@Telefon", (object)cari.Telefon ?? DBNull.Value),
                new SqlParameter("@Eposta", (object)cari.Eposta ?? DBNull.Value),
                new SqlParameter("@Adres", (object)cari.Adres ?? DBNull.Value),
                new SqlParameter("@Bakiye", cari.Bakiye));

            return Convert.ToInt32(id);
        }

        public static void Update(Cari cari)
        {
            const string sql = @"UPDATE dbo.Cariler
                                  SET CariAdi = @CariAdi, Telefon = @Telefon, Eposta = @Eposta,
                                      Adres = @Adres, Bakiye = @Bakiye
                                  WHERE Id = @Id";

            DbHelper.ExecuteNonQuery(sql,
                new SqlParameter("@CariAdi", cari.CariAdi),
                new SqlParameter("@Telefon", (object)cari.Telefon ?? DBNull.Value),
                new SqlParameter("@Eposta", (object)cari.Eposta ?? DBNull.Value),
                new SqlParameter("@Adres", (object)cari.Adres ?? DBNull.Value),
                new SqlParameter("@Bakiye", cari.Bakiye),
                new SqlParameter("@Id", cari.Id));
        }

        public static void Delete(int id)
        {
            const string sql = "UPDATE dbo.Cariler SET Aktif = 0 WHERE Id = @Id";
            DbHelper.ExecuteNonQuery(sql, new SqlParameter("@Id", id));
        }

        private static Cari Map(IDataRecord record)
        {
            return new Cari
            {
                Id = record.GetInt32(0),
                CariAdi = record.GetString(1),
                Telefon = record.IsDBNull(2) ? null : record.GetString(2),
                Eposta = record.IsDBNull(3) ? null : record.GetString(3),
                Adres = record.IsDBNull(4) ? null : record.GetString(4),
                Bakiye = record.GetDecimal(5),
                OlusturmaTarihi = record.GetDateTime(6),
                Aktif = record.GetBoolean(7)
            };
        }
    }
}
