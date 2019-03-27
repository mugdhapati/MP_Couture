using System;
using System.Collections.Generic;
using System.Text;

namespace MP_Couture
{
    static class MP_App ///MP_App is the Factory class 
    {

        #region Methods

        static public Account CreateAccount(string firstName, string lastName, string emailAddress, int phoneNumber) ///static method - a static class should have a static method not an instance
        {
            var a1 = new Account ///creating new account for the ecommerce user 
            {
                ///<summary>
                /// User gives the below details used to create an account like first & lastname, email, phone number
                ///</summary> 
                EmailAddress = emailAddress,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                
            };

            return a1;  /// Returns the account that has been created for the user

        }

        #endregion

    }
}
