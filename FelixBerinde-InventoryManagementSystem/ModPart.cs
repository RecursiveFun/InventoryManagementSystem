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
    public partial class ModPart : Form
    {
        
        public ModPart()
        {
            InitializeComponent();
            IDBox.ReadOnly = true;
        }

        public ModPart(Part part)
        {
            InitializeComponent();
            IDBox.ReadOnly = true;
            IDBox.Text = part.PartID.ToString();
            nameBox.Text = part.Name.ToString();
            inventoryBox.Text = part.InStock.ToString();
            priceCostBox.Text = part.Price.ToString();
            maxBox.Text = part.Max.ToString();
            minBox.Text = part.Min.ToString();

            if (part is Inhouse)
            {
                inHouseRadio.Checked = true;

                Inhouse partInhouse = (Inhouse)part;
                machineIDBox.Text = partInhouse.MachineID.ToString();
                machineIDLabel.Text = "Machine ID:";
            }
            else
            {
                outsourcedRadio.Checked = true;

                Outsourced partOutsourced = (Outsourced)part;
                machineIDBox.Text = partOutsourced.CompanyName;
                machineIDLabel.Text = "Company Name:";

            }
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


            int num = int.Parse(IDBox.Text);

            var name = nameBox.Text;

            var inventory = int.Parse(inventoryBox.Text);

            var price = decimal.Parse(priceCostBox.Text);

            var max = int.Parse(maxBox.Text);

            var min = int.Parse(minBox.Text);

            if (inHouseRadio.Checked)
            {
                

                var tempInHousePart = new Inhouse
                {
                    PartID = num,
                    Name = name,
                    InStock = inventory,
                    MachineID = int.Parse(machineIDBox.Text),
                    Max = max,
                    Min = min,
                    Price = price
                };

                Inventory.updatePart(num, tempInHousePart);

            }
            else
            {
                var tempOutSourcedPart = new Outsourced
                {
                    PartID = num,
                    Name = name,
                    InStock = inventory,
                    CompanyName = machineIDBox.Text,
                    Max = max,
                    Min = min,
                    Price = price
                };

                Inventory.updatePart(num, tempOutSourcedPart);
            }
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.ShowDialog();
            this.Close();
        }

        private void Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    machineIDLabel.Text = "Company Name";
                    machineIDBox.Clear();
                }
            }
        }

        private void inHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    machineIDLabel.Text = "Machine ID";
                    machineIDBox.Clear();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.ShowDialog();
            this.Close();
        }

        private void ModPart_Load(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                nameBox.BackColor = System.Drawing.Color.Salmon;
                ToolTip isAString = new ToolTip();
                isAString.ShowAlways = true;
                isAString.SetToolTip(nameBox, "Please enter a Part name.");
                saveBtn.Enabled = false;
            }
            else
            {
                nameBox.BackColor = System.Drawing.Color.White;
                saveBtn.Enabled = true;
            }
        }

        private void inventoryBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryBox.Text) || int.TryParse(inventoryBox.Text, out _) == false)
            {
                inventoryBox.BackColor = System.Drawing.Color.Salmon;
                ToolTip isANumber= new ToolTip();
                isANumber.ShowAlways = true;
                isANumber.SetToolTip(inventoryBox, "Please enter a number.");
                saveBtn.Enabled = false;
            }
            else
            {
                inventoryBox.BackColor = System.Drawing.Color.White;
                saveBtn.Enabled = true;
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
                saveBtn.Enabled = false;
            }
            else
            {
                priceCostBox.BackColor = System.Drawing.Color.White;
                saveBtn.Enabled = true;
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
                saveBtn.Enabled = false;
            }
            else
            {
                maxBox.BackColor = System.Drawing.Color.White;
                saveBtn.Enabled = true;
            }
        }

        private void minBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minBox.Text) || int.TryParse(minBox.Text, out _) == false)
            {
                minBox.BackColor = System.Drawing.Color.Salmon;
                ToolTip isANumber = new ToolTip();
                isANumber.ShowAlways = true;
                isANumber.SetToolTip(inventoryBox, "Please enter a number.");
                saveBtn.Enabled = false;
            }
            else
            {
                minBox.BackColor = System.Drawing.Color.White;
                saveBtn.Enabled = true;
            }
        }

        private void machineIDBox_TextChanged(object sender, EventArgs e)
        {
            if (inHouseRadio.Checked)
            {
                if (string.IsNullOrWhiteSpace(machineIDBox.Text) || int.TryParse(machineIDBox.Text, out _) == false)
                {
                    machineIDBox.BackColor = System.Drawing.Color.Salmon;
                    ToolTip isANumber = new ToolTip();
                    isANumber.ShowAlways = true;
                    isANumber.SetToolTip(machineIDBox, "Please enter a number.");
                    saveBtn.Enabled = false;
                }
                else
                {
                    machineIDBox.BackColor = System.Drawing.Color.White;
                    saveBtn.Enabled = true;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(machineIDBox.Text))
                {
                    machineIDBox.BackColor = System.Drawing.Color.Salmon;
                    ToolTip isText = new ToolTip();
                    isText.ShowAlways = true;
                    isText.SetToolTip(machineIDBox, "Please enter a company name.");
                    saveBtn.Enabled = false;
                }
                else
                {
                    machineIDBox.BackColor = System.Drawing.Color.White;
                    saveBtn.Enabled = true;
                }
            }
        }
    }
}
