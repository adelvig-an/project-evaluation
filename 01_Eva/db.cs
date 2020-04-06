using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace _01_Eva
{
    class db
    {
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;User=postgres;Password=dakar-21;Database=eva_db;");


        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public NpgsqlConnection GetConnection()
        {
            return connection;
        }

        //String connectionString = "Server=localhost;Port=5432;UserId=postgres;Password=dakar-21;Database=eva_db;";
        //NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
        //npgSqlConnection.Open();
        //Console.WriteLine("Соединение с БД открыто");
    }
}
