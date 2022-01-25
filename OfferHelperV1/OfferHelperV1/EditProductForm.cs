using OfferHelperV1.ProductClasses;
using OfferHelperV1.ProductManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfferHelperV1
{
    public partial class EditProductForm : Form
    {
        Product item1;
        public EditProductForm(Product curItem)
        {
            item1 = curItem;
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            ProductManagerClass pmc = new ProductManagerClass();
            Product item2 = GetNewProduct();
            pmc.Edit(item1, item2);
        }

        private Product GetNewProduct()
        {
            Product newProduct=null;
            DialogResult f = DialogResult.Yes;
            TypeOfProduct t = TypeOfProduct.Miscs;
            try
            {
                t = (TypeOfProduct)Type_cmbBx.SelectedItem;
            }
            catch (Exception)
            {

                f = MessageBox.Show("Невозможно определить тип! Будет выбран тип разное","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }

            if (f == DialogResult.Yes)
            {
                switch (t)
                {
                    case TypeOfProduct.Server:
                        newProduct = new Server(int.Parse(ID_txtBx.Text), int.Parse(DeliveryTime_txtBx.Text));
                        break;
                    case TypeOfProduct.Antenna:
                        newProduct = new Antenna(int.Parse(ID_txtBx.Text), int.Parse(DeliveryTime_txtBx.Text));
                        break;
                    case TypeOfProduct.Cable:
                        newProduct = new Cable(int.Parse(ID_txtBx.Text), int.Parse(DeliveryTime_txtBx.Text));
                        break;
                    case TypeOfProduct.Reciver:
                        newProduct = new Misc(int.Parse(ID_txtBx.Text), int.Parse(DeliveryTime_txtBx.Text));
                        break;
                    case TypeOfProduct.Miscs:
                        newProduct = new Misc(int.Parse(ID_txtBx.Text), int.Parse(DeliveryTime_txtBx.Text));
                        break;
                    case TypeOfProduct.Service:
                        newProduct = new Services(int.Parse(ID_txtBx.Text), int.Parse(DeliveryTime_txtBx.Text));
                        break;
                    default:
                        MessageBox.Show("Не получилось изменить модуль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            if (newProduct != null)
            {
                newProduct.Description = Description_txtBx.Text;
                newProduct.InPrice = int.Parse(InPrice_txtBx.Text);
                newProduct.K = int.Parse(K_txtBx.Text);
                newProduct.Price = int.Parse(Price_txtBx.Text);
            }
            return newProduct;

        }
    }
}
