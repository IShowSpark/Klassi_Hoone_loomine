using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public class Inimene
    {
        private string nimi;
        public Hoone hoone { get; set; }

        public Inimene(string nimi)
        {
            this.nimi = nimi;
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen inimene, nimu nimi on {nimi}");
            Console.WriteLine("Hoone info:");
            hoone.NaitaInfo();
            hoone.NaitaInfo1();
            Console.WriteLine("Ukse info:");
            hoone.GetUks().NaitaInfo();
        }
    }
}
