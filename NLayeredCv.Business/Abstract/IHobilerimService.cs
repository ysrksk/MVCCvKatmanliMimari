using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Business.Abstract
{
    public interface IHobilerimService
    {
        List<TblHobilerim> GetAll();
        void Update(TblHobilerim p);
        void Add(TblHobilerim p);
        void Delete(TblHobilerim p);
        //TblHobilerim Get(TblHobilerim p);

    }
}
