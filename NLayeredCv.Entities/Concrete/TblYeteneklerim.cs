using NLayeredCv.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredCv.Entities.Concrete
{
    public class TblYeteneklerim : IEntity
    {
        public int ID { get; set; }
        public string Yetenek { get; set; }
        public int Oran { get; set; }

    }
}
