using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Business.Abstract
{
    public interface IYeteneklerimService
    {
        List<TblYeteneklerim> GetAll();
        void Update(TblYeteneklerim p);
        void Add(TblYeteneklerim p);
        void Delete(TblYeteneklerim p);
        TblYeteneklerim GetById(int id);
        //TblYeteneklerim Get(Expression<<Func<TblYeteneklerim,bool>> filter);

    }
}
