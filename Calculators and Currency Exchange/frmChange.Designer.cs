namespace Calculators_and_Currency_Exchange
{
    partial class frmChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplay1 = new System.Windows.Forms.Label();
            this.lblDisplay2 = new System.Windows.Forms.Label();
            this.lblDisplay3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUREAU-EXCHANGE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplay1
            // 
            this.lblDisplay1.BackColor = System.Drawing.Color.Gray;
            this.lblDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay1.Location = new System.Drawing.Point(530, 229);
            this.lblDisplay1.Name = "lblDisplay1";
            this.lblDisplay1.Size = new System.Drawing.Size(459, 55);
            this.lblDisplay1.TabIndex = 1;
            this.lblDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplay2
            // 
            this.lblDisplay2.BackColor = System.Drawing.Color.Gray;
            this.lblDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay2.Location = new System.Drawing.Point(530, 317);
            this.lblDisplay2.Name = "lblDisplay2";
            this.lblDisplay2.Size = new System.Drawing.Size(459, 55);
            this.lblDisplay2.TabIndex = 2;
            this.lblDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplay3
            // 
            this.lblDisplay3.BackColor = System.Drawing.Color.Gray;
            this.lblDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay3.Location = new System.Drawing.Point(480, 434);
            this.lblDisplay3.Name = "lblDisplay3";
            this.lblDisplay3.Size = new System.Drawing.Size(152, 41);
            this.lblDisplay3.TabIndex = 5;
            this.lblDisplay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(480, 497);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(152, 40);
            this.txtAmount.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Gray;
            this.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConvert.FlatAppearance.BorderSize = 5;
            this.btnConvert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.Black;
            this.btnConvert.Location = new System.Drawing.Point(775, 434);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(214, 51);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(775, 491);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(214, 51);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Gray;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Black;
            this.btnQuit.Location = new System.Drawing.Point(775, 548);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(214, 51);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // cboCountry
            // 
            this.cboCountry.BackColor = System.Drawing.Color.White;
            this.cboCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(12, 167);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(340, 37);
            this.cboCountry.TabIndex = 10;
            this.cboCountry.Text = "Select Country";
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 194);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion type";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(53, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(357, 43);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(53, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(336, 39);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 683);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(310, 41);
            this.lblResult.TabIndex = 12;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 757);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblDisplay3);
            this.Controls.Add(this.lblDisplay2);
            this.Controls.Add(this.lblDisplay1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$ International Currency Exchange";
            this.Load += new System.EventHandler(this.frmChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplay1;
        private System.Windows.Forms.Label lblDisplay2;
        private System.Windows.Forms.Label lblDisplay3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblResult;
    }
}