using System;
using System.Collections.Generic;
using System.Text;

namespace MP_Couture
{
    class Cart
    {
        #region Properities

        private static List<CartItem> cart = new List<CartItem>();

        public int CartID { get; set; }

        public int CartItems { get; set; }

        #endregion
    }
}
