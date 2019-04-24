using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KrediKartıProblemi
{
    public class MasterCardFactory : IKrediKartiFactory
    {
        public KrediKartiBilgi krediKartiYarat()
        {
            return new MasterCard();
        }
    }
}
