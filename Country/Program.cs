using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Runtime.CompilerServices;
namespace Country
{
    public class Program
    {

        static void Main(string[] args)
        {

            Service service = new Service();

            string strConn = "Server=127.0.0.1;Database=Country;Uid=root;Pwd=12345";
            //service.CreateTables();
            DataTable table;
            using (var conn = new MySqlConnection(strConn)) {
               table = service.Init(conn);
            }

            var l = table.Rows[1];
            Console.WriteLine(l.Field<string>("name"));
           
        }
        

    }
}
