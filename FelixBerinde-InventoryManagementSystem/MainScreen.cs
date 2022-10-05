using FelixBerinde_InventoryManagementSystem.model;
using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace FelixBerinde_InventoryManagementSystem
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            //set the data source
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.Products;

            //see a full row selection
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //make grids read only
            dgvParts.ReadOnly = true;
            dgvProducts.ReadOnly = true;

            //make grids ony able to select one row
            dgvParts.MultiSelect = false;
            dgvProducts.MultiSelect = false;
            //remove bottom
            dgvParts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToAddRows = false;

            //remove row header
            dgvParts.RowHeadersVisible = false;
            dgvProducts.RowHeadersVisible = false;

            // autosize all columns according to their content
            dgvParts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // make column 1 fill the empty space
            dgvParts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // remove column 1 autosizing to prevent 'jumping' behaviour
            dgvParts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // let the last column fill the empty space when the grid or any column is resized (more natural/expected behaviour) 
            dgvParts.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProducts.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        //closes the application on button click
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void partAddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPart Part = new AddPart();
            Part.ShowDialog();
        }

        private void myPartBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clear selection
            dgvParts.ClearSelection();
        }

        private void myProductBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clear selection
            dgvProducts.ClearSelection();
        }


        private void partModifyBtn_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow == null || !dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection.");
                return;
            }

            Part modPart = (Part)dgvParts.CurrentRow.DataBoundItem;
            this.Hide();
            ModPart Part = new ModPart(modPart);
            Part.ShowDialog();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //Add fake data
            Inventory.fakeData();
        }

        private void productAddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct Product = new AddProduct();
            Product.ShowDialog();
        }

        private void productModifyBtn_Click(object sender, EventArgs e)
        {
            //check for no selection
            if (dgvProducts.CurrentRow == null || !dgvProducts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection.");
                return;
            }
            Product modProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
            this.Hide();
            ModProduct Product = new ModProduct(modProduct);
            Product.ShowDialog();
        }

        private void partDeleteBtn_Click(object sender, EventArgs e)
        {
            //check for no selection
            if(dgvParts.CurrentRow == null || !dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection.");
                return;
            }
            //get the selected row
            Part P = dgvParts.CurrentRow.DataBoundItem as Part;

            //Confirm the delete with a MessageBox
            if (DialogResult.Yes == MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning))
            {
                //remove the selected part from the list
                Inventory.AllParts.Remove(P);
            }

        }

        private void productDeleteBtn_Click(object sender, EventArgs e)
        {
            //check for no selection
            if (dgvProducts.CurrentRow == null || !dgvProducts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection.");
                return;
            }
            //get the selected row
            Product P = dgvProducts.CurrentRow.DataBoundItem as Product;

            if (P.AssociatedParts.Count != 0)
            {
                MessageBox.Show("Sorry! Unable to delete product with any parts associated to it. Please modify the product and remove all associated parts to delete this product.");
                return;
            }

            //Confirm the delete with a messagebox
            if (DialogResult.Yes == MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning))
            {
                //remove the selected part from the list
                Inventory.Products.Remove(P);
            }
        }

        private void partSearchBtn_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (partSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(partSearchBox.Text.ToUpper()) || (Inventory.AllParts[i].PartID.ToString() == partSearchBox.Text))
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

        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempList = new BindingList<Product>();
            bool found = false;
            if (productSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(productSearchBox.Text.ToUpper()) || (Inventory.Products[i].ProductID.ToString() == productSearchBox.Text))
                    {
                        TempList.Add(Inventory.Products[i]);
                        found = true;
                    }
                }
                if (found)
                    dgvProducts.DataSource = TempList;
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
                dgvProducts.DataSource = Inventory.Products;
            }
        }
    }
}
