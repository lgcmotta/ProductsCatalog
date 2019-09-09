namespace ProductsCatalog.WinForms.Components.UserControl
{
    partial class ConfigurationCrud
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.hostLabel = new System.Windows.Forms.Label();
            this.crudButtonBar = new ProductsCatalog.WinForms.Components.UserControl.CrudButtonBar();
            this.portLabel = new System.Windows.Forms.Label();
            this.portUpDown = new System.Windows.Forms.NumericUpDown();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainPanel.Controls.Add(this.headerLabel, 0, 0);
            this.mainPanel.Controls.Add(this.hostTextBox, 0, 2);
            this.mainPanel.Controls.Add(this.hostLabel, 0, 1);
            this.mainPanel.Controls.Add(this.crudButtonBar, 0, 3);
            this.mainPanel.Controls.Add(this.portLabel, 1, 1);
            this.mainPanel.Controls.Add(this.portUpDown, 1, 2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 4;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.Size = new System.Drawing.Size(443, 400);
            this.mainPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.mainPanel.SetColumnSpan(this.headerLabel, 2);
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Bold);
            this.headerLabel.Location = new System.Drawing.Point(3, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.headerLabel.Size = new System.Drawing.Size(437, 80);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Configuration";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hostTextBox
            // 
            this.hostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hostTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostTextBox.Font = new System.Drawing.Font("Segoe UI Light", 22F);
            this.hostTextBox.Location = new System.Drawing.Point(10, 143);
            this.hostTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(267, 40);
            this.hostTextBox.TabIndex = 11;
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.hostLabel.Location = new System.Drawing.Point(0, 80);
            this.hostLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.hostLabel.Size = new System.Drawing.Size(287, 60);
            this.hostLabel.TabIndex = 8;
            this.hostLabel.Text = "Hostname:";
            this.hostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // crudButtonBar
            // 
            this.crudButtonBar.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.SetColumnSpan(this.crudButtonBar, 2);
            this.crudButtonBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudButtonBar.Location = new System.Drawing.Point(3, 323);
            this.crudButtonBar.Name = "crudButtonBar";
            this.crudButtonBar.Size = new System.Drawing.Size(437, 74);
            this.crudButtonBar.TabIndex = 13;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.portLabel.Location = new System.Drawing.Point(287, 80);
            this.portLabel.Margin = new System.Windows.Forms.Padding(0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.portLabel.Size = new System.Drawing.Size(156, 60);
            this.portLabel.TabIndex = 9;
            this.portLabel.Text = "Port:";
            this.portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // portUpDown
            // 
            this.portUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portUpDown.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.portUpDown.Location = new System.Drawing.Point(297, 143);
            this.portUpDown.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.portUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.portUpDown.Name = "portUpDown";
            this.portUpDown.Size = new System.Drawing.Size(136, 39);
            this.portUpDown.TabIndex = 12;
            // 
            // ConfigurationCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainPanel);
            this.Name = "ConfigurationCrud";
            this.Size = new System.Drawing.Size(443, 400);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.NumericUpDown portUpDown;
        private CrudButtonBar crudButtonBar;
    }
}
