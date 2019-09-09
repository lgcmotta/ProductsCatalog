using Autofac;
using ProductsCatalog.WinForms.Components;
using ProductsCatalog.WinForms.Components.UserControl;
using ProductsCatalog.WinForms.ViewModel.Interfaces;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsCatalogForm));
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.crudContainer = new ProductsCatalog.WinForms.Components.CrudContainer();
            this.viewerContainer = new ProductsCatalog.WinForms.Components.ViewerContainer(_container.Resolve<IProductsViewModel>()
                , _container.Resolve<ILogger<ViewerContainer>>());
            this.configurationCrud = new ProductsCatalog.WinForms.Components.UserControl.ConfigurationCrud(_container.Resolve<IConfigurationViewModel>()
                ,_container.Resolve<ILogger<ConfigurationCrud>>());
            this.mainMenuBar = new ProductsCatalog.WinForms.Components.UserControl.MainMenuBar();
            this.mainPanel.SuspendLayout();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.79732F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.20267F));
            this.mainPanel.Controls.Add(this.containerPanel, 1, 0);
            this.mainPanel.Controls.Add(this.mainMenuBar, 0, 1);
            this.mainPanel.Controls.Add(this.logoBox, 0, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 2;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.94242F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.05758F));
            this.mainPanel.Size = new System.Drawing.Size(1046, 521);
            this.mainPanel.TabIndex = 0;
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.configurationCrud);
            this.containerPanel.Controls.Add(this.crudContainer);
            this.containerPanel.Controls.Add(this.viewerContainer);
            this.containerPanel.Location = new System.Drawing.Point(230, 3);
            this.containerPanel.Name = "containerPanel";
            this.mainPanel.SetRowSpan(this.containerPanel, 2);
            this.containerPanel.Size = new System.Drawing.Size(812, 515);
            this.containerPanel.TabIndex = 1;
            // 
            // logoBox
            // 
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoBox.Image = global::ProductsCatalog.WinForms.Properties.Resources.ProductsCatalogsNoBg;
            this.logoBox.Location = new System.Drawing.Point(3, 3);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(221, 150);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 2;
            this.logoBox.TabStop = false;
            // 
            // crudContainer
            // 
            this.crudContainer.BackColor = System.Drawing.Color.Transparent;
            this.crudContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudContainer.Location = new System.Drawing.Point(0, 0);
            this.crudContainer.Name = "crudContainer";
            this.crudContainer.Size = new System.Drawing.Size(812, 515);
            this.crudContainer.TabIndex = 3;
            // 
            // viewerContainer
            // 
            this.viewerContainer.BackColor = System.Drawing.Color.Transparent;
            this.viewerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerContainer.Location = new System.Drawing.Point(0, 0);
            this.viewerContainer.Name = "viewerContainer";
            this.viewerContainer.Size = new System.Drawing.Size(812, 515);
            this.viewerContainer.TabIndex = 0;
            // 
            // configurationCrud
            // 
            this.configurationCrud.BackColor = System.Drawing.Color.Transparent;
            this.configurationCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configurationCrud.Location = new System.Drawing.Point(0, 0);
            this.configurationCrud.Name = "configurationCrud";
            this.configurationCrud.Size = new System.Drawing.Size(812, 515);
            this.configurationCrud.TabIndex = 2;
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuBar.Location = new System.Drawing.Point(3, 159);
            this.mainMenuBar.Name = "mainMenuBar";
            this.mainMenuBar.Size = new System.Drawing.Size(221, 359);
            this.mainMenuBar.TabIndex = 0;
            // 
            // ProductsCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1046, 521);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1062, 560);
            this.Name = "ProductsCatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Catalog";
            this.mainPanel.ResumeLayout(false);
            this.containerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private MainMenuBar mainMenuBar;
        private System.Windows.Forms.Panel containerPanel;
        private ViewerContainer viewerContainer;
        private ConfigurationCrud configurationCrud;
        private CrudContainer crudContainer;
        private System.Windows.Forms.PictureBox logoBox;
    }
}

