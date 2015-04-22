namespace DemoSalesSystem
{
    partial class CatalogForm
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
            this.catformProductsLabel = new System.Windows.Forms.Label();
            this.catformCatalogsListBox = new System.Windows.Forms.ListBox();
            this.catformIDlabel = new System.Windows.Forms.Label();
            this.catFormIDtextBox = new System.Windows.Forms.TextBox();
            this.catFormAddButton = new System.Windows.Forms.Button();
            this.catFormUpdateButton = new System.Windows.Forms.Button();
            this.catFormDeleteButton = new System.Windows.Forms.Button();
            this.catFormSDateLabel = new System.Windows.Forms.Label();
            this.catFormNameTextBox = new System.Windows.Forms.TextBox();
            this.catFormNameLabel = new System.Windows.Forms.Label();
            this.catFormDescripTextBox = new System.Windows.Forms.TextBox();
            this.catFormDescrpLabel = new System.Windows.Forms.Label();
            this.catFormNoteTextBox = new System.Windows.Forms.TextBox();
            this.catFormNoteLabel = new System.Windows.Forms.Label();
            this.catFormEDateLabel = new System.Windows.Forms.Label();
            this.catFormdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.catFormEnddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.catProductListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.catProductsComboBox = new System.Windows.Forms.ComboBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catformProductsLabel
            // 
            this.catformProductsLabel.AutoSize = true;
            this.catformProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catformProductsLabel.ForeColor = System.Drawing.Color.Maroon;
            this.catformProductsLabel.Location = new System.Drawing.Point(34, 14);
            this.catformProductsLabel.Name = "catformProductsLabel";
            this.catformProductsLabel.Size = new System.Drawing.Size(56, 13);
            this.catformProductsLabel.TabIndex = 0;
            this.catformProductsLabel.Text = "Catalogs";
            // 
            // catformCatalogsListBox
            // 
            this.catformCatalogsListBox.FormattingEnabled = true;
            this.catformCatalogsListBox.Location = new System.Drawing.Point(37, 30);
            this.catformCatalogsListBox.Name = "catformCatalogsListBox";
            this.catformCatalogsListBox.Size = new System.Drawing.Size(120, 82);
            this.catformCatalogsListBox.TabIndex = 1;
            this.catformCatalogsListBox.SelectedIndexChanged += new System.EventHandler(this.catformCatalogsListBox_SelectedIndexChanged);
            // 
            // catformIDlabel
            // 
            this.catformIDlabel.AutoSize = true;
            this.catformIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catformIDlabel.ForeColor = System.Drawing.Color.Maroon;
            this.catformIDlabel.Location = new System.Drawing.Point(216, 47);
            this.catformIDlabel.Name = "catformIDlabel";
            this.catformIDlabel.Size = new System.Drawing.Size(24, 13);
            this.catformIDlabel.TabIndex = 2;
            this.catformIDlabel.Text = "ID:";
            // 
            // catFormIDtextBox
            // 
            this.catFormIDtextBox.Location = new System.Drawing.Point(297, 44);
            this.catFormIDtextBox.Name = "catFormIDtextBox";
            this.catFormIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.catFormIDtextBox.TabIndex = 8;
            // 
            // catFormAddButton
            // 
            this.catFormAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catFormAddButton.ForeColor = System.Drawing.Color.Maroon;
            this.catFormAddButton.Location = new System.Drawing.Point(207, 257);
            this.catFormAddButton.Name = "catFormAddButton";
            this.catFormAddButton.Size = new System.Drawing.Size(75, 23);
            this.catFormAddButton.TabIndex = 14;
            this.catFormAddButton.Text = "Add";
            this.catFormAddButton.UseVisualStyleBackColor = true;
            this.catFormAddButton.Click += new System.EventHandler(this.catFormAddButton_Click);
            // 
            // catFormUpdateButton
            // 
            this.catFormUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catFormUpdateButton.ForeColor = System.Drawing.Color.Maroon;
            this.catFormUpdateButton.Location = new System.Drawing.Point(297, 257);
            this.catFormUpdateButton.Name = "catFormUpdateButton";
            this.catFormUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.catFormUpdateButton.TabIndex = 15;
            this.catFormUpdateButton.Text = "Update";
            this.catFormUpdateButton.UseVisualStyleBackColor = true;
            this.catFormUpdateButton.Click += new System.EventHandler(this.catFormUpdateButton_Click);
            // 
            // catFormDeleteButton
            // 
            this.catFormDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catFormDeleteButton.ForeColor = System.Drawing.Color.Maroon;
            this.catFormDeleteButton.Location = new System.Drawing.Point(396, 257);
            this.catFormDeleteButton.Name = "catFormDeleteButton";
            this.catFormDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.catFormDeleteButton.TabIndex = 16;
            this.catFormDeleteButton.Text = "Delete";
            this.catFormDeleteButton.UseVisualStyleBackColor = true;
            this.catFormDeleteButton.Click += new System.EventHandler(this.catFormDeleteButton_Click);
            // 
            // catFormSDateLabel
            // 
            this.catFormSDateLabel.AutoSize = true;
            this.catFormSDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catFormSDateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.catFormSDateLabel.Location = new System.Drawing.Point(216, 99);
            this.catFormSDateLabel.Name = "catFormSDateLabel";
            this.catFormSDateLabel.Size = new System.Drawing.Size(69, 13);
            this.catFormSDateLabel.TabIndex = 17;
            this.catFormSDateLabel.Text = "Start Date:";
            // 
            // catFormNameTextBox
            // 
            this.catFormNameTextBox.Location = new System.Drawing.Point(297, 70);
            this.catFormNameTextBox.Name = "catFormNameTextBox";
            this.catFormNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.catFormNameTextBox.TabIndex = 20;
            // 
            // catFormNameLabel
            // 
            this.catFormNameLabel.AutoSize = true;
            this.catFormNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catFormNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.catFormNameLabel.Location = new System.Drawing.Point(216, 73);
            this.catFormNameLabel.Name = "catFormNameLabel";
            this.catFormNameLabel.Size = new System.Drawing.Size(43, 13);
            this.catFormNameLabel.TabIndex = 19;
            this.catFormNameLabel.Text = "Name:";
            // 
            // catFormDescripTextBox
            // 
            this.catFormDescripTextBox.Location = new System.Drawing.Point(297, 148);
            this.catFormDescripTextBox.Name = "catFormDescripTextBox";
            this.catFormDescripTextBox.Size = new System.Drawing.Size(100, 20);
            this.catFormDescripTextBox.TabIndex = 26;
            // 
            // catFormDescrpLabel
            // 
            this.catFormDescrpLabel.AutoSize = true;
            this.catFormDescrpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catFormDescrpLabel.ForeColor = System.Drawing.Color.Maroon;
            this.catFormDescrpLabel.Location = new System.Drawing.Point(216, 151);
            this.catFormDescrpLabel.Name = "catFormDescrpLabel";
            this.catFormDescrpLabel.Size = new System.Drawing.Size(75, 13);
            this.catFormDescrpLabel.TabIndex = 25;
            this.catFormDescrpLabel.Text = "Description:";
            // 
            // catFormNoteTextBox
            // 
            this.catFormNoteTextBox.Location = new System.Drawing.Point(297, 174);
            this.catFormNoteTextBox.Name = "catFormNoteTextBox";
            this.catFormNoteTextBox.Size = new System.Drawing.Size(100, 20);
            this.catFormNoteTextBox.TabIndex = 24;
            // 
            // catFormNoteLabel
            // 
            this.catFormNoteLabel.AutoSize = true;
            this.catFormNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catFormNoteLabel.ForeColor = System.Drawing.Color.Maroon;
            this.catFormNoteLabel.Location = new System.Drawing.Point(216, 177);
            this.catFormNoteLabel.Name = "catFormNoteLabel";
            this.catFormNoteLabel.Size = new System.Drawing.Size(38, 13);
            this.catFormNoteLabel.TabIndex = 23;
            this.catFormNoteLabel.Text = "Note:";
            // 
            // catFormEDateLabel
            // 
            this.catFormEDateLabel.AutoSize = true;
            this.catFormEDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catFormEDateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.catFormEDateLabel.Location = new System.Drawing.Point(216, 125);
            this.catFormEDateLabel.Name = "catFormEDateLabel";
            this.catFormEDateLabel.Size = new System.Drawing.Size(64, 13);
            this.catFormEDateLabel.TabIndex = 21;
            this.catFormEDateLabel.Text = "End Date:";
            // 
            // catFormdateTimePicker
            // 
            this.catFormdateTimePicker.Location = new System.Drawing.Point(297, 99);
            this.catFormdateTimePicker.Name = "catFormdateTimePicker";
            this.catFormdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.catFormdateTimePicker.TabIndex = 27;
            // 
            // catFormEnddateTimePicker
            // 
            this.catFormEnddateTimePicker.Location = new System.Drawing.Point(297, 122);
            this.catFormEnddateTimePicker.Name = "catFormEnddateTimePicker";
            this.catFormEnddateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.catFormEnddateTimePicker.TabIndex = 28;
            // 
            // catProductListBox
            // 
            this.catProductListBox.FormattingEnabled = true;
            this.catProductListBox.Location = new System.Drawing.Point(37, 135);
            this.catProductListBox.Name = "catProductListBox";
            this.catProductListBox.Size = new System.Drawing.Size(120, 82);
            this.catProductListBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(34, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Catalog Products";
            // 
            // catProductsComboBox
            // 
            this.catProductsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catProductsComboBox.FormattingEnabled = true;
            this.catProductsComboBox.Location = new System.Drawing.Point(36, 243);
            this.catProductsComboBox.Name = "catProductsComboBox";
            this.catProductsComboBox.Size = new System.Drawing.Size(121, 21);
            this.catProductsComboBox.TabIndex = 31;
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.ForeColor = System.Drawing.Color.Maroon;
            this.addProductButton.Location = new System.Drawing.Point(37, 284);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(111, 23);
            this.addProductButton.TabIndex = 32;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 332);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.catProductsComboBox);
            this.Controls.Add(this.catProductListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catFormEnddateTimePicker);
            this.Controls.Add(this.catFormdateTimePicker);
            this.Controls.Add(this.catFormDescripTextBox);
            this.Controls.Add(this.catFormDescrpLabel);
            this.Controls.Add(this.catFormNoteTextBox);
            this.Controls.Add(this.catFormNoteLabel);
            this.Controls.Add(this.catFormEDateLabel);
            this.Controls.Add(this.catFormNameTextBox);
            this.Controls.Add(this.catFormNameLabel);
            this.Controls.Add(this.catFormSDateLabel);
            this.Controls.Add(this.catFormDeleteButton);
            this.Controls.Add(this.catFormUpdateButton);
            this.Controls.Add(this.catFormAddButton);
            this.Controls.Add(this.catFormIDtextBox);
            this.Controls.Add(this.catformIDlabel);
            this.Controls.Add(this.catformCatalogsListBox);
            this.Controls.Add(this.catformProductsLabel);
            this.Name = "CatalogForm";
            this.Text = "CatalogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label catformProductsLabel;
        private System.Windows.Forms.ListBox catformCatalogsListBox;
        private System.Windows.Forms.Label catformIDlabel;
        private System.Windows.Forms.TextBox catFormIDtextBox;
        private System.Windows.Forms.Button catFormAddButton;
        private System.Windows.Forms.Button catFormUpdateButton;
        private System.Windows.Forms.Button catFormDeleteButton;
        private System.Windows.Forms.Label catFormSDateLabel;
        private System.Windows.Forms.TextBox catFormNameTextBox;
        private System.Windows.Forms.Label catFormNameLabel;
        private System.Windows.Forms.TextBox catFormDescripTextBox;
        private System.Windows.Forms.Label catFormDescrpLabel;
        private System.Windows.Forms.TextBox catFormNoteTextBox;
        private System.Windows.Forms.Label catFormNoteLabel;
        private System.Windows.Forms.Label catFormEDateLabel;
        private System.Windows.Forms.DateTimePicker catFormdateTimePicker;
        private System.Windows.Forms.DateTimePicker catFormEnddateTimePicker;
        private System.Windows.Forms.ListBox catProductListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox catProductsComboBox;
        private System.Windows.Forms.Button addProductButton;
    }
}