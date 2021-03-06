using OfferHelperV1.ProductClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfferHelperV1.ProductManager
{
    class ProductManagerClass
    {
        static List<Product> products = new List<Product>();
        static ObservableCollection<Server> servers = new ObservableCollection<Server>();
        static ObservableCollection<Antenna> antennas = new ObservableCollection<Antenna>();
        static ObservableCollection<Cable> cables = new ObservableCollection<Cable>();
        static ObservableCollection<Misc> miscs = new ObservableCollection<Misc>();


        GetProdFromXML GetLoadFromXML = new GetProdFromXML();

        internal  List<Product> Products { get => products; set => products = value; }
        public ObservableCollection<Server> Servers { get => servers; set => servers = value; }
        internal ObservableCollection<Antenna> Antennas { get => antennas; set => antennas = value; }
        internal ObservableCollection<Cable> Cables { get => cables; set => cables = value; }
        public ObservableCollection<Misc> Miscs { get => miscs; set => miscs = value; }
        internal ObservableCollection<Services> AllServices { get => allServices; set => allServices = value; }

        ObservableCollection<Services> allServices = new ObservableCollection<Services>();

        public ProductManagerClass()
        {
            Products = GetProducts();
            RefreshListsOfProducts();
        }

        public void RefreshListsOfProducts()
        {
            Servers = new ObservableCollection<Server>();
            Antennas = new ObservableCollection<Antenna>();
            Cables = new ObservableCollection<Cable>();
            AllServices = new ObservableCollection<Services>();
            Miscs = new ObservableCollection<Misc>();
            foreach (var item in Products)
            {
                if (item.Type == TypeOfProduct.Server)
                    Servers.Add((Server)item);
                else if (item.Type == TypeOfProduct.Antenna)
                    Antennas.Add((Antenna)item);
                else if (item.Type == TypeOfProduct.Cable)
                    Cables.Add((Cable)item);
                else if (item.Type == TypeOfProduct.Service)
                    AllServices.Add((Services)item);
                else if (item.Type == TypeOfProduct.Miscs)
                    Miscs.Add((Misc)item);
            }
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
                GetLoadFromXML.Save(prods);
            }
            else
                System.Windows.Forms.MessageBox.Show("Недьзя сохранить пустой список всех продуктов!");
        }

        internal void Edit(Product item1, Product item2)
        {
            if (item1==null)
            {
                AddProduct(item2);
            }
            else
            {
                Remove(item1);
                AddProduct(item2);
            }
            SortByID();
        }

        private void SortByID()
        {
            Products.Sort();
        }

        internal void AddProduct(Product item2)
        {
            if (!Products.Contains(item2))
                Products.Add(item2);
            SaveProducts(Products);
        }

        public Product GetProductByID(int id)
        {
            foreach (var item in Products)
            {
                if (item.ID == id)
                    return item;
            }
            return null;
        }

        public List<Product> GetSameNaneProducts(string str)
        {
            List<Product> res = new List<Product>();
            foreach (var item in Products)
            {
                if (item.Name.Contains(str))
                {
                    res.Add(item);
                }
            }
            return res;
        }


        public List<Product> GetProductsByProp(string str)
        {
            List<Product> res = new List<Product>();
            foreach (var item in Products)
            {
                if (item.Name.Contains(str))
                {
                    res.Add(item);
                }
                else if (item.Description.Contains(str))
                {
                    res.Add(item);
                }
            }
            return res;
        }

        public string GetProductString(int id)
        {
            foreach (var item in Products)
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

        public void Remove(Product p)
        {
            if (Products.Contains(p))
                Products.Remove(p);
            SaveProducts(Products);
        }

        public void RemoveAt(int i)
        {
            if (i>-1 && i<Products.Count)
                Products.RemoveAt(i);
            SaveProducts(Products);
        }

    }
}
