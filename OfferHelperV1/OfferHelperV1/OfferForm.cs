using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfferHelperV1.OfferClasses;
using OfferHelperV1.ProductClasses;
using OfferHelperV1.ProductManager;

namespace OfferHelperV1
{
    public partial class OfferForm : Form
    {
        ProductManagerClass PM;
        TextTemplates textTemplates = new TextTemplates();
        ObservableCollection<Product> offerListOfProduct = new ObservableCollection<Product>();
        ObservableCollection<Server> searchServers = new ObservableCollection<Server>();
        ObservableCollection<Misc> searchMisc = new ObservableCollection<Misc>();
        public OfferForm()
        {
            InitializeComponent();
            PM = new ProductManagerClass();
            ServersListHandler(PM.Servers, SearchAll_txtBx.Text);
            MiscListHandler(PM.Miscs, SearchMisc_txtBx.Text);
            BindListBoxes();
            Servers_lstBx.ContextMenuStrip = Servsrs_cntxtMnStrp;
            Antennas_lstBx.ContextMenuStrip = Antennas_cntxtMnStrp;
            Cables_lstBx.ContextMenuStrip = Cables_cntxtMnStrp;
            Misc_lstBx.ContextMenuStrip = Misc_CntetMnStrp;
            OfferList_lstBx.ContextMenuStrip = OfferList_CntxtMnStrp;
            offerListOfProduct.CollectionChanged += OfferListOfProduct_CollectionChanged;
            RefreshOfferList();
        }

        public void ServersListHandler(ObservableCollection<Server> defServers, string searchString)
        {
            searchServers = new ObservableCollection<Server>();
            if (string.IsNullOrEmpty(searchString) || searchString == "Поиск")
            {
                foreach (var item in defServers)
                {
                    if (item!=null)
                        searchServers.Add(item);
                }
            }
            else
            {
                foreach (var item in defServers)
                {
                    if (item != null && item.Name.ToLower().Contains(searchString.ToLower()))
                        searchServers.Add(item);
                }
            }
        }

        public void MiscListHandler(ObservableCollection<Misc> defMisc, string searchString)
        {
            searchMisc = new ObservableCollection<Misc>();
            if (string.IsNullOrEmpty(searchString) || searchString=="Поиск")
            {
                foreach (var item in defMisc)
                {
                    if (item != null)
                        searchMisc.Add(item);
                }
            }
            else
            {
                foreach (var item in defMisc)
                {
                    if (item != null && item.Name.ToLower().Contains(searchString.ToLower()))
                        searchMisc.Add(item);
                }
            }
        }

        private void OfferListOfProduct_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            RefreshResultText();
        }

        private void RefreshResultText()
        {
            string res = "";
            foreach (var item in offerListOfProduct)
            {
                res += item.Name + Environment.NewLine + Environment.NewLine;
                res += item.Description + Environment.NewLine + Environment.NewLine;
                res += "Цена " + item.Price + " евро с НДС." + Environment.NewLine + Environment.NewLine;
                if (Delivery_chckBx.Checked)
                {
                    res += textTemplates.GetDeliveryTimeString(item.DeliveryTime, item.Type) + Environment.NewLine + Environment.NewLine;
                }
            }
            

            if (Verification_chkBx.Checked)
            {
                foreach (var item in offerListOfProduct)
                {
                    if (item.Name.Contains("HQ") || item.Name.Contains("DHQ") || item.Name.Contains("MRS"))
                    {
                        res += "Организация поверки(получение свидетельства о поверке)" + Environment.NewLine + "500 Евро с НДС." + Environment.NewLine + Environment.NewLine;
                        break;
                    }
                }
            }
            if (Producer_chckBx.Checked)
            {
                res += Environment.NewLine+textTemplates.Producer + Environment.NewLine;
            }
            if (Remark_chckBx.Checked)
            {
                res += Environment.NewLine+textTemplates.Remark + Environment.NewLine;
            }
            if (VerifEx_chckBx.Checked)
            {
                res += Environment.NewLine+textTemplates.VerificationExample + Environment.NewLine;
            }
            
            ResultText_txtBx.Text = res;
        }

        private void RefreshOfferList()
        {
            OfferList_lstBx.DataSource = null;
            OfferList_lstBx.DataSource = offerListOfProduct;
            OfferList_lstBx.DisplayMember = "Name";
            OfferList_lstBx.ValueMember = "ID";
        }

        public void BindListBoxes()
        {
            
            Servers_lstBx.DataSource = null;
            Cables_lstBx.DataSource = null;
            Antennas_lstBx.DataSource = null;
            Misc_lstBx.DataSource = null;
            Servers_lstBx.DataSource = searchServers;
            Servers_lstBx.DisplayMember = "ShortName";
            Servers_lstBx.ValueMember = "ID";
            Antennas_lstBx.DataSource = PM.Antennas;
            Antennas_lstBx.DisplayMember = "ShortName";
            Antennas_lstBx.ValueMember = "ID";
            Cables_lstBx.DataSource = PM.Cables;
            Cables_lstBx.DisplayMember = "ShortName";
            Cables_lstBx.ValueMember = "ID";
            Misc_lstBx.DataSource = searchMisc;
            Misc_lstBx.DisplayMember = "ShortName";
            Misc_lstBx.ValueMember = "ID";
        }

        private void AddServerToOffer_btn_Click(object sender, EventArgs e)
        {
            Product p = Servers_lstBx.SelectedItem as Product;
            if (!offerListOfProduct.Contains(p))
            {
                offerListOfProduct.Add(p);
            }
            RefreshOfferList();
        }

