namespace Aki_Tanaka_C968
{
    partial class FormModPart
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
            this.LabelAddPart = new System.Windows.Forms.Label();
            this.InputInHouse = new System.Windows.Forms.RadioButton();
            this.InputOutsourced = new System.Windows.Forms.RadioButton();
            this.TextboxPartId = new System.Windows.Forms.TextBox();
            this.InputPartMax = new System.Windows.Forms.TextBox();
            this.InputPartMachineCo = new System.Windows.Forms.TextBox();
            this.InputPartPrice = new System.Windows.Forms.TextBox();
            this.InputPartInventory = new System.Windows.Forms.TextBox();
            this.InputPartName = new System.Windows.Forms.TextBox();
            this.InputPartMin = new System.Windows.Forms.TextBox();
            this.BtnAddParts = new System.Windows.Forms.Button();
            this.BtnModPartCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelMachineId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelAddPart
            // 
            this.LabelAddPart.AutoSize = true;
            this.LabelAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddPart.Location = new System.Drawing.Point(12, 9);
            this.LabelAddPart.Name = "LabelAddPart";
            this.LabelAddPart.Size = new System.Drawing.Size(121, 25);
            this.LabelAddPart.TabIndex = 0;
            this.LabelAddPart.Text = "Modify Part";
            // 
            // InputInHouse
            // 
            this.InputInHouse.AutoSize = true;
            this.InputInHouse.Location = new System.Drawing.Point(143, 40);
            this.InputInHouse.Name = "InputInHouse";
            this.InputInHouse.Size = new System.Drawing.Size(68, 17);
            this.InputInHouse.TabIndex = 1;
            this.InputInHouse.TabStop = true;
            this.InputInHouse.Text = "In-House";
            this.InputInHouse.UseVisualStyleBackColor = true;
            this.InputInHouse.CheckedChanged += new System.EventHandler(this.InputInHouse_CheckedChanged);
            // 
            // InputOutsourced
            // 
            this.InputOutsourced.AutoSize = true;
            this.InputOutsourced.Location = new System.Drawing.Point(237, 39);
            this.InputOutsourced.Name = "InputOutsourced";
            this.InputOutsourced.Size = new System.Drawing.Size(80, 17);
            this.InputOutsourced.TabIndex = 2;
            this.InputOutsourced.TabStop = true;
            this.InputOutsourced.Text = "Outsourced";
            this.InputOutsourced.UseVisualStyleBackColor = true;
            this.InputOutsourced.CheckedChanged += new System.EventHandler(this.InputOutsourced_CheckedChanged);
            // 
            // TextboxPartId
            // 
            this.TextboxPartId.Location = new System.Drawing.Point(137, 71);
            this.TextboxPartId.Name = "TextboxPartId";
            this.TextboxPartId.ReadOnly = true;
            this.TextboxPartId.Size = new System.Drawing.Size(158, 20);
            this.TextboxPartId.TabIndex = 3;
            // 
            // InputPartMax
            // 
            this.InputPartMax.Location = new System.Drawing.Point(137, 203);
            this.InputPartMax.Name = "InputPartMax";
            this.InputPartMax.Size = new System.Drawing.Size(101, 20);
            this.InputPartMax.TabIndex = 7;
            // 
            // InputPartMachineCo
            // 
            this.InputPartMachineCo.Location = new System.Drawing.Point(137, 235);
            this.InputPartMachineCo.Name = "InputPartMachineCo";
            this.InputPartMachineCo.Size = new System.Drawing.Size(158, 20);
            this.InputPartMachineCo.TabIndex = 9;
            this.InputPartMachineCo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputPartMachineCo_KeyPress);
            // 
            // InputPartPrice
            // 
            this.InputPartPrice.Location = new System.Drawing.Point(137, 171);
            this.InputPartPrice.Name = "InputPartPrice";
            this.InputPartPrice.Size = new System.Drawing.Size(158, 20);
            this.InputPartPrice.TabIndex = 6;
            this.InputPartPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputPartPrice_KeyPress);
            // 
            // InputPartInventory
            // 
            this.InputPartInventory.Location = new System.Drawing.Point(137, 139);
            this.InputPartInventory.Name = "InputPartInventory";
            this.InputPartInventory.Size = new System.Drawing.Size(158, 20);
            this.InputPartInventory.TabIndex = 5;
            this.InputPartInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputPartInventory_KeyPress);
            // 
            // InputPartName
            // 
            this.InputPartName.Location = new System.Drawing.Point(137, 107);
            this.InputPartName.Name = "InputPartName";
            this.InputPartName.Size = new System.Drawing.Size(158, 20);
            this.InputPartName.TabIndex = 4;
            // 
            // InputPartMin
            // 
            this.InputPartMin.Location = new System.Drawing.Point(307, 203);
            this.InputPartMin.Name = "InputPartMin";
            this.InputPartMin.Size = new System.Drawing.Size(101, 20);
            this.InputPartMin.TabIndex = 8;
            this.InputPartMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputPartMin_KeyPress);
            // 
            // BtnAddParts
            // 
            this.BtnAddParts.Location = new System.Drawing.Point(268, 274);
            this.BtnAddParts.Name = "BtnAddParts";
            this.BtnAddParts.Size = new System.Drawing.Size(69, 36);
            this.BtnAddParts.TabIndex = 12;
            this.BtnAddParts.Text = "Save";
            this.BtnAddParts.UseVisualStyleBackColor = true;
            this.BtnAddParts.Click += new System.EventHandler(this.BtnAddParts_Click);
            // 
            // BtnModPartCancel
            // 
            this.BtnModPartCancel.Location = new System.Drawing.Point(343, 274);
            this.BtnModPartCancel.Name = "BtnModPartCancel";
            this.BtnModPartCancel.Size = new System.Drawing.Size(69, 36);
            this.BtnModPartCancel.TabIndex = 13;
            this.BtnModPartCancel.Text = "Cancel";
            this.BtnModPartCancel.UseVisualStyleBackColor = true;
            this.BtnModPartCancel.Click += new System.EventHandler(this.BtnModPartCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Min";
            // 
            // LabelMachineId
            // 
            this.LabelMachineId.AutoSize = true;
            this.LabelMachineId.Location = new System.Drawing.Point(49, 235);
            this.LabelMachineId.Name = "LabelMachineId";
            this.LabelMachineId.Size = new System.Drawing.Size(62, 13);
            this.LabelMachineId.TabIndex = 16;
            this.LabelMachineId.Text = "Machine ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price / Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Inventory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Name";
            // 
            // FormModPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 331);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelMachineId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnModPartCancel);
            this.Controls.Add(this.BtnAddParts);
            this.Controls.Add(this.InputPartMin);
            this.Controls.Add(this.InputPartName);
            this.Controls.Add(this.InputPartInventory);
            this.Controls.Add(this.InputPartPrice);
            this.Controls.Add(this.InputPartMachineCo);
            this.Controls.Add(this.InputPartMax);
            this.Controls.Add(this.TextboxPartId);
            this.Controls.Add(this.InputOutsourced);
            this.Controls.Add(this.InputInHouse);
            this.Controls.Add(this.LabelAddPart);
            this.Name = "FormModPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAddPart;
        private System.Windows.Forms.RadioButton InputInHouse;
        private System.Windows.Forms.RadioButton InputOutsourced;
        private System.Windows.Forms.TextBox TextboxPartId;
        private System.Windows.Forms.TextBox InputPartMax;
        private System.Windows.Forms.TextBox InputPartMachineCo;
        private System.Windows.Forms.TextBox InputPartPrice;
        private System.Windows.Forms.TextBox InputPartInventory;
        private System.Windows.Forms.TextBox InputPartName;
        private System.Windows.Forms.TextBox InputPartMin;
        private System.Windows.Forms.Button BtnAddParts;
        private System.Windows.Forms.Button BtnModPartCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelMachineId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}