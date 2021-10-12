using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class SonyUltra_TV : SonyTV, IUltraHD_TV
    {
        public SonyUltra_TV() : base()
        {
            this.setPrice(480);
            this.setBrand("Sony");
            this.setType("Ultra TV");
        }
    }
}
