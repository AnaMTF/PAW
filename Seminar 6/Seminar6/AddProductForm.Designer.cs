namespace Seminar6
{
    partial class AddProductForm
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
            this.saveButton.Location = new System.Drawing.Point(237, 160);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 39);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // netPriceLabel
            // 
            this.netPriceLabel.AutoSize = true;
            this.netPriceLabel.Location = new System.Drawing.Point(12, 137);
            this.netPriceLabel.Name = "netPriceLabel";
            this.netPriceLabel.Size = new System.Drawing.Size(72, 20);
            this.netPriceLabel.TabIndex = 3;
            this.netPriceLabel.Text = "Net price";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(94, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(299, 26);
            this.nameTextBox.TabIndex = 5;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(94, 32);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(299, 96);
            this.descriptionRichTextBox.TabIndex = 6;
            this.descriptionRichTextBox.Text = "";
            // 
            // netPriceTextBox
            // 
            this.netPriceTextBox.Location = new System.Drawing.Point(94, 134);
            this.netPriceTextBox.Name = "netPriceTextBox";
            this.netPriceTextBox.Size = new System.Drawing.Size(299, 26);
            this.netPriceTextBox.TabIndex = 7;
            // 
            // isFoodItemCheckBox
            // 
            this.isFoodItemCheckBox.AutoSize = true;
            this.isFoodItemCheckBox.Location = new System.Drawing.Point(15, 160);
            this.isFoodItemCheckBox.Name = "isFoodItemCheckBox";
            this.isFoodItemCheckBox.Size = new System.Drawing.Size(120, 24);
            this.isFoodItemCheckBox.TabIndex = 8;
            this.isFoodItemCheckBox.Text = "Is food item?";
            this.isFoodItemCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(318, 160);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 197);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.isFoodItemCheckBox);
            this.Controls.Add(this.netPriceTextBox);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.netPriceLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.saveButton);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
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

