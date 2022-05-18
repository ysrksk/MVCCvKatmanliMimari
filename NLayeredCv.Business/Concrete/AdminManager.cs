using NLayeredCv.Business.Abstract;
using NLayeredCv.DataAccess.Abstract;
using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Business.Concrete
{
    public class AdminManager : IAdminService
    {
        private IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(TblAdmin tblAdmin)
        {
            _adminDal.Add(tblAdmin);
        }

        //public List<TblAdmin> AdminControl(TblAdmin tblAdmin2)
        //{
        //    return _adminDal.Get(p => p.KullaniciAdi == tblAdmin2.KullaniciAdi && p.Sifre == tblAdmin2.Sifre);
        //}

        public void Delete(TblAdmin tblAdmin)
        {
            _adminDal.Delete(tblAdmin);
        }

        //public TblAdmin Get(TblAdmin tblAdmin)
        //{
        //    throw new NotImplementedException();
        //}

        public List<TblAdmin> GetAll()
        {
            return _adminDal.GetAll();
        }

        public void Update(TblAdmin tblAdmin)
        {
            _adminDal.Update(tblAdmin);
        }
    }
}
