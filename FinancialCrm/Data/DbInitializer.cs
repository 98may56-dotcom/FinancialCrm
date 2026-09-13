using System.Configuration;
using System.Data.SqlClient;

namespace FinancialCrm.Data
{
    internal static class DbInitializer
    {
        public static void Initialize()
        {
            EnsureDatabaseExists();
            EnsureSchemaExists();
        }

        private static void EnsureDatabaseExists()
        {
            var builder = new SqlConnectionStringBuilder(
                ConfigurationManager.ConnectionStrings["FinancialCrmDb"].ConnectionString);
            var databaseName = builder.InitialCatalog;
            builder.InitialCatalog = "master";

            using (var connection = new SqlConnection(builder.ConnectionString))
            using (var command = new SqlCommand(
                $"IF DB_ID(N'{databaseName}') IS NULL CREATE DATABASE [{databaseName}]", connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private static void EnsureSchemaExists()
        {
            const string sql = @"
IF OBJECT_ID(N'dbo.Cariler', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Cariler
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        CariAdi NVARCHAR(200) NOT NULL,
        Telefon NVARCHAR(20) NULL,
        Eposta NVARCHAR(200) NULL,
        Adres NVARCHAR(500) NULL,
        Bakiye DECIMAL(18,2) NOT NULL DEFAULT 0,
        OlusturmaTarihi DATETIME NOT NULL DEFAULT GETDATE(),
        Aktif BIT NOT NULL DEFAULT 1
    );
END";
            DbHelper.ExecuteNonQuery(sql);
        }
    }
}
