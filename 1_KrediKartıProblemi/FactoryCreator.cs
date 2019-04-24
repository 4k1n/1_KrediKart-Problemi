using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KrediKartıProblemi
{
    public class FactoryCreator
    {
        IKrediKartiFactory factory;
        public KrediKartiBilgi krediKarti;

        public FactoryCreator(IKrediKartiFactory _addrFactory)
        {
            this.factory = _addrFactory;
            this.krediKarti = this.factory.krediKartiYarat();
        }
    }
}
