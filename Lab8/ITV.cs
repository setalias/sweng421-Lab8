using System;

namespace Lab8
{
    public interface ITV
    {
        TV replenishTV(int budget);

        void getInfo();

        int getPrice();

        void setPrice(int price);

        string getTVType();

        void setType(string tvType);

        string getBrand();

        void setBrand(string brand);

    }
}
