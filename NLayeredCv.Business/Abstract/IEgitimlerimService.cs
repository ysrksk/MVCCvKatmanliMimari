using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Business.Abstract
{
    public interface IEgitimlerimService
    {
        List<TblEgitimlerim> GetAll();
        void Update(TblEgitimlerim p);
        void Add(TblEgitimlerim p);
        void Delete(TblEgitimlerim p);
        TblEgitimlerim GetById(int id);
        //TblEgitimlerim Get(TblEgitimlerim p);

    }
}
