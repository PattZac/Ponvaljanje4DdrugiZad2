using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponvaljanje4DdrugiZad2
{
    internal class Program
    {
        class GeometrijskiLik
        {
            int brojStranica;
            double[] stranice = new double[10];

            public int BrojStranica { get => brojStranica; set => brojStranica = value; }
            public double[] Stranice { get => stranice; set => stranice = value; }

            public void UcitajStranice()
            {
                for(int i = 0; i<BrojStranica; i++)
                {
                    Console.Write("Unesi " + (i+1) + ". stranicu: ");
                    Stranice[i]= Convert.ToDouble( Console.ReadLine() );
                }
            }
            public double Opseg()
            {
                double opseg = 0;
                for(int i = 0; i<BrojStranica; i++)
                {
                    opseg += Stranice[i];
                }
                return opseg;
            }
        }
        class Trokut : GeometrijskiLik
        {
            public Trokut()
            {
                BrojStranica = 3;
            }
        }
        class Cetverokut : GeometrijskiLik
        {
            public Cetverokut()
            {
                BrojStranica = 4;
            }
        }
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            Cetverokut cetverokut = new Cetverokut();
            Console.WriteLine("Unesi duljine sve 3 strane trokuta u cm");
            trokut.UcitajStranice();
            Console.WriteLine("Unesi duljine sve 4 strane cetverokuta u cm");
            cetverokut.UcitajStranice();
            Console.WriteLine("Opseg trokuta je " + trokut.Opseg() + "cm, a opseg cetverokuta je " + cetverokut.Opseg() + "cm.");
            Console.ReadLine();
        }
    }
}
