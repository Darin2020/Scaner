
namespace Scanner
{
    partial class Scanner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.TextBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.lblQuantityToAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product code";
            // 
            // lblProductId
            // 
            this.lblProductId.Location = new System.Drawing.Point(176, 26);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductId.Size = new System.Drawing.Size(208, 31);
            this.lblProductId.TabIndex = 1;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(895, 26);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(101, 31);
            this.btnProductAdd.TabIndex = 2;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // lblQuantityToAdd
            // 
            this.lblQuantityToAdd.Location = new System.Drawing.Point(662, 26);
            this.lblQuantityToAdd.Name = "lblQuantityToAdd";
            this.lblQuantityToAdd.Size = new System.Drawing.Size(211, 31);
            this.lblQuantityToAdd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(176, 71);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(328, 31);
            this.lblProductName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unit Price";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Location = new System.Drawing.Point(662, 71);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(334, 31);
            this.lblUnitPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity per unit";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(176, 118);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(328, 31);
            this.lblQuantityPerUnit.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Units in stock";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.Location = new System.Drawing.Point(662, 118);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(334, 31);
            this.lblUnitsInStock.TabIndex = 13;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(403, 26);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(101, 31);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Ok";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 516);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblUnitsInStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblQuantityPerUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuantityToAdd);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.label1);
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblProductId;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox lblQuantityToAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblQuantityPerUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblUnitsInStock;
        private System.Windows.Forms.Button btnEnter;
    }
}

