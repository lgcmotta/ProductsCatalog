namespace ProductsCatalog.WinForms.UserControl
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
            this.jsonButton = new System.Windows.Forms.RadioButton();
            this.xmlButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
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
            this.mainPanel.Controls.Add(this.button1, 1, 0);
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
            this.formatsBox.Size = new System.Drawing.Size(218, 78);
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
            this.fileFormatsPanel.Size = new System.Drawing.Size(212, 47);
            this.fileFormatsPanel.TabIndex = 0;
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
            // xmlButton
            // 
            this.xmlButton.AutoSize = true;
            this.xmlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlButton.Location = new System.Drawing.Point(109, 3);
            this.xmlButton.Name = "xmlButton";
            this.xmlButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.xmlButton.Size = new System.Drawing.Size(100, 41);
            this.xmlButton.TabIndex = 1;
            this.xmlButton.TabStop = true;
            this.xmlButton.Text = "XML";
            this.xmlButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(254, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ExportButtonBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Button button1;
    }
}
