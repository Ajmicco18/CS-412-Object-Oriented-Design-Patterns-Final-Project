namespace DataApplication.UX
{
    partial class CFormTemplateMaster
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
            tabPages = new TabControl();
            tabViewBrowser = new TabPage();
            pnlBrowserCommands = new Panel();
            btnDelete = new Button();
            btnNew = new Button();
            btnOpen = new Button();
            btnRefreshBrowser = new Button();
            pnlBrowser = new Panel();
            dgvBrowser = new DataGridView();
            tabViewEntity = new TabPage();
            pnlEntityCommands = new Panel();
            btnBackToBrowser = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnEntityDelete = new Button();
            btnEntityNew = new Button();
            btnEdit = new Button();
            pnlEntityView = new Panel();
            tabPages.SuspendLayout();
            tabViewBrowser.SuspendLayout();
            pnlBrowserCommands.SuspendLayout();
            pnlBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrowser).BeginInit();
            tabViewEntity.SuspendLayout();
            pnlEntityCommands.SuspendLayout();
            SuspendLayout();
            // 
            // tabPages
            // 
            tabPages.Controls.Add(tabViewBrowser);
            tabPages.Controls.Add(tabViewEntity);
            tabPages.Dock = DockStyle.Fill;
            tabPages.Location = new Point(0, 0);
            tabPages.Margin = new Padding(4, 5, 4, 5);
            tabPages.Name = "tabPages";
            tabPages.SelectedIndex = 0;
            tabPages.Size = new Size(1317, 894);
            tabPages.TabIndex = 0;
            tabPages.SelectedIndexChanged += DoOnAnyCommand;
            // 
            // tabViewBrowser
            // 
            tabViewBrowser.Controls.Add(pnlBrowserCommands);
            tabViewBrowser.Controls.Add(pnlBrowser);
            tabViewBrowser.Location = new Point(4, 34);
            tabViewBrowser.Margin = new Padding(4, 5, 4, 5);
            tabViewBrowser.Name = "tabViewBrowser";
            tabViewBrowser.Padding = new Padding(4, 5, 4, 5);
            tabViewBrowser.Size = new Size(1309, 856);
            tabViewBrowser.TabIndex = 0;
            tabViewBrowser.Text = "Browser";
            tabViewBrowser.UseVisualStyleBackColor = true;
            // 
            // pnlBrowserCommands
            // 
            pnlBrowserCommands.BackColor = Color.Gainsboro;
            pnlBrowserCommands.Controls.Add(btnDelete);
            pnlBrowserCommands.Controls.Add(btnNew);
            pnlBrowserCommands.Controls.Add(btnOpen);
            pnlBrowserCommands.Controls.Add(btnRefreshBrowser);
            pnlBrowserCommands.Location = new Point(5, 5);
            pnlBrowserCommands.Margin = new Padding(4, 5, 4, 5);
            pnlBrowserCommands.Name = "pnlBrowserCommands";
            pnlBrowserCommands.Size = new Size(1300, 85);
            pnlBrowserCommands.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(610, 25);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += DoOnAnyCommand;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Green;
            btnNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(440, 25);
            btnNew.Margin = new Padding(4, 5, 4, 5);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(140, 40);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += DoOnAnyCommand;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.DeepSkyBlue;
            btnOpen.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(100, 25);
            btnOpen.Margin = new Padding(4, 5, 4, 5);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(140, 40);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += DoOnAnyCommand;
            // 
            // btnRefreshBrowser
            // 
            btnRefreshBrowser.BackColor = Color.DeepSkyBlue;
            btnRefreshBrowser.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefreshBrowser.ForeColor = Color.White;
            btnRefreshBrowser.Location = new Point(270, 25);
            btnRefreshBrowser.Margin = new Padding(4, 5, 4, 5);
            btnRefreshBrowser.Name = "btnRefreshBrowser";
            btnRefreshBrowser.Size = new Size(140, 40);
            btnRefreshBrowser.TabIndex = 0;
            btnRefreshBrowser.Text = "Refresh\r\nBrowser";
            btnRefreshBrowser.UseVisualStyleBackColor = false;
            btnRefreshBrowser.Click += DoOnAnyCommand;
            // 
            // pnlBrowser
            // 
            pnlBrowser.Controls.Add(dgvBrowser);
            pnlBrowser.Dock = DockStyle.Top;
            pnlBrowser.Location = new Point(4, 5);
            pnlBrowser.Margin = new Padding(4, 5, 4, 5);
            pnlBrowser.Name = "pnlBrowser";
            pnlBrowser.Size = new Size(1301, 850);
            pnlBrowser.TabIndex = 0;
            // 
            // dgvBrowser
            // 
            dgvBrowser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrowser.Location = new Point(1, 82);
            dgvBrowser.Name = "dgvBrowser";
            dgvBrowser.RowHeadersWidth = 62;
            dgvBrowser.RowTemplate.Height = 25;
            dgvBrowser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBrowser.Size = new Size(1300, 761);
            dgvBrowser.TabIndex = 0;
            dgvBrowser.DoubleClick += DoOnAnyCommand;
            // 
            // tabViewEntity
            // 
            tabViewEntity.Controls.Add(pnlEntityCommands);
            tabViewEntity.Controls.Add(pnlEntityView);
            tabViewEntity.Location = new Point(4, 34);
            tabViewEntity.Margin = new Padding(4, 5, 4, 5);
            tabViewEntity.Name = "tabViewEntity";
            tabViewEntity.Padding = new Padding(4, 5, 4, 5);
            tabViewEntity.Size = new Size(1309, 856);
            tabViewEntity.TabIndex = 1;
            tabViewEntity.Text = "Entity";
            tabViewEntity.UseVisualStyleBackColor = true;
            // 
            // pnlEntityCommands
            // 
            pnlEntityCommands.BackColor = Color.LightGray;
            pnlEntityCommands.Controls.Add(btnBackToBrowser);
            pnlEntityCommands.Controls.Add(btnCancel);
            pnlEntityCommands.Controls.Add(btnSave);
            pnlEntityCommands.Controls.Add(btnEntityDelete);
            pnlEntityCommands.Controls.Add(btnEntityNew);
            pnlEntityCommands.Controls.Add(btnEdit);
            pnlEntityCommands.Location = new Point(5, 5);
            pnlEntityCommands.Margin = new Padding(4, 5, 4, 5);
            pnlEntityCommands.Name = "pnlEntityCommands";
            pnlEntityCommands.Size = new Size(1300, 85);
            pnlEntityCommands.TabIndex = 1;
            // 
            // btnBackToBrowser
            // 
            btnBackToBrowser.BackColor = Color.Red;
            btnBackToBrowser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackToBrowser.ForeColor = Color.White;
            btnBackToBrowser.Location = new Point(20, 25);
            btnBackToBrowser.Margin = new Padding(4, 5, 4, 5);
            btnBackToBrowser.Name = "btnBackToBrowser";
            btnBackToBrowser.Size = new Size(40, 40);
            btnBackToBrowser.TabIndex = 8;
            btnBackToBrowser.Text = "<--";
            btnBackToBrowser.UseVisualStyleBackColor = false;
            btnBackToBrowser.Click += DoOnAnyCommand;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DeepSkyBlue;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(780, 25);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += DoOnAnyCommand;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(610, 25);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += DoOnAnyCommand;
            // 
            // btnEntityDelete
            // 
            btnEntityDelete.BackColor = Color.Red;
            btnEntityDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntityDelete.ForeColor = Color.White;
            btnEntityDelete.Location = new Point(440, 25);
            btnEntityDelete.Margin = new Padding(4, 5, 4, 5);
            btnEntityDelete.Name = "btnEntityDelete";
            btnEntityDelete.Size = new Size(140, 40);
            btnEntityDelete.TabIndex = 5;
            btnEntityDelete.Text = "Delete";
            btnEntityDelete.UseVisualStyleBackColor = false;
            btnEntityDelete.Click += DoOnAnyCommand;
            // 
            // btnEntityNew
            // 
            btnEntityNew.BackColor = Color.DeepSkyBlue;
            btnEntityNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntityNew.ForeColor = Color.White;
            btnEntityNew.Location = new Point(270, 25);
            btnEntityNew.Margin = new Padding(4, 5, 4, 5);
            btnEntityNew.Name = "btnEntityNew";
            btnEntityNew.Size = new Size(140, 40);
            btnEntityNew.TabIndex = 4;
            btnEntityNew.Text = "New";
            btnEntityNew.UseVisualStyleBackColor = false;
            btnEntityNew.Click += DoOnAnyCommand;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DeepSkyBlue;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(100, 25);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 40);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += DoOnAnyCommand;
            // 
            // pnlEntityView
            // 
            pnlEntityView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlEntityView.BackColor = Color.Gainsboro;
            pnlEntityView.Location = new Point(5, 100);
            pnlEntityView.Margin = new Padding(4, 5, 4, 5);
            pnlEntityView.Name = "pnlEntityView";
            pnlEntityView.Size = new Size(1300, 750);
            pnlEntityView.TabIndex = 11;
            // 
            // CFormTemplateMaster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 894);
            Controls.Add(tabPages);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "CFormTemplateMaster";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Master Form";
            FormClosed += DoOnFormClosed;
            tabPages.ResumeLayout(false);
            tabViewBrowser.ResumeLayout(false);
            pnlBrowserCommands.ResumeLayout(false);
            pnlBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBrowser).EndInit();
            tabViewEntity.ResumeLayout(false);
            pnlEntityCommands.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPages;
        private TabPage tabViewBrowser;
        private TabPage tabViewEntity;
        private Panel pnlBrowserCommands;
        private Panel pnlBrowser;
        private Button btnDelete;
        private Button btnNew;
        private Button btnOpen;
        private Button btnRefreshBrowser;
        private Panel pnlEntityCommands;
        private Button btnEntityDelete;
        private Button btnEntityNew;
        private Button btnEdit;
        private Button btnSave;
        private Button btnCancel;
        private Button btnBackToBrowser;
        private Panel pnlEntityView;
        private DataGridView dgvBrowser;
    }
}