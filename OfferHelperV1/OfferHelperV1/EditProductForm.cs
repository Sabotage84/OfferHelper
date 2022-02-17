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
        bool isadd = false;
        public EditProductForm(Product curItem)
        {
            item1 = curItem;
            isadd = false;
            InitializeComponent();
           
        }

        public EditProductForm()
        {
            item1 = null;
            isadd = true;
            InitializeComponent();
            
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            ProductManagerClass pmc = new ProductManagerClass();
            Product item2 = GetNewProduct();
            if (isadd && item2!=null)
            {
                pmc.AddProduct(item2);
            }
            else if (!isadd && item2!=null)
            {
                pmc.Edit(item1, item2);
            }
            else
            {
                MessageBox.Show("Неправильный элемент!");
            }
            pmc.RefreshListsOfProducts();
            OfferForm OF1 =  (OfferForm)Owner;
            OF1.BindListBoxes();
            Close();
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
                int t1 = int.Parse(ID_txtBx.Text);
                int t2 = int.Parse(DeliveryTime_txtBx.Text);
                switch (t)
                {
                    case TypeOfProduct.Server:
                        newProduct = new Server(int.Parse(ID_txtBx.Text), int.Parse(DeliveryTime_txtBx.Text));
                        break;
                    case TypeOfProduct.Antenna:
                        newProduct = new Antenna(t1,t2);
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
                try
                {
                    newProduct.Name = Name_txtBx.Text;
                    newProduct.Description = Description_txtBx.Text;
                    newProduct.InPrice = int.Parse(InPrice_txtBx.Text);
                    newProduct.K = double.Parse(K_txtBx.Text);
                    newProduct.Price = int.Parse(Price_txtBx.Text);
                    newProduct.Type = (TypeOfProduct)Type_cmbBx.SelectedItem;
                }
                catch
                {
                    MessageBox.Show("Неправильный элемент!");
                    return null;
                }
            }
            return newProduct;

        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            Type_cmbBx.DataSource = Enum.GetValues(typeof(TypeOfProduct));
            Type_cmbBx.SelectedItem = TypeOfProduct.Miscs;
            if (item1!=null)
            {
                ID_txtBx.Text = item1.ID.ToString();
                Name_txtBx.Text = item1.Name;
                Description_txtBx.Text = item1.Description;
                DeliveryTime_txtBx.Text = item1.DeliveryTime.ToString();
                InPrice_txtBx.Text = item1.InPrice.ToString();
                K_txtBx.Text = item1.K.ToString();
                Price_txtBx.Text = item1.Price.ToString();
            }
            else
            {
                MessageBox.Show("Создание нового элемента.");
            }
        }

        private void Type_cmbBx_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
