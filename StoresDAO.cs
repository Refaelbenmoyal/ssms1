using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMS1
{
    class StoresDAO: IStoresDAO
    {
        public object GetAllStoresMusicInOneFloor()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(@"Data Source=.;Initial Catalog=storesDB;Integrated Security=True");
            cmd.Connection.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Stores";


            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);

            List<Object> list = new List<object>();
            while (reader.Read() == true)
            {
                Console.WriteLine($" {reader["ID"]} {reader["Name"]} {reader["Floor"]} {reader["Category_ID"]}");
                var s = new
                {
                    Id = reader["ID"],
                    NAME = reader["Name"]
                };
                list.Add(s);
                cmd.CommandText = "SELECT c Category_ID FROM Stores join f Floor where  ";


            }

            cmd.Connection.Close();
        }
    }
}
