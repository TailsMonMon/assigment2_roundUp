using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment2_roundUp {
    class Program {
        static void Main(string[] args) {

            //  Intro
            Console.WriteLine("Hejsan! Nu ska vi runda av tal!");
            do {

                //  Input
                Console.Write("Skriv ett tal med många decimaler: ");
                string userInput = Console.ReadLine();

                if(userInput.Contains('.')) {
                    Console.WriteLine("Använd komma istället för punkt, tack.");
                    Console.WriteLine();    // Just to get some space in the output
                }
                else {
                    double userDeci = Convert.ToDouble(userInput);
                    // decimal userDeci = Convert.ToDecimal(Console.ReadLine()); // Input from user is converted to a double

                Console.Write("Skriv antalet decimaler du vill runda av till: ");
                int userRoundUp = Convert.ToInt32(Console.ReadLine());  // Input from user is converted to a int

                Console.WriteLine();    // More space.. 

                    //  Output
                Console.WriteLine("Din avrundning blir: {0}", Math.Round(userDeci, userRoundUp));
                Console.WriteLine("En förbestämd avrundning: {0}", Math.Round(userDeci, 3));
                Console.WriteLine();
                Console.WriteLine();    // More space.. 
                }
            } while(true);
            
        }
    }
}
            /* 
             * Kort intro
             * användaren skriver ett tal med x decimaler 
             *   spara i en variabel - userDeci
             * användaren skriver hur många decimaler det ska avrundas till
             *   spara i en variabel - userRoundUp
             * 
             * runda av userDeci med userRoundUp
             * runda av userDeci med destinedRoundUp
             */
