using MySql.Data.MySqlClient;

namespace VegetablesBD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strConn = "Server=127.0.0.1;Database=Vegetables;Uid=root;Pwd=12345";

            using (var conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string str = "CREATE TABLE VegetablesFruits (id INTEGER PRIMARY KEY AUTO_INCREMENT, name TEXT, type TEXT, color TEXT, calories INTEGER);";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();

            }
        }
    }
    
}
