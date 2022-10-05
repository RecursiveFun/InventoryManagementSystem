
namespace FelixBerinde_InventoryManagementSystem
{
    partial class AddPart
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.inHouse = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.IDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceCostLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.machineIDLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.priceCostBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.machineIDBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(12, 9);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(95, 25);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Add Part";
            // 
            // inHouse
            // 
            this.inHouse.AutoSize = true;
            this.inHouse.Location = new System.Drawing.Point(171, 12);
            this.inHouse.Name = "inHouse";
            this.inHouse.Size = new System.Drawing.Size(68, 17);
            this.inHouse.TabIndex = 1;
            this.inHouse.TabStop = true;
            this.inHouse.Text = "In-House";
            this.inHouse.UseVisualStyleBackColor = true;
            this.inHouse.CheckedChanged += new System.EventHandler(this.inHouse_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(260, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Outsourced";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(60, 102);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(43, 135);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(27, 177);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 5;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceCostLabel
            // 
            this.priceCostLabel.AutoSize = true;
            this.priceCostLabel.Location = new System.Drawing.Point(15, 220);
            this.priceCostLabel.Name = "priceCostLabel";
            this.priceCostLabel.Size = new System.Drawing.Size(63, 13);
            this.priceCostLabel.TabIndex = 6;
            this.priceCostLabel.Text = "Price / Cost";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(51, 256);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 7;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(265, 256);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 8;
            this.minLabel.Text = "Min";
            // 
            // machineIDLabel
            // 
            this.machineIDLabel.AutoSize = true;
            this.machineIDLabel.Location = new System.Drawing.Point(16, 299);
            this.machineIDLabel.Name = "machineIDLabel";
            this.machineIDLabel.Size = new System.Drawing.Size(62, 13);
            this.machineIDLabel.TabIndex = 9;
            this.machineIDLabel.Text = "Machine ID";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(123, 99);
            this.IDBox.Name = "IDBox";
            this.IDBox.ReadOnly = true;
            this.IDBox.Size = new System.Drawing.Size(127, 20);
            this.IDBox.TabIndex = 10;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(123, 135);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(127, 20);
            this.nameBox.TabIndex = 11;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // inventoryBox
            // 
            this.inventoryBox.Location = new System.Drawing.Point(123, 170);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(127, 20);
            this.inventoryBox.TabIndex = 12;
            this.inventoryBox.TextChanged += new System.EventHandler(this.inventoryBox_TextChanged);
            // 
            // priceCostBox
            // 
            this.priceCostBox.Location = new System.Drawing.Point(123, 213);
            this.priceCostBox.Name = "priceCostBox";
            this.priceCostBox.Size = new System.Drawing.Size(127, 20);
            this.priceCostBox.TabIndex = 13;
            this.priceCostBox.TextChanged += new System.EventHandler(this.priceCostBox_TextChanged);
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(123, 253);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(127, 20);
            this.maxBox.TabIndex = 14;
            this.maxBox.TextChanged += new System.EventHandler(this.maxBox_TextChanged);
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(322, 253);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(127, 20);
            this.minBox.TabIndex = 15;
            this.minBox.TextChanged += new System.EventHandler(this.minBox_TextChanged);
            // 
            // machineIDBox
            // 
            this.machineIDBox.Location = new System.Drawing.Point(123, 296);
            this.machineIDBox.Name = "machineIDBox";
            this.machineIDBox.Size = new System.Drawing.Size(127, 20);
            this.machineIDBox.TabIndex = 16;
            this.machineIDBox.TextChanged += new System.EventHandler(this.machineIDBox_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(274, 377);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(66, 46);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(368, 377);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(66, 46);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.machineIDBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.priceCostBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.machineIDLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceCostLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.inHouse);
            this.Controls.Add(this.addPartLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 480);
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "AddPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.RadioButton inHouse;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceCostLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label machineIDLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.TextBox priceCostBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox machineIDBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}