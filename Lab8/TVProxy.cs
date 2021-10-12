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

        public TVProxy() { }

        public void getInfo()
        {
            if (this.tv == null) 
            {
                this.getInfo();
            }
            else
            {
                this.tv.getInfo();
            }
        }

        public ITV replenishTV(int budget)
        {
            switch(budget)
            {
                case >= 480:
                    return new SonyUltra_TV();
                case >= 450:
                    return new VizioUltra_TV();
                case >= 400:
                    return new UltraHD_TV();
                case >= 380:
                    return new SonySmart_TV();
                case >= 350:
                    return new VizioSmart_TV();
                case >= 300:
                    return new Smart_TV();
                case >= 280:
                    return new SonyTV();
                case >= 250:
                    return new VizioTV();
                case >= 200:
                    return new TV();
                default:
                    return null;
            }
        }
    }
}
