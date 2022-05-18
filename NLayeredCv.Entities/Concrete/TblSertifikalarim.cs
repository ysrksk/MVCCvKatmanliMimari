using NLayeredCv.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Entities.Concrete
{
    public class TblSertifikalarim : IEntity
    {
        public int ID { get; set; }
        public string Açıklama { get; set; }
        public string Baslik { get; set; }
        public string Tarih { get; set; }
    }
}
