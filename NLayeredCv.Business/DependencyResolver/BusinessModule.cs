using Ninject.Modules;
using NLayeredCv.Business.Abstract;
using NLayeredCv.Business.Concrete;
using NLayeredCv.DataAccess.Abstract;
using NLayeredCv.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Business.DependencyResolver
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAdminService>().To<AdminManager>().InSingletonScope();
            Bind<IAdminDal>().To<EfAdminDal>().InSingletonScope();

            Bind<IDeneyimlerimService>().To<DeneyimlerimManager>().InSingletonScope();
            Bind<IDeneyimlerimDal>().To<EfDeneyimlerimDal>().InSingletonScope();

            Bind<IEgitimlerimService>().To<EgitimlerimManager>().InSingletonScope();
            Bind<IEgitimlerimDal>().To<EfEgitimlerimDal>().InSingletonScope();

            Bind<IHakkindaService>().To<HakkindaManager>().InSingletonScope();
            Bind<IHakkindaDal>().To<EfHakkindaDal>().InSingletonScope();

            Bind<IHobilerimService>().To<HobilerimManager>().InSingletonScope();
            Bind<IHobilerimDal>().To<EfHobilerimDal>().InSingletonScope();

            Bind<IIletisimService>().To<IletisimManager>().InSingletonScope();
            Bind<IIletisimDal>().To<EfIletisimDal>().InSingletonScope();

            Bind<ISertifikalarimService>().To<SertifikalarimManager>().InSingletonScope();
            Bind<ISertifikalarimDal>().To<EfSertifikalarimDal>().InSingletonScope();

            Bind<IYeteneklerimService>().To<YeteneklerimManager>().InSingletonScope();
            Bind<IYeteneklerimDal>().To<EfYeteneklerimDal>().InSingletonScope();
        }
    }
}
