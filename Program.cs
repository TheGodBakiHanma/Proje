using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int not1, not2, not3, not4;
            double kişisys, gçnkişi, tplm;
            gçnkişi = 0;
            Console.Write("Sınıf Kişi Sayısı :");
            kişisys = Convert.ToInt32(Console.ReadLine());
            for (int i = 1;i<=kişisys;i++)
            {
                Console.Write(i + "." + "Öğrencinin " + "Notunu Gir :");
                not1 = Convert.ToInt32(Console.ReadLine());
                Console.Write(i + "." + "Öğrencinin " + "Notunu Gir :");
                not2 = Convert.ToInt32(Console.ReadLine());
                Console.Write(i + "." + "Öğrencinin " + "Notunu Gir :");
                not3 = Convert.ToInt32(Console.ReadLine());
                Console.Write(i + "." + "Öğrencinin " + "Notunu Gir :");
                not4 = Convert.ToInt32(Console.ReadLine());

                tplm = (not1 + not2 + not3 + not4) / 4;

                if (tplm >= 50)
                {
                    Console.WriteLine("Öğrenci Geçti "+"Notu :"+tplm);
                    gçnkişi = gçnkişi + 1;
                }
                else
                {
                    Console.WriteLine("Öğrenci Kaldı..." + "Notu :" + tplm);
                }
                if (i == kişisys)
                {
                    if ((kişisys / 2) < gçnkişi)
                    {
                        Console.WriteLine("Sınıf Zeki.." + " Öğrenci Sayısı :" + kişisys + " Geçen Kişi Sayısı :" + gçnkişi);
                    }
                    else
                    {
                        Console.WriteLine("Sınıf Mal.." + " Öğrenci Sayısı :" + kişisys + " Geçen Kişi Sayısı :" + gçnkişi);
                    }
                }
            }
            Console.ReadKey();
        }


    }
}
