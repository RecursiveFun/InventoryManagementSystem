
namespace FelixBerinde_InventoryManagementSystem
{
    partial class ModProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.minBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.priceCostBox = new System.Windows.Forms.TextBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceCostLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.canididatePartLabel = new System.Windows.Forms.Label();
            this.associatedPartLabel = new System.Windows.Forms.Label();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.productSearchBtn = new System.Windows.Forms.Button();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.addProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.SuspendLayout();
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(324, 408);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(99, 20);
            this.minBox.TabIndex = 50;
            this.minBox.TextChanged += new System.EventHandler(this.minBox_TextChanged);
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(125, 408);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(99, 20);
            this.maxBox.TabIndex = 49;
            this.maxBox.TextChanged += new System.EventHandler(this.maxBox_TextChanged);
            // 
            // priceCostBox
            // 
            this.priceCostBox.Location = new System.Drawing.Point(125, 368);
            this.priceCostBox.Name = "priceCostBox";
            this.priceCostBox.Size = new System.Drawing.Size(99, 20);
            this.priceCostBox.TabIndex = 48;
            this.priceCostBox.TextChanged += new System.EventHandler(this.priceCostBox_TextChanged);
            // 
            // inventoryBox
            // 
            this.inventoryBox.Location = new System.Drawing.Point(125, 325);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(99, 20);
            this.inventoryBox.TabIndex = 47;
            this.inventoryBox.TextChanged += new System.EventHandler(this.inventoryBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(125, 290);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(99, 20);
            this.nameBox.TabIndex = 46;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(125, 254);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(99, 20);
            this.IDBox.TabIndex = 45;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(267, 411);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 44;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(53, 411);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 43;
            this.maxLabel.Text = "Max";
            // 
            // priceCostLabel
            // 
            this.priceCostLabel.AutoSize = true;
            this.priceCostLabel.Location = new System.Drawing.Point(17, 375);
            this.priceCostLabel.Name = "priceCostLabel";
            this.priceCostLabel.Size = new System.Drawing.Size(63, 13);
            this.priceCostLabel.TabIndex = 42;
            this.priceCostLabel.Text = "Price / Cost";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(29, 332);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 41;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(45, 290);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 40;
            this.nameLabel.Text = "Name";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(62, 257);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 39;
            this.IDLabel.Text = "ID";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(822, 692);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 32);
            this.saveBtn.TabIndex = 38;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(915, 692);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 32);
            this.cancelBtn.TabIndex = 37;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(915, 636);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 32);
            this.deleteBtn.TabIndex = 36;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(915, 313);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(75, 32);
            this.addProductBtn.TabIndex = 35;
            this.addProductBtn.Text = "Add";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // canididatePartLabel
            // 
            this.canididatePartLabel.AutoSize = true;
            this.canididatePartLabel.Location = new System.Drawing.Point(456, 41);
            this.canididatePartLabel.Name = "canididatePartLabel";
            this.canididatePartLabel.Size = new System.Drawing.Size(95, 13);
            this.canididatePartLabel.TabIndex = 34;
            this.canididatePartLabel.Text = "All candidate Parts";
            // 
            // associatedPartLabel
            // 
            this.associatedPartLabel.AutoSize = true;
            this.associatedPartLabel.Location = new System.Drawing.Point(456, 367);
            this.associatedPartLabel.Name = "associatedPartLabel";
            this.associatedPartLabel.Size = new System.Drawing.Size(167, 13);
            this.associatedPartLabel.TabIndex = 33;
            this.associatedPartLabel.Text = "Parts Associated with this Product";
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(788, 33);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(225, 20);
            this.productSearchBox.TabIndex = 32;
            // 
            // productSearchBtn
            // 
            this.productSearchBtn.Location = new System.Drawing.Point(707, 31);
            this.productSearchBtn.Name = "productSearchBtn";
            this.productSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.productSearchBtn.TabIndex = 31;
            this.productSearchBtn.Text = "Search";
            this.productSearchBtn.UseVisualStyleBackColor = true;
            this.productSearchBtn.Click += new System.EventHandler(this.productSearchBtn_Click);
            // 
            // dgvAssociatedParts
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssociatedParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssociatedParts.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(459, 392);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssociatedParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(554, 226);
            this.dgvAssociatedParts.TabIndex = 30;
            this.dgvAssociatedParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myAssociatedPartBindingComplete);
            // 
            // dgvParts
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParts.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvParts.Location = new System.Drawing.Point(459, 69);
            this.dgvParts.Name = "dgvParts";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvParts.Size = new System.Drawing.Size(554, 226);
            this.dgvParts.TabIndex = 29;
            this.dgvParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myPartBindingComplete);
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(12, 9);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(156, 25);
            this.addProductLabel.TabIndex = 28;
            this.addProductLabel.Text = "Modify Product";
            // 
            // ModProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.priceCostBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceCostLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.canididatePartLabel);
            this.Controls.Add(this.associatedPartLabel);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.productSearchBtn);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.addProductLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "ModProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Product";
            this.Load += new System.EventHandler(this.ModProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox priceCostBox;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceCostLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Label canididatePartLabel;
        private System.Windows.Forms.Label associatedPartLabel;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button productSearchBtn;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Label addProductLabel;
    }
}