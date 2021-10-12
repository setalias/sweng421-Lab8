using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class SonySmart_TV : SonyTV, ISmart_TV
    {
        public SonySmart_TV() : base()
        {
            this.setPrice(380);
            this.setBrand("Sony");
        }

        public double getPowerUsage()
        {
            return 5.15;
        }
    }
}
