﻿using System;
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
                test1 += item.ID + " ";
            }
            MessageBox.Show(test1);

            pm.RemoveAt(0);
            
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
            f.ShowDialog();
        }
    }
}
