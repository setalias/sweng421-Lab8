using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class VizioUltra_TV : VizioTV, IUltraHD_TV
    {
        public VizioUltra_TV() : base()
        {
            this.setPrice(450);
            this.setBrand("Vizio");
        }

    }
}
