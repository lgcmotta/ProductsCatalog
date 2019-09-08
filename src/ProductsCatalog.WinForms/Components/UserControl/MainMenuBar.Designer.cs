namespace ProductsCatalog.WinForms.Components.UserControl
{
    partial class MainMenuBar
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
            this.allProductsBtn = new System.Windows.Forms.Button();
            this.configBtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.allProductsBtn, 0, 0);
            this.mainPanel.Controls.Add(this.configBtn, 0, 1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 4;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.mainPanel.Size = new System.Drawing.Size(209, 484);
            this.mainPanel.TabIndex = 0;
            // 
            // allProductsBtn
            // 
            this.allProductsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allProductsBtn.Enabled = false;
            this.allProductsBtn.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Bold);
            this.allProductsBtn.Location = new System.Drawing.Point(3, 3);
            this.allProductsBtn.Name = "allProductsBtn";
            this.allProductsBtn.Size = new System.Drawing.Size(203, 66);
            this.allProductsBtn.TabIndex = 1;
            this.allProductsBtn.Text = "Products";
            this.allProductsBtn.UseVisualStyleBackColor = true;
            // 
            // configBtn
            // 
            this.configBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configBtn.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Bold);
            this.configBtn.Location = new System.Drawing.Point(3, 75);
            this.configBtn.Name = "configBtn";
            this.configBtn.Size = new System.Drawing.Size(203, 66);
            this.configBtn.TabIndex = 2;
            this.configBtn.Text = "Configuration";
            this.configBtn.UseVisualStyleBackColor = true;
            // 
            // MainMenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "MainMenuBar";
            this.Size = new System.Drawing.Size(209, 484);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Button allProductsBtn;
        private System.Windows.Forms.Button configBtn;
    }
}
