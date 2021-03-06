﻿using RentalBikes.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBikes.Engine
{
    public class RentalByHourStrategy : IRentalStrategy
    {
        public decimal GetPrice()
        {
            ConfigurationReader configurationReader = ConfigurationReader.GetInstance;
            return configurationReader.RentalByHourPrice;
        }
    }
}
