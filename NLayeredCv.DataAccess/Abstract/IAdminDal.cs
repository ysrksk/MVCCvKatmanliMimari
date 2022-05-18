using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayeredCv.Entities.Concrete;


namespace NLayeredCv.DataAccess.Abstract
{
    public interface IAdminDal : IEntityRepository<TblAdmin>
    {
    }
}
