using RentalBikes.Abstraction;
using RentalBikes.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBikes
{
    public class RentalBikes
    {
        private readonly RentalStrategyFactory _rentalStrategyFactory;
        private readonly ConfigurationReader _configurationReader;

        public RentalBikes()
        {
            // injection of dependecies
            _rentalStrategyFactory = RentalStrategyFactory.GetInstance;
            _configurationReader = ConfigurationReader.GetInstance;
        }

        public decimal GetTotalPrice(List<string> rentals)
        {
            decimal totalPrice = 0;

            foreach (var rental in rentals)
            {
                IRentalStrategy rentalStrategy = _rentalStrategyFactory.GetRentalStrategy(rental);
                totalPrice += rentalStrategy.GetPrice();
            }

            int familyDiscountMinNumber = _configurationReader.FamilyRentalMinAmout;
            int familyDiscountMaxNumber = _configurationReader.FamilyRentalMaxAmout;

            if (familyDiscountMinNumber <= rentals.Count && rentals.Count <= familyDiscountMaxNumber)
            {
                decimal familyDiscount = _configurationReader.FamilyRentalDiscount;
                totalPrice = totalPrice * (1 - familyDiscount);
            }

            return totalPrice;
        }
    }
}
