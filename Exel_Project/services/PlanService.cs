using Exel_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exel_Project.services
{
    class PlanService
    {
        private static PlanService _instance;
        public static PlanService getInstance()
        {
            _instance = _instance == null ? new PlanService() : _instance;
            return _instance;
        }
        private PlanService()
        {

        }
        public void addNewPlan(PlanModel plan)
        {
            if (plan.component_id < 1) throw new Exception("Please select component");
            if (String.IsNullOrEmpty(plan.model_name) || String.IsNullOrWhiteSpace(plan.model_name)) throw new Exception("Plan model cannot leave empty");
            if (plan.plan_data < 0) throw new Exception("Plan data must greater than 0");
            if (plan.plan_line < 0) throw new Exception("Plan line must greater than 0");
            decimal model_id = BomModelModelDAO.getInstance().getIdByName(plan.model_name);
            plan.model_id = model_id;
            if (PlanDao.getInstance().isExist(plan)) throw new Exception("Plan existed");
            PlanDao.getInstance().add(plan);
        }
    }
}
