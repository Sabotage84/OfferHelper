using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfferHelperV1.ProductClasses;
using OfferHelperV1.ProductManager;

namespace OfferHelperV1
{
    public partial class OfferForm : Form
    {
        ProductManagerClass PM;
        public OfferForm()
        {
            InitializeComponent();
            BindListBoxes();
            Servers_lstBx.ContextMenuStrip = contextMenuStrip1;
        }

        public void BindListBoxes()
        {
            PM = new ProductManagerClass();
            Servers_lstBx.DataSource = null;
            Cables_lstBx.DataSource = null;
            Antennas_lstBx.DataSource = null;
            Servers_lstBx.DataSource = PM.Servers;
            Servers_lstBx.DisplayMember = "Name";
            Servers_lstBx.ValueMember = "ID";
            Antennas_lstBx.DataSource = PM.Antennas;
            Antennas_lstBx.DisplayMember = "Name";
            Antennas_lstBx.ValueMember = "ID";
            Cables_lstBx.DataSource = PM.Cables;
            Cables_lstBx.DisplayMember = "Name";
            Cables_lstBx.ValueMember = "ID";
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
            pm.Cables.Add(new Cable(9118,"test5",TypeOfProduct.Cable));
            BindListBoxes();
        }

        private void EditProduct_btn_Click(object sender, EventArgs e)
        {
            Product p;
            p = (Product)Servers_lstBx.SelectedItem;
            EditProductForm f = new EditProductForm(p);
            f.ShowDialog();
        }

        private void ADDEq_btn_Click(object sender, EventArgs e)
        {
            EditProductForm f = new EditProductForm();
            f.Owner = this;
            f.ShowDialog();
        }

        private void Antennas_lstBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p = Servers_lstBx.SelectedItem as Product;
            MessageBox.Show(p.Name+Environment.NewLine+Environment.NewLine+p.Description+Environment.NewLine+
                "Вход: "+p.InPrice.ToString()+Environment.NewLine+"К = "+p.K.ToString()+Environment.NewLine+
                "Цена: "+ p.Price+ Environment.NewLine+"Срок поставки "+p.DeliveryTime.ToString()+" рабочих дней.");
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p;
            p = (Product)Servers_lstBx.SelectedItem;
            EditProductForm f = new EditProductForm(p);
            f.Owner = this;
            f.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManagerClass pm = new ProductManagerClass();
            Product p;
            p = (Product)Servers_lstBx.SelectedItem;
            pm.Remove(p);
            BindListBoxes();
        }
    }
}
