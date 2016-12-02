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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        // Keep track of the current button we're working with.
        private RadioButton selectedrb;
        private List<CheckBox> selectedcb = new List<CheckBox>();
        Pizza pizza;

        private void frmOrder_Load(object sender, EventArgs e)
        {
            btnPizza.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (grpDisplay.Text == "Pizza")
            {
                string[] toppings = new string[selectedcb.Count];
                int i = 0;
                foreach (CheckBox cb in selectedcb)
                {
                    toppings[i] = cb.Text;
                    i++;
                }

                //pizza = new Pizza(selectedrb.Tag, "Pizza", 54m, selectedrb.Text, selectedcb);


                if (selectedrb.Checked)
                {
                    MessageBox.Show(selectedrb.Text + " was selected");
                }

                string output = "";
                 if (selectedcb.Count > 0)
                {
                    foreach(CheckBox cb in selectedcb)
                    {
                        output += cb.Text + "\n";
                    }

                    MessageBox.Show(output);
                }
            }
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            grpDisplay.Controls.Clear();
            grpDisplay.Text = "Pizza";

            //disabledButton = this.btnPizza.Name;
            //string[] sizes = { "sizeSmall", "sizeMedium", "sizeLarge" };

            //for (int i = 0; i < sizes.Length; i++)
            //{
            //    RadioButton radioButton = new RadioButton();

            //}

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

            //disabledButton.Enabled = true;
            //this.btnDrinks.Enabled = false;

            RadioButton smallDrink = new RadioButton();
            smallDrink.Name = "radSmallDrink";
            smallDrink.Text = "Small";
            smallDrink.Checked = true;
            smallDrink.TabIndex = 5;
            smallDrink.Location = new Point(128, 49);
            grpDisplay.Controls.Add(smallDrink);

            RadioButton mediumDrink = new RadioButton();
            mediumDrink.Name = "radMediumDrink";
            mediumDrink.Text = "Medium";
            mediumDrink.TabIndex = 6;
            mediumDrink.Location = new Point(128, 115);
            grpDisplay.Controls.Add(mediumDrink);

            RadioButton largeDrink = new RadioButton();
            largeDrink.Name = "radLargeDrink";
            largeDrink.Text = "Large";
            largeDrink.TabIndex = 7;
            largeDrink.Location = new Point(128, 181);
            grpDisplay.Controls.Add(largeDrink);
        }

        private void btnSalads_Click(object sender, EventArgs e)
        {
            grpDisplay.Controls.Clear();
            grpDisplay.Text = "Salads";

            RadioButton houseSalad = new RadioButton();
            houseSalad.Name = "radHouseSalad";
            houseSalad.Text = "House Salad";
            houseSalad.Checked = true;
            houseSalad.TabIndex = 5;
            houseSalad.Location = new Point(128, 49);
            grpDisplay.Controls.Add(houseSalad);

            RadioButton chefSalad = new RadioButton();
            chefSalad.Name = "radChefSalad";
            chefSalad.Text = "Chef Salad";
            chefSalad.TabIndex = 6;
            chefSalad.Location = new Point(128, 115);
            grpDisplay.Controls.Add(chefSalad);

            RadioButton insalataSalad = new RadioButton();
            insalataSalad.Name = "radInsalataSalad";
            insalataSalad.Text = "Insalata Salad";
            insalataSalad.TabIndex = 7;
            insalataSalad.Location = new Point(128, 181);
            grpDisplay.Controls.Add(insalataSalad);
        }

        private void btnSpecials_Click(object sender, EventArgs e)
        {
            grpDisplay.Controls.Clear();
            grpDisplay.Text = "Specials";

            RadioButton special1 = new RadioButton();
            special1.Name = "radSpecial1";
            special1.Text = "Medium hamburger pizza, house salad,\n and medium drink";
            special1.Checked = true;
            special1.TabIndex = 5;
            special1.Location = new Point(37, 48);
            special1.AutoSize = true;
            grpDisplay.Controls.Add(special1);

            RadioButton special2 = new RadioButton();
            special2.Name = "radSpecial2";
            special2.Text = "Medium cheese pizza, insalata salad,\n and medium drink";
            special2.TabIndex = 6;
            special2.Location = new Point(37, 115);
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
            tShirtPizzaCheesy.AutoSize = true;
            grpDisplay.Controls.Add(tShirtPizzaCheesy);

            CheckBox tShirtPizzaPizza = new CheckBox();
            tShirtPizzaPizza.Name = "chkPizzaPizza";
            tShirtPizzaPizza.Text = "T-shirt: Pizza! Pizza!";
            tShirtPizzaPizza.TabIndex = 6;
            tShirtPizzaPizza.Location = new Point(37, 115);
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

            if (cb == null)
            {
                MessageBox.Show("Sender is not a CheckBox");
                return;
            }

            if (cb.Checked)
            {
                //MessageBox.Show(cb.Text);
                selectedcb.Add(cb);
            }
        }
    }
}
