namespace Lesya_3
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
            this.Insurances_types = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.create_insurance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Insurances_types
            // 
            this.Insurances_types.FormattingEnabled = true;
            this.Insurances_types.Location = new System.Drawing.Point(60, 200);
            this.Insurances_types.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Insurances_types.Name = "Insurances_types";
            this.Insurances_types.Size = new System.Drawing.Size(165, 32);
            this.Insurances_types.TabIndex = 0;
            this.Insurances_types.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид страховки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена страховки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(748, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Страховая выплата";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Location = new System.Drawing.Point(752, 400);
            this.payment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(0, 25);
            this.payment.TabIndex = 4;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(748, 208);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 25);
            this.price.TabIndex = 5;
            // 
            // create_insurance
            // 
            this.create_insurance.Location = new System.Drawing.Point(749, 471);
            this.create_insurance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.create_insurance.Name = "create_insurance";
            this.create_insurance.Size = new System.Drawing.Size(103, 34);
            this.create_insurance.TabIndex = 6;
            this.create_insurance.Text = "Принять";
            this.create_insurance.UseVisualStyleBackColor = true;
            this.create_insurance.Click += new System.EventHandler(this.create_insurance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.create_insurance);
            this.Controls.Add(this.price);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insurances_types);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Insurances_types;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button create_insurance;
    }
}

