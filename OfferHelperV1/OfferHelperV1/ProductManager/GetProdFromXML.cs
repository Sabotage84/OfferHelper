using OfferHelperV1.ProductClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OfferHelperV1.ProductManager
{
    class GetProdFromXML
    {
        List<Product> products = new List<Product>();

        XmlSerializer formatter = new XmlSerializer(typeof(List<Product>));

        public GetProdFromXML()
        {
            try
            {
                Load();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                products.Add(new Server(12,40,TypeOfProduct.Server));
                products.Add(new Server(10, 40, TypeOfProduct.Server));
                products.Add(new Server(11, 40, TypeOfProduct.Server));
                products.Add(new Server(9, 40, TypeOfProduct.Server));
                products.Add(new Server(8, 40, TypeOfProduct.Server));

            }
        }

        public void Load()
        {
            using (FileStream fs = new FileStream("products.xml", FileMode.OpenOrCreate))
            {
                products = (List<Product>)formatter.Deserialize(fs);
            }
        }

        public List<Product> AllProducts()
        {
            return products;
        }

        public void Save(List<Product> prods)
        {
            using (FileStream fs = new FileStream("products.xml", FileMode.Create))
            {
                formatter.Serialize(fs, prods);
                products = prods;
            }
        }
    }
}
