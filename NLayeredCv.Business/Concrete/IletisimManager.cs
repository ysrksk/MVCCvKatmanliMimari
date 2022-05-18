using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayeredCv.Business.Abstract;
using NLayeredCv.DataAccess.Abstract;
using NLayeredCv.Entities.Concrete;

namespace NLayeredCv.Business.Concrete
{
    public class IletisimManager : IIletisimService
    {
        private IIletisimDal _iletisimDal;
        public IletisimManager(IIletisimDal iletisimDal)
        {
            _iletisimDal = iletisimDal;
        }

        public void Add(TblIletisim tblIletisim)
        {
            _iletisimDal.Add(tblIletisim);
        }

        public void Delete(TblIletisim tblIletisim)
        {
            _iletisimDal.Delete(tblIletisim);
        }

        //public TblIletisim Get(TblIletisim tblIletisim)
        //{
        //    throw new NotImplementedException();
        //}

        public List<TblIletisim> GetAll()
        {
            return _iletisimDal.GetAll();
        }

        public void Update(TblIletisim tblIletisim)
        {
            _iletisimDal.Update(tblIletisim);
        }
    }
}
