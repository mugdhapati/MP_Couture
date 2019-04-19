using System;
using System.Collections.Generic;
using System.Text;

namespace MP_Couture
{
    static class MP_App ///MP_App is the Factory class 
    {
        /// <summary>
        /// Creating a collection/list called 'cart'
        /// </summary>
        private static List<CartItem> cart = new List<CartItem>();
        
        #region Methods

        public static CartItem CreateCart(int productId, string productName, string productSize, Category Category, DateTime orderDate) ///static method - a static class should have a static method not an instance
        {
            
             var a1 = new Cart /// 
             {
                    ///<summary>
                    /// Building a cart
                    ///</summary> 
                    ProductID = productId,
                    ProductName = productName,
                    ProductSize = productSize,
                    
                    Category = Category

             };

            cart.Add(a1);

            
            return a1;  /// Returns the account that has been created for the user

        }

        public static IEnumerable<CartItem> GetAllItems()
        {
            return cart;

        }
       

        #endregion

    }
}
