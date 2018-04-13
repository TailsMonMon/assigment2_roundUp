using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment2_roundUp {
    class Program {
        static void Main(string[] args) {

            //      DEFINING DATA
            double userDeci = 0;
            int userRoundUp = -1;

            //      INTRO
            Console.WriteLine("Hejsan! Nu ska vi runda av tal!");
            

            //      INPUT
            do {
                try {
                    Console.WriteLine();
                    Console.Write("Skriv ett tal med många decimaler: ");
                    userDeci = Convert.ToDouble(Console.ReadLine());    // Input from user is converted to a double
                }
                catch(FormatException) {
                    Console.WriteLine("Använd komma \",\" och endast siffror när ni skriver");
                }
            } while(userDeci == 0); // As long as the user don't write a number, the loop will continue

            do {
                try {
                    Console.Write("Skriv antalet decimaler du vill runda av till: ");
                    userRoundUp = Convert.ToInt32(Console.ReadLine());  // Input from user is converted to a int
                }
                catch(FormatException) {
                    Console.WriteLine();
                    Console.WriteLine("Använd endast siffror när ni skriver");
                }
            } while(userRoundUp == -1);

            
            //      OUTPUT
            Console.WriteLine(); 
            Console.WriteLine("Din avrundning blir: {0}", Math.Round(userDeci, userRoundUp));
            Console.WriteLine("En förbestämd avrundning: {0}", Math.Round(userDeci, 3));

            Console.ReadLine();
        }
    }
}
