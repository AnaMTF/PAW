namespace Seminar6
{
    partial class UpdateProductForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.netPriceLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.netPriceTextBox = new System.Windows.Forms.TextBox();
            this.isFoodItemCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(356, 246);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 35);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(18, 14);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(18, 60);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // netPriceLabel
            // 
            this.netPriceLabel.AutoSize = true;
            this.netPriceLabel.Location = new System.Drawing.Point(18, 211);
            this.netPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.netPriceLabel.Name = "netPriceLabel";
            this.netPriceLabel.Size = new System.Drawing.Size(72, 20);
            this.netPriceLabel.TabIndex = 3;
            this.netPriceLabel.Text = "Net price";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(141, 9);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(446, 26);
            this.nameTextBox.TabIndex = 5;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(141, 49);
            this.descriptionRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(446, 146);
            this.descriptionRichTextBox.TabIndex = 6;
            this.descriptionRichTextBox.Text = "";
            // 
            // netPriceTextBox
            // 
            this.netPriceTextBox.Location = new System.Drawing.Point(141, 206);
            this.netPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.netPriceTextBox.Name = "netPriceTextBox";
            this.netPriceTextBox.Size = new System.Drawing.Size(446, 26);
            this.netPriceTextBox.TabIndex = 7;
            // 
            // isFoodItemCheckBox
            // 
            this.isFoodItemCheckBox.AutoSize = true;
            this.isFoodItemCheckBox.Location = new System.Drawing.Point(22, 246);
            this.isFoodItemCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.isFoodItemCheckBox.Name = "isFoodItemCheckBox";
            this.isFoodItemCheckBox.Size = new System.Drawing.Size(127, 24);
            this.isFoodItemCheckBox.TabIndex = 8;
            this.isFoodItemCheckBox.Text = "Is food item?";
            this.isFoodItemCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(477, 246);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 35);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 303);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.isFoodItemCheckBox);
            this.Controls.Add(this.netPriceTextBox);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.netPriceLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.saveButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateProductForm";
            this.Text = "UpdateProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label netPriceLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.TextBox netPriceTextBox;
        private System.Windows.Forms.CheckBox isFoodItemCheckBox;
        private System.Windows.Forms.Button cancelButton;
    }
}

