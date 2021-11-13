
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBookBox = new System.Windows.Forms.GroupBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblBookP = new System.Windows.Forms.Label();
            this.tbUnitP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBookBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBookBox
            // 
            this.gBookBox.Controls.Add(this.tbUnitP);
            this.gBookBox.Controls.Add(this.lblBookP);
            this.gBookBox.Controls.Add(this.lblQuantity);
            this.gBookBox.Controls.Add(this.btnCalculate);
            this.gBookBox.Controls.Add(this.tbQuantity);
            this.gBookBox.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.gBookBox.Location = new System.Drawing.Point(119, 66);
            this.gBookBox.Name = "gBookBox";
            this.gBookBox.Size = new System.Drawing.Size(275, 246);
            this.gBookBox.TabIndex = 0;
            this.gBookBox.TabStop = false;
            this.gBookBox.Text = "Book Buying";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(117, 107);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(110, 31);
            this.tbQuantity.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(70, 170);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 48);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(4, 107);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(107, 21);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Enter Quantity:";
            // 
            // lblBookP
            // 
            this.lblBookP.AutoSize = true;
            this.lblBookP.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookP.Location = new System.Drawing.Point(33, 65);
            this.lblBookP.Name = "lblBookP";
            this.lblBookP.Size = new System.Drawing.Size(78, 21);
            this.lblBookP.TabIndex = 3;
            this.lblBookP.Text = "Book Price:";
            // 
            // tbUnitP
            // 
            this.tbUnitP.Location = new System.Drawing.Point(117, 60);
            this.tbUnitP.Name = "tbUnitP";
            this.tbUnitP.Size = new System.Drawing.Size(110, 31);
            this.tbUnitP.TabIndex = 4;
            this.tbUnitP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(123, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "5% discount on orders less than 20,\r\nbetween 20 and 50 %10 discount, \r\nbetween 50" +
    " and100 %15 discount,\r\nmore than 100 %25 discount.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBookBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBookBox.ResumeLayout(false);
            this.gBookBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBookBox;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbUnitP;
        private System.Windows.Forms.Label lblBookP;
        private System.Windows.Forms.Label label1;
    }
}

