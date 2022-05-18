using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Business.Abstract
{
    public interface ISertifikalarimService
    {
        List<TblSertifikalarim> GetAll();
        void Update(TblSertifikalarim p);
        void Add(TblSertifikalarim p);
        void Delete(TblSertifikalarim p);
        TblSertifikalarim GetById(int id);
        //TblSertifikalarim Get(TblSertifikalarim p);

    }
}
