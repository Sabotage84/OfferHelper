using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OfferHelperV1.ProductClasses
{
    [Serializable,
        XmlInclude(typeof(Server)),
        XmlInclude(typeof(Misc)),
        XmlType]
    public abstract class Product: IComparable
    {
        int iD;
        string name;
        string description;
        int inPrice;
        double k;
        int price;
        TypeOfProduct type;
        int deliveryTime;

        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
        public string Description { get => description; set => description = value; }
        public int InPrice { get => inPrice; set => inPrice = value; }
        public double K { get => k; set => k = value; }
        public int Price { get => price; set => price = value; }
        public int DeliveryTime { get => deliveryTime; set => deliveryTime = value; }
        public TypeOfProduct Type { get => type; set => type = value; }

        public override bool Equals(object obj)
        {
            Product p = obj as Product;
            if (p!=null)
                return Equals(p.ID,ID);

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Product p=null;
            if (obj != null && obj is Product)
                p = obj as Product;
            if (p == null)
                return -1;

            return ID.CompareTo(p.ID);
        }

        public Product(int dt = 60, TypeOfProduct t= TypeOfProduct.Miscs)
        {
            type = t;
            deliveryTime = dt;
        }

        public Product(int id, int dt = 60, TypeOfProduct t= TypeOfProduct.Miscs) : this(dt, t)
        {
            ID = id;
        }

        public Product()
        {
            deliveryTime = 60;
            type = TypeOfProduct.Miscs;
            ID = -1;
        }

    }
}
