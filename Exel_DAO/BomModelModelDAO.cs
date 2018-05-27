using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exel_DAO
{
    public class BomModelModelDAO:ICRUD<BOM_Model_Model>
    {
        private static BomModelModelDAO _instance;
        public decimal getIdByComonentAndModel(decimal component_id, string model_name)
        {
            var q = $"select id from {DBHelper.tblBomModel} where component_id = {component_id} and model_name = '{model_name}'";
            return DBHelper.getInstance().excute2GetDecimal(q);
        }
        public static BomModelModelDAO getInstance()
        {
            if (_instance == null) _instance = new BomModelModelDAO();
            return _instance;
        }

        public decimal add(BOM_Model_Model t)
        {
            if (isExist(t)) throw new Exception("Model existed");
            string quey = $"insert into {DBHelper.tblBomModel}(component_id,model_name,model_value) values({t.component_id},'{t.model_name}',{t.model_value})";
            DBHelper.getInstance().excuteQuery(quey);
            return 1;
        }
        public bool isExist(BOM_Model_Model t)
        {
            string query = $"select count(*) from {DBHelper.tblBomModel} where component_id= {t.component_id} and model_name='{t.model_name}'";
            decimal res = DBHelper.getInstance().excuteCount(query);
            return res > 0;
        }

        public bool delete(BOM_Model_Model t)
        {
            string quey = $"delete from {DBHelper.tblBomModel} where component_id= {t.component_id} and model_name='{t.model_name}'";
            return DBHelper.getInstance().excuteQuery(quey) > 0;
        }

        public bool deleteById(decimal id)
        {
            throw new NotImplementedException();
        }
        public void clearData()
        {
            string query = $"delete from {DBHelper.tblBomModel}";
            DBHelper.getInstance().excuteQuery(query);
        }

        public bool update(BOM_Model_Model t)
        {
            string query = $"update {DBHelper.tblBomModel} set model_name='{t.model_name}', model_value={t.model_value} where component_id={t.component_id} and model_name='{t.model_name}'";
            DBHelper.getInstance().excuteQuery(query);
            return true;
            //throw new NotImplementedException();
        }

        public bool updateById(decimal id, BOM_Model_Model t)
        {
            throw new NotImplementedException();
        }

        public List<BOM_Model_Model> getPage(PageAble page)
        {
            throw new NotImplementedException();
        }

        private BomModelModelDAO()
        {

        }
        public decimal getIdByName(string name)
        {
            string query = $"select id from {DBHelper.tblBomModel} where model_name = '{name}'";
            return DBHelper.getInstance().excute2GetDecimal(query);
        }
        public List<string> getListModelName(decimal component_id)
        {
            List<string> models = new List<string>();
            string query = $"select distinct model_name from {DBHelper.tblBomModel} where component_id = {component_id}";
            using (SqlConnection con = DBHelper.getConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                var reader =  cmd.ExecuteReader();
                while (reader.Read())
                {
                    models.Add(reader.GetString(0));
                }
            }
            return models;
        }
        public List<string> getListModelName()
        {
            List<string> models = new List<string>();
            string query = $"select distinct model_name from {DBHelper.tblBomModel}";
            using (SqlConnection con = DBHelper.getConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    models.Add(reader.GetString(0));
                }
            }
            return models;
        }
    }
}
