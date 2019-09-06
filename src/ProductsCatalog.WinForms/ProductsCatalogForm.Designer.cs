namespace ProductsCatalog.WinForms
{
    partial class ProductsCatalogForm
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
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.mainMenuBar = new ProductsCatalog.WinForms.UserControl.MainMenuBar();
            this.crudContainer = new ProductsCatalog.WinForms.Containers.CrudContainer();
            this.viewerContainer = new ProductsCatalog.WinForms.Containers.ViewerContainer();
            this.configurationCrud = new ProductsCatalog.WinForms.UserControl.ConfigurationCrud();
            this.mainPanel.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.625F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.375F));
            this.mainPanel.Controls.Add(this.mainMenuBar, 0, 0);
            this.mainPanel.Controls.Add(this.containerPanel, 1, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(740, 521);
            this.mainPanel.TabIndex = 0;
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.configurationCrud);
            this.containerPanel.Controls.Add(this.crudContainer);
            this.containerPanel.Controls.Add(this.viewerContainer);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(200, 3);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(537, 515);
            this.containerPanel.TabIndex = 1;
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuBar.Location = new System.Drawing.Point(3, 3);
            this.mainMenuBar.Name = "mainMenuBar";
            this.mainMenuBar.Size = new System.Drawing.Size(191, 515);
            this.mainMenuBar.TabIndex = 0;
            // 
            // crudContainer
            // 
            this.crudContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudContainer.Location = new System.Drawing.Point(0, 0);
            this.crudContainer.Name = "crudContainer";
            this.crudContainer.Size = new System.Drawing.Size(537, 515);
            this.crudContainer.TabIndex = 1;
            // 
            // viewerContainer
            // 
            this.viewerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerContainer.Location = new System.Drawing.Point(0, 0);
            this.viewerContainer.Name = "viewerContainer";
            this.viewerContainer.Size = new System.Drawing.Size(537, 515);
            this.viewerContainer.TabIndex = 0;
            // 
            // configurationCrud
            // 
            this.configurationCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configurationCrud.Location = new System.Drawing.Point(0, 0);
            this.configurationCrud.Name = "configurationCrud";
            this.configurationCrud.Size = new System.Drawing.Size(537, 515);
            this.configurationCrud.TabIndex = 2;
            // 
            // ProductsCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 521);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(720, 560);
            this.Name = "ProductsCatalogForm";
            this.Text = "Products Catalog";
            this.mainPanel.ResumeLayout(false);
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private UserControl.MainMenuBar mainMenuBar;
        private System.Windows.Forms.Panel containerPanel;
        private Containers.ViewerContainer viewerContainer;
        private Containers.CrudContainer crudContainer;
        private UserControl.ConfigurationCrud configurationCrud;
    }
}

