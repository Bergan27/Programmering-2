using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in namn");
            string användarNamn = Console.ReadLine();
            Console.WriteLine("Skriv in din ålder");
            int ålder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lever du? 1=Ja/2=Nej");

            bool livsstatus = true;
            var ingenpuls = Console.ReadLine();

            if ( ingenpuls == "1"){
                livsstatus = true;

            }
            else
            {
                livsstatus = false;
            }
            if(livsstatus == true)
            {
                Console.WriteLine("Ditt namn är " + användarNamn);
                Console.WriteLine("Din ålder är " + ålder);
                Console.WriteLine("Du lever fortfarande, fortsätt så");
            }
            else
            {
                Console.WriteLine("Ditt namn är" + användarNamn);
                Console.WriteLine("Din ålder är" + ålder);
                Console.WriteLine("Ajdå, RIP");
            }
                
            
            

        }
    }
}
