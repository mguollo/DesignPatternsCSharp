﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforma
{
    interface IPlataforma
    {
        void ConfigureRMTP();
        void AuthToken();
    }
}
