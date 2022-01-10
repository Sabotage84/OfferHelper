using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfferHelperV1.ProductManager;

namespace OfferHelperV1
{
    public partial class OfferForm : Form
    {
        public OfferForm()
        {
            InitializeComponent();
        }

        private void AddServerToOffer_btn_Click(object sender, EventArgs e)
        {

        }

        private void ReciverAddToOffer_btn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditTextTemplates nf = new EditTextTemplates();
            nf.ShowDialog();
        }

        private void RemoveFromOfferList_btn_Click(object sender, EventArgs e)
        {

        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            ProductManagerClass pm = new ProductManagerClass();
            string test1 = "";
            foreach (var item in pm.Products)
            {
                test1 += item.Name + " ";
            }
            MessageBox.Show(test1);

        }
    }
}
