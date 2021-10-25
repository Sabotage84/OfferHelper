using OfferHelperV1.ProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.ProductManager
{
    class GetProdFromXML
    {
        List<Product> products = new List<Product>();
        public GetProdFromXML()
        {
            products.Add(new Server());
        }

        public List<Product> AllProducts()
        {
            return products;
        }
    }
}
