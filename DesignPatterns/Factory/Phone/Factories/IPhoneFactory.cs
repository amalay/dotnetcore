﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.DesignPatterns.Factory.Phone
{
    public interface IPhoneFactory
    {
        IPhone CreatePhone();
    }
}
