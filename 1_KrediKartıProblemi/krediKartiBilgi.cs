using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KrediKartıProblemi
{
    public abstract class KrediKartiBilgi
    {
        public string kartNo;
        public string kartSahibi;
        public DateTime kartSKT; // son kullanma tarihi

        public virtual string KartNumarasi
        {
            get { return kartNo; }
            set { kartNo = value; }
        }

        public abstract string KartKodu { get; set; }
    }
}
