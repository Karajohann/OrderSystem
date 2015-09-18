namespace OrderSystem
{
    partial class OrdersForm
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
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.CustomerInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UpdateDescription = new System.Windows.Forms.TextBox();
            this.UpdateQuantity = new System.Windows.Forms.TextBox();
            this.UpdatePrice = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.OrdersNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.AllowUserToAddRows = false;
            this.OrdersGridView.AllowUserToDeleteRows = false;
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(12, 99);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.ReadOnly = true;
            this.OrdersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGridView.Size = new System.Drawing.Size(861, 448);
            this.OrdersGridView.TabIndex = 0;
            this.OrdersGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OrdersGridView_MouseClick);
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.AutoSize = true;
            this.CustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CustomerInfo.Location = new System.Drawing.Point(20, 15);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(45, 16);
            this.CustomerInfo.TabIndex = 1;
            this.CustomerInfo.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Προσθήκη Παραγγελίας";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(767, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Διαγραφή Παραγγελίας";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateDescription
            // 
            this.UpdateDescription.Location = new System.Drawing.Point(12, 557);
            this.UpdateDescription.Name = "UpdateDescription";
            this.UpdateDescription.Size = new System.Drawing.Size(290, 20);
            this.UpdateDescription.TabIndex = 4;
            // 
            // UpdateQuantity
            // 
            this.UpdateQuantity.Location = new System.Drawing.Point(308, 557);
            this.UpdateQuantity.Name = "UpdateQuantity";
            this.UpdateQuantity.Size = new System.Drawing.Size(128, 20);
            this.UpdateQuantity.TabIndex = 5;
            // 
            // UpdatePrice
            // 
            this.UpdatePrice.Location = new System.Drawing.Point(442, 557);
            this.UpdatePrice.Name = "UpdatePrice";
            this.UpdatePrice.Size = new System.Drawing.Size(118, 20);
            this.UpdatePrice.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 553);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 27);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ενημέρωση Παραγγελίας";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OrdersNumber
            // 
            this.OrdersNumber.AutoSize = true;
            this.OrdersNumber.Location = new System.Drawing.Point(751, 559);
            this.OrdersNumber.Name = "OrdersNumber";
            this.OrdersNumber.Size = new System.Drawing.Size(35, 13);
            this.OrdersNumber.TabIndex = 8;
            this.OrdersNumber.Text = "label1";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(885, 584);
            this.Controls.Add(this.OrdersNumber);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.UpdatePrice);
            this.Controls.Add(this.UpdateQuantity);
            this.Controls.Add(this.UpdateDescription);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustomerInfo);
            this.Controls.Add(this.OrdersGridView);
            this.Name = "OrdersForm";
            this.Text = "Παραγγελίες";
            this.Activated += new System.EventHandler(this.OrdersForm_Load);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Label CustomerInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox UpdateDescription;
        private System.Windows.Forms.TextBox UpdateQuantity;
        private System.Windows.Forms.TextBox UpdatePrice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label OrdersNumber;
    }
}