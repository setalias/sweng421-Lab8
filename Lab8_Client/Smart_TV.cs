using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    sealed class Smart_TV : TV, ISmart_TV
    {
        public Smart_TV() : base()
        {
            this.setPrice(300);
            this.setType("Smart");
        }

        public double getPowerUsage()
        {
            return 5.5;
        }

        public new void getInfo()
        {
            base.getInfo();
            Console.WriteLine("Power Usage: " + this.getPowerUsage() + " Watts");
        }
    }
}
