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
        public EditTextTemplates()
        {
            InitializeComponent();
        }

        private void EditTextTemplates_Load(object sender, EventArgs e)
        {
            TextTemplates tt = new TextTemplates();
            Producer_txtBx.Text = tt.Producer;
        }
    }
}
