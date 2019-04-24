using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KrediKartıProblemi
{
    public class Visa : KrediKartiBilgi
    {
        public override string KartKodu
        {
            get
            {
                return "4";
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
                if (value.Length == 13 || value.Length == 16)
                    base.KartNumarasi = value;
            }
        }
    }
}
