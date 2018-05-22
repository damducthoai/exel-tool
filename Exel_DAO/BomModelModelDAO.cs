using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exel_DAO
{
    public class BomModelModelDAO:ICRUD<BOM_Model_Model>
    {
        private static BomModelModelDAO _instance;
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
            int res = DBHelper.getInstance().excuteCount(query);
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

        public bool update(BOM_Model_Model t)
        {
            throw new NotImplementedException();
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
    }
}
