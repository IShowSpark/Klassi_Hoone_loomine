using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public abstract class Hoone
    {
        public Hoone() { }
        public int Pindala { get; set; }
        public Uks uks;

        public Hoone(int pindala = 100)
        {
            Pindala = pindala;
        }
        public abstract void NaitaInfo();
        public void NaitaInfo1()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");
        }
        public Uks GetUks() 
        {
            return uks;
        }
        public class Uks
        {
            public string Color { get; set; }
            public Uks(string color = "sinine")
            {
                Color = color;
            }
            public void NaitaInfo()
            {
                Console.WriteLine($"Mina olen uks, minu värv on {Color}");
            }

        }
    }
}
