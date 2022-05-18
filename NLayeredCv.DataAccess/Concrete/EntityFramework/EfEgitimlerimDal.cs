using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayeredCv.DataAccess.Abstract;
using NLayeredCv.Entities.Concrete;

namespace NLayeredCv.DataAccess.Concrete.EntityFramework
{
    public class EfEgitimlerimDal : IEntityRepositoryBase<TblEgitimlerim, EfDataContext>, IEgitimlerimDal
    {
    }
}
