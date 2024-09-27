namespace ProductInventory
{
    partial class FrmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTxtDescription = new RichTextBox();
            gridViewProductList = new DataGridView();
            txtQuantity = new TextBox();
            txtProductName = new TextBox();
            txtSellPrice = new TextBox();
            dtPickerExpDate = new DateTimePicker();
            dtPickerMfgDate = new DateTimePicker();
            cbCategory = new ComboBox();
            btnAddProduct = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(268, 65);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(255, 184);
            richTxtDescription.TabIndex = 1;
            richTxtDescription.Text = "";
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(12, 306);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(511, 150);
            gridViewProductList.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(89, 185);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(159, 23);
            txtQuantity.TabIndex = 3;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(89, 50);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(159, 23);
            txtProductName.TabIndex = 3;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(89, 224);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(159, 23);
            txtSellPrice.TabIndex = 4;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Format = DateTimePickerFormat.Short;
            dtPickerExpDate.Location = new Point(89, 156);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(159, 23);
            dtPickerExpDate.TabIndex = 5;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Format = DateTimePickerFormat.Short;
            dtPickerMfgDate.Location = new Point(89, 127);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(159, 23);
            dtPickerMfgDate.TabIndex = 6;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(89, 89);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(159, 23);
            cbCategory.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(432, 266);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(91, 23);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 35);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 10;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 11;
            label3.Text = "Add Product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 51);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 12;
            label4.Text = "Product";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 89);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 13;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 131);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 14;
            label6.Text = "Mfg. Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 160);
            label7.Name = "label7";
            label7.Size = new Size(63, 17);
            label7.TabIndex = 15;
            label7.Text = "Exp. Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 191);
            label8.Name = "label8";
            label8.Size = new Size(31, 17);
            label8.TabIndex = 16;
            label8.Text = "Qty.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 224);
            label9.Name = "label9";
            label9.Size = new Size(36, 17);
            label9.TabIndex = 17;
            label9.Text = "Price";
            // 
            // FrmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 463);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAddProduct);
            Controls.Add(cbCategory);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(dtPickerExpDate);
            Controls.Add(txtSellPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtQuantity);
            Controls.Add(gridViewProductList);
            Controls.Add(richTxtDescription);
            Name = "FrmAddProduct";
            Text = "Form1";
            Load += FrmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTxtDescription;
        private DataGridView gridViewProductList;
        private TextBox txtQuantity;
        private TextBox txtProductName;
        private TextBox txtSellPrice;
        private DateTimePicker dtPickerExpDate;
        private DateTimePicker dtPickerMfgDate;
        private ComboBox cbCategory;
        private Button btnAddProduct;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
