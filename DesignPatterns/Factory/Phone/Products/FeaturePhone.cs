﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Factory.Phone
{
    class FeaturePhone : IPhone
    {
        public string Result()
        {
            return "Feature Phone";
        }
    }
}
