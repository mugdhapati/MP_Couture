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
        private static int lastAccountNumber = 0;
        #endregion

        #region Properities
        /// <summary>
        /// general information of a user like AccountNumber, firstname, lastname, email, phonenumber, createddate
        /// </summary>
        public int AccountNumber { get; private set; }

        public decimal Balance { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public DateTime CreatedDate { get; private set; }

        public int PhoneNumber { get; set; }
        #endregion

        #region Constructor 
        ///<summary>
        ///Constructor is a method with the same name as Class & is hidden by default
        ///
        ///</summary>
        public Account() ///Constructor has no return type, not even VOID 
        {
            AccountNumber = ++lastAccountNumber;   
            CreatedDate = DateTime.Now;

        }
        #endregion

        #region Methods
        ///<summary>
        ///User tries to buy/ return products from the ecommerce website
        /// 
        /// </summary>
        /// <param name="amount">Amount </param>
        public void Buy(decimal amount)
        {
            Balance -= amount; 
        }
        public void Return(decimal amount)
        {
            Balance += amount;
        }
        #endregion
    }
}

