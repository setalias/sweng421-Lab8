using System;
namespace Lab8
{
    public class Smart_TVProxy : TVProxy, ISmart_TV
    {
        private ISmart_TV tv;

        public Smart_TVProxy(ISmart_TV tv) : base(tv)
        {
            this.tv = tv;
        }

        public double getPowerUsage()
        {
           return this.tv.getPowerUsage();
        }
    }
}
