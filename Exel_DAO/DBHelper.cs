using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exel_DAO
{
    public class DBHelper
    {
        public static string tblBom = "bom";
        public static string tblBomModel = "bom_model";
        public static string selectCmdForBomDGV = $"select component_id as id,component_name as name,object_description as description from {tblBom}";
        public static string getStringSelecteForBomDGV(decimal page, decimal size)
        {
            string select = $"select component_id as id,component_name as name,object_description as description from {tblBom} order by id OFFSET {size*(page-1)} ROWS FETCH NEXT {size} ROWS ONLY";
            return select;
        }
        public static string getStringSelecteForBomModelDGV(decimal page, decimal size, decimal id)
        {
            string select = $"select model_name as name,model_value as quantity from {tblBomModel} where component_id = {id} order by id OFFSET {size * (page - 1)} ROWS FETCH NEXT {size} ROWS ONLY";
            return select;
        }
        public static DBHelper _instance;
        public static DBHelper getInstance()
        {
            if (_instance == null) _instance = new DBHelper();
            return _instance;
        }
        private DBHelper()
        {

        }
        public static string connString = "Server=.;Database=exeltool;Trusted_Connection=true";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(connString);
        }
        

        public int excuteQuery(string query)
        {
            int res = -1;
            using (SqlConnection con = getConnection())
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = con;
                res = command.ExecuteNonQuery();
            }
            return res;
        }
        public decimal excuteCount(string query)
        {
            decimal res = -1;
            using (SqlConnection con = getConnection())
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = con;
                try
                {
                    res = Convert.ToDecimal(command.ExecuteScalar());
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return res;
        }
        public bool trueOrFalse(string query)
        {
            bool res = false;
            using(SqlConnection con = getConnection())
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = con;
                
                res = command.ExecuteScalar() == null ? false : true;
            }
            return res;
        }
    }
}
