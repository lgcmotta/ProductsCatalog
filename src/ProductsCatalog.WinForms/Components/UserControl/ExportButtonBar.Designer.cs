namespace ProductsCatalog.WinForms.Components.UserControl
{
    partial class ExportButtonBar
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
            this.formatsBox = new System.Windows.Forms.GroupBox();
            this.fileFormatsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.xmlButton = new System.Windows.Forms.RadioButton();
            this.jsonButton = new System.Windows.Forms.RadioButton();
            this.exportBtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.formatsBox.SuspendLayout();
            this.fileFormatsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.64286F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.35714F));
            this.mainPanel.Controls.Add(this.formatsBox, 0, 0);
            this.mainPanel.Controls.Add(this.exportBtn, 1, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(504, 84);
            this.mainPanel.TabIndex = 0;
            // 
            // formatsBox
            // 
            this.formatsBox.Controls.Add(this.fileFormatsPanel);
            this.formatsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formatsBox.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.formatsBox.Location = new System.Drawing.Point(3, 3);
            this.formatsBox.Name = "formatsBox";
            this.formatsBox.Size = new System.Drawing.Size(219, 78);
            this.formatsBox.TabIndex = 0;
            this.formatsBox.TabStop = false;
            this.formatsBox.Text = "File Formats";
            // 
            // fileFormatsPanel
            // 
            this.fileFormatsPanel.ColumnCount = 2;
            this.fileFormatsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fileFormatsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fileFormatsPanel.Controls.Add(this.xmlButton, 1, 0);
            this.fileFormatsPanel.Controls.Add(this.jsonButton, 0, 0);
            this.fileFormatsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileFormatsPanel.Location = new System.Drawing.Point(3, 28);
            this.fileFormatsPanel.Name = "fileFormatsPanel";
            this.fileFormatsPanel.RowCount = 1;
            this.fileFormatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fileFormatsPanel.Size = new System.Drawing.Size(213, 47);
            this.fileFormatsPanel.TabIndex = 0;
            // 
            // xmlButton
            // 
            this.xmlButton.AutoSize = true;
            this.xmlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlButton.Location = new System.Drawing.Point(109, 3);
            this.xmlButton.Name = "xmlButton";
            this.xmlButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.xmlButton.Size = new System.Drawing.Size(101, 41);
            this.xmlButton.TabIndex = 1;
            this.xmlButton.TabStop = true;
            this.xmlButton.Text = "XML";
            this.xmlButton.UseVisualStyleBackColor = true;
            // 
            // jsonButton
            // 
            this.jsonButton.AutoSize = true;
            this.jsonButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonButton.Location = new System.Drawing.Point(3, 3);
            this.jsonButton.Name = "jsonButton";
            this.jsonButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.jsonButton.Size = new System.Drawing.Size(100, 41);
            this.jsonButton.TabIndex = 0;
            this.jsonButton.TabStop = true;
            this.jsonButton.Text = "JSON";
            this.jsonButton.UseVisualStyleBackColor = true;
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.exportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold);
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.Location = new System.Drawing.Point(255, 20);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(219, 44);
            this.exportBtn.TabIndex = 1;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            // 
            // ExportButtonBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainPanel);
            this.Name = "ExportButtonBar";
            this.Size = new System.Drawing.Size(504, 84);
            this.mainPanel.ResumeLayout(false);
            this.formatsBox.ResumeLayout(false);
            this.fileFormatsPanel.ResumeLayout(false);
            this.fileFormatsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.GroupBox formatsBox;
        private System.Windows.Forms.TableLayoutPanel fileFormatsPanel;
        private System.Windows.Forms.RadioButton xmlButton;
        private System.Windows.Forms.RadioButton jsonButton;
        private System.Windows.Forms.Button exportBtn;
    }
}
