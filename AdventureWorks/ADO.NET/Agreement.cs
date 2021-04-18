using System;
using System.Data;
using System.Data.SqlClient;

namespace AdventureWorks.ADO.NET
{
    public class Agreement
    {
        private string connectionString { get; set; }
        public Agreement()
        {
            connectionString = "Server=.\\SQLEXPRESS01;Database=kaspilab;Integrated Security = true;";
        }

        public void ClientAgreement(string IIN)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand()
                    {
                        CommandText = "[dbo].[agreementInformation]",
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add("IIN", SqlDbType.NVarChar).Value = IIN;

                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                        Console.WriteLine($"IIN : {reader["IIN"]}, type : {reader["type"]}, " +
                            $"IBAN : {reader["IBAN"]}, current_balance : {reader["current_balance"]}, agreement's issue date : {reader["issue_date"]}, " +
                            $"agreement's expiration date {reader["expiration_date"]}, isActive : {reader["isActive"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
