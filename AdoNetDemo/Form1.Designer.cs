﻿namespace AdoNetDemo
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUnitpriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblsource = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(88, 19);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(135, 31);
            this.tbxName.TabIndex = 2;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(8, 78);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Unit Price";
            this.lblUnitPrice.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(88, 66);
            this.tbxUnitPrice.Multiline = true;
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(135, 34);
            this.tbxUnitPrice.TabIndex = 4;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(8, 128);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(74, 13);
            this.lblStockAmount.TabIndex = 5;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(88, 116);
            this.tbxStockAmount.Multiline = true;
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(135, 35);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxAdd.Controls.Add(this.tbxStockAmount);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.lblStockAmount);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblUnitPrice);
            this.gbxAdd.Location = new System.Drawing.Point(12, 201);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(249, 207);
            this.gbxAdd.TabIndex = 7;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(99, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitpriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(279, 201);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(254, 207);
            this.gbxUpdate.TabIndex = 8;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(99, 166);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 25);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUnitpriceUpdate
            // 
            this.tbxUnitpriceUpdate.Location = new System.Drawing.Point(88, 66);
            this.tbxUnitpriceUpdate.Multiline = true;
            this.tbxUnitpriceUpdate.Name = "tbxUnitpriceUpdate";
            this.tbxUnitpriceUpdate.Size = new System.Drawing.Size(135, 34);
            this.tbxUnitpriceUpdate.TabIndex = 4;
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(88, 116);
            this.tbxStockAmountUpdate.Multiline = true;
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(135, 35);
            this.tbxStockAmountUpdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(8, 33);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name";
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(8, 128);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(74, 13);
            this.lblStockAmountUpdate.TabIndex = 5;
            this.lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(88, 19);
            this.tbxNameUpdate.Multiline = true;
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(135, 31);
            this.tbxNameUpdate.TabIndex = 2;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(8, 78);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPriceUpdate.TabIndex = 3;
            this.lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(659, 150);
            this.dgwProducts.TabIndex = 9;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // lblsource
            // 
            this.lblsource.AutoSize = true;
            this.lblsource.Location = new System.Drawing.Point(539, 222);
            this.lblsource.Name = "lblsource";
            this.lblsource.Size = new System.Drawing.Size(35, 13);
            this.lblsource.TabIndex = 10;
            this.lblsource.Text = "Name";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(580, 216);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(83, 20);
            this.tbxSearch.TabIndex = 11;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(561, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 419);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblsource);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUnitpriceUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblsource;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnDelete;
    }
}

