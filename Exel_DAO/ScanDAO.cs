using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exel_DAO
{
    public class ScanDAO : ICRUD<ScanModel>
    {
        private static ScanDAO _instance;

        public decimal getTotalByCode(string code, string table)
        {
            var q = $"select ISNULL(SUM(quantity), 0) from {table} where code = '{code}'";
            return DBHelper.getInstance().excute2GetDecimal(q);
        }

        public static ScanDAO getInstance()
        {
            return _instance = _instance == null ? new ScanDAO() : _instance;
        }
        private ScanDAO()
        {

        }
        public decimal add(ScanModel t)
        {
            var query = $"insert into {t.table}(scan,shift,date,code,quantity,line,model) values('{t.scan}','{t.shift}','{t.date}','{t.code}',{t.quantity},{t.line},'{t.model}')";
            DBHelper.getInstance().excuteQuery(query);
            return 1;
            //throw new NotImplementedException();
        }

        public bool delete(ScanModel t)
        {
            throw new NotImplementedException();
        }

        public bool deleteById(decimal id)
        {
            //var q = $"delete from "
            throw new NotImplementedException();
        }
        public void delete(decimal id, string table)
        {
            var q = $"delete from {table} where id = {id}";
            DBHelper.getInstance().excuteQuery(q);
        }

        public List<ScanModel> getPage(PageAble page)
        {
            throw new NotImplementedException();
        }

        public bool update(ScanModel t)
        {
            throw new NotImplementedException();
        }

        public bool updateById(decimal id, ScanModel t)
        {
            throw new NotImplementedException();
        }
    }
}
