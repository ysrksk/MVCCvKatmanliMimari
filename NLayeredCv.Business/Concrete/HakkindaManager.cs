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
    public class HakkindaManager : IHakkindaService
    {
        private IHakkindaDal _hakkindaDal;
        public HakkindaManager(IHakkindaDal hakkindaDal)
        {
            _hakkindaDal = hakkindaDal;
        }

        public void Add(TblHakkinda tblHakkinda)
        {
            _hakkindaDal.Add(tblHakkinda);
        }

        public void Delete(TblHakkinda tblHakkinda)
        {
            _hakkindaDal.Delete(tblHakkinda);
        }

        //public TblHakkinda Get()
        //{
        //    return _hakkindaDal.Get();
        //}


        public List<TblHakkinda> GetAll()
        {
            return _hakkindaDal.GetAll();
        }

        public TblHakkinda GetByİd()
        {
            return _hakkindaDal.Get(p => p.ID == 1);
        }

        public void Update(TblHakkinda tblHakkinda)
        {
            _hakkindaDal.Update(tblHakkinda);
        }
    }
}
