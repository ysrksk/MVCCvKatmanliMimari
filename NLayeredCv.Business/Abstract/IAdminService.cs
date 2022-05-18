using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Business.Abstract
{
    public interface IAdminService
    {
        List<TblAdmin> GetAll();
        void Update(TblAdmin p);
        void Add(TblAdmin p);
        void Delete(TblAdmin p);
        //List<TblAdmin> AdminControl(TblAdmin tblAdmin2);
        //TblAdmin Get(TblAdmin p);

    }
}
