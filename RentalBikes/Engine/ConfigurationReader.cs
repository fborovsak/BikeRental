using RentalBikes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBikes.Engine
{
    public class ConfigurationReader
    {
        private static ConfigurationReader _instance;

        // typed names for every configuration in db, to reduce the chance of a typo in every get/set below
        private const string RENTAL_BY_HOUR_PRICE = "RentalByHourPrice";
        private const string RENTAL_BY_DAY_PRICE = "RentalByDayPrice";
        private const string RENTAL_BY_WEEK_PRICE = "RentalByWeekPrice";
        private const string FAMILY_RENTAL_MIN_AMOUNT = "FamilyRentalMinAmount";
        private const string FAMILY_RENTAL_MAX_AMOUNT = "FamilyRentalMaxAmount";
        private const string FAMILY_RENTAL_DISCOUNT = "FamilyRentalDiscount";

        // for simplicity sake, I'm going to skip the way this list is filled
        public List<Configuration> ConfigurationList { get; set; }

        public static ConfigurationReader GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConfigurationReader();
                return _instance;
            }
        }

        public decimal RentalByHourPrice {
            get { return Convert.ToInt32(ConfigurationList.First(x => x.Name == RENTAL_BY_HOUR_PRICE).Value); }
            set { ConfigurationList.First(x => x.Name == RENTAL_BY_HOUR_PRICE).Value = value.ToString(); }
        }

        public decimal RentalByDayPrice
        {
            get { return Convert.ToInt32(ConfigurationList.First(x => x.Name == RENTAL_BY_DAY_PRICE).Value); }
            set { ConfigurationList.First(x => x.Name == RENTAL_BY_DAY_PRICE).Value = value.ToString(); }
        }

        public decimal RentalByWeekPrice
        {
            get { return Convert.ToInt32(ConfigurationList.First(x => x.Name == RENTAL_BY_WEEK_PRICE).Value); }
            set { ConfigurationList.First(x => x.Name == RENTAL_BY_WEEK_PRICE).Value = value.ToString(); }
        }

        public int FamilyRentalMinAmout
        {
            get { return Convert.ToInt32(ConfigurationList.First(x => x.Name == FAMILY_RENTAL_MIN_AMOUNT).Value); }
            set { ConfigurationList.First(x => x.Name == FAMILY_RENTAL_MIN_AMOUNT).Value = value.ToString(); }
        }

        public int FamilyRentalMaxAmout
        {
            get { return Convert.ToInt32(ConfigurationList.First(x => x.Name == FAMILY_RENTAL_MAX_AMOUNT).Value); }
            set { ConfigurationList.First(x => x.Name == FAMILY_RENTAL_MAX_AMOUNT).Value = value.ToString(); }
        }

        public decimal FamilyRentalDiscount
        {
            get { return Convert.ToDecimal(ConfigurationList.First(x => x.Name == FAMILY_RENTAL_DISCOUNT).Value); }
            set { ConfigurationList.First(x => x.Name == FAMILY_RENTAL_DISCOUNT).Value = value.ToString(); }
        }
    }
}
