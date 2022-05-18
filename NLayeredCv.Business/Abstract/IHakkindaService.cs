using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Business.Abstract
{
    public interface IHakkindaService
    {
        List<TblHakkinda> GetAll();
        void Update(TblHakkinda p);
        void Add(TblHakkinda p);
        void Delete(TblHakkinda p);
        TblHakkinda GetByİd();
        //TblHakkinda Get();

    }
}
