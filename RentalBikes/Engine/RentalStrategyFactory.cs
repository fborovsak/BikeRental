using RentalBikes.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBikes.Engine
{
    public class RentalStrategyFactory
    {
        private static RentalStrategyFactory _instance;
        public static RentalStrategyFactory GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new RentalStrategyFactory();
                return _instance;
            }
        }

        public IRentalStrategy GetRentalStrategy(string rentalType)
        {
            switch (rentalType)
            {
                case "ByHour":
                    return new RentalByHourStrategy();
                case "ByDay":
                    return new RentalByDayStrategy();
                case "ByWeek":
                    return new RentalByWeekStrategy();
                default:
                    throw new Exception("Unknown rental strategy selected");
            }
        }
    }
}
