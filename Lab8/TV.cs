using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class TV
    {
        private int price;
        private String brand;
        private String type;

        public TV()
        {
            this.setBrand("None");
            this.setType("Regular");
            this.setPrice(200);
        }

        public TV replenishTV(int budget)
        {

            throw new NotImplementedException();
        }

        public void getInfo() {
            Console.WriteLine("Type: " + this.getType());
            Console.WriteLine("Price: $" + this.getPrice());
        }

        protected int getPrice()
        {
            return this.price;
        }

        protected void setPrice(int price)
        {
            this.price = price;
        }

        protected string getType()
        {
            return this.type;
        }

        protected void setType(string tvType)
        {
            this.type = tvType;
        }

        protected string getBrand()
        {
            return this.brand;
        }

        protected void setBrand(string brand)
        {
            this.brand = brand;
        }
    }

     
}
