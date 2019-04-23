using System;
using System.Collections.Generic;
using System.Text;

namespace MP_Couture
{
    
    class CartItem
    {
        #region statics
        private static int lastCartNumber = 0;
        #endregion

        #region Properities
        /// <summary>
        /// Cart Information of a user
        /// </summary>
        public int CartItemID { get; private set; }

        public int CartID { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductSize { get; set; }

        public int Quantity { get; set; }



        #endregion

    }
}