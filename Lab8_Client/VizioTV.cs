using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class VizioTV : TV
    {
        public VizioTV() : base()
        {
            this.setPrice(250);
            this.setBrand("Vizio");
            
        }
    }
}
