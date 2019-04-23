using System;
using System.Collections.Generic;
using System.Text;

namespace MP_Couture
{
    class MP_App ///MP_App is the Factory class 
    {
        /// <summary>
        /// Creating a collection/list called 'cart'
        /// </summary>
        private static List<CartItem> cart = new List<CartItem>();
        
        #region Methods

        public Customer CreateCustomer(string fistName, string lastName, string emailAddress)
        {
            var c1 = new Customer
            {
                FistName = fistName,

                LastName = lastName,

                EmailAddress = emailAddress,

            };
            return c1;

        }

        public Product AddProduct(int productId, string productName, string productSize, int price)
        {
            var p1 = new Product
            {

                ProductId = productId,

                ProductName = productName,

                ProductSize = productSize,

                Price = price,

            };
            return p1;
        }        
        
       

        #endregion

    }
}
