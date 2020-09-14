namespace Aki_Tanaka_C968
{
    partial class FormMainScreen
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
            this.components = new System.ComponentModel.Container();
            this.BtnSearchParts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputSearchParts = new System.Windows.Forms.TextBox();
            this.InputSearchProd = new System.Windows.Forms.TextBox();
            this.BtnSearchProd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddParts = new System.Windows.Forms.Button();
            this.BtnModParts = new System.Windows.Forms.Button();
            this.BtnDelParts = new System.Windows.Forms.Button();
            this.BtnAddProd = new System.Windows.Forms.Button();
            this.BtnModProd = new System.Windows.Forms.Button();
            this.BtnDelProd = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.DatagridParts = new System.Windows.Forms.DataGridView();
            this.DatagridProd = new System.Windows.Forms.DataGridView();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearchParts
            // 
            this.BtnSearchParts.Location = new System.Drawing.Point(362, 57);
            this.BtnSearchParts.Name = "BtnSearchParts";
            this.BtnSearchParts.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchParts.TabIndex = 0;
            this.BtnSearchParts.Text = "Search";
            this.BtnSearchParts.UseVisualStyleBackColor = true;
            this.BtnSearchParts.Click += new System.EventHandler(this.BtnSearchParts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Management System";
            // 
            // InputSearchParts
            // 
            this.InputSearchParts.Location = new System.Drawing.Point(443, 57);
            this.InputSearchParts.Name = "InputSearchParts";
            this.InputSearchParts.Size = new System.Drawing.Size(191, 20);
            this.InputSearchParts.TabIndex = 2;
            // 
            // InputSearchProd
            // 
            this.InputSearchProd.Location = new System.Drawing.Point(1101, 57);
            this.InputSearchProd.Name = "InputSearchProd";
            this.InputSearchProd.Size = new System.Drawing.Size(191, 20);
            this.InputSearchProd.TabIndex = 4;
            // 
            // BtnSearchProd
            // 
            this.BtnSearchProd.Location = new System.Drawing.Point(1020, 57);
            this.BtnSearchProd.Name = "BtnSearchProd";
            this.BtnSearchProd.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchProd.TabIndex = 3;
            this.BtnSearchProd.Text = "Search";
            this.BtnSearchProd.UseVisualStyleBackColor = true;
            this.BtnSearchProd.Click += new System.EventHandler(this.BtnSearchProd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(685, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Products";
            // 
            // BtnAddParts
            // 
            this.BtnAddParts.Location = new System.Drawing.Point(415, 373);
            this.BtnAddParts.Name = "BtnAddParts";
            this.BtnAddParts.Size = new System.Drawing.Size(69, 36);
            this.BtnAddParts.TabIndex = 11;
            this.BtnAddParts.Text = "Add";
            this.BtnAddParts.UseVisualStyleBackColor = true;
            this.BtnAddParts.Click += new System.EventHandler(this.BtnAddParts_Click);
            // 
            // BtnModParts
            // 
            this.BtnModParts.Location = new System.Drawing.Point(490, 373);
            this.BtnModParts.Name = "BtnModParts";
            this.BtnModParts.Size = new System.Drawing.Size(69, 36);
            this.BtnModParts.TabIndex = 12;
            this.BtnModParts.Text = "Modify";
            this.BtnModParts.UseVisualStyleBackColor = true;
            this.BtnModParts.Click += new System.EventHandler(this.BtnModParts_Click);
            // 
            // BtnDelParts
            // 
            this.BtnDelParts.Location = new System.Drawing.Point(565, 373);
            this.BtnDelParts.Name = "BtnDelParts";
            this.BtnDelParts.Size = new System.Drawing.Size(69, 36);
            this.BtnDelParts.TabIndex = 13;
            this.BtnDelParts.Text = "Delete";
            this.BtnDelParts.UseVisualStyleBackColor = true;
            this.BtnDelParts.Click += new System.EventHandler(this.BtnDelParts_Click);
            // 
            // BtnAddProd
            // 
            this.BtnAddProd.Location = new System.Drawing.Point(1073, 373);
            this.BtnAddProd.Name = "BtnAddProd";
            this.BtnAddProd.Size = new System.Drawing.Size(69, 36);
            this.BtnAddProd.TabIndex = 14;
            this.BtnAddProd.Text = "Add";
            this.BtnAddProd.UseVisualStyleBackColor = true;
            this.BtnAddProd.Click += new System.EventHandler(this.BtnAddProd_Click);
            // 
            // BtnModProd
            // 
            this.BtnModProd.Location = new System.Drawing.Point(1148, 373);
            this.BtnModProd.Name = "BtnModProd";
            this.BtnModProd.Size = new System.Drawing.Size(69, 36);
            this.BtnModProd.TabIndex = 15;
            this.BtnModProd.Text = "Modify";
            this.BtnModProd.UseVisualStyleBackColor = true;
            this.BtnModProd.Click += new System.EventHandler(this.BtnModProd_Click);
            // 
            // BtnDelProd
            // 
            this.BtnDelProd.Location = new System.Drawing.Point(1223, 373);
            this.BtnDelProd.Name = "BtnDelProd";
            this.BtnDelProd.Size = new System.Drawing.Size(69, 36);
            this.BtnDelProd.TabIndex = 16;
            this.BtnDelProd.Text = "Delete";
            this.BtnDelProd.UseVisualStyleBackColor = true;
            this.BtnDelProd.Click += new System.EventHandler(this.BtnDelProd_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(1223, 441);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(69, 36);
            this.BtnExit.TabIndex = 17;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // DatagridParts
            // 
            this.DatagridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridParts.Location = new System.Drawing.Point(31, 103);
            this.DatagridParts.Name = "DatagridParts";
            this.DatagridParts.RowHeadersVisible = false;
            this.DatagridParts.Size = new System.Drawing.Size(603, 264);
            this.DatagridParts.TabIndex = 18;
            // 
            // DatagridProd
            // 
            this.DatagridProd.AllowUserToAddRows = false;
            this.DatagridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridProd.Location = new System.Drawing.Point(689, 103);
            this.DatagridProd.Name = "DatagridProd";
            this.DatagridProd.RowHeadersVisible = false;
            this.DatagridProd.Size = new System.Drawing.Size(603, 264);
            this.DatagridProd.TabIndex = 19;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(Aki_Tanaka_C968.Inventory);
            // 
            // FormMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 489);
            this.Controls.Add(this.DatagridProd);
            this.Controls.Add(this.DatagridParts);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDelProd);
            this.Controls.Add(this.BtnModProd);
            this.Controls.Add(this.BtnAddProd);
            this.Controls.Add(this.BtnDelParts);
            this.Controls.Add(this.BtnModParts);
            this.Controls.Add(this.BtnAddParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputSearchProd);
            this.Controls.Add(this.BtnSearchProd);
            this.Controls.Add(this.InputSearchParts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSearchParts);
            this.Name = "FormMainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.FormMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearchParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputSearchParts;
        private System.Windows.Forms.TextBox InputSearchProd;
        private System.Windows.Forms.Button BtnSearchProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAddParts;
        private System.Windows.Forms.Button BtnModParts;
        private System.Windows.Forms.Button BtnDelParts;
        private System.Windows.Forms.Button BtnAddProd;
        private System.Windows.Forms.Button BtnModProd;
        private System.Windows.Forms.Button BtnDelProd;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView DatagridParts;
        private System.Windows.Forms.DataGridView DatagridProd;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
    }
}

