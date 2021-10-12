using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    sealed class UltraHD_TV : TV, IUltraHD_TV
    {
        public UltraHD_TV() : base()
        {
            this.setPrice(400);
            this.setType("Ultra");
        }
    }
}
