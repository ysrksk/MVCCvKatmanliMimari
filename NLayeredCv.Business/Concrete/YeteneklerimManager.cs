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
    public class YeteneklerimManager : IYeteneklerimService
    {
        private IYeteneklerimDal _yeteneklerimDal;
        public YeteneklerimManager(IYeteneklerimDal yeteneklerimDal)
        {
            _yeteneklerimDal = yeteneklerimDal;
        }

        public void Add(TblYeteneklerim  tblYeteneklerim)
        {
            _yeteneklerimDal.Add(tblYeteneklerim);
        }

        public void Delete(TblYeteneklerim tblYeteneklerim)
        {
            _yeteneklerimDal.Delete(tblYeteneklerim);
        }

        //public TblYeteneklerim Get(filter)
        //{
        //    return _yeteneklerimDal.Get(filter);
        //}

        public List<TblYeteneklerim> GetAll()
        {
            return _yeteneklerimDal.GetAll();
        }

        public TblYeteneklerim GetById(int id)
        {
            return _yeteneklerimDal.GetAll(p=> p.ID == id).FirstOrDefault();
        }

        public void Update(TblYeteneklerim tblYeteneklerim)
        {
            _yeteneklerimDal.Update(tblYeteneklerim);
        }
    }
}
