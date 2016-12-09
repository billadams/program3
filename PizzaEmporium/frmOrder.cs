using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaEmporium
{
    /*****************************************************************
    * Name: Bill Adams
    * Project: Program 3
    * Date: 12/8/2016
    * Description: Order pizza and other items.
    * **************************************************************/
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        // Keep track of the current option/checkboxes the form uses for gathering order information.
        private RadioButton selectedrb;
        private List<CheckBox> selectedcb;
        public Order order = null;
        decimal subtotal;

        private void frmOrder_Load(object sender, EventArgs e)
        {
            btnPizza.PerformClick();
            btnRemove.Enabled = false;
            btnFinish.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Either order hasn't been used or we've set it 
            // to null when we finished up a previous order.
            if (order == null)
            {
                order = new Order();
            }

            if (grpDisplay.Text == "Pizza")
            {
                AddPizza();
            }
            else if (grpDisplay.Text == "Drinks")
            {
                AddDrinks();
            }
            else if (grpDisplay.Text == "Salads")
            {
                AddSalads();
            }
            else if (grpDisplay.Text == "Specials")
            {
                AddSpecials();
            }
            else if (grpDisplay.Text == "Cool Stuff")
            {
                AddCoolStuff();
            }

            if (!btnRemove.Enabled)
            {
                btnRemove.Enabled = true;
            }
            if (!btnFinish.Enabled)
            {
                btnFinish.Enabled = true;
            }

            subtotal = order.OrderTotal - order.OrderTax;
            txtSubtotal.Text = subtotal.ToString("c");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstReceipt.SelectedIndex != -1)
            {
                int currentItem = lstReceipt.SelectedIndex;
                lstReceipt.Items.RemoveAt(currentItem);
                order.DeleteItem(currentItem);
            }

            if (lstReceipt.Items.Count == 0)
            {
                btnFinish.Enabled = false;
                btnRemove.Enabled = false;
            }

            subtotal = order.OrderTotal - order.OrderTax;
            txtSubtotal.Text = subtotal.ToString("c");
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            // Format and display a receipt to the user.
            StringBuilder output = InvoiceItem.PrintReceipt(order);
            frmReceipt frmReceipt = new frmReceipt();
            frmReceipt.ShowReceipt(output);

            // Save the order to a database and clear the GUI listbox.
            if (order.SaveOrder())
            {
                lstReceipt.Items.Clear();
            }

            // Set order to null to prepare it for the next order.
            order = null;

            btnFinish.Enabled = false;
            btnRemove.Enabled = false;

            subtotal = 0M;
            txtSubtotal.Text = subtotal.ToString("c");
        }

        private void AddPizza()
        {
            try
            {
                // Create a string array based on the text property of each checkbox object.
                string[] toppings = new string[selectedcb.Count];
                int i = 0;
                foreach (CheckBox cb in selectedcb)
                {
                    toppings[i] = cb.Text;
                    i++;
                }

                Pizza pizza = new Pizza(105, "Pizza", selectedrb.Text, toppings);
                lstReceipt.Items.Add(pizza.GetDisplayText());
                order.AddItem(pizza);

                // Clear the values of the option and checkboxes.
                selectedrb.Checked = false;
                selectedrb = null;
                foreach (CheckBox cb in selectedcb)
                {
                    cb.Checked = false;
                }
                selectedcb = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You must select a pizza size and at least one ingredient.", "Selection error");
            }
        }

        private void AddDrinks()
        {
            try
            {
                Drink drink = new Drink(106, "Drink", selectedrb.Text);
                lstReceipt.Items.Add(drink.GetDisplayText());
                order.AddItem(drink);

                selectedrb.Checked = false;
                selectedrb = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You must select a drink size.", "Selection error");
            }
        }

        private void AddSalads()
        {
            try
            {
                Salad salad = new Salad(107, "Salad", selectedrb.Text);
                lstReceipt.Items.Add(salad.GetDisplayText());
                order.AddItem(salad);

                selectedrb.Checked = false;
                selectedrb = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You must select a salad size.", "Selection error");
            }
        }

        private void AddSpecials()
        {
            try
            {
                Specials special = new Specials(108, selectedrb.Text, Convert.ToString(selectedrb.Tag));
                lstReceipt.Items.Add(special.GetDisplayText());
                order.AddItem(special);

                selectedrb.Checked = false;
                selectedrb = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You must select one special.", "Selection error");
            }
        }

        private void AddCoolStuff()
        {
            try
            {
                // Create a string array based on the text property of each checkbox object.
                string[] items = new string[selectedcb.Count];
                int i = 0;
                foreach (CheckBox cb in selectedcb)
                {
                    items[i] = cb.Text;
                    i++;
                }

                Promotional promotional = new Promotional(109, "Promotional", items);
                lstReceipt.Items.Add(promotional.GetDisplayText());
                order.AddItem(promotional);

                foreach (CheckBox cb in selectedcb)
                {
                    cb.Checked = false;
                }
                selectedcb = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You must select a promotional item.", "Selection error");
            }
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            grpDisplay.Controls.Clear();
            grpDisplay.Text = "Pizza";

            RadioButton sizeSmall = new RadioButton();
            sizeSmall.Name = "radSmall";
            sizeSmall.Text = "Small";
            sizeSmall.TabIndex = 5;
            sizeSmall.Location = new Point(37, 49);
            sizeSmall.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            grpDisplay.Controls.Add(sizeSmall);

            RadioButton sizeMedium = new RadioButton();
            sizeMedium.Name = "radMedium";
            sizeMedium.Text = "Medium";
            sizeMedium.TabIndex = 6;
            sizeMedium.Location = new Point(37, 115);
            sizeMedium.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            grpDisplay.Controls.Add(sizeMedium);

            RadioButton sizeLarge = new RadioButton();
            sizeLarge.Name = "radLarge";
            sizeLarge.Text = "Large";
            sizeLarge.TabIndex = 7;
            sizeLarge.Location = new Point(37, 181);
            sizeLarge.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            grpDisplay.Controls.Add(sizeLarge);

            CheckBox cheeseTopping = new CheckBox();
            cheeseTopping.Name = "chkCheese";
            cheeseTopping.Text = "Cheese";
            cheeseTopping.TabIndex = 8;
            cheeseTopping.Location = new Point(190, 27);
            cheeseTopping.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            grpDisplay.Controls.Add(cheeseTopping);

            CheckBox hamburgerTopping = new CheckBox();
            hamburgerTopping.Name = "chkHamburger";
            hamburgerTopping.Text = "Hamburger";
            hamburgerTopping.TabIndex = 9;
            hamburgerTopping.Location = new Point(190, 71);
            hamburgerTopping.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            grpDisplay.Controls.Add(hamburgerTopping);

            CheckBox greenPepperTopping = new CheckBox();
            greenPepperTopping.Name = "chkGreenPepper";
            greenPepperTopping.Text = "Green Pepper";
            greenPepperTopping.TabIndex = 10;
            greenPepperTopping.Location = new Point(190, 115);
            greenPepperTopping.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            grpDisplay.Controls.Add(greenPepperTopping);

            CheckBox blackOliveTopping = new CheckBox();
            blackOliveTopping.Name = "chkBlackOlive";
            blackOliveTopping.Text = "Black Olive";
            blackOliveTopping.TabIndex = 11;
            blackOliveTopping.Location = new Point(190, 159);
            blackOliveTopping.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            grpDisplay.Controls.Add(blackOliveTopping);

            CheckBox veggieTopping = new CheckBox();
            veggieTopping.Name = "chkVeggie";
            veggieTopping.Text = "Veggie";
            veggieTopping.TabIndex = 12;
            veggieTopping.Location = new Point(190, 203);
            veggieTopping.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            grpDisplay.Controls.Add(veggieTopping);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            grpDisplay.Controls.Clear();
            grpDisplay.Text = "Drinks";

            RadioButton smallDrink = new RadioButton();
            smallDrink.Name = "radSmallDrink";
            smallDrink.Text = "Small";
            smallDrink.TabIndex = 5;
            smallDrink.Location = new Point(128, 49);
            smallDrink.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            grpDisplay.Controls.Add(smallDrink);

            RadioButton mediumDrink = new RadioButton();
            mediumDrink.Name = "radMediumDrink";
            mediumDrink.Text = "Medium";
            mediumDrink.TabIndex = 6;
            mediumDrink.Location = new Point(128, 115);
            mediumDrink.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            grpDisplay.Controls.Add(mediumDrink);

            RadioButton largeDrink = new RadioButton();
            largeDrink.Name = "radLargeDrink";
            largeDrink.Text = "Large";
            largeDrink.TabIndex = 7;
            largeDrink.Location = new Point(128, 181);
            largeDrink.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            grpDisplay.Controls.Add(largeDrink);
        }

        private void btnSalads_Click(object sender, EventArgs e)
        {
            grpDisplay.Controls.Clear();
            grpDisplay.Text = "Salads";

            RadioButton houseSalad = new RadioButton();
            houseSalad.Name = "radHouseSalad";
            houseSalad.Text = "House";
            houseSalad.TabIndex = 5;
            houseSalad.Location = new Point(128, 49);
            houseSalad.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            grpDisplay.Controls.Add(houseSalad);

            RadioButton chefSalad = new RadioButton();
            chefSalad.Name = "radChefSalad";
            chefSalad.Text = "Chef";
            chefSalad.TabIndex = 6;
            chefSalad.Location = new Point(128, 115);
            chefSalad.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            grpDisplay.Controls.Add(chefSalad);

            RadioButton insalataSalad = new RadioButton();
            insalataSalad.Name = "radInsalataSalad";
            insalataSalad.Text = "Insalata";
            insalataSalad.TabIndex = 7;
            insalataSalad.Location = new Point(128, 181);
            insalataSalad.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            grpDisplay.Controls.Add(insalataSalad);
        }

        private void btnSpecials_Click(object sender, EventArgs e)
        {
            grpDisplay.Controls.Clear();
            grpDisplay.Text = "Specials";

            RadioButton special1 = new RadioButton();
            special1.Name = "radSpecial1";
            special1.Text = "Medium hamburger pizza, House salad, Medium drink";
            special1.Tag = "Special1";
            special1.TabIndex = 5;
            special1.Location = new Point(37, 48);
            special1.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            special1.AutoSize = true;
            grpDisplay.Controls.Add(special1);

            RadioButton special2 = new RadioButton();
            special2.Name = "radSpecial2";
            special2.Text = "Medium cheese pizza, Insalata salad, Medium drink";
            special2.Tag = "Special2";
            special2.TabIndex = 6;
            special2.Location = new Point(37, 115);
            special2.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            special2.AutoSize = true;
            grpDisplay.Controls.Add(special2);
        }

        private void btnCoolStuff_Click(object sender, EventArgs e)
        {
            grpDisplay.Controls.Clear();
            grpDisplay.Text = "Cool Stuff";

            CheckBox tShirtPizzaCheesy = new CheckBox();
            tShirtPizzaCheesy.Name = "chkPizzaCheesy";
            tShirtPizzaCheesy.Text = "T-shirt: Pizza is Cheesy";
            tShirtPizzaCheesy.TabIndex = 5;
            tShirtPizzaCheesy.Location = new Point(37, 48);
            tShirtPizzaCheesy.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            tShirtPizzaCheesy.AutoSize = true;
            grpDisplay.Controls.Add(tShirtPizzaCheesy);

            CheckBox tShirtPizzaPizza = new CheckBox();
            tShirtPizzaPizza.Name = "chkPizzaPizza";
            tShirtPizzaPizza.Text = "T-shirt: Pizza! Pizza!";
            tShirtPizzaPizza.TabIndex = 6;
            tShirtPizzaPizza.Location = new Point(37, 115);
            tShirtPizzaPizza.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            tShirtPizzaPizza.AutoSize = true;
            grpDisplay.Controls.Add(tShirtPizzaPizza);
        }

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                selectedrb = rb;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            // If selectedcb is null, we either haven't used it or we've
            // nulled it after adding its contents to an order.
            if (selectedcb == null)
                selectedcb = new List<CheckBox>();
        
            if (cb == null)
            {
                MessageBox.Show("Sender is not a CheckBox");
                return;
            }

            if (cb.Checked && !selectedcb.Contains(cb))
            {
                selectedcb.Add(cb);
            }
        }
    }
}
