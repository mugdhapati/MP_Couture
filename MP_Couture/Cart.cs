using System;
using System.Collections.Generic;
using System.Text;

namespace MP_Couture
{
    
    class Cart
    {
        #region Properities

        public int CartID { get; set; }

        public int CartItems { get; set; }

        public decimal ItemPrice { get; set; }

        public int Quantity { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
        #endregion
    }
}
