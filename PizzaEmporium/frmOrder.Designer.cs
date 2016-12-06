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
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.lstReceipt = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
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
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(190, 41);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(90, 64);
            this.btnDrinks.TabIndex = 1;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnSalads
            // 
            this.btnSalads.Location = new System.Drawing.Point(339, 41);
            this.btnSalads.Name = "btnSalads";
            this.btnSalads.Size = new System.Drawing.Size(90, 64);
            this.btnSalads.TabIndex = 2;
            this.btnSalads.Text = "Salads";
            this.btnSalads.UseVisualStyleBackColor = true;
            this.btnSalads.Click += new System.EventHandler(this.btnSalads_Click);
            // 
            // btnSpecials
            // 
            this.btnSpecials.Location = new System.Drawing.Point(485, 41);
            this.btnSpecials.Name = "btnSpecials";
            this.btnSpecials.Size = new System.Drawing.Size(90, 64);
            this.btnSpecials.TabIndex = 3;
            this.btnSpecials.Text = "Specials";
            this.btnSpecials.UseVisualStyleBackColor = true;
            this.btnSpecials.Click += new System.EventHandler(this.btnSpecials_Click);
            // 
            // btnCoolStuff
            // 
            this.btnCoolStuff.Location = new System.Drawing.Point(628, 41);
            this.btnCoolStuff.Name = "btnCoolStuff";
            this.btnCoolStuff.Size = new System.Drawing.Size(90, 64);
            this.btnCoolStuff.TabIndex = 4;
            this.btnCoolStuff.Text = "Cool Stuff";
            this.btnCoolStuff.UseVisualStyleBackColor = true;
            this.btnCoolStuff.Click += new System.EventHandler(this.btnCoolStuff_Click);
            // 
            // grpDisplay
            // 
            this.grpDisplay.Location = new System.Drawing.Point(48, 160);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Size = new System.Drawing.Size(319, 246);
            this.grpDisplay.TabIndex = 5;
            this.grpDisplay.TabStop = false;
            this.grpDisplay.Text = "Pizza";
            // 
            // lstReceipt
            // 
            this.lstReceipt.FormattingEnabled = true;
            this.lstReceipt.Location = new System.Drawing.Point(501, 160);
            this.lstReceipt.Name = "lstReceipt";
            this.lstReceipt.Size = new System.Drawing.Size(394, 290);
            this.lstReceipt.TabIndex = 6;
            this.lstReceipt.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(238, 490);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(448, 490);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "&Remove from order";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(640, 490);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(112, 23);
            this.btnFinish.TabIndex = 15;
            this.btnFinish.Text = "&Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Order Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(795, 458);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.TabStop = false;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 534);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lstReceipt);
            this.Controls.Add(this.grpDisplay);
            this.Controls.Add(this.btnCoolStuff);
            this.Controls.Add(this.btnSpecials);
            this.Controls.Add(this.btnSalads);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnPizza);
            this.Name = "frmOrder";
            this.Text = "Pizza Emporium";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnSalads;
        private System.Windows.Forms.Button btnSpecials;
        private System.Windows.Forms.Button btnCoolStuff;
        private System.Windows.Forms.GroupBox grpDisplay;
        private System.Windows.Forms.ListBox lstReceipt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtotal;
    }
}

