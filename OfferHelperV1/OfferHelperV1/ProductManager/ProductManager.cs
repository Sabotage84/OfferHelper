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
            if (prods != null)
            {
                GetProdFromXML.Save(prods);
            }
            else
                System.Windows.Forms.MessageBox.Show("Недьзя сохранить пустой список всех продуктов!");
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

        public string GetProductString(int id)
        {
            foreach (var item in products)
            {
                if (item.ID==id)
                {
                    string str = "";
                    str += item.Name+"\n";
                    str += item.Description+"\n";
                    str += "Цена с НДС " + item.Price.ToString() + "Евро.";
                }
            }
            return "Объект не найден!";
        }

        public int GetCorrectDeliveryTime(List<Product> lst)
        {
            int res = 60;
            try
            {
                if (lst.Count >= 1)
                {
                   res = lst[0].DeliveryTime;
                }
                foreach (var item in lst)
                {
                    if (item.DeliveryTime > res)
                        res = item.DeliveryTime;
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Test error del time");
            }
            return res;

        }

        public string GetDeliveryTimeString(List<Product> lst)
        {
            string res = "";
            int t = GetCorrectDeliveryTime(lst);
            res += "Срок поставки ";
            res += t.ToString();
            res += "рабочих дн.";
            return res;
        }

    }
}
