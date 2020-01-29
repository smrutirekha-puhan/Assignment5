using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> PrimeMinister = new Dictionary<int, string>();
            PrimeMinister.Add(1998,"Atal Bihari Vajpayee");
            PrimeMinister.Add( 2014, "Narendra Modi");
            PrimeMinister.Add( 2004,"Manmohan Singh");

            Console.WriteLine("PrimeMinister Of 2004:" + PrimeMinister[2004]);
            //Adding current PrimeMinister
           
            PrimeMinister.Add(2020, "Narendra Modi");
            //sorted by year
            PrimeMinister.OrderBy(y => y.Value);
            Console.WriteLine("After sorting List Of PrimeMinister :");
            foreach (var pm in PrimeMinister) 
            {
                Console.WriteLine( pm.Key+" : " +pm.Value);
            }
            Console.ReadKey();
            
        }
    }
}
