using System;

namespace _4_paskaita_2018_11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //SayHello();
            //SaySomething();
            //Console.ReadKey();
            //Console.Write("Iveskite pirma skaiciu: ");
            //int pirmas = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Iveskite antra skaiciu: ");
            // int antras = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Suma lygi: " + Suma());
            // Console.ReadKey();
            /*
            Console.Write("Iveskite ugi metrais: ");
            float ugis_m = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite svori kilogramais: ");
            int svoris = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu KMI: " + KMI(ugis_m, svoris));
            Console.WriteLine("Jus esate: " + FizBusena(ugis_m, svoris));
            */
            int a = 13;
            int b = 9;
            int c = 87;
            Console.WriteLine("Didziausias skaicius " + Max(a,b,c));
            Console.WriteLine("Ar skaicius a yra tarp b ir c: " + InRange(a,b,c));
            Console.WriteLine("Ar skaicius yra pirminis: " + IsPrimal(a));
            Console.WriteLine("Atsitiktinis numeris yra: " + D20());
            Console.ReadKey();
        }
        static void SayHello()
        {
            Console.WriteLine("Hello!");
            SaySomething();

        }
        static void SaySomething()
        {

        }
        static int Suma(int pirmas = 2, int antras = 3)
        {
            int suma = pirmas + antras;
            return suma;
        }
        static float KMI(float ugis_m, int svoris)
        {
            float kmi = svoris / (ugis_m * ugis_m);
            return kmi;
        }
        static string FizBusena(float ugis_m, int svoris)
        {
            float kmi = svoris / (ugis_m * ugis_m);
            if (kmi < 15)
            {
                return "Badaujantis zmogus";
            } else if (kmi < 18.5 && kmi > 15)
            {
                return "Liesas zmogus";
            }else if (kmi > 18.5 && kmi < 25)
            {
                return "Normalaus svorio zmogus";
            }
            else
            {
                return "Nutukes zmogus";
            }
        }
        static int Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            } else if (b > a && b > c)
            {
                return b;
            } else
            {
                return c;
            }
        }
        static bool InRange(int a, int b, int c)
        {
            if (a >= b && a < c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsPrimal(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    break;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        static int D20()
        {
            Random random = new Random();
            int randomNumber = random.Next(0,100);
            return randomNumber;
        }
    }
}
