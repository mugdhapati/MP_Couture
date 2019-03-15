using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// name of my ecommerce website for womens apparel is Pati_couture
/// </summary>
namespace MP_Couture
{

    /// <summary>
    /// defining a class for a user to login to the ecommerce website
    /// </summary>
    class User
    {
        #region Properities
        /// <summary>
        /// general information of a user like userID, firstname, lastname, email, phonenumber
        /// </summary>
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public int PhoneNumber { get; set; }
        #endregion
    }
    class ShoppingCart
    {
        #region Properities
        /// <summary>
        /// User's Shopping Cart
        /// </summary>
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        #endregion

    }
    
       
}

