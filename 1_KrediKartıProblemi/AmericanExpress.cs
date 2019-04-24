using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KrediKartıProblemi
{
    public class AmericanExpress : KrediKartiBilgi
    {
        public override string KartKodu
        {
            get
            {
                return "3";
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string KartNumarasi
        {
            get
            {
                return base.KartNumarasi;
            }

            set
            {
                if (value.Length == 15)
                    base.KartNumarasi = value;
            }
        }
    }
}
