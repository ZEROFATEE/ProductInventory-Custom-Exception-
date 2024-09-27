using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace ProductInventory
{
    public partial class FrmAddProduct : Form
    {
        BindingSource showProductList;
        BindingList<ProductClass> ListOfProducts;
        private int _Quantity;
        private double _SellPrice;
        private string? _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListofProductCategory = { "Beverages", "Bread/Bakery", "Canned/Jar Foods",
                "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other" };

            foreach (string item in ListofProductCategory)
            {
                cbCategory.Items.Add(item);
            }

        }
        public FrmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
            ListOfProducts = new BindingList<ProductClass>();
            showProductList.DataSource = ListOfProducts;
            gridViewProductList.DataSource = showProductList;
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public class NumberFormatException : Exception
        {
            public NumberFormatException(string message) : base(message) { }
        }

        public class StringFormatException : Exception
        {
            public StringFormatException(string message) : base(message) { }
        }

        public class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string message) : base(message) { }
        }

        public string Product_Name(string name)
        {
            try
            {
                if (!Regex.IsMatch(name, @"^[a-zA-z]+$"))
                {
                    throw new StringFormatException("Product name must contain only letters."); 
                }
            return name;
        }
        catch (StringFormatException ex)   
            {
             MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
             throw;
            }
}


        public int Quantity(string qty)
        {
            try
            {
                if (!Regex.IsMatch(qty, @"^[0-9]"))
                {
                    throw new NumberFormatException("Quantity must be a valid positive integer.");
                }
                return Convert.ToInt32(qty);
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public double SellingPrice(string price)
        {
            try
            {
                if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                {
                    throw new CurrencyFormatException("Selling price must be a valid number.");
                }
                return Convert.ToDouble(price);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public string ExpirationDate(DateTime expDate)
        {
            try
            {
                if (expDate < DateTime.Now)
                {
                    throw new NumberFormatException("Expiration date cannot be earlier than the current date.");
                }
                return expDate.ToString("yyyy-MM-dd");
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Expiration Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
      
                if (txtProductName == null)
                    throw new NullReferenceException("Product Name text box is not initialized.");
                if (cbCategory == null)
                    throw new NullReferenceException("Category combo box is not initialized.");
                if (dtPickerMfgDate == null)
                    throw new NullReferenceException("Manufacturing Date picker is not initialized.");
                if (dtPickerExpDate == null)
                    throw new NullReferenceException("Expiration Date picker is not initialized.");
                if (txtQuantity == null)
                    throw new NullReferenceException("Quantity text box is not initialized.");
                if (txtSellPrice == null)
                    throw new NullReferenceException("Selling Price text box is not initialized.");
                if (showProductList == null)
                    throw new NullReferenceException("Product list is not initialized.");

      
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = ExpirationDate(dtPickerExpDate.Value);
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);


                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));

               
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (StringFormatException ex)
            {
        
                MessageBox.Show($"Error: {ex.Message}", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    class ProductClass
    {
        private int _Quantity;
        private double _SellPrice;
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;

        public ProductClass(string ProductName, string Category, string MfgDate, string ExpDate, double Price, int Quantity, string Description)
        {
            this._Quantity = Quantity;
            this._SellPrice = Price;
            this._ProductName = ProductName;
            this._Category = Category;
            this._MfgDate = MfgDate;
            this._ExpDate = ExpDate;
            this._Description = Description;
        }
        public string ProductName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this._ProductName = value;
            }
        }
        public string Category
        {
            get

            { return this._Category; }
            set { this._Category = value; }
        }
        public string ManufacturingDate
        {
            get
            {
                return this._MfgDate;
            }

            set
            {
                this._MfgDate = value;
            }
        }

        public string ExpirationDate
        {
            get
            {
                return this._ExpDate;
            }

            set
            {
                this._ExpDate = value;
            }
        }
        public string Description
        {
            get
            {
                return this._Description;
            }

            set
            {
                this._Description = value;
            }
        }
        public int Quantity
        {
            get
            {
                return this._Quantity;
            }

            set
            {
                this._Quantity = value;
            }
        }
        public double SellingPrice
        {
            get
            {
                return this._SellPrice;
            }
            set
            {
                this._SellPrice = value;
            }
        }

    }
}
    



