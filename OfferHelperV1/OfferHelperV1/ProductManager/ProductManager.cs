using OfferHelperV1.ProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.ProductManager
{
    class ProductManager
    {
        List<Product> products = new List<Product>();
        public ProductManager()
        {
            products = GetProducts();
        }

        private List<Product> GetProducts()
        {
            GetProdFromXML t = new GetProdFromXML();
            return t.AllProducts();
        }
    }
}
