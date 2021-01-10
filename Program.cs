using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMS1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myconfig = ConfigurationManager.AppSettings[" ssms "];
            IStoresDAO dao = new StoresDAO();

            var result = dao.GetAllStoresMusicInOneFloor();
        
        }
    }
}
