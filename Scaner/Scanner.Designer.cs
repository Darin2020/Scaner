
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNewOrder = new System.Windows.Forms.TabPage();
            this.lblUnitsInStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.lblQuantityToAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCurrentInvoice = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblQuantityDelete = new System.Windows.Forms.TextBox();
            this.lblProductIdDelete = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabNewOrder.SuspendLayout();
            this.tabCurrentInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNewOrder);
            this.tabControl1.Controls.Add(this.tabCurrentInvoice);
            this.tabControl1.Controls.Add(this.tabDelete);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1196, 573);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabNewOrder
            // 
            this.tabNewOrder.Controls.Add(this.lblUnitsInStock);
            this.tabNewOrder.Controls.Add(this.label6);
            this.tabNewOrder.Controls.Add(this.lblUnitPrice);
            this.tabNewOrder.Controls.Add(this.label4);
            this.tabNewOrder.Controls.Add(this.btnProductAdd);
            this.tabNewOrder.Controls.Add(this.lblQuantityToAdd);
            this.tabNewOrder.Controls.Add(this.label2);
            this.tabNewOrder.Controls.Add(this.lblQuantityPerUnit);
            this.tabNewOrder.Controls.Add(this.label5);
            this.tabNewOrder.Controls.Add(this.btnEnter);
            this.tabNewOrder.Controls.Add(this.lblProductName);
            this.tabNewOrder.Controls.Add(this.lblProductId);
            this.tabNewOrder.Controls.Add(this.label3);
            this.tabNewOrder.Controls.Add(this.label1);
            this.tabNewOrder.Location = new System.Drawing.Point(4, 34);
            this.tabNewOrder.Name = "tabNewOrder";
            this.tabNewOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewOrder.Size = new System.Drawing.Size(1188, 535);
            this.tabNewOrder.TabIndex = 0;
            this.tabNewOrder.Text = "Invoice";
            this.tabNewOrder.UseVisualStyleBackColor = true;
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.Location = new System.Drawing.Point(750, 113);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(400, 31);
            this.lblUnitsInStock.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Units in stock";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Location = new System.Drawing.Point(750, 68);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(400, 31);
            this.lblUnitPrice.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Unit Price";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(1049, 22);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(101, 31);
            this.btnProductAdd.TabIndex = 20;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            // 
            // lblQuantityToAdd
            // 
            this.lblQuantityToAdd.Location = new System.Drawing.Point(750, 25);
            this.lblQuantityToAdd.Name = "lblQuantityToAdd";
            this.lblQuantityToAdd.Size = new System.Drawing.Size(211, 31);
            this.lblQuantityToAdd.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantity";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(176, 110);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(328, 31);
            this.lblQuantityPerUnit.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantity per unit";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(403, 19);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(101, 31);
            this.btnEnter.TabIndex = 15;
            this.btnEnter.Text = "Ok";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(176, 68);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(328, 31);
            this.lblProductName.TabIndex = 9;
            // 
            // lblProductId
            // 
            this.lblProductId.Location = new System.Drawing.Point(176, 19);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductId.Size = new System.Drawing.Size(208, 31);
            this.lblProductId.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product code";
            // 
            // tabCurrentInvoice
            // 
            this.tabCurrentInvoice.Controls.Add(this.dataGridView1);
            this.tabCurrentInvoice.Location = new System.Drawing.Point(4, 34);
            this.tabCurrentInvoice.Name = "tabCurrentInvoice";
            this.tabCurrentInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrentInvoice.Size = new System.Drawing.Size(1188, 535);
            this.tabCurrentInvoice.TabIndex = 1;
            this.tabCurrentInvoice.Text = "Current Invoice";
            this.tabCurrentInvoice.UseVisualStyleBackColor = true;
            this.tabCurrentInvoice.Click += new System.EventHandler(this.tabCurrentInvoice_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 120;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1188, 539);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.btnDelete);
            this.tabDelete.Controls.Add(this.lblQuantityDelete);
            this.tabDelete.Controls.Add(this.lblProductIdDelete);
            this.tabDelete.Controls.Add(this.label8);
            this.tabDelete.Controls.Add(this.label7);
            this.tabDelete.Location = new System.Drawing.Point(4, 34);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(1188, 535);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete Product";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1043, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "OK";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblQuantityDelete
            // 
            this.lblQuantityDelete.Location = new System.Drawing.Point(705, 26);
            this.lblQuantityDelete.Name = "lblQuantityDelete";
            this.lblQuantityDelete.Size = new System.Drawing.Size(237, 31);
            this.lblQuantityDelete.TabIndex = 3;
            // 
            // lblProductIdDelete
            // 
            this.lblProductIdDelete.Location = new System.Drawing.Point(180, 25);
            this.lblProductIdDelete.Name = "lblProductIdDelete";
            this.lblProductIdDelete.Size = new System.Drawing.Size(288, 31);
            this.lblProductIdDelete.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Product ID";
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 573);
            this.Controls.Add(this.tabControl1);
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.Load += new System.EventHandler(this.Scanner_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabNewOrder.ResumeLayout(false);
            this.tabNewOrder.PerformLayout();
            this.tabCurrentInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNewOrder;
        private System.Windows.Forms.TextBox lblUnitsInStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox lblQuantityToAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblQuantityPerUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox lblProductName;
        private System.Windows.Forms.TextBox lblProductId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.TextBox lblQuantityDelete;
        private System.Windows.Forms.TextBox lblProductIdDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tabCurrentInvoice;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

