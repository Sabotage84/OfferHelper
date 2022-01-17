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
            throw new NotImplementedException();
        }
    }
}
