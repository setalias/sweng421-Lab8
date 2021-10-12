using System;
namespace Lab8
{
    public class UltraHD_TVProxy : TVProxy, IUltraHD_TV
    {
        private IUltraHD_TV tv;

        public UltraHD_TVProxy(IUltraHD_TV tv) : base(tv)
        {
            this.tv = tv;
        }
    }
}
