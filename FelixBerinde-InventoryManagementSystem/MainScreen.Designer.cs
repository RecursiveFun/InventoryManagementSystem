
namespace FelixBerinde_InventoryManagementSystem
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Partslabel = new System.Windows.Forms.Label();
            this.Productslabel = new System.Windows.Forms.Label();
            this.partAddBtn = new System.Windows.Forms.Button();
            this.partModifyBtn = new System.Windows.Forms.Button();
            this.partDeleteBtn = new System.Windows.Forms.Button();
            this.productDeleteBtn = new System.Windows.Forms.Button();
            this.productModifyBtn = new System.Windows.Forms.Button();
            this.productAddBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.partSearchBtn = new System.Windows.Forms.Button();
            this.productSearchBtn = new System.Windows.Forms.Button();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(12, 129);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(554, 226);
            this.dgvParts.TabIndex = 1;
            this.dgvParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myPartBindingComplete);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(618, 129);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(554, 226);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myProductBindingComplete);
            // 
            // Partslabel
            // 
            this.Partslabel.AutoSize = true;
            this.Partslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Partslabel.Location = new System.Drawing.Point(8, 106);
            this.Partslabel.Name = "Partslabel";
            this.Partslabel.Size = new System.Drawing.Size(46, 20);
            this.Partslabel.TabIndex = 3;
            this.Partslabel.Text = "Parts";
            // 
            // Productslabel
            // 
            this.Productslabel.AutoSize = true;
            this.Productslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productslabel.Location = new System.Drawing.Point(614, 106);
            this.Productslabel.Name = "Productslabel";
            this.Productslabel.Size = new System.Drawing.Size(72, 20);
            this.Productslabel.TabIndex = 4;
            this.Productslabel.Text = "Products";
            // 
            // partAddBtn
            // 
            this.partAddBtn.Location = new System.Drawing.Point(168, 361);
            this.partAddBtn.Name = "partAddBtn";
            this.partAddBtn.Size = new System.Drawing.Size(75, 23);
            this.partAddBtn.TabIndex = 5;
            this.partAddBtn.Text = "Add";
            this.partAddBtn.UseVisualStyleBackColor = true;
            this.partAddBtn.Click += new System.EventHandler(this.partAddBtn_Click);
            // 
            // partModifyBtn
            // 
            this.partModifyBtn.Location = new System.Drawing.Point(249, 361);
            this.partModifyBtn.Name = "partModifyBtn";
            this.partModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.partModifyBtn.TabIndex = 6;
            this.partModifyBtn.Text = "Modify";
            this.partModifyBtn.UseVisualStyleBackColor = true;
            this.partModifyBtn.Click += new System.EventHandler(this.partModifyBtn_Click);
            // 
            // partDeleteBtn
            // 
            this.partDeleteBtn.Location = new System.Drawing.Point(330, 361);
            this.partDeleteBtn.Name = "partDeleteBtn";
            this.partDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.partDeleteBtn.TabIndex = 7;
            this.partDeleteBtn.Text = "Delete";
            this.partDeleteBtn.UseVisualStyleBackColor = true;
            this.partDeleteBtn.Click += new System.EventHandler(this.partDeleteBtn_Click);
            // 
            // productDeleteBtn
            // 
            this.productDeleteBtn.Location = new System.Drawing.Point(941, 361);
            this.productDeleteBtn.Name = "productDeleteBtn";
            this.productDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.productDeleteBtn.TabIndex = 10;
            this.productDeleteBtn.Text = "Delete";
            this.productDeleteBtn.UseVisualStyleBackColor = true;
            this.productDeleteBtn.Click += new System.EventHandler(this.productDeleteBtn_Click);
            // 
            // productModifyBtn
            // 
            this.productModifyBtn.Location = new System.Drawing.Point(860, 361);
            this.productModifyBtn.Name = "productModifyBtn";
            this.productModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.productModifyBtn.TabIndex = 9;
            this.productModifyBtn.Text = "Modify";
            this.productModifyBtn.UseVisualStyleBackColor = true;
            this.productModifyBtn.Click += new System.EventHandler(this.productModifyBtn_Click);
            // 
            // productAddBtn
            // 
            this.productAddBtn.Location = new System.Drawing.Point(779, 361);
            this.productAddBtn.Name = "productAddBtn";
            this.productAddBtn.Size = new System.Drawing.Size(75, 23);
            this.productAddBtn.TabIndex = 8;
            this.productAddBtn.Text = "Add";
            this.productAddBtn.UseVisualStyleBackColor = true;
            this.productAddBtn.Click += new System.EventHandler(this.productAddBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1065, 506);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(107, 43);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // partSearchBtn
            // 
            this.partSearchBtn.Location = new System.Drawing.Point(249, 92);
            this.partSearchBtn.Name = "partSearchBtn";
            this.partSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.partSearchBtn.TabIndex = 12;
            this.partSearchBtn.Text = "Search";
            this.partSearchBtn.UseVisualStyleBackColor = true;
            this.partSearchBtn.Click += new System.EventHandler(this.partSearchBtn_Click);
            // 
            // productSearchBtn
            // 
            this.productSearchBtn.Location = new System.Drawing.Point(860, 91);
            this.productSearchBtn.Name = "productSearchBtn";
            this.productSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.productSearchBtn.TabIndex = 13;
            this.productSearchBtn.Text = "Search";
            this.productSearchBtn.UseVisualStyleBackColor = true;
            this.productSearchBtn.Click += new System.EventHandler(this.productSearchBtn_Click);
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(346, 94);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(220, 20);
            this.partSearchBox.TabIndex = 14;
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(952, 92);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(220, 20);
            this.productSearchBox.TabIndex = 15;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.productSearchBtn);
            this.Controls.Add(this.partSearchBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.productDeleteBtn);
            this.Controls.Add(this.productModifyBtn);
            this.Controls.Add(this.productAddBtn);
            this.Controls.Add(this.partDeleteBtn);
            this.Controls.Add(this.partModifyBtn);
            this.Controls.Add(this.partAddBtn);
            this.Controls.Add(this.Productslabel);
            this.Controls.Add(this.Partslabel);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label Partslabel;
        private System.Windows.Forms.Label Productslabel;
        private System.Windows.Forms.Button partAddBtn;
        private System.Windows.Forms.Button partModifyBtn;
        private System.Windows.Forms.Button partDeleteBtn;
        private System.Windows.Forms.Button productDeleteBtn;
        private System.Windows.Forms.Button productModifyBtn;
        private System.Windows.Forms.Button productAddBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button partSearchBtn;
        private System.Windows.Forms.Button productSearchBtn;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.TextBox productSearchBox;
    }
}

