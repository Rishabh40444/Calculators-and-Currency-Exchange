namespace Calculators_and_Currency_Exchange
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lbllVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lbllVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(939, 556);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(4, 5);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(301, 546);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(318, 0);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.lblProductName.MaximumSize = new System.Drawing.Size(0, 26);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(617, 26);
            this.lblProductName.TabIndex = 19;
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // lbllVersion
            // 
            this.lbllVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbllVersion.Location = new System.Drawing.Point(318, 55);
            this.lbllVersion.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.lbllVersion.MaximumSize = new System.Drawing.Size(0, 26);
            this.lbllVersion.Name = "lbllVersion";
            this.lbllVersion.Size = new System.Drawing.Size(617, 26);
            this.lbllVersion.TabIndex = 0;
            this.lbllVersion.Text = "Version:";
            this.lbllVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbllVersion.Click += new System.EventHandler(this.lbllVersion_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Location = new System.Drawing.Point(318, 110);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.lblCopyright.MaximumSize = new System.Drawing.Size(0, 26);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(617, 26);
            this.lblCopyright.TabIndex = 21;
            this.lblCopyright.Text = "Copyright:";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCopyright.Click += new System.EventHandler(this.lblCopyright_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompanyName.Location = new System.Drawing.Point(318, 165);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.lblCompanyName.MaximumSize = new System.Drawing.Size(0, 26);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(617, 26);
            this.lblCompanyName.TabIndex = 22;
            this.lblCompanyName.Text = "Company Name:";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(318, 225);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(9, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(617, 268);
            this.txtDescription.TabIndex = 23;
            this.txtDescription.TabStop = false;
            this.txtDescription.Text = "Description";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(823, 517);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(112, 34);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // frmAbout
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 584);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About This Application";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lbllVersion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button okButton;
    }
}
