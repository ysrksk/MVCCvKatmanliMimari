using NLayeredCv.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Entities.Concrete
{
    public class TblEgitimlerim : IEntity
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string AltBaslik1 { get; set; }
        public string AltBaslik2 { get; set; }
        public string GNO { get; set; }
        public string Tarih { get; set; }
    }
}
