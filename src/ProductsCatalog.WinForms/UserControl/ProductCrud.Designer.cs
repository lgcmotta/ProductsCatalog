namespace ProductsCatalog.WinForms.UserControl
{
    partial class ProductCrud
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priceUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.nameTextBox, 0, 1);
            this.mainPanel.Controls.Add(this.nameLabel, 0, 0);
            this.mainPanel.Controls.Add(this.quantityLabel, 0, 6);
            this.mainPanel.Controls.Add(this.priceLabel, 0, 4);
            this.mainPanel.Controls.Add(this.descriptionLabel, 0, 2);
            this.mainPanel.Controls.Add(this.priceUpDown, 0, 5);
            this.mainPanel.Controls.Add(this.quantityUpDown, 0, 7);
            this.mainPanel.Controls.Add(this.descriptionTextBox, 0, 3);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 8;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.Size = new System.Drawing.Size(329, 429);
            this.mainPanel.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.nameTextBox.Location = new System.Drawing.Point(10, 45);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(309, 36);
            this.nameTextBox.TabIndex = 7;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.nameLabel.Size = new System.Drawing.Size(329, 42);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.quantityLabel.Location = new System.Drawing.Point(0, 318);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.quantityLabel.Size = new System.Drawing.Size(329, 42);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity:";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.priceLabel.Location = new System.Drawing.Point(0, 212);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.priceLabel.Size = new System.Drawing.Size(329, 42);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price:";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.descriptionLabel.Location = new System.Drawing.Point(0, 106);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.descriptionLabel.Size = new System.Drawing.Size(329, 42);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceUpDown
            // 
            this.priceUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceUpDown.DecimalPlaces = 2;
            this.priceUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceUpDown.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.priceUpDown.Location = new System.Drawing.Point(10, 257);
            this.priceUpDown.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.priceUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.priceUpDown.Name = "priceUpDown";
            this.priceUpDown.Size = new System.Drawing.Size(309, 39);
            this.priceUpDown.TabIndex = 4;
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityUpDown.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.quantityUpDown.Location = new System.Drawing.Point(10, 363);
            this.quantityUpDown.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.quantityUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(309, 39);
            this.quantityUpDown.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.descriptionTextBox.Location = new System.Drawing.Point(10, 151);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(309, 36);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // ProductCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "ProductCrud";
            this.Size = new System.Drawing.Size(329, 429);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.NumericUpDown priceUpDown;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}
