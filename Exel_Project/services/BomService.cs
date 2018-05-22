using Exel_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exel_Project.services
{
    class BomService
    {
        static BomService _instance;
        public static BomService getInstance()
        {
            if (_instance == null) _instance = new BomService();
            return _instance;
        }
        private BomService()
        {

        }
        
        public void save(BOM_Model model)
        {
            if (BOMDao.getInstance().isExist(model.component_name))
            {
                throw new Exception(MessageHelper.component_existed);
            }
            BOMDao.getInstance().add(model);
        }
        public void deleteBomById(decimal id)
        {
            BOMDao.getInstance().deleteById(id);
        }
        public void updateBom(BOM_Model model)
        {
            if (String.IsNullOrEmpty(model.component_name) || String.IsNullOrWhiteSpace(model.component_name)) throw new Exception("Component name cannot left empty");
            if (model.component_id < 1) throw new Exception("Invalid component, cannot update");
            BOMDao.getInstance().update(model);
        }
    }
}
