
namespace OfferHelperV1
{
    partial class EditTextTemplates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Producer_lbl = new System.Windows.Forms.Label();
            this.Producer_txtBx = new System.Windows.Forms.TextBox();
            this.VerificationExample_lbl = new System.Windows.Forms.Label();
            this.VerificationExample_txtBx = new System.Windows.Forms.TextBox();
            this.Remark_lbl = new System.Windows.Forms.Label();
            this.Remark_txtBx = new System.Windows.Forms.TextBox();
            this.DeliveryText_txtBx = new System.Windows.Forms.TextBox();
            this.DeliveryText_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Producer_lbl
            // 
            this.Producer_lbl.AutoSize = true;
            this.Producer_lbl.Location = new System.Drawing.Point(22, 28);
            this.Producer_lbl.Name = "Producer_lbl";
            this.Producer_lbl.Size = new System.Drawing.Size(110, 17);
            this.Producer_lbl.TabIndex = 0;
            this.Producer_lbl.Text = "Производитель";
            // 
            // Producer_txtBx
            // 
            this.Producer_txtBx.Location = new System.Drawing.Point(25, 48);
            this.Producer_txtBx.Multiline = true;
            this.Producer_txtBx.Name = "Producer_txtBx";
            this.Producer_txtBx.Size = new System.Drawing.Size(319, 116);
            this.Producer_txtBx.TabIndex = 1;
            // 
            // VerificationExample_lbl
            // 
            this.VerificationExample_lbl.AutoSize = true;
            this.VerificationExample_lbl.Location = new System.Drawing.Point(22, 192);
            this.VerificationExample_lbl.Name = "VerificationExample_lbl";
            this.VerificationExample_lbl.Size = new System.Drawing.Size(64, 17);
            this.VerificationExample_lbl.TabIndex = 2;
            this.VerificationExample_lbl.Text = "Поверка";
            // 
            // VerificationExample_txtBx
            // 
            this.VerificationExample_txtBx.Location = new System.Drawing.Point(25, 212);
            this.VerificationExample_txtBx.Multiline = true;
            this.VerificationExample_txtBx.Name = "VerificationExample_txtBx";
            this.VerificationExample_txtBx.Size = new System.Drawing.Size(319, 112);
            this.VerificationExample_txtBx.TabIndex = 3;
            // 
            // Remark_lbl
            // 
            this.Remark_lbl.AutoSize = true;
            this.Remark_lbl.Location = new System.Drawing.Point(22, 343);
            this.Remark_lbl.Name = "Remark_lbl";
            this.Remark_lbl.Size = new System.Drawing.Size(91, 17);
            this.Remark_lbl.TabIndex = 4;
            this.Remark_lbl.Text = "Примечание";
            // 
            // Remark_txtBx
            // 
            this.Remark_txtBx.Location = new System.Drawing.Point(25, 363);
            this.Remark_txtBx.Multiline = true;
            this.Remark_txtBx.Name = "Remark_txtBx";
            this.Remark_txtBx.Size = new System.Drawing.Size(319, 102);
            this.Remark_txtBx.TabIndex = 5;
            // 
            // DeliveryText_txtBx
            // 
            this.DeliveryText_txtBx.Location = new System.Drawing.Point(453, 48);
            this.DeliveryText_txtBx.Multiline = true;
            this.DeliveryText_txtBx.Name = "DeliveryText_txtBx";
            this.DeliveryText_txtBx.Size = new System.Drawing.Size(301, 116);
            this.DeliveryText_txtBx.TabIndex = 6;
            // 
            // DeliveryText_lbl
            // 
            this.DeliveryText_lbl.AutoSize = true;
            this.DeliveryText_lbl.Location = new System.Drawing.Point(450, 28);
            this.DeliveryText_lbl.Name = "DeliveryText_lbl";
            this.DeliveryText_lbl.Size = new System.Drawing.Size(64, 17);
            this.DeliveryText_lbl.TabIndex = 7;
            this.DeliveryText_lbl.Text = "Дотавка";
            // 
            // EditTextTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 477);
            this.Controls.Add(this.DeliveryText_lbl);
            this.Controls.Add(this.DeliveryText_txtBx);
            this.Controls.Add(this.Remark_txtBx);
            this.Controls.Add(this.Remark_lbl);
            this.Controls.Add(this.VerificationExample_txtBx);
            this.Controls.Add(this.VerificationExample_lbl);
            this.Controls.Add(this.Producer_txtBx);
            this.Controls.Add(this.Producer_lbl);
            this.Name = "EditTextTemplates";
            this.Text = "EditTextTemplates";
            this.Load += new System.EventHandler(this.EditTextTemplates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Producer_lbl;
        private System.Windows.Forms.TextBox Producer_txtBx;
        private System.Windows.Forms.Label VerificationExample_lbl;
        private System.Windows.Forms.TextBox VerificationExample_txtBx;
        private System.Windows.Forms.Label Remark_lbl;
        private System.Windows.Forms.TextBox Remark_txtBx;
        private System.Windows.Forms.TextBox DeliveryText_txtBx;
        private System.Windows.Forms.Label DeliveryText_lbl;
    }
}