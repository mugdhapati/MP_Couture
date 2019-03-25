using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// name of my ecommerce website for womens apparel is MP_Couture
/// </summary>
namespace MP_Couture
{

    /// <summary>
    /// defining a class account for a user to login to the ecommerce website
    /// </summary>
    class Account
    {
        #region statics
        public static int lastaccountnumber = 0;
        #endregion

        #region Properities
        /// <summary>
        /// general information of a user like AccountNumber, firstname, lastname, email, phonenumber, createddate
        /// </summary>
        public int AccountNumber { get; set; } 

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public DateTime CreatedDate { get; set; }

        public int PhoneNumber { get; set; }
        #endregion
        #region
        public Account()
        {
            AccountNumber = ++lastaccountnumber;
            CreatedDate = DateTime.Now;

        }
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
    #region Methods
    ///<summary>
    ///User tries to buy products from the ecommerce website
    /// 
    /// </summary>
    public void Buy()
    {

    }

    public void Return()
    {

    }
    #endregion

}