        private void ReciverAddToOffer_btn_Click(object sender, EventArgs e)
        {
            Product p = Misc_lstBx.SelectedItem as Product;
            if (!offerListOfProduct.Contains(p))
            {
                offerListOfProduct.Add(p);
            }
            RefreshOfferList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditTextTemplates nf = new EditTextTemplates();
            nf.ShowDialog();
        }

        private void RemoveFromOfferList_btn_Click(object sender, EventArgs e)
        {
            Product p = OfferList_lstBx.SelectedItem as Product;
            offerListOfProduct.Remove(p);
            RefreshOfferList();
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            TextTemplates tt = new TextTemplates();
            tt.SaveTemplates(TextTemplates.strings);
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
            ShowProduct(p);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p;
            p = (Product)Servers_lstBx.SelectedItem;
            EditProduct(p);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Product p;
            p = (Product)Servers_lstBx.SelectedItem;
            RemoveProduct(p);
            ServersListHandler(PM.Servers, "");
            MiscListHandler(PM.Miscs, "");
            BindListBoxes();
        }

        private void Antennas_cntxtMnStrp_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p = Antennas_lstBx.SelectedItem as Product;
            ShowProduct(p);
        }

        private static void ShowProduct(Product p)
        {
            if (p != null)
            {
                MessageBox.Show(p.Name + Environment.NewLine + Environment.NewLine+"Артикул: " + p.ShortName + Environment.NewLine + p.Description + Environment.NewLine +
                    "Вход: " + p.InPrice.ToString() + Environment.NewLine + "К = " + p.K.ToString() + Environment.NewLine +
                    "Цена: " + p.Price + Environment.NewLine + "Срок поставки " + p.DeliveryTime.ToString() + " рабочих дней.");
            }
            else
            {
                MessageBox.Show("Элемент не выбран!");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p;
            p = (Product)Antennas_lstBx.SelectedItem;
            EditProduct(p);
        }

        private void EditProduct(Product p)
        {
            if (p != null)
            {
                EditProductForm f = new EditProductForm(p);
                f.Owner = this;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Элемент не выбран!");
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Product p;
            p = (Product)Antennas_lstBx.SelectedItem;
            RemoveProduct(p);
            BindListBoxes();
        }

        private void RemoveProduct(Product p)
        {
            if (p != null)
            {
                ProductManagerClass pm = new ProductManagerClass();
                pm.Remove(p);
                pm.RefreshListsOfProducts();
                BindListBoxes();
            }
            else
            {
                MessageBox.Show("Элемент не выбран!");
            }
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product p = Cables_lstBx.SelectedItem as Product;
            ShowProduct(p);
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product p = Cables_lstBx.SelectedItem as Product;
            EditProduct(p);
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product p = Cables_lstBx.SelectedItem as Product;
            RemoveProduct(p);
            BindListBoxes();
        }

        private void showToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Product p = Misc_lstBx.SelectedItem as Product;
            ShowProduct(p);
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Product p = Misc_lstBx.SelectedItem as Product;
            EditProduct(p);
        }

        private void removeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Product p = Misc_lstBx.SelectedItem as Product;
            RemoveProduct(p);
        }

        private void showToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Product p = OfferList_lstBx.SelectedItem as Product;
            ShowProduct(p);
        }

        private void AddAntenna_btn_Click(object sender, EventArgs e)
        {
            Product p = Antennas_lstBx.SelectedItem as Product;
            if (!offerListOfProduct.Contains(p))
            {
                offerListOfProduct.Add(p);
            }
            RefreshOfferList();
        }

        private void AddCableToOffer_btn_Click(object sender, EventArgs e)
        {
            Product p = Cables_lstBx.SelectedItem as Product;
            if (!offerListOfProduct.Contains(p))
            {
                offerListOfProduct.Add(p);
            }
            RefreshOfferList();
        }

        private void Verification_chkBx_CheckedChanged(object sender, EventArgs e)
        {
            RefreshResultText();
        }

        private void OfferList_lbl_Click(object sender, EventArgs e)
        {

        }

        private void CopyToBuffer_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ResultText_txtBx.Text);
            MessageBox.Show("Текст скопирован!");
        }

        private void Producer_chckBx_CheckedChanged(object sender, EventArgs e)
        {
            RefreshResultText();
        }

        private void Remark_chckBx_CheckedChanged(object sender, EventArgs e)
        {
            RefreshResultText();
        }

        private void VerifEx_chckBx_CheckedChanged(object sender, EventArgs e)
        {
            RefreshResultText();
        }

        private void Delivery_chckBx_CheckedChanged(object sender, EventArgs e)
        {
            RefreshResultText();
        }

        private void ResetOffer_btn_Click(object sender, EventArgs e)
        {
            Producer_chckBx.Checked = false;
            Remark_chckBx.Checked = false;
            VerifEx_chckBx.Checked = false;
            Delivery_chckBx.Checked = false;
            Verification_chkBx.Checked = false;
            offerListOfProduct.Clear();
            RefreshOfferList();

        }

        private void SearchAll_txtBx_TextChanged(object sender, EventArgs e)
        {
            ServersListHandler(PM.Servers, SearchAll_txtBx.Text);
            BindListBoxes();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchMisc_txtBx_TextChanged(object sender, EventArgs e)
        {
            MiscListHandler(PM.Miscs, SearchMisc_txtBx.Text);
            BindListBoxes();
        }
    }
}
