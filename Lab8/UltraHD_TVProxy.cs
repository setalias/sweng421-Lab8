using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class UltraHD_TVProxy
    public class UltraHD_TVProxy : TVProxy, IUltraHD_TV
    {
        private IUltraHD_TV tv;

        public UltraHD_TVProxy(IUltraHD_TV tv) : base(tv)
        {
            this.tv = tv;
        }
    }
}
