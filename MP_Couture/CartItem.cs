using System;
using System.Collections.Generic;
using System.Text;

namespace MP_Couture
{
    enum Category
    {
        Tops,
        Bottoms,
        Sweaters,
        Dresses,
        Outerwear,
        Shoes,
        Accessories
    }
    class CartItem
    {
        #region statics
        private static int lastCartNumber = 0;
        #endregion

        #region Properities
        /// <summary>
        /// Cart Information of a user
        /// </summary>
        public int CartID { get; private set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductSize { get; set; }

        public string EmailAddress { get; set; }

        public Category Category { get; set; }

        public DateTime OrderDate { get; private set; }

        public int PhoneNumber { get; set; }

        #endregion

    }
}