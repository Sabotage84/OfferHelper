using OfferHelperV1.ProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.OfferClasses
{
    class OfferList
    {
        List<Product> items = new List<Product>();

        public void AddItem(Product p)
        {
            items.Add(p);
        }

        public void RemoveItem(Product p)
        {
            items.Remove(p);
        }

        public string GetStringOffer()//TODO add string tampletes
        {
            string res = "";
            foreach (var item in items)
            {
                res += item.ToString()+"\n";
            }
            return res;
        }
    }
}
