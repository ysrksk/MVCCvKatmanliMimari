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
    public class HobilerimManager : IHobilerimService
    {
        private IHobilerimDal _hobilerimDal;
        public HobilerimManager(IHobilerimDal hobilerimDal)
        {
            _hobilerimDal = hobilerimDal;
        }

        public void Add(TblHobilerim tblHobilerim)
        {
            _hobilerimDal.Add(tblHobilerim);
        }

        public void Delete(TblHobilerim tblHobilerim)
        {
            _hobilerimDal.Delete(tblHobilerim);
        }

        //public TblHobilerim Get(TblHobilerim tblHobilerim)
        //{
        //    throw new NotImplementedException();
        //}

        public List<TblHobilerim> GetAll()
        {
            return _hobilerimDal.GetAll();
        }

        public void Update(TblHobilerim tblHobilerim)
        {
            _hobilerimDal.Update(tblHobilerim);
        }
    }
}
