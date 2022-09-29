using System;
namespace Uppgift_3_13
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            string svar=Console.ReadLine();
          int svar2=int.Parse(svar);
            if (svar2 < 16) 
            {
                Console.WriteLine("Du är för ung för att vara med");
            }
            else if (svar2 > 19)
            {
                Console.WriteLine("Du är för gammal för att vara med i tävlingen");
            }
            else
            {
                Console.WriteLine("Du får delta i tävlingen!");
            }
        }
    }
}