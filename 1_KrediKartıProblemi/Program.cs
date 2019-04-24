using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_KrediKartıProblemi
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryCreator creator1 = new FactoryCreator(new VisaFactory());
            creator1.krediKarti.kartSahibi = "Kart Sahibi --> Akın EĞİNLİ";
            creator1.krediKarti.kartNo = "Kart Numarası --> 4*** **** **** ****";
            creator1.krediKarti.kartSKT = DateTime.Today;

            FactoryCreator creator2 = new FactoryCreator(new MasterCardFactory());
            creator2.krediKarti.kartSahibi = "Kart Sahibi --> Serdar EREN";
            creator2.krediKarti.kartNo = "Kart Numarası --> 53** **** **** ****";
            creator2.krediKarti.kartSKT = DateTime.Today;

            Console.WriteLine(creator1.krediKarti.kartSahibi);
            Console.WriteLine(creator1.krediKarti.kartNo);
            Console.WriteLine(creator1.krediKarti.kartSKT);
            Console.WriteLine();
            Console.WriteLine(creator2.krediKarti.kartSahibi);
            Console.WriteLine(creator2.krediKarti.kartNo);
            Console.WriteLine(creator2.krediKarti.kartSKT);
            Console.ReadLine();

        }
    }
}
