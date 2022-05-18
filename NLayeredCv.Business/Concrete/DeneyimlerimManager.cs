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
    public class DeneyimlerimManager : IDeneyimlerimService
    {
        private IDeneyimlerimDal _deneyimlerimDal;
        public DeneyimlerimManager(IDeneyimlerimDal deneyimlerimDal)
        {
            _deneyimlerimDal = deneyimlerimDal;
        }

        public void Add(TblDeneyimlerim tblDeneyimlerim)
        {
            _deneyimlerimDal.Add(tblDeneyimlerim);
        }

        public void Delete(TblDeneyimlerim tblDeneyimlerim)
        {
            _deneyimlerimDal.Delete(tblDeneyimlerim);
        }

        //public TblDeneyimlerim Get(TblDeneyimlerim tblDeneyimlerim)
        //{
        //    throw new NotImplementedException();
        //}

        public List<TblDeneyimlerim> GetAll()
        {
            return _deneyimlerimDal.GetAll();
        }

        public TblDeneyimlerim GetById(int id)
        {
            return _deneyimlerimDal.GetAll(p => p.ID == id).FirstOrDefault();
        }

        public void Update(TblDeneyimlerim tblDeneyimlerim)
        {
            _deneyimlerimDal.Update(tblDeneyimlerim);
        }
    }
}
