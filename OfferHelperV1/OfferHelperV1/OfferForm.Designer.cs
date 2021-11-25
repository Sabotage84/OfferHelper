
namespace OfferHelperV1
{
    partial class OfferForm
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
            this.SearchALL_lbl = new System.Windows.Forms.Label();
            this.SearchAll_txtBx = new System.Windows.Forms.TextBox();
            this.Servers_lstBx = new System.Windows.Forms.ListBox();
            this.Servsrs_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchALL_lbl
            // 
            this.SearchALL_lbl.AutoSize = true;
            this.SearchALL_lbl.Location = new System.Drawing.Point(12, 38);
            this.SearchALL_lbl.Name = "SearchALL_lbl";
            this.SearchALL_lbl.Size = new System.Drawing.Size(48, 17);
            this.SearchALL_lbl.TabIndex = 0;
            this.SearchALL_lbl.Text = "Поиск";
            // 
            // SearchAll_txtBx
            // 
            this.SearchAll_txtBx.Location = new System.Drawing.Point(12, 58);
            this.SearchAll_txtBx.Name = "SearchAll_txtBx";
            this.SearchAll_txtBx.Size = new System.Drawing.Size(176, 22);
            this.SearchAll_txtBx.TabIndex = 1;
            // 
            // Servers_lstBx
            // 
            this.Servers_lstBx.FormattingEnabled = true;
            this.Servers_lstBx.ItemHeight = 16;
            this.Servers_lstBx.Location = new System.Drawing.Point(12, 114);
            this.Servers_lstBx.Name = "Servers_lstBx";
            this.Servers_lstBx.Size = new System.Drawing.Size(176, 180);
            this.Servers_lstBx.TabIndex = 2;
            // 
            // Servsrs_lbl
            // 
            this.Servsrs_lbl.AutoSize = true;
            this.Servsrs_lbl.Location = new System.Drawing.Point(14, 94);
            this.Servsrs_lbl.Name = "Servsrs_lbl";
            this.Servsrs_lbl.Size = new System.Drawing.Size(66, 17);
            this.Servsrs_lbl.TabIndex = 3;
            this.Servsrs_lbl.Text = "Серверы";
            // 
            // OfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 503);
            this.Controls.Add(this.Servsrs_lbl);
            this.Controls.Add(this.Servers_lstBx);
            this.Controls.Add(this.SearchAll_txtBx);
            this.Controls.Add(this.SearchALL_lbl);
            this.Name = "OfferForm";
            this.Text = "OfferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchALL_lbl;
        private System.Windows.Forms.TextBox SearchAll_txtBx;
        private System.Windows.Forms.ListBox Servers_lstBx;
        private System.Windows.Forms.Label Servsrs_lbl;
    }
}