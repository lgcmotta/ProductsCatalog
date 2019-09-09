using ProductsCatalog.WinForms.Components.UserControl;

namespace ProductsCatalog.WinForms.Components
{
    partial class CrudContainer
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
            this.productCrud = new ProductsCatalog.WinForms.Components.UserControl.ProductCrud();
            this.crudButtonBar = new ProductsCatalog.WinForms.Components.UserControl.CrudButtonBar();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Controls.Add(this.productCrud, 0, 0);
            this.mainPanel.Controls.Add(this.crudButtonBar, 0, 1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 2;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.01805F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.98195F));
            this.mainPanel.Size = new System.Drawing.Size(446, 511);
            this.mainPanel.TabIndex = 0;
            // 
            // productCrud
            // 
            this.productCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(245)))));
            this.productCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productCrud.Location = new System.Drawing.Point(3, 3);
            this.productCrud.Name = "productCrud";
            this.productCrud.Size = new System.Drawing.Size(440, 428);
            this.productCrud.TabIndex = 0;
            // 
            // crudButtonBar
            // 
            this.crudButtonBar.BackColor = System.Drawing.Color.Transparent;
            this.crudButtonBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudButtonBar.Location = new System.Drawing.Point(3, 437);
            this.crudButtonBar.Name = "crudButtonBar";
            this.crudButtonBar.Size = new System.Drawing.Size(440, 71);
            this.crudButtonBar.TabIndex = 1;
            // 
            // CrudContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainPanel);
            this.Name = "CrudContainer";
            this.Size = new System.Drawing.Size(446, 511);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private UserControl.ProductCrud productCrud;
        private UserControl.CrudButtonBar crudButtonBar;
    }
}
