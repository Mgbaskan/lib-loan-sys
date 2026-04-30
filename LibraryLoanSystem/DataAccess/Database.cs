using Microsoft.Data.SqlClient;

namespace LibraryLoanSystem.DataAccess
{
    public static class Database
    {
        public static string ConnectionString =
            @"Server=.\SQLEXPRESS;Database=KutuphaneDB;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}