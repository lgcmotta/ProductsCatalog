namespace ProductsCatalog.WinForms.UserControl
{
    partial class ViewerButtonBar
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
            this.removeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 4;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.Controls.Add(this.refreshBtn, 3, 0);
            this.mainPanel.Controls.Add(this.editBtn, 2, 0);
            this.mainPanel.Controls.Add(this.removeBtn, 1, 0);
            this.mainPanel.Controls.Add(this.addBtn, 0, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Size = new System.Drawing.Size(796, 84);
            this.mainPanel.TabIndex = 0;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.LightGray;
            this.removeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.removeBtn.Location = new System.Drawing.Point(219, 20);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(20);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(159, 44);
            this.removeBtn.TabIndex = 0;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.LightGray;
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.editBtn.Location = new System.Drawing.Point(418, 20);
            this.editBtn.Margin = new System.Windows.Forms.Padding(20);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(159, 44);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.LightGray;
            this.refreshBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.refreshBtn.Location = new System.Drawing.Point(617, 20);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(20);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(159, 44);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.LightGray;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.addBtn.Location = new System.Drawing.Point(20, 20);
            this.addBtn.Margin = new System.Windows.Forms.Padding(20);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(159, 44);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "New Product";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // ViewerButtonBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "ViewerButtonBar";
            this.Size = new System.Drawing.Size(796, 84);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button addBtn;
    }
}
