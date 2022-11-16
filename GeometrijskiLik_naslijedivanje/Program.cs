using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskiLik_naslijedivanje
{
    class GeometrijskiLik
    {
        int brojStranice;
        double[] stranice = new double[10];

        public void UcitajStranice()
        {
            for (int i = 0; i < brojStranice; i++)
            {
                Console.WriteLine("Unesite duljinu {0} stranice" , i + 1);
                string s = Console.ReadLine();
                stranice[i] = Convert.ToDouble(s);
            }
        }

        public double Opseg()
        {
            double opseg = 0;
            for (int i = 0; i < brojStranice; i++)
            {
                opseg += stranice[i];
            }
            return opseg;
        }
        

        public GeometrijskiLik(int brojStranice1)
        {
            brojStranice = brojStranice1;
        }
    }
    class Trokut : GeometrijskiLik
    {
        public Trokut() : base(3)
        { 
        }
    }
    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut() : base(4)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            Cetverokut cetverokut = new Cetverokut();

            Console.WriteLine("Opseg trokuta:");
            Console.WriteLine("Unesi duljine stranice trokuta: ");
            trokut.UcitajStranice();
            Console.WriteLine("Opseg trokuta je: {0}" , trokut.Opseg());

            Console.WriteLine("\r\n Opseg cetverokuta:");
            Console.WriteLine("Unesi duljine stranica cetverokuta: ");
            cetverokut.UcitajStranice();
            Console.WriteLine("Opseg cetverokuta je: {0}" , cetverokut.Opseg());

            Console.ReadKey();
        }
    }
}
