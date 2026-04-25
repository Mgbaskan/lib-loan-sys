using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace LibraryLoanSystem.DataAccess
{
    public static class DbHelper
    {
        public static DataTable GetDataTable(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(Database.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);

                DataTable table = new DataTable();
                connection.Open();
                adapter.Fill(table);
                return table;
            }
        }

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(Database.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(Database.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);

                connection.Open();
                return command.ExecuteScalar();
            }
        }

        // Process overdue loans: for loans with a non-null ReturnDate older than today and not returned,
        // mark them as returned and increment the corresponding book stock.
        public static void ProcessOverdueReturns()
        {
            DataTable overdue = GetDataTable(
                "SELECT LoanId, BookId FROM Loans WHERE IsReturned = 0 AND ReturnDate IS NOT NULL AND CAST(ReturnDate AS DATE) < @Today",
                new SqlParameter("@Today", DateTime.Now.Date)
            );

            foreach (DataRow row in overdue.Rows)
            {
                int loanId = Convert.ToInt32(row["LoanId"]);
                int bookId = Convert.ToInt32(row["BookId"]);

                // mark loan as returned (set ReturnDate to today if it was earlier) and increment stock
                ExecuteNonQuery(
                    "UPDATE Loans SET IsReturned = 1, ReturnDate = @ReturnDate WHERE LoanId = @LoanId",
                    new SqlParameter("@ReturnDate", DateTime.Now.Date),
                    new SqlParameter("@LoanId", loanId)
                );

                ExecuteNonQuery(
                    "UPDATE Books SET Stock = Stock + 1 WHERE BookId = @BookId",
                    new SqlParameter("@BookId", bookId)
                );
            }
        }
    }
}