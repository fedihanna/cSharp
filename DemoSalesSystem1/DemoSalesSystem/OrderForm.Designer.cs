namespace DemoSalesSystem
{
    partial class OrderForm
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
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.oformCompanyLlabel = new System.Windows.Forms.Label();
            this.orderStatLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderStatusTextBox = new System.Windows.Forms.TextBox();
            this.OrdersListBox = new System.Windows.Forms.ListBox();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.oformProductsListBox = new System.Windows.Forms.ListBox();
            this.oformProductsLabel = new System.Windows.Forms.Label();
            this.oformAddButton = new System.Windows.Forms.Button();
            this.oformDeleteButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.UpdateOrderButton = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.orderProductComboBox = new System.Windows.Forms.ComboBox();
            this.ordFormCompComboBox = new System.Windows.Forms.ComboBox();
            this.orFormContactComboBox = new System.Windows.Forms.ComboBox();
            this.ordFormDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.orderDateLabel.Location = new System.Drawing.Point(271, 45);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(73, 13);
            this.orderDateLabel.TabIndex = 0;
            this.orderDateLabel.Text = "Order Date:";
            // 
            // oformCompanyLlabel
            // 
            this.oformCompanyLlabel.AutoSize = true;
            this.oformCompanyLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oformCompanyLlabel.ForeColor = System.Drawing.Color.Maroon;
            this.oformCompanyLlabel.Location = new System.Drawing.Point(271, 98);
            this.oformCompanyLlabel.Name = "oformCompanyLlabel";
            this.oformCompanyLlabel.Size = new System.Drawing.Size(62, 13);
            this.oformCompanyLlabel.TabIndex = 1;
            this.oformCompanyLlabel.Text = "Company:";
            // 
            // orderStatLabel
            // 
            this.orderStatLabel.AutoSize = true;
            this.orderStatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatLabel.ForeColor = System.Drawing.Color.Maroon;
            this.orderStatLabel.Location = new System.Drawing.Point(271, 155);
            this.orderStatLabel.Name = "orderStatLabel";
            this.orderStatLabel.Size = new System.Drawing.Size(82, 13);
            this.orderStatLabel.TabIndex = 2;
            this.orderStatLabel.Text = "Order Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(271, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Company Contact:";
            // 
            // orderStatusTextBox
            // 
            this.orderStatusTextBox.Location = new System.Drawing.Point(387, 152);
            this.orderStatusTextBox.Name = "orderStatusTextBox";
            this.orderStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderStatusTextBox.TabIndex = 6;
            // 
            // OrdersListBox
            // 
            this.OrdersListBox.FormattingEnabled = true;
            this.OrdersListBox.Location = new System.Drawing.Point(43, 57);
            this.OrdersListBox.Name = "OrdersListBox";
            this.OrdersListBox.Size = new System.Drawing.Size(156, 95);
            this.OrdersListBox.TabIndex = 8;
            this.OrdersListBox.SelectedIndexChanged += new System.EventHandler(this.OrdersListBox_SelectedIndexChanged);
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersLabel.ForeColor = System.Drawing.Color.Maroon;
            this.OrdersLabel.Location = new System.Drawing.Point(43, 38);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(44, 13);
            this.OrdersLabel.TabIndex = 9;
            this.OrdersLabel.Text = "Orders";
            // 
            // oformProductsListBox
            // 
            this.oformProductsListBox.FormattingEnabled = true;
            this.oformProductsListBox.Location = new System.Drawing.Point(43, 193);
            this.oformProductsListBox.Name = "oformProductsListBox";
            this.oformProductsListBox.Size = new System.Drawing.Size(156, 95);
            this.oformProductsListBox.TabIndex = 10;
            // 
            // oformProductsLabel
            // 
            this.oformProductsLabel.AutoSize = true;
            this.oformProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oformProductsLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.oformProductsLabel.Location = new System.Drawing.Point(40, 177);
            this.oformProductsLabel.Name = "oformProductsLabel";
            this.oformProductsLabel.Size = new System.Drawing.Size(57, 13);
            this.oformProductsLabel.TabIndex = 11;
            this.oformProductsLabel.Text = "Products";
            // 
            // oformAddButton
            // 
            this.oformAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oformAddButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.oformAddButton.Location = new System.Drawing.Point(43, 347);
            this.oformAddButton.Name = "oformAddButton";
            this.oformAddButton.Size = new System.Drawing.Size(75, 23);
            this.oformAddButton.TabIndex = 12;
            this.oformAddButton.Text = "Add";
            this.oformAddButton.UseVisualStyleBackColor = true;
            this.oformAddButton.Click += new System.EventHandler(this.oformAddButton_Click);
            // 
            // oformDeleteButton
            // 
            this.oformDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oformDeleteButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.oformDeleteButton.Location = new System.Drawing.Point(124, 347);
            this.oformDeleteButton.Name = "oformDeleteButton";
            this.oformDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.oformDeleteButton.TabIndex = 13;
            this.oformDeleteButton.Text = "Delete";
            this.oformDeleteButton.UseVisualStyleBackColor = true;
            this.oformDeleteButton.Click += new System.EventHandler(this.oformDeleteButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderButton.ForeColor = System.Drawing.Color.Maroon;
            this.AddOrderButton.Location = new System.Drawing.Point(274, 256);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(75, 23);
            this.AddOrderButton.TabIndex = 14;
            this.AddOrderButton.Text = "Add Order";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // UpdateOrderButton
            // 
            this.UpdateOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateOrderButton.ForeColor = System.Drawing.Color.Maroon;
            this.UpdateOrderButton.Location = new System.Drawing.Point(355, 256);
            this.UpdateOrderButton.Name = "UpdateOrderButton";
            this.UpdateOrderButton.Size = new System.Drawing.Size(107, 23);
            this.UpdateOrderButton.TabIndex = 15;
            this.UpdateOrderButton.Text = "Update Order";
            this.UpdateOrderButton.UseVisualStyleBackColor = true;
            this.UpdateOrderButton.Click += new System.EventHandler(this.UpdateOrderButton_Click);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrderButton.ForeColor = System.Drawing.Color.Maroon;
            this.DeleteOrderButton.Location = new System.Drawing.Point(468, 256);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrderButton.TabIndex = 16;
            this.DeleteOrderButton.Text = "Delete Order";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // orderProductComboBox
            // 
            this.orderProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderProductComboBox.FormattingEnabled = true;
            this.orderProductComboBox.Location = new System.Drawing.Point(43, 304);
            this.orderProductComboBox.Name = "orderProductComboBox";
            this.orderProductComboBox.Size = new System.Drawing.Size(153, 21);
            this.orderProductComboBox.TabIndex = 17;
            // 
            // ordFormCompComboBox
            // 
            this.ordFormCompComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ordFormCompComboBox.FormattingEnabled = true;
            this.ordFormCompComboBox.Location = new System.Drawing.Point(387, 98);
            this.ordFormCompComboBox.Name = "ordFormCompComboBox";
            this.ordFormCompComboBox.Size = new System.Drawing.Size(121, 21);
            this.ordFormCompComboBox.TabIndex = 18;
            this.ordFormCompComboBox.SelectedIndexChanged += new System.EventHandler(this.ordFormCompComboBox_SelectedIndexChanged);
            // 
            // orFormContactComboBox
            // 
            this.orFormContactComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orFormContactComboBox.FormattingEnabled = true;
            this.orFormContactComboBox.Location = new System.Drawing.Point(403, 206);
            this.orFormContactComboBox.Name = "orFormContactComboBox";
            this.orFormContactComboBox.Size = new System.Drawing.Size(121, 21);
            this.orFormContactComboBox.TabIndex = 19;
            // 
            // ordFormDateTimePicker
            // 
            this.ordFormDateTimePicker.Location = new System.Drawing.Point(387, 45);
            this.ordFormDateTimePicker.Name = "ordFormDateTimePicker";
            this.ordFormDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ordFormDateTimePicker.TabIndex = 20;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 382);
            this.Controls.Add(this.ordFormDateTimePicker);
            this.Controls.Add(this.orFormContactComboBox);
            this.Controls.Add(this.ordFormCompComboBox);
            this.Controls.Add(this.orderProductComboBox);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.UpdateOrderButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.oformDeleteButton);
            this.Controls.Add(this.oformAddButton);
            this.Controls.Add(this.oformProductsLabel);
            this.Controls.Add(this.oformProductsListBox);
            this.Controls.Add(this.OrdersLabel);
            this.Controls.Add(this.OrdersListBox);
            this.Controls.Add(this.orderStatusTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderStatLabel);
            this.Controls.Add(this.oformCompanyLlabel);
            this.Controls.Add(this.orderDateLabel);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label orderDateLabel;
        public System.Windows.Forms.Label oformCompanyLlabel;
        public System.Windows.Forms.Label orderStatLabel;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox orderStatusTextBox;
        public System.Windows.Forms.ListBox OrdersListBox;
        public System.Windows.Forms.Label OrdersLabel;
        public System.Windows.Forms.ListBox oformProductsListBox;
        public System.Windows.Forms.Label oformProductsLabel;
        public System.Windows.Forms.Button oformAddButton;
        public System.Windows.Forms.Button oformDeleteButton;
        public System.Windows.Forms.Button AddOrderButton;
        public System.Windows.Forms.Button UpdateOrderButton;
        public System.Windows.Forms.Button DeleteOrderButton;
        public System.Windows.Forms.ComboBox orderProductComboBox;
        private System.Windows.Forms.ComboBox ordFormCompComboBox;
        private System.Windows.Forms.ComboBox orFormContactComboBox;
        private System.Windows.Forms.DateTimePicker ordFormDateTimePicker;
    }
}