using System;

namespace MP_Couture
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ///Joe Smith users details
            var a1 = MP_App.CreateAccount("Joe", "Smith", "joe@test.com", 425425908);
            /// Joe Smith's account details will be displayed in this format on the console
            Console.WriteLine($"AN: {a1.AccountNumber}, FN: {a1.FirstName}, LN: {a1.LastName}, CD: {a1.CreatedDate}, EA: {a1.EmailAddress}, PN: {a1.PhoneNumber} ");

            ///Mickey Mouse user details
            var a2 = MP_App.CreateAccount("Mickey", "Mouse", "Mickey@test.com", 908425908);
            ///Mickey Mouse account details will be displayed in this format on the console
            Console.WriteLine($"AN: {a2.AccountNumber},FN: {a2.FirstName}, LN: {a2.LastName}, CD: {a2.CreatedDate}, EA: {a2.EmailAddress}, PN: {a2.PhoneNumber}");

        }

    }
}
