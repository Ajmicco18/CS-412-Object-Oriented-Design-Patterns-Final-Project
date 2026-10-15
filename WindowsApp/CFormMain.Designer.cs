namespace WindowsApp
{
    partial class CFormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuMasterDetail = new ToolStripMenuItem();
            mnuBanksAndBankAccts = new ToolStripMenuItem();
            tablesToolStripMenuItem = new ToolStripMenuItem();
            mnuCountries = new ToolStripMenuItem();
            mnuSuppliers = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuHighlight;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuMasterDetail, tablesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10);
            menuStrip1.Size = new Size(1040, 49);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuMasterDetail
            // 
            mnuMasterDetail.BackColor = Color.LightGray;
            mnuMasterDetail.DropDownItems.AddRange(new ToolStripItem[] { mnuBanksAndBankAccts });
            mnuMasterDetail.ForeColor = SystemColors.MenuHighlight;
            mnuMasterDetail.Name = "mnuMasterDetail";
            mnuMasterDetail.Size = new Size(82, 29);
            mnuMasterDetail.Text = "Master";
            // 
            // mnuBanksAndBankAccts
            // 
            mnuBanksAndBankAccts.BackColor = Color.LightGray;
            mnuBanksAndBankAccts.ForeColor = SystemColors.MenuHighlight;
            mnuBanksAndBankAccts.Name = "mnuBanksAndBankAccts";
            mnuBanksAndBankAccts.Size = new Size(316, 34);
            mnuBanksAndBankAccts.Text = "Banks and Bank Accounts";
            mnuBanksAndBankAccts.Click += DoOnAnyCommand;
            // 
            // tablesToolStripMenuItem
            // 
            tablesToolStripMenuItem.BackColor = Color.LightGray;
            tablesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuCountries, mnuSuppliers });
            tablesToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            tablesToolStripMenuItem.Size = new Size(76, 29);
            tablesToolStripMenuItem.Text = "Tables";
            // 
            // mnuCountries
            // 
            mnuCountries.BackColor = Color.LightGray;
            mnuCountries.ForeColor = SystemColors.MenuHighlight;
            mnuCountries.Name = "mnuCountries";
            mnuCountries.Size = new Size(189, 34);
            mnuCountries.Text = "Countries";
            mnuCountries.Click += DoOnAnyCommand;
            // 
            // mnuSuppliers
            // 
            mnuSuppliers.BackColor = Color.LightGray;
            mnuSuppliers.ForeColor = SystemColors.MenuHighlight;
            mnuSuppliers.Name = "mnuSuppliers";
            mnuSuppliers.Size = new Size(189, 34);
            mnuSuppliers.Text = "Suppliers";
            mnuSuppliers.Click += DoOnAnyCommand;
            // 
            // CFormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1040, 486);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Transparent;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CFormMain";
            Text = "Bank Accounts";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuMasterDetail;
        private ToolStripMenuItem mnuBanksAndBankAccts;
        private ToolStripMenuItem tablesToolStripMenuItem;
        private ToolStripMenuItem mnuCountries;
        private ToolStripMenuItem mnuSuppliers;
    }
}
