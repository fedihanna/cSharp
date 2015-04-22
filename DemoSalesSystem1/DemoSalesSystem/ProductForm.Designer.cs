namespace DemoSalesSystem
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.productIDLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.ProductIDTextbox = new System.Windows.Forms.TextBox();
            this.ProductNameTextbox = new System.Windows.Forms.TextBox();
            this.pformListBox = new System.Windows.Forms.ListBox();
            this.pformProductsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.ForeColor = System.Drawing.Color.Maroon;
            this.productIDLabel.Location = new System.Drawing.Point(208, 52);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(72, 13);
            this.productIDLabel.TabIndex = 3;
            this.productIDLabel.Text = "Product ID:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.productNameLabel.Location = new System.Drawing.Point(189, 112);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(91, 13);
            this.productNameLabel.TabIndex = 4;
            this.productNameLabel.Text = "Product Name:";
            // 
            // ProductIDTextbox
            // 
            this.ProductIDTextbox.Location = new System.Drawing.Point(286, 49);
            this.ProductIDTextbox.Name = "ProductIDTextbox";
            this.ProductIDTextbox.ReadOnly = true;
            this.ProductIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.ProductIDTextbox.TabIndex = 5;
            // 
            // ProductNameTextbox
            // 
            this.ProductNameTextbox.Location = new System.Drawing.Point(286, 109);
            this.ProductNameTextbox.Name = "ProductNameTextbox";
            this.ProductNameTextbox.ReadOnly = true;
            this.ProductNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.ProductNameTextbox.TabIndex = 6;
            // 
            // pformListBox
            // 
            this.pformListBox.FormattingEnabled = true;
            this.pformListBox.Location = new System.Drawing.Point(34, 63);
            this.pformListBox.Name = "pformListBox";
            this.pformListBox.Size = new System.Drawing.Size(120, 212);
            this.pformListBox.TabIndex = 7;
            this.pformListBox.SelectedIndexChanged += new System.EventHandler(this.pformListBox_SelectedIndexChanged);
            // 
            // pformProductsLabel
            // 
            this.pformProductsLabel.AutoSize = true;
            this.pformProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pformProductsLabel.ForeColor = System.Drawing.Color.Maroon;
            this.pformProductsLabel.Location = new System.Drawing.Point(34, 44);
            this.pformProductsLabel.Name = "pformProductsLabel";
            this.pformProductsLabel.Size = new System.Drawing.Size(57, 13);
            this.pformProductsLabel.TabIndex = 8;
            this.pformProductsLabel.Text = "Products";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 305);
            this.Controls.Add(this.pformProductsLabel);
            this.Controls.Add(this.pformListBox);
            this.Controls.Add(this.ProductNameTextbox);
            this.Controls.Add(this.ProductIDTextbox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productIDLabel);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label productIDLabel;
        public System.Windows.Forms.Label productNameLabel;
        public System.Windows.Forms.TextBox ProductIDTextbox;
        public System.Windows.Forms.TextBox ProductNameTextbox;
        public System.Windows.Forms.ListBox pformListBox;
        public System.Windows.Forms.Label pformProductsLabel;
    }
}