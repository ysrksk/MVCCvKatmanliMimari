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
    public class SertifikalarimManager : ISertifikalarimService
    {
        private ISertifikalarimDal _sertifikalarimDal;
        public SertifikalarimManager(ISertifikalarimDal sertifikalarimDal)
        {
            _sertifikalarimDal = sertifikalarimDal;
        }

        public void Add(TblSertifikalarim tblSertifikalarim)
        {
            _sertifikalarimDal.Add(tblSertifikalarim);
        }

        public void Delete(TblSertifikalarim tblSertifikalarim)
        {
            _sertifikalarimDal.Delete(tblSertifikalarim);
        }

        //public TblSertifikalarim Get(TblSertifikalarim p)
        //{
        //    throw new NotImplementedException();
        //}

        public List<TblSertifikalarim> GetAll()
        {
            return _sertifikalarimDal.GetAll();
        }

        public TblSertifikalarim GetById(int id)
        {
            return _sertifikalarimDal.GetAll(p => p.ID == id).FirstOrDefault();
        }

        public void Update(TblSertifikalarim tblSertifikalarim)
        {
            _sertifikalarimDal.Update(tblSertifikalarim);
        }
    }
}
