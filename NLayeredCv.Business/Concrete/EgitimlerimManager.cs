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
    public class EgitimlerimManager : IEgitimlerimService
    {
        private IEgitimlerimDal _egitimlerimDal;
        public EgitimlerimManager(IEgitimlerimDal egitimlerimDal)
        {
            _egitimlerimDal = egitimlerimDal;
        }

        public void Add(TblEgitimlerim tblEgitimlerim)
        {
            _egitimlerimDal.Add(tblEgitimlerim);
        }

        public void Delete(TblEgitimlerim tblEgitimlerim)
        {
            _egitimlerimDal.Delete(tblEgitimlerim);
        }

        //public TblEgitimlerim Get(TblEgitimlerim tblEgitimlerim)
        //{
        //    throw new NotImplementedException();
        //}

        public List<TblEgitimlerim> GetAll()
        {
            return _egitimlerimDal.GetAll();
        }

        public TblEgitimlerim GetById(int id)
        {
            return _egitimlerimDal.GetAll(p => p.ID == id).FirstOrDefault();
        }

        public void Update(TblEgitimlerim tblEgitimlerim)
        {
            _egitimlerimDal.Update(tblEgitimlerim);
        }
    }
}
