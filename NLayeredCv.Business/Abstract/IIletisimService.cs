using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayeredCv.Entities.Concrete;

namespace NLayeredCv.Business.Abstract
{
    public interface IIletisimService
    {
        void Add(TblIletisim p);
        List<TblIletisim> GetAll(); 
        void Update(TblIletisim p);
        void Delete(TblIletisim p);
        //TblIletisim Get(TblIletisim p);


    }
}
