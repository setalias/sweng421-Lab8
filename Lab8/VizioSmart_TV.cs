﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class VizioSmart_TV : VizioTV, ISmart_TV
    {
        public VizioSmart_TV() : base()
        {
            this.setPrice(350);
            this.setBrand("Vizio");
        }

        public double getPowerUsage()
        {
            return 6.35;
        }
    }
}
