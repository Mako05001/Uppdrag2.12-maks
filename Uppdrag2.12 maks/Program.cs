using System;
namespace uppdrag2._12
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många dagar ska du hyra bilen?");
            String strNr = Console.ReadLine();
            int nr = Convert.ToInt32(strNr);
            nr = nr - 1;
            int tr = nr * 500 + 300;
            Console.WriteLine("Hur många KM ska du köra?");
            string strKm = Console.ReadLine();
            int km = Convert.ToInt32(strKm);
            km = km ;
            Console.Write("Så här mycket kommer din bil att kosta ");
            Console.WriteLine(tr + km); 
            
        }
    }
}

