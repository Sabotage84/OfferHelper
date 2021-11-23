
namespace OfferHelperV1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MakeOffer_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MakeOffer_btn
            // 
            this.MakeOffer_btn.Location = new System.Drawing.Point(79, 374);
            this.MakeOffer_btn.Name = "MakeOffer_btn";
            this.MakeOffer_btn.Size = new System.Drawing.Size(110, 41);
            this.MakeOffer_btn.TabIndex = 0;
            this.MakeOffer_btn.Text = "Сделать КП";
            this.MakeOffer_btn.UseVisualStyleBackColor = true;
            this.MakeOffer_btn.Click += new System.EventHandler(this.MakeOffer_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MakeOffer_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MakeOffer_btn;
    }
}

