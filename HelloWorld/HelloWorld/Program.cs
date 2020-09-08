using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
          
                Console.WriteLine("Skriv in namn");
                string användarNamn = Console.ReadLine();

                Console.WriteLine("Skriv in din ålder");
                int ålder = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < 18; i++)
                {
                    Console.WriteLine("Du är inte myndig");
                    break;
                }

                Console.WriteLine("Lever du? 1=Ja/2=Nej");
                
                var day = Console.ReadLine();
                switch (day)
                {
                    case "1":
                        Console.WriteLine("Monday");
                        break;
                    case "2":
                        Console.WriteLine("Tuesday");
                        break;
                    default:
                        Console.WriteLine("Inget");
                        break;
                }

                        bool livsstatus;

                var ingenpuls = Console.ReadLine();

                if (ingenpuls == "1") {
                    livsstatus = true;

                }
                else
                {
                    livsstatus = false;
                }
                if (livsstatus == true)
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
                    break;
                }
            }
        }
    }
}
