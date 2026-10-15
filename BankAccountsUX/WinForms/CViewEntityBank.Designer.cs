namespace BankAccounts.UX.WinForms
{
    partial class CViewEntityBank
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
            dgvDetails = new DataGridView();
            lblBankName = new Label();
            lblCountry = new Label();
            txtBankName = new TextBox();
            cbCountry = new ComboBox();
            lblBankAccounts = new Label();
            btnNewDetail = new Button();
            btnDeleteDetail = new Button();
            lblRoutNumber = new Label();
            txtRoutNumber = new TextBox();
            lblSwiftCode = new Label();
            txtSwiftCode = new TextBox();
            lblAccountNum = new Label();
            txtAccountNum = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvDetails
            // 
            dgvDetails.BackgroundColor = Color.DeepSkyBlue;
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Location = new Point(55, 375);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.RowHeadersWidth = 70;
            dgvDetails.RowTemplate.Height = 30;
            dgvDetails.Size = new Size(894, 537);
            dgvDetails.TabIndex = 0;
            // 
            // lblBankName
            // 
            lblBankName.AutoSize = true;
            lblBankName.BackColor = Color.Gainsboro;
            lblBankName.BorderStyle = BorderStyle.FixedSingle;
            lblBankName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBankName.ForeColor = Color.DeepSkyBlue;
            lblBankName.Location = new Point(83, 20);
            lblBankName.Name = "lblBankName";
            lblBankName.Size = new Size(153, 34);
            lblBankName.TabIndex = 1;
            lblBankName.Text = "Bank Name:";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.BackColor = Color.Gainsboro;
            lblCountry.BorderStyle = BorderStyle.FixedSingle;
            lblCountry.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountry.ForeColor = Color.DeepSkyBlue;
            lblCountry.Location = new Point(120, 75);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(116, 34);
            lblCountry.TabIndex = 2;
            lblCountry.Text = "Country:";
            // 
            // txtBankName
            // 
            txtBankName.BackColor = Color.White;
            txtBankName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBankName.ForeColor = Color.Black;
            txtBankName.Location = new Point(256, 20);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(355, 34);
            txtBankName.TabIndex = 3;
            // 
            // cbCountry
            // 
            cbCountry.BackColor = Color.White;
            cbCountry.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCountry.ForeColor = Color.Black;
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(256, 73);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(355, 36);
            cbCountry.TabIndex = 4;
            // 
            // lblBankAccounts
            // 
            lblBankAccounts.AutoSize = true;
            lblBankAccounts.BackColor = Color.Gainsboro;
            lblBankAccounts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBankAccounts.Location = new Point(55, 325);
            lblBankAccounts.Name = "lblBankAccounts";
            lblBankAccounts.Size = new Size(283, 32);
            lblBankAccounts.TabIndex = 5;
            lblBankAccounts.Text = "Bank Accounts in Bank:";
            // 
            // btnNewDetail
            // 
            btnNewDetail.BackColor = Color.DeepSkyBlue;
            btnNewDetail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewDetail.ForeColor = Color.White;
            btnNewDetail.Location = new Point(640, 322);
            btnNewDetail.Name = "btnNewDetail";
            btnNewDetail.Size = new Size(145, 40);
            btnNewDetail.TabIndex = 6;
            btnNewDetail.Text = "Add Account";
            btnNewDetail.UseVisualStyleBackColor = false;
            btnNewDetail.Click += DoOnAnyCommand;
            // 
            // btnDeleteDetail
            // 
            btnDeleteDetail.BackColor = Color.DeepSkyBlue;
            btnDeleteDetail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteDetail.ForeColor = Color.White;
            btnDeleteDetail.Location = new Point(800, 322);
            btnDeleteDetail.Name = "btnDeleteDetail";
            btnDeleteDetail.Size = new Size(145, 40);
            btnDeleteDetail.TabIndex = 7;
            btnDeleteDetail.Text = "Delete ";
            btnDeleteDetail.UseVisualStyleBackColor = false;
            btnDeleteDetail.Click += DoOnAnyCommand;
            // 
            // lblRoutNumber
            // 
            lblRoutNumber.AutoSize = true;
            lblRoutNumber.BorderStyle = BorderStyle.FixedSingle;
            lblRoutNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoutNumber.ForeColor = Color.DeepSkyBlue;
            lblRoutNumber.Location = new Point(22, 185);
            lblRoutNumber.Name = "lblRoutNumber";
            lblRoutNumber.Size = new Size(216, 34);
            lblRoutNumber.TabIndex = 8;
            lblRoutNumber.Text = "Routing Number:";
            // 
            // txtRoutNumber
            // 
            txtRoutNumber.BackColor = Color.White;
            txtRoutNumber.Font = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoutNumber.ForeColor = Color.Black;
            txtRoutNumber.Location = new Point(256, 185);
            txtRoutNumber.Name = "txtRoutNumber";
            txtRoutNumber.Size = new Size(355, 34);
            txtRoutNumber.TabIndex = 9;
            // 
            // lblSwiftCode
            // 
            lblSwiftCode.AutoSize = true;
            lblSwiftCode.BorderStyle = BorderStyle.FixedSingle;
            lblSwiftCode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSwiftCode.ForeColor = Color.DeepSkyBlue;
            lblSwiftCode.Location = new Point(100, 240);
            lblSwiftCode.Name = "lblSwiftCode";
            lblSwiftCode.Size = new Size(138, 34);
            lblSwiftCode.TabIndex = 10;
            lblSwiftCode.Text = "Swift Code";
            // 
            // txtSwiftCode
            // 
            txtSwiftCode.BackColor = Color.White;
            txtSwiftCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSwiftCode.ForeColor = Color.Black;
            txtSwiftCode.Location = new Point(256, 240);
            txtSwiftCode.Name = "txtSwiftCode";
            txtSwiftCode.Size = new Size(355, 34);
            txtSwiftCode.TabIndex = 11;
            // 
            // lblAccountNum
            // 
            lblAccountNum.AutoSize = true;
            lblAccountNum.BorderStyle = BorderStyle.FixedSingle;
            lblAccountNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccountNum.ForeColor = Color.DeepSkyBlue;
            lblAccountNum.Location = new Point(26, 130);
            lblAccountNum.Name = "lblAccountNum";
            lblAccountNum.Size = new Size(212, 34);
            lblAccountNum.TabIndex = 12;
            lblAccountNum.Text = "Account Number";
            // 
            // txtAccountNum
            // 
            txtAccountNum.BackColor = Color.White;
            txtAccountNum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccountNum.ForeColor = Color.Black;
            txtAccountNum.Location = new Point(256, 133);
            txtAccountNum.Name = "txtAccountNum";
            txtAccountNum.Size = new Size(355, 34);
            txtAccountNum.TabIndex = 13;
            // 
            // CViewEntityBank
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1011, 944);
            Controls.Add(txtAccountNum);
            Controls.Add(lblAccountNum);
            Controls.Add(txtSwiftCode);
            Controls.Add(lblSwiftCode);
            Controls.Add(txtRoutNumber);
            Controls.Add(lblRoutNumber);
            Controls.Add(btnDeleteDetail);
            Controls.Add(btnNewDetail);
            Controls.Add(lblBankAccounts);
            Controls.Add(cbCountry);
            Controls.Add(txtBankName);
            Controls.Add(lblCountry);
            Controls.Add(lblBankName);
            Controls.Add(dgvDetails);
            Name = "CViewEntityBank";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CFormViewEntityBank";
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetails;
        private Label lblBankName;
        private Label lblCountry;
        private TextBox txtBankName;
        private ComboBox cbCountry;
        private Label lblBankAccounts;
        private Button btnNewDetail;
        private Button btnDeleteDetail;
        private Label lblRoutNumber;
        private TextBox txtRoutNumber;
        private Label lblSwiftCode;
        private TextBox txtSwiftCode;
        private Label lblAccountNum;
        private TextBox txtAccountNum;
    }
}