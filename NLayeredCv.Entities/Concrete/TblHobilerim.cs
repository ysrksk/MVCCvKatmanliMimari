using NLayeredCv.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Entities.Concrete
{
    public class TblHobilerim : IEntity
    {
        public int ID { get; set; }
        public string Açıklama1 { get; set; }
        public string Açıklama2 { get; set; }
    }
}
