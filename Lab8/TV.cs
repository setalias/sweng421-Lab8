﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class TV : ITV
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

        internal int getPrice()
        {
            return this.price;
        }

        internal void setPrice(int price)
        {
            this.price = price;
        }

        internal string getType()
        {
            return this.type;
        }

        internal void setType(string tvType)
        {
            this.type = tvType;
        }

        internal string getBrand()
        {
            return this.brand;
        }

        internal void setBrand(string brand)
        {
            this.brand = brand;
        }
    }

     
}
