using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class TVProxy : ITV
    {
        private ITV tv;

        public TVProxy(ITV tv)
        {
            this.tv = tv;
        }

        public void getInfo()
        {
            this.tv.getInfo();
        }

        public TV replenishTV(int budget)
        {
            throw new NotImplementedException();
        }
    }
}
