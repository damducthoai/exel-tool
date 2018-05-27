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
        public static string tblKitting = "kitting";
        public static string tblNhanle = "nhanle";
        public static string tblChiacat = "chiacat";
        public static string tblPmg = "pgmtrave";
        public static string tblThurut = "thurut";
        public static string tblBom = "bom";
        public static string tblBomModel = "bom_model";
        public static string tblPlan = "planx";
        public static string selectCmdForBomDGV = $"select component_id as id,component_name as name,object_description as description from {tblBom}";

        public static string getQuery4ScanDGV(decimal page, decimal size, string date, string table)
        {
            var query = $"select * from {table} where date like '%{date}%' order by id OFFSET {size * (page - 1)} ROWS FETCH NEXT {size} ROWS ONLY";
            return query;
        }
        public static string getQuery4PlanDGV(decimal page, decimal size, decimal line, decimal componentid, string search)
        {
            //string query = $"select plan_id as plan_id, model_name as model, plan_data as data, plan_line as line, plan_time as time from {tblPlan}  join {tblBomModel} on {tblBomModel}.id = {tblPlan}.model_id where plan_line={line} and {DBHelper.tblPlan}.component_id = {componentid} order by plan_id OFFSET {size * (page - 1)} ROWS FETCH NEXT {size} ROWS ONLY";
            var query = $"select planx.plan_id, planx.plan_data* bom_model.model_value as [plan], planx.model_code as model, planx.plan_data as data, planx.plan_time as time, planx.plan_line as line from planx, bom_model where planx.bom_model_id = bom_model.id and bom_model.component_id = {componentid}";
            return query;
        }

        public static string getQuery4LineComponentDGV(decimal page, decimal size, string search)
        {
            string query = "";
            if(String.IsNullOrEmpty(search) || String.IsNullOrWhiteSpace(search))
            {
                query = $"select component_id as id,component_name as name,(select ISNULL(SUM(kitting.quantity), 0) from kitting where kitting.code = bom.component_name) as kitting, (select ISNULL(SUM(nhanle.quantity), 0) from nhanle where nhanle.code = bom.component_name) as [nhan le],(select ISNULL(SUM(pgmtrave.quantity), 0) from pgmtrave where pgmtrave.code = bom.component_name) as [nhan le],(select ISNULL(SUM(chiacat.quantity), 0) from chiacat where chiacat.code = bom.component_name) as [chia cat],object_description as description from {tblBom} order by id OFFSET {size * (page - 1)} ROWS FETCH NEXT {size} ROWS ONLY";
            }
            else
            {
                query = $"select component_id as id,component_name as name,(select ISNULL(SUM(kitting.quantity), 0) from kitting where kitting.code = bom.component_name) as kitting, (select ISNULL(SUM(nhanle.quantity), 0) from nhanle where nhanle.code = bom.component_name) as [nhan le],(select ISNULL(SUM(pgmtrave.quantity), 0) from pgmtrave where pgmtrave.code = bom.component_name) as [nhan le],(select ISNULL(SUM(chiacat.quantity), 0) from chiacat where chiacat.code = bom.component_name) as [chia cat],object_description as description from {tblBom} where component_name LIKE '%{search}%' OR object_description LIKE '%{search}%' order by id OFFSET {size * (page - 1)} ROWS FETCH NEXT {size} ROWS ONLY";
            }
            return query;
        }
        public static string getStringSelecteForBomDGV(decimal page, decimal size, string search)
        {
            string select = "";
            if (!String.IsNullOrEmpty(search) && !String.IsNullOrWhiteSpace(search))
            {
                select = $"select component_id as id,component_name as name,object_description as description from {tblBom} where component_name LIKE '%{search}%' OR object_description LIKE '%{search}%' order by id OFFSET {size * (page - 1)} ROWS FETCH NEXT {size} ROWS ONLY";
            }
            else
            {
                select = $"select component_id as id,component_name as name,object_description as description from {tblBom} order by id OFFSET {size * (page - 1)} ROWS FETCH NEXT {size} ROWS ONLY";
            }
            
            return select;
        }
        public static string getStringSelecteForBomModelDGV(decimal page, decimal size, decimal id)
        {
            string select = $"select model_name as model,model_value as point from {tblBomModel} where component_id = {id} order by id OFFSET {size * (page - 1)} ROWS FETCH NEXT {size} ROWS ONLY";
            return select;
        }
        public decimal excute2GetDecimal(string query)
        {
            decimal res = -1;
            using(SqlConnection con = getConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                res = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            return res;
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
