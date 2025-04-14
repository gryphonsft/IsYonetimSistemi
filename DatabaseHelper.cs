using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsYonetimSistemi
{
    class DatabaseHelper
    {
        private readonly string _connectionString = "Data Source=database.db";

        public void ExecuteQuery(string query, Action<SqliteCommand> parameterSetter = null)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    parameterSetter?.Invoke(command);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
