using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exel_DAO
{
    public class BOMDao : ICRUD<BOM_Model>
    {
        private static BOMDao _instance;
        public static BOMDao getInstance()
        {
            if (_instance == null) _instance = new BOMDao();
            return _instance;
        }
        private BOMDao()
        {

        }
        public decimal add(BOM_Model t)
        {
            string query = $"insert into {DBHelper.tblBom}(component_name, object_description) values ('{t.component_name}','{t.object_description}')";

            DBHelper.getInstance().excuteQuery(query);
            return 1;
        }

        public bool delete(BOM_Model t)
        {
            throw new NotImplementedException();
        }

        public bool deleteById(decimal t)
        {
            string query = $"delete from {DBHelper.tblBom} where component_id = {t}";
            DBHelper.getInstance().excuteQuery(query);
            return true;
        }
        public decimal getComponentIdByName(string name)
        {
            string query = $"select component_id from {DBHelper.tblBom} where component_name='{name}'";
            return DBHelper.getInstance().excuteCount(query);
        }

        public bool update(BOM_Model t)
        {
            throw new NotImplementedException();
        }

        public bool updateById(decimal id, BOM_Model t)
        {
            throw new NotImplementedException();
        }

        public List<BOM_Model> getPage(PageAble page)
        {
            throw new NotImplementedException();
        }
        public bool isExist(string name)
        {
            string query = $"select * from {DBHelper.tblBom} where component_name = '{name}'";
            return DBHelper.getInstance().trueOrFalse(query);
        }
    }
}
