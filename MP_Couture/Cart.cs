using System;
using System.Collections.Generic;
using System.Text;

namespace MP_Couture
{
    class Cart
    {
        #region Properities
        /// <summary>
        /// User's Shopping Cart
        /// </summary>
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public int Price { get; private set; }

        #endregion


        #region Methods

        public void AddToCart()
        {


        }
        #endregion
    }
}