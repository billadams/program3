namespace PizzaEmporium
{
    partial class frmOrder
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
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnSalads = new System.Windows.Forms.Button();
            this.btnSpecials = new System.Windows.Forms.Button();
            this.btnCoolStuff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkHamburger = new System.Windows.Forms.CheckBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkBlackOlive = new System.Windows.Forms.CheckBox();
            this.chkVeggie = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(48, 41);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(90, 64);
            this.btnPizza.TabIndex = 0;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.UseVisualStyleBackColor = true;
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(190, 41);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(90, 64);
            this.btnDrinks.TabIndex = 1;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            // 
            // btnSalads
            // 
            this.btnSalads.Location = new System.Drawing.Point(339, 41);
            this.btnSalads.Name = "btnSalads";
            this.btnSalads.Size = new System.Drawing.Size(90, 64);
            this.btnSalads.TabIndex = 2;
            this.btnSalads.Text = "Salads";
            this.btnSalads.UseVisualStyleBackColor = true;
            // 
            // btnSpecials
            // 
            this.btnSpecials.Location = new System.Drawing.Point(485, 41);
            this.btnSpecials.Name = "btnSpecials";
            this.btnSpecials.Size = new System.Drawing.Size(90, 64);
            this.btnSpecials.TabIndex = 3;
            this.btnSpecials.Text = "Specials";
            this.btnSpecials.UseVisualStyleBackColor = true;
            // 
            // btnCoolStuff
            // 
            this.btnCoolStuff.Location = new System.Drawing.Point(628, 41);
            this.btnCoolStuff.Name = "btnCoolStuff";
            this.btnCoolStuff.Size = new System.Drawing.Size(90, 64);
            this.btnCoolStuff.TabIndex = 4;
            this.btnCoolStuff.Text = "Cool Stuff";
            this.btnCoolStuff.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkVeggie);
            this.groupBox1.Controls.Add(this.chkBlackOlive);
            this.groupBox1.Controls.Add(this.chkGreenPepper);
            this.groupBox1.Controls.Add(this.chkHamburger);
            this.groupBox1.Controls.Add(this.chkCheese);
            this.groupBox1.Controls.Add(this.radLarge);
            this.groupBox1.Controls.Add(this.radMedium);
            this.groupBox1.Controls.Add(this.radSmall);
            this.groupBox1.Location = new System.Drawing.Point(48, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 246);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(516, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 290);
            this.listBox1.TabIndex = 6;
            this.listBox1.TabStop = false;
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(22, 42);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(50, 17);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Location = new System.Drawing.Point(22, 101);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(62, 17);
            this.radMedium.TabIndex = 1;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(22, 161);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(52, 17);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(190, 33);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(62, 17);
            this.chkCheese.TabIndex = 3;
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkHamburger
            // 
            this.chkHamburger.AutoSize = true;
            this.chkHamburger.Location = new System.Drawing.Point(190, 74);
            this.chkHamburger.Name = "chkHamburger";
            this.chkHamburger.Size = new System.Drawing.Size(78, 17);
            this.chkHamburger.TabIndex = 4;
            this.chkHamburger.Text = "Hamburger";
            this.chkHamburger.UseVisualStyleBackColor = true;
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Location = new System.Drawing.Point(190, 115);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(92, 17);
            this.chkGreenPepper.TabIndex = 5;
            this.chkGreenPepper.Text = "Green Pepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            // 
            // chkBlackOlive
            // 
            this.chkBlackOlive.AutoSize = true;
            this.chkBlackOlive.Location = new System.Drawing.Point(190, 157);
            this.chkBlackOlive.Name = "chkBlackOlive";
            this.chkBlackOlive.Size = new System.Drawing.Size(80, 17);
            this.chkBlackOlive.TabIndex = 6;
            this.chkBlackOlive.Text = "Black Olive";
            this.chkBlackOlive.UseVisualStyleBackColor = true;
            // 
            // chkVeggie
            // 
            this.chkVeggie.AutoSize = true;
            this.chkVeggie.Location = new System.Drawing.Point(190, 199);
            this.chkVeggie.Name = "chkVeggie";
            this.chkVeggie.Size = new System.Drawing.Size(59, 17);
            this.chkVeggie.TabIndex = 7;
            this.chkVeggie.Text = "Veggie";
            this.chkVeggie.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(238, 490);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(463, 490);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "&Remove from order";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(655, 490);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(112, 23);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "&Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 534);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCoolStuff);
            this.Controls.Add(this.btnSpecials);
            this.Controls.Add(this.btnSalads);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnPizza);
            this.Name = "frmOrder";
            this.Text = "Pizza Emporium";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnSalads;
        private System.Windows.Forms.Button btnSpecials;
        private System.Windows.Forms.Button btnCoolStuff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkVeggie;
        private System.Windows.Forms.CheckBox chkBlackOlive;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.CheckBox chkHamburger;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFinish;
    }
}

