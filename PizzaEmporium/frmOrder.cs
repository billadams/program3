﻿using System;
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
        Object disabledButton = null;

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            grpDisplay.Controls.Clear();
            grpDisplay.Text = "Pizza";

            //disabledButton = this.btnPizza.Name;

            RadioButton sizeSmall = new RadioButton();
            sizeSmall.Name = "radSmall";
            sizeSmall.Text = "Small";
            sizeSmall.Checked = true;
            sizeSmall.TabIndex = 5;
            sizeSmall.Location = new Point(37, 49);
            grpDisplay.Controls.Add(sizeSmall);

            RadioButton sizeMedium = new RadioButton();
            sizeMedium.Name = "radMedium";
            sizeMedium.Text = "Medium";
            sizeMedium.TabIndex = 6;
            sizeMedium.Location = new Point(37, 115);
            grpDisplay.Controls.Add(sizeMedium);

            RadioButton sizeLarge = new RadioButton();
            sizeLarge.Name = "radLarge";
            sizeLarge.Text = "Large";
            sizeLarge.TabIndex = 7;
            sizeLarge.Location = new Point(37, 181);
            grpDisplay.Controls.Add(sizeLarge);

            CheckBox cheeseTopping = new CheckBox();
            cheeseTopping.Name = "chkCheese";
            cheeseTopping.Text = "Cheese";
            cheeseTopping.TabIndex = 8;
            cheeseTopping.Location = new Point(190, 27);
            grpDisplay.Controls.Add(cheeseTopping);

            CheckBox hamburgerTopping = new CheckBox();
            hamburgerTopping.Name = "chkHamburger";
            hamburgerTopping.Text = "Hamburger";
            hamburgerTopping.TabIndex = 9;
            hamburgerTopping.Location = new Point(190, 71);
            grpDisplay.Controls.Add(hamburgerTopping);

            CheckBox greenPepperTopping = new CheckBox();
            greenPepperTopping.Name = "chkGreenPepper";
            greenPepperTopping.Text = "Green Pepper";
            greenPepperTopping.TabIndex = 10;
            greenPepperTopping.Location = new Point(190, 115);
            grpDisplay.Controls.Add(greenPepperTopping);

            CheckBox blackOliveTopping = new CheckBox();
            blackOliveTopping.Name = "chkBlackOlive";
            blackOliveTopping.Text = "Black Olive";
            blackOliveTopping.TabIndex = 11;
            blackOliveTopping.Location = new Point(190, 159);
            grpDisplay.Controls.Add(blackOliveTopping);

            CheckBox veggieTopping = new CheckBox();
            veggieTopping.Name = "chkVeggie";
            veggieTopping.Text = "Veggie";
            veggieTopping.TabIndex = 12;
            veggieTopping.Location = new Point(190, 203);
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
            houseSalad.Location = new Point(128, 48);
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
    }
}
