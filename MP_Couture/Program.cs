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
                Console.WriteLine("1. Create a Cart");
                Console.WriteLine("2. Purchase an item");
                Console.WriteLine("3. Return an item");
                Console.WriteLine("4. GetAllItems");
                Console.Write("Select an Option: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting MP_Couture!");
                        return;
                    case "1":
                        Console.Write("FirstName: ");
                        var firstname = Console.ReadLine();
                        Console.Write("LastName: ");
                        var lastname = Console.ReadLine();
                        Console.Write("EmailAddress: ");
                        var emailaddress = Console.ReadLine();

                        var Categories = Enum.GetNames(typeof(Category));

                        for (int i = 0; i < Categories.Length; i++)
                        {
                            Console.WriteLine($"{i}.{Categories[i]}");
                        }

                        Console.Write("Select a Category: ");
                        var category = Enum.Parse<Category>(Console.ReadLine());

                        var a1 = MP_App.CreateCart(productId, productName, productSize, Category, orderDate);
                        Console.WriteLine($"PI: {a1.ProductID}, PN: {a1.ProductName}, PS: {a1.ProductSize}, EA: {a1.EmailAddress}, C: {a1.Category}");

                        break;
                    case "2":
                    case "3":
                    case "4":
                        var cart = MP_App.GetAllItems();
                        foreach (var cartitems in cart)  
                        {
                            
                        }
                    default:
                        break;
                }
            } 
           
        }

    }
}
