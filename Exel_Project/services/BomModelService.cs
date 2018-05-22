using Exel_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exel_Project.services
{
    class BomModelService
    {
        private static BomModelService _instance;
        public static BomModelService getInstance()
        {
            if (_instance == null) _instance = new BomModelService();
            return _instance;
        }
        public void saveBomModel(BOM_Model_Model model)
        {
            if (model.component_id < 1) throw new Exception("Please select component first");
            BomModelModelDAO.getInstance().add(model);
        }
        private BomModelService()
        {

        }
        public void delete(BOM_Model_Model model)
        {
            if (model.component_id < 1) throw new Exception("Please select component first");
            if(String.IsNullOrEmpty(model.model_name) || String.IsNullOrWhiteSpace(model.model_name)) throw new Exception("No model was delete");
            if (!BomModelModelDAO.getInstance().delete(model)) throw new Exception("Cannot delete model");
        }
    }
}
