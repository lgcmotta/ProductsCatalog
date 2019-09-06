﻿namespace ProductsCatalog.WinForms.Containers
{
    partial class ViewerContainer
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
            this.viewerButtonBar1 = new ProductsCatalog.WinForms.UserControl.ViewerButtonBar();
            this.productsGridViewer1 = new ProductsCatalog.WinForms.UserControl.ProductsGridViewer();
            this.exportButtonBar = new ProductsCatalog.WinForms.UserControl.ExportButtonBar();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.viewerButtonBar1, 0, 2);
            this.mainPanel.Controls.Add(this.productsGridViewer1, 0, 1);
            this.mainPanel.Controls.Add(this.exportButtonBar, 0, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 3;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.98455F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.1673F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.01141F));
            this.mainPanel.Size = new System.Drawing.Size(780, 526);
            this.mainPanel.TabIndex = 0;
            // 
            // viewerButtonBar1
            // 
            this.viewerButtonBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerButtonBar1.Location = new System.Drawing.Point(3, 428);
            this.viewerButtonBar1.Name = "viewerButtonBar1";
            this.viewerButtonBar1.Size = new System.Drawing.Size(774, 95);
            this.viewerButtonBar1.TabIndex = 1;
            // 
            // productsGridViewer1
            // 
            this.productsGridViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsGridViewer1.Location = new System.Drawing.Point(5, 102);
            this.productsGridViewer1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.productsGridViewer1.Name = "productsGridViewer1";
            this.productsGridViewer1.Size = new System.Drawing.Size(770, 320);
            this.productsGridViewer1.TabIndex = 2;
            // 
            // exportButtonBar
            // 
            this.exportButtonBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportButtonBar.Location = new System.Drawing.Point(3, 3);
            this.exportButtonBar.Name = "exportButtonBar";
            this.exportButtonBar.Size = new System.Drawing.Size(774, 93);
            this.exportButtonBar.TabIndex = 3;
            // 
            // ViewerContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "ViewerContainer";
            this.Size = new System.Drawing.Size(780, 526);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private UserControl.ViewerButtonBar viewerButtonBar1;
        private UserControl.ProductsGridViewer productsGridViewer1;
        private UserControl.ExportButtonBar exportButtonBar;
    }
}
