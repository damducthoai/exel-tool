using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exel_DAO
{
    public class PlanDao:ICRUD<PlanModel>
    {
        private static PlanDao _instance;

        public static PlanDao getInstance()
        {
            return _instance = _instance == null ? new PlanDao() : _instance;
        }

        public decimal add(PlanModel t)
        {
            string query = $"insert into {DBHelper.tblPlan}(component_id,model_id,plan_data,plan_line,plan_time) values({t.component_id},{t.model_id},{t.plan_data},{t.plan_line},'{t.plan_time}')";
            DBHelper.getInstance().excuteQuery(query);
            return 1;
            //throw new NotImplementedException();
        }
        public bool isExist(PlanModel plan)
        {
            string query = $"select count(*) from {DBHelper.tblPlan} where component_id={plan.component_id} and model_id = {plan.model_id} and plan_line = {plan.plan_line} and plan_time = '{plan.plan_time}'";
            return DBHelper.getInstance().excute2GetDecimal(query) > 0;
        }

        public bool delete(PlanModel t)
        {
            string query = $"delete from {DBHelper.tblPlan} where plan_id = {t.plan_id}";
            DBHelper.getInstance().excuteQuery(query);
            return true;
            //throw new NotImplementedException();
        }

        public bool deleteById(decimal id)
        {
            throw new NotImplementedException();
        }

        public bool update(PlanModel t)
        {
            throw new NotImplementedException();
        }

        public bool updateById(decimal id, PlanModel t)
        {
            throw new NotImplementedException();
        }

        public List<PlanModel> getPage(PageAble page)
        {
            throw new NotImplementedException();
        }

        private PlanDao()
        {

        }
    }
}
