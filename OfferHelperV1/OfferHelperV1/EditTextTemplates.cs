using OfferHelperV1.OfferClasses;
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
    public partial class EditTextTemplates : Form
    {
        TextTemplates tt;
        public EditTextTemplates()
        {
            InitializeComponent();
            tt = new TextTemplates();
        }

        private void EditTextTemplates_Load(object sender, EventArgs e)
        {
            Producer_txtBx.Text = tt.Producer;
            VerificationExample_txtBx.Text = tt.VerificationExample;
            Remark_txtBx.Text = tt.Remark;
            DeliveryText_txtBx.Text = tt.DeliveryText;
        }

        private void SaveEditTextTemplates_btn_Click(object sender, EventArgs e)
        {
            string[] st = new string[4];
            st[0] = Producer_txtBx.Text;
            st[1] = Remark_txtBx.Text;
            st[2] = VerificationExample_txtBx.Text;
            st[3] = DeliveryText_txtBx.Text;
            tt.SaveTemplates(st);
            Close();
        }

        private void CancelEditTextTemplates_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
