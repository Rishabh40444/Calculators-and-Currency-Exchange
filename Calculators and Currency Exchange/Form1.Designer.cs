namespace Calculators_and_Currency_Exchange
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrograms = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalcuators = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScientific = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBureau = new System.Windows.Forms.ToolStripMenuItem();
            this.menulocal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOnline = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserManual = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stCalcbtn = new System.Windows.Forms.ToolStripButton();
            this.sciCalcbtn = new System.Windows.Forms.ToolStripButton();
            this.CurrExchangeINT = new System.Windows.Forms.ToolStripButton();
            this.CurrXchangeOnline = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrograms,
            this.menuView,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrograms
            // 
            this.menuPrograms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCalcuators,
            this.menuBureau,
            this.menuQuit});
            this.menuPrograms.Name = "menuPrograms";
            this.menuPrograms.Size = new System.Drawing.Size(105, 29);
            this.menuPrograms.Text = "Programs";
            // 
            // menuCalcuators
            // 
            this.menuCalcuators.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStandard,
            this.menuScientific});
            this.menuCalcuators.Name = "menuCalcuators";
            this.menuCalcuators.Size = new System.Drawing.Size(284, 34);
            this.menuCalcuators.Text = "Calculators";
            // 
            // menuStandard
            // 
            this.menuStandard.Name = "menuStandard";
            this.menuStandard.Size = new System.Drawing.Size(248, 34);
            this.menuStandard.Text = "Standard Version";
            this.menuStandard.Click += new System.EventHandler(this.menuStandard_Click);
            // 
            // menuScientific
            // 
            this.menuScientific.Name = "menuScientific";
            this.menuScientific.Size = new System.Drawing.Size(248, 34);
            this.menuScientific.Text = "Scientific version";
            this.menuScientific.Click += new System.EventHandler(this.menuScientific_Click);
            // 
            // menuBureau
            // 
            this.menuBureau.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menulocal,
            this.menuOnline});
            this.menuBureau.Name = "menuBureau";
            this.menuBureau.Size = new System.Drawing.Size(284, 34);
            this.menuBureau.Text = "Bureau Exchange";
            // 
            // menulocal
            // 
            this.menulocal.Name = "menulocal";
            this.menulocal.Size = new System.Drawing.Size(170, 34);
            this.menulocal.Text = "Local ";
            this.menulocal.Click += new System.EventHandler(this.menulocal_Click);
            // 
            // menuOnline
            // 
            this.menuOnline.Enabled = false;
            this.menuOnline.Name = "menuOnline";
            this.menuOnline.Size = new System.Drawing.Size(170, 34);
            this.menuOnline.Text = "Online ";
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuQuit.Size = new System.Drawing.Size(284, 34);
            this.menuQuit.Text = "Quit Program";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarMnuItem,
            this.statusMnuItem});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(65, 29);
            this.menuView.Text = "View";
            // 
            // toolbarMnuItem
            // 
            this.toolbarMnuItem.Checked = true;
            this.toolbarMnuItem.CheckOnClick = true;
            this.toolbarMnuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolbarMnuItem.Name = "toolbarMnuItem";
            this.toolbarMnuItem.Size = new System.Drawing.Size(192, 34);
            this.toolbarMnuItem.Text = "Toolbar";
            this.toolbarMnuItem.Click += new System.EventHandler(this.toolbarMnuItem_Click);
            // 
            // statusMnuItem
            // 
            this.statusMnuItem.Checked = true;
            this.statusMnuItem.CheckOnClick = true;
            this.statusMnuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusMnuItem.Name = "statusMnuItem";
            this.statusMnuItem.Size = new System.Drawing.Size(192, 34);
            this.statusMnuItem.Text = "Status Bar";
            this.statusMnuItem.Click += new System.EventHandler(this.statusMnuItem_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout,
            this.menuUserManual});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 29);
            this.menuHelp.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(212, 34);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuUserManual
            // 
            this.menuUserManual.Name = "menuUserManual";
            this.menuUserManual.Size = new System.Drawing.Size(212, 34);
            this.menuUserManual.Text = "User Manual";
            this.menuUserManual.Click += new System.EventHandler(this.menuUserManual_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gray;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stCalcbtn,
            this.sciCalcbtn,
            this.CurrExchangeINT,
            this.CurrXchangeOnline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // stCalcbtn
            // 
            this.stCalcbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stCalcbtn.Image = ((System.Drawing.Image)(resources.GetObject("stCalcbtn.Image")));
            this.stCalcbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stCalcbtn.Name = "stCalcbtn";
            this.stCalcbtn.Size = new System.Drawing.Size(34, 28);
            this.stCalcbtn.Text = "Standard";
            this.stCalcbtn.Click += new System.EventHandler(this.stCalcbtn_Click);
            // 
            // sciCalcbtn
            // 
            this.sciCalcbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sciCalcbtn.Image = ((System.Drawing.Image)(resources.GetObject("sciCalcbtn.Image")));
            this.sciCalcbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sciCalcbtn.Name = "sciCalcbtn";
            this.sciCalcbtn.Size = new System.Drawing.Size(34, 28);
            this.sciCalcbtn.Text = "Scientific";
            this.sciCalcbtn.Click += new System.EventHandler(this.sciCalcbtn_Click);
            // 
            // CurrExchangeINT
            // 
            this.CurrExchangeINT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CurrExchangeINT.Image = ((System.Drawing.Image)(resources.GetObject("CurrExchangeINT.Image")));
            this.CurrExchangeINT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CurrExchangeINT.Name = "CurrExchangeINT";
            this.CurrExchangeINT.Size = new System.Drawing.Size(34, 28);
            this.CurrExchangeINT.Text = "Currency Exchange International";
            this.CurrExchangeINT.Click += new System.EventHandler(this.CurrExchangeINT_Click);
            // 
            // CurrXchangeOnline
            // 
            this.CurrXchangeOnline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CurrXchangeOnline.Image = ((System.Drawing.Image)(resources.GetObject("CurrXchangeOnline.Image")));
            this.CurrXchangeOnline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CurrXchangeOnline.Name = "CurrXchangeOnline";
            this.CurrXchangeOnline.Size = new System.Drawing.Size(34, 28);
            this.CurrXchangeOnline.Text = "Currency Exchange Online";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "College institute Teccart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrograms;
        private System.Windows.Forms.ToolStripMenuItem menuCalcuators;
        private System.Windows.Forms.ToolStripMenuItem menuStandard;
        private System.Windows.Forms.ToolStripMenuItem menuScientific;
        private System.Windows.Forms.ToolStripMenuItem menuBureau;
        private System.Windows.Forms.ToolStripMenuItem menulocal;
        private System.Windows.Forms.ToolStripMenuItem menuOnline;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem toolbarMnuItem;
        private System.Windows.Forms.ToolStripMenuItem statusMnuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuUserManual;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stCalcbtn;
        private System.Windows.Forms.ToolStripButton sciCalcbtn;
        private System.Windows.Forms.ToolStripButton CurrExchangeINT;
        private System.Windows.Forms.ToolStripButton CurrXchangeOnline;
    }
}

