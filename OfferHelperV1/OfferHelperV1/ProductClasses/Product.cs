using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.ProductClasses
{
    abstract class Product
    {
        int iD;
        string name;
        string description;
        int inPrice;
        double k;
        int price;
        TypeOfProduct type;

        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
        public string Description { get => description; set => description = value; }
        public int InPrice { get => inPrice; set => inPrice = value; }
        public double K { get => k; set => k = value; }
        public int Price { get => price; set => price = value; }
        internal TypeOfProduct Type { get => type; set => type = value; }
    }
}
