using System;

namespace Strategy
{
    public class MovieTicket
    {
        private double _price;
        private IDiscount _discount;

        public double Price
        {
            get
            {
                return _discount.Calculate(_price);
            }
            set
            {
                _price = value;
            }
        }

        public IDiscount Discount
        {
            set
            {
                _discount = value;
            }
        }
    }
}
