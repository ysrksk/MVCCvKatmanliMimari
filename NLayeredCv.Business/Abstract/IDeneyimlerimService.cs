using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Business.Abstract
{
    public interface IDeneyimlerimService
    {
        List<TblDeneyimlerim> GetAll();
        void Update(TblDeneyimlerim p);
        void Add(TblDeneyimlerim p);
        void Delete(TblDeneyimlerim p);
        TblDeneyimlerim GetById(int id);
        //TblDeneyimlerim Get(TblDeneyimlerim p);

    }
}
