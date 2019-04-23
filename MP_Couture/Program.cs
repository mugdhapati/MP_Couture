using System;

namespace MP_Couture
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("WELCOME TO MP_COUTURE!");
            Console.WriteLine("*************************************");
            while(true)
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1. Create a Customer");
                Console.WriteLine("2. Purchase an item");
                Console.WriteLine("3. Return an item");
                Console.WriteLine("4. GetAllItems");
                Console.Write("Select an Option: ");
                var option = Console.ReadLine();
                
            } 
           
        }

    }
}
