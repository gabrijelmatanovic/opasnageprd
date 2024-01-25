using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedivanje
{
    class Cat
    {
        bool opasna;

        public bool Opasna { get => opasna; set => opasna = value; }

        public virtual void Opasnost()
        {
            Opasna = false;
        }
    }

    class Gepard : Cat
    {
        public override void Opasnost()
        {
            Opasna = true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Gepard g = new Gepard();
            Console.WriteLine(g.Opasna);
            g.Opasnost();

            Console.WriteLine(g.Opasna);

            Console.ReadLine();
        }
    }
}
