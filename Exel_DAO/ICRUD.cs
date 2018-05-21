using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exel_DAO
{
    interface ICRUD<T>
    {
        decimal add(T t);
        bool delete(T t);
        bool deleteById(decimal id);
        bool update(T t);
        bool updateById(decimal id, T t);
        List<T> getPage(PageAble page);
    }
}
