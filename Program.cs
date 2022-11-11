using System;

namespace dongular_while_foreach
{
    class program
    {
        private static int sayi;

        static void Main(string[]args)
        { 
          
            Console.Write("***** foreach*****");
            string[]arabalar ={"bmw","audi","mercedes","volvo"};

            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);


            }
             
                
            

    
        }
    }   
}       

