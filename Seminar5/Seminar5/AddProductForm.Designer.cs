namespace Seminar5
{
    partial class productNameForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.netPriceLabel = new System.Windows.Forms.Label();
            this.netPriceTextBox = new System.Windows.Forms.TextBox();
            this.isFoodItemCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(101, 28);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(262, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(469, 28);
            this.descriptionRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(269, 89);
            this.descriptionRichTextBox.TabIndex = 2;
            this.descriptionRichTextBox.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(390, 32);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // netPriceLabel
            // 
            this.netPriceLabel.AutoSize = true;
            this.netPriceLabel.Location = new System.Drawing.Point(25, 70);
            this.netPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.netPriceLabel.Name = "netPriceLabel";
            this.netPriceLabel.Size = new System.Drawing.Size(51, 13);
            this.netPriceLabel.TabIndex = 4;
            this.netPriceLabel.Text = "Net Price";
            // 
            // netPriceTextBox
            // 
            this.netPriceTextBox.Location = new System.Drawing.Point(101, 70);
            this.netPriceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.netPriceTextBox.Name = "netPriceTextBox";
            this.netPriceTextBox.Size = new System.Drawing.Size(262, 20);
            this.netPriceTextBox.TabIndex = 5;
            // 
            // isFoodItemCheckBox
            // 
            this.isFoodItemCheckBox.AutoSize = true;
            this.isFoodItemCheckBox.Location = new System.Drawing.Point(27, 107);
            this.isFoodItemCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.isFoodItemCheckBox.Name = "isFoodItemCheckBox";
            this.isFoodItemCheckBox.Size = new System.Drawing.Size(103, 17);
            this.isFoodItemCheckBox.TabIndex = 6;
            this.isFoodItemCheckBox.Text = "Is it a food item?";
            this.isFoodItemCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.Location = new System.Drawing.Point(469, 129);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 30);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product name";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(628, 129);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 27);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // productNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(751, 170);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.isFoodItemCheckBox);
            this.Controls.Add(this.netPriceTextBox);
            this.Controls.Add(this.netPriceLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "productNameForm";
            this.Text = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label netPriceLabel;
        private System.Windows.Forms.TextBox netPriceTextBox;
        private System.Windows.Forms.CheckBox isFoodItemCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
    }
}

