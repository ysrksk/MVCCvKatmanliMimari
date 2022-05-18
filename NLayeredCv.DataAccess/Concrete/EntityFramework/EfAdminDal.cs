using NLayeredCv.DataAccess.Abstract;
using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.DataAccess.Concrete.EntityFramework
{
    public class EfAdminDal : IEntityRepositoryBase<TblAdmin, EfDataContext>, IAdminDal
    {
    }
}
