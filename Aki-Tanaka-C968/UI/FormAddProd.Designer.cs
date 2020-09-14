namespace Aki_Tanaka_C968
{
    partial class FormAddProd
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputSearchParts = new System.Windows.Forms.TextBox();
            this.BtnSearchParts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddProdPart = new System.Windows.Forms.Button();
            this.BtnRemoveProdPart = new System.Windows.Forms.Button();
            this.BtnAddProdCancel = new System.Windows.Forms.Button();
            this.BtnSaveProd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InputProdMin = new System.Windows.Forms.TextBox();
            this.InputProdName = new System.Windows.Forms.TextBox();
            this.InputProdInventory = new System.Windows.Forms.TextBox();
            this.InputProdPrice = new System.Windows.Forms.TextBox();
            this.InputProdMax = new System.Windows.Forms.TextBox();
            this.TextboxProdId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DatagridParts2 = new System.Windows.Forms.DataGridView();
            this.DataGridProdParts = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridParts2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProdParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Product";
            // 
            // InputSearchParts
            // 
            this.InputSearchParts.Location = new System.Drawing.Point(816, 30);
            this.InputSearchParts.Name = "InputSearchParts";
            this.InputSearchParts.Size = new System.Drawing.Size(191, 20);
            this.InputSearchParts.TabIndex = 8;
            // 
            // BtnSearchParts
            // 
            this.BtnSearchParts.Location = new System.Drawing.Point(735, 28);
            this.BtnSearchParts.Name = "BtnSearchParts";
            this.BtnSearchParts.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchParts.TabIndex = 7;
            this.BtnSearchParts.Text = "Search";
            this.BtnSearchParts.UseVisualStyleBackColor = true;
            this.BtnSearchParts.Click += new System.EventHandler(this.BtnSearchParts_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 34;
            // 
            // BtnAddProdPart
            // 
            this.BtnAddProdPart.Location = new System.Drawing.Point(939, 215);
            this.BtnAddProdPart.Name = "BtnAddProdPart";
            this.BtnAddProdPart.Size = new System.Drawing.Size(69, 36);
            this.BtnAddProdPart.TabIndex = 9;
            this.BtnAddProdPart.Text = "Add";
            this.BtnAddProdPart.UseVisualStyleBackColor = true;
            this.BtnAddProdPart.Click += new System.EventHandler(this.BtnAddProdPart_Click);
            // 
            // BtnRemoveProdPart
            // 
            this.BtnRemoveProdPart.Location = new System.Drawing.Point(939, 431);
            this.BtnRemoveProdPart.Name = "BtnRemoveProdPart";
            this.BtnRemoveProdPart.Size = new System.Drawing.Size(69, 36);
            this.BtnRemoveProdPart.TabIndex = 10;
            this.BtnRemoveProdPart.Text = "Delete";
            this.BtnRemoveProdPart.UseVisualStyleBackColor = true;
            this.BtnRemoveProdPart.Click += new System.EventHandler(this.BtnRemoveProdPart_Click);
            // 
            // BtnAddProdCancel
            // 
            this.BtnAddProdCancel.Location = new System.Drawing.Point(939, 473);
            this.BtnAddProdCancel.Name = "BtnAddProdCancel";
            this.BtnAddProdCancel.Size = new System.Drawing.Size(69, 36);
            this.BtnAddProdCancel.TabIndex = 12;
            this.BtnAddProdCancel.Text = "Cancel";
            this.BtnAddProdCancel.UseVisualStyleBackColor = true;
            this.BtnAddProdCancel.Click += new System.EventHandler(this.BtnAddProdCancel_Click);
            // 
            // BtnSaveProd
            // 
            this.BtnSaveProd.Location = new System.Drawing.Point(864, 473);
            this.BtnSaveProd.Name = "BtnSaveProd";
            this.BtnSaveProd.Size = new System.Drawing.Size(69, 36);
            this.BtnSaveProd.TabIndex = 11;
            this.BtnSaveProd.Text = "Save";
            this.BtnSaveProd.UseVisualStyleBackColor = true;
            this.BtnSaveProd.Click += new System.EventHandler(this.BtnSaveProd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Inventory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "ID";
            // 
            // InputProdMin
            // 
            this.InputProdMin.Location = new System.Drawing.Point(278, 285);
            this.InputProdMin.Name = "InputProdMin";
            this.InputProdMin.Size = new System.Drawing.Size(101, 20);
            this.InputProdMin.TabIndex = 6;
            this.InputProdMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputProdMin_KeyPress);
            // 
            // InputProdName
            // 
            this.InputProdName.Location = new System.Drawing.Point(108, 189);
            this.InputProdName.Name = "InputProdName";
            this.InputProdName.Size = new System.Drawing.Size(158, 20);
            this.InputProdName.TabIndex = 2;
            // 
            // InputProdInventory
            // 
            this.InputProdInventory.Location = new System.Drawing.Point(108, 221);
            this.InputProdInventory.Name = "InputProdInventory";
            this.InputProdInventory.Size = new System.Drawing.Size(158, 20);
            this.InputProdInventory.TabIndex = 3;
            this.InputProdInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputProdInventory_KeyPress);
            // 
            // InputProdPrice
            // 
            this.InputProdPrice.Location = new System.Drawing.Point(108, 253);
            this.InputProdPrice.Name = "InputProdPrice";
            this.InputProdPrice.Size = new System.Drawing.Size(158, 20);
            this.InputProdPrice.TabIndex = 4;
            this.InputProdPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputProdPrice_KeyPress);
            // 
            // InputProdMax
            // 
            this.InputProdMax.Location = new System.Drawing.Point(108, 285);
            this.InputProdMax.Name = "InputProdMax";
            this.InputProdMax.Size = new System.Drawing.Size(101, 20);
            this.InputProdMax.TabIndex = 5;
            this.InputProdMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputProdMax_KeyPress);
            // 
            // TextboxProdId
            // 
            this.TextboxProdId.Location = new System.Drawing.Point(108, 153);
            this.TextboxProdId.Name = "TextboxProdId";
            this.TextboxProdId.ReadOnly = true;
            this.TextboxProdId.Size = new System.Drawing.Size(158, 20);
            this.TextboxProdId.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(399, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // DatagridParts2
            // 
            this.DatagridParts2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridParts2.Location = new System.Drawing.Point(405, 57);
            this.DatagridParts2.Name = "DatagridParts2";
            this.DatagridParts2.Size = new System.Drawing.Size(603, 153);
            this.DatagridParts2.TabIndex = 35;
            // 
            // DataGridProdParts
            // 
            this.DataGridProdParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProdParts.Location = new System.Drawing.Point(405, 272);
            this.DataGridProdParts.Name = "DataGridProdParts";
            this.DataGridProdParts.Size = new System.Drawing.Size(603, 153);
            this.DataGridProdParts.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(401, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "All candidate Parts";
            // 
            // FormAddProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 532);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DataGridProdParts);
            this.Controls.Add(this.DatagridParts2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputProdMin);
            this.Controls.Add(this.InputProdName);
            this.Controls.Add(this.InputProdInventory);
            this.Controls.Add(this.InputProdPrice);
            this.Controls.Add(this.InputProdMax);
            this.Controls.Add(this.TextboxProdId);
            this.Controls.Add(this.BtnSaveProd);
            this.Controls.Add(this.BtnAddProdCancel);
            this.Controls.Add(this.BtnRemoveProdPart);
            this.Controls.Add(this.BtnAddProdPart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputSearchParts);
            this.Controls.Add(this.BtnSearchParts);
            this.Controls.Add(this.label1);
            this.Name = "FormAddProd";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.DatagridParts2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProdParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputSearchParts;
        private System.Windows.Forms.Button BtnSearchParts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddProdPart;
        private System.Windows.Forms.Button BtnRemoveProdPart;
        private System.Windows.Forms.Button BtnAddProdCancel;
        private System.Windows.Forms.Button BtnSaveProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputProdMin;
        private System.Windows.Forms.TextBox InputProdName;
        private System.Windows.Forms.TextBox InputProdInventory;
        private System.Windows.Forms.TextBox InputProdPrice;
        private System.Windows.Forms.TextBox InputProdMax;
        private System.Windows.Forms.TextBox TextboxProdId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DatagridParts2;
        private System.Windows.Forms.DataGridView DataGridProdParts;
        private System.Windows.Forms.Label label10;
    }
}