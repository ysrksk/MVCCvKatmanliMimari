using NLayeredCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.DataAccess.Concrete.EntityFramework
{
    public class EfDataContext : DbContext
    {
        public DbSet<TblAdmin> TblAdmin { get; set; }
        public DbSet<TblDeneyimlerim> TblDeneyimlerim { get; set; }
        public DbSet<TblEgitimlerim> TblEgitimlerim { get; set; }
        public DbSet<TblHakkinda> TblHakkinda { get; set; }
        public DbSet<TblHobilerim> TblHobilerim { get; set; }
        public DbSet<TblIletisim> TblIletisim { get; set; }
        public DbSet<TblSertifikalarim> TblSertifikalarim { get; set; }
        public DbSet<TblYeteneklerim> TblYeteneklerim { get; set; }

    }
}
