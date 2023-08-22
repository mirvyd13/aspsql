using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DataLibrary1.DBAccess
{
    public class SqlWorkflow
    {
        public static string getStringConection()
        {
            return ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
        }
        public static List<T> loadData<T>(string sql)
        {
            using (IDbConnection conn=new SqlConnection(getStringConection()))
            {
                return conn.Query<T>(sql).ToList();
            }
        }
    }
}
