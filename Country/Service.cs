using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country
{
    public class Service
    {
        public DataTable Init(MySqlConnection conn)
        {
            conn.Open();
            string strCommand = $"SELECT Country.*, Town.*, Capital.* FROM Country INNER JOIN Town ON Town.country_id=Country.id INNER JOIN Capital ON Capital.country_id=Country.id;";
            MySqlCommand cmd = new MySqlCommand(strCommand, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }

        public void CreateTables()
        {

            string strConn = "Server=127.0.0.1;Database=Country;Uid=root;Pwd=12345";


            using (var conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string str = "CREATE TABLE IF NOT EXISTS Country (id INTEGER PRIMARY KEY AUTO_INCREMENT, name TEXT, residnets FLOAT, region TEXT, square INTEGER);" +
                    "CREATE TABLE IF NOT EXISTS Town (id INTEGER PRIMARY KEY AUTO_INCREMENT, name TEXT, residnets FLOAT, square INTEGER, country_id INTEGER, FOREIGN KEY (country_id) REFERENCES Country (id));" +
                    "CREATE TABLE IF NOT EXISTS Capital (id INTEGER PRIMARY KEY AUTO_INCREMENT, name TEXT, residnets FLOAT, square INTEGER, country_id INTEGER UNIQUE, FOREIGN KEY (country_id) REFERENCES Country (id));" +
                    "INSERT INTO Country (name, residnets, region, square) VALUES ('Russia', 144, 'Europe', 17100);" +
                    "INSERT INTO Country (name, residnets, region, square) VALUES ('German', 85, 'Europe', 358);" +
                    "INSERT INTO Town (name, residnets, square, country_id) VALUES ('Samara', 2.7, 541, 1);" +
                    "INSERT INTO Town (name, residnets, square, country_id) VALUES ('Peterburg', 5.6, 1439, 1);" +
                    "INSERT INTO Town (name, residnets, square, country_id) VALUES ('Munchen', 1.5, 310, 2);" +
                    "INSERT INTO Town (name, residnets, square, country_id) VALUES ('Hamburg', 1.9, 892, 2);" +
                    "INSERT INTO Capital (name, residnets, square, country_id) VALUES ('Moscow', 13.2, 2561, 1);" +
                    "INSERT INTO Capital (name, residnets, square, country_id) VALUES ('Berlin', 3.7, 1213, 2);";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();

            }
        }
    }
}
