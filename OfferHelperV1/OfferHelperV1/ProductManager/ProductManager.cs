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

        public void SaveProducts(List<Product> prods)
        {
            GetProdFromXML.Save(prods);
        }

        public Product GetProductByID(int id)
        {
            foreach (var item in products)
            {
                if (item.ID == id)
                    return item;
            }
            return null;
        }

        public List<Product> GetSameNaneProducts(string str)
        {
            List<Product> res = new List<Product>();
            foreach (var item in products)
            {
                if (item.Name.Contains(str))
                {
                    res.Add(item);
                }
            }
            return res;
        }
    }
}
