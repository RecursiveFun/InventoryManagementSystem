using FelixBerinde_InventoryManagementSystem.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelixBerinde_InventoryManagementSystem
{
    public partial class AddProduct : Form
    {
        private void save()
        {
            if (nameBox.Text == "" || inventoryBox.Text.ToString() == "" || priceCostBox.Text.ToString() == "" || maxBox.Text.ToString() == "" || minBox.Text.ToString() == "")
            {
                saveBtn.Enabled = false;
            }
            else
            {
                saveBtn.Enabled = true;
            }
        }

        private Product myProduct = new Product();

        public AddProduct()
        {
            InitializeComponent();
            save();

            dgvAssociatedParts.DataSource = myProduct.AssociatedParts;
            dgvParts.DataSource = Inventory.AllParts;

            //see a full row selection
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //make grids read only
            dgvParts.ReadOnly = true;
            dgvAssociatedParts.ReadOnly = true;

            //make grids ony able to select one row
            dgvParts.MultiSelect = false;
            dgvAssociatedParts.MultiSelect = false;
            //remove botttom
            dgvParts.AllowUserToAddRows = false;
            dgvAssociatedParts.AllowUserToAddRows = false;

            //remove row header
            dgvParts.RowHeadersVisible = false;
            dgvAssociatedParts.RowHeadersVisible = false;

            //autosize all columns according to their content
            dgvParts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvAssociatedParts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //make column 1 fill the empty space
            dgvParts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAssociatedParts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //remove column 1 autosizing to prevent 'jumping' behaviour
            dgvParts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvAssociatedParts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            //let the last column fill the empty space when the grid or any column is resized (more natural/expected behaviour) 
            dgvParts.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAssociatedParts.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.ShowDialog();
            this.Close();
        }

        private void myBindingListComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clear selection
            dgvParts.ClearSelection();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (int.Parse(minBox.Text) > int.Parse(maxBox.Text))
            {
                MessageBox.Show("Minimum must be less than maximum.");
                return;
            }

            if (int.Parse(inventoryBox.Text) > int.Parse(maxBox.Text) || int.Parse(inventoryBox.Text) < int.Parse(minBox.Text))
            {
                MessageBox.Show("Inventory must be between minimum and maximum.");
                return;
            }

            //Random rnd = new Random();
            int num = Inventory.Products.Count + 1;

            var name = nameBox.Text;

            var inventory = int.Parse(inventoryBox.Text);

            var price = decimal.Parse(priceCostBox.Text);

            var max = int.Parse(maxBox.Text);

            var min = int.Parse(minBox.Text);


            var tempProduct = new Product()
            {
                ProductID = num,
                Name = name,
                InStock = inventory,
                Max = max, 
                Min = min, 
                Price = price
            };


            foreach (DataGridViewRow row in dgvAssociatedParts.Rows)
            {
                Part tempPart = (Part)row.DataBoundItem;
                tempProduct.AssociatedParts.Add(tempPart);
                ++(num);
            }


            Inventory.Products.Add(tempProduct);

            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.ShowDialog();
            this.Close();
            
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {

            if (!dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a row.");
                return;

            }
            else
            {
                Part tempPart = (Part)dgvParts.CurrentRow.DataBoundItem;
                myProduct.addAssociatedPart(tempPart);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //check for no selection
            if (dgvAssociatedParts.CurrentRow == null || !dgvAssociatedParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection.");
                return;
            }
            //get the selected row
            Part P = (Part)dgvAssociatedParts.CurrentRow.DataBoundItem;

            //Confirm the delete with a MessageBox
            if (DialogResult.Yes == MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning))
            {
                //remove the selected part from the list
                myProduct.AssociatedParts.Remove(P);
            }
        }

        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (productSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(productSearchBox.Text.ToUpper()) || (Inventory.AllParts[i].PartID.ToString() == productSearchBox.Text))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                    dgvParts.DataSource = TempList;
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
                dgvParts.DataSource = Inventory.AllParts;
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                nameBox.BackColor = System.Drawing.Color.Salmon;
                ToolTip isAString = new ToolTip();
                isAString.ShowAlways = true;
                isAString.SetToolTip(nameBox, "Please enter a Product name.");
                save();
            }
            else
            {
                nameBox.BackColor = System.Drawing.Color.White;
                save();
            }
        }

        private void inventoryBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryBox.Text) || int.TryParse(inventoryBox.Text, out _) == false)
            {
                inventoryBox.BackColor = System.Drawing.Color.Salmon;
                ToolTip isANumber = new ToolTip();
                isANumber.ShowAlways = true;
                isANumber.SetToolTip(inventoryBox, "Please enter a number.");
                save();
            }
            else
            {
                inventoryBox.BackColor = System.Drawing.Color.White;
                save();
            }
        }

        private void priceCostBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceCostBox.Text) || decimal.TryParse(priceCostBox.Text, out _) == false)
            {
                priceCostBox.BackColor = System.Drawing.Color.Salmon;
                ToolTip isANumber = new ToolTip();
                isANumber.ShowAlways = true;
                isANumber.SetToolTip(priceCostBox, "Please enter a number.");
                save();
            }
            else
            {
                priceCostBox.BackColor = System.Drawing.Color.White;
                save();
            }
        }

        private void maxBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maxBox.Text) || int.TryParse(maxBox.Text, out _) == false)
            {
                maxBox.BackColor = System.Drawing.Color.Salmon;
                ToolTip isANumber = new ToolTip();
                isANumber.ShowAlways = true;
                isANumber.SetToolTip(maxBox, "Please enter a number.");
                save();
            }
            else
            {
                maxBox.BackColor = System.Drawing.Color.White;
                save();
            }
        }

        private void minBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minBox.Text) || int.TryParse(minBox.Text, out _) == false)
            {
                minBox.BackColor = System.Drawing.Color.Salmon;
                ToolTip isANumber = new ToolTip();
                isANumber.ShowAlways = true;
                isANumber.SetToolTip(minBox, "Please enter a number.");
                save();
            }
            else
            {
                minBox.BackColor = System.Drawing.Color.White;
                save();
            }
        }
    }
}
