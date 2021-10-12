using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class SonyTV : TV
    {
        public SonyTV() : base() 
        {
            this.setPrice(280);
            this.setBrand("Sony");
            
        }
    }
}
