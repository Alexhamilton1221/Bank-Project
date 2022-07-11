namespace Bank_Account_Project
{
    partial class Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.//
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
        /// 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.view_accounts = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.transfer = new System.Windows.Forms.Button();
            this.etransfer = new System.Windows.Forms.Button();
            this.pay_bill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // view_accounts
            // 
            this.view_accounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.view_accounts.Location = new System.Drawing.Point(158, 183);
            this.view_accounts.Name = "view_accounts";
            this.view_accounts.Size = new System.Drawing.Size(213, 57);
            this.view_accounts.TabIndex = 0;
            this.view_accounts.Text = "View Accounts";
            this.view_accounts.UseVisualStyleBackColor = true;
            this.view_accounts.Click += new System.EventHandler(this.view_accounts_Click);
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logout.Location = new System.Drawing.Point(158, 501);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(213, 58);
            this.logout.TabIndex = 1;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // transfer
            // 
            this.transfer.Location = new System.Drawing.Point(158, 268);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(213, 51);
            this.transfer.TabIndex = 2;
            this.transfer.Text = "Transfer";
            this.transfer.UseVisualStyleBackColor = true;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // etransfer
            // 
            this.etransfer.Location = new System.Drawing.Point(158, 350);
            this.etransfer.Name = "etransfer";
            this.etransfer.Size = new System.Drawing.Size(213, 55);
            this.etransfer.TabIndex = 5;
            this.etransfer.Text = "E-Transfer";
            this.etransfer.UseVisualStyleBackColor = true;
            this.etransfer.Click += new System.EventHandler(this.etransfer_Click);
            // 
            // pay_bill
            // 
            this.pay_bill.Location = new System.Drawing.Point(158, 422);
            this.pay_bill.Name = "pay_bill";
            this.pay_bill.Size = new System.Drawing.Size(213, 55);
            this.pay_bill.TabIndex = 6;
            this.pay_bill.Text = "Pay Bill";
            this.pay_bill.UseVisualStyleBackColor = true;
            this.pay_bill.Click += new System.EventHandler(this.pay_bill_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 740);
            this.Controls.Add(this.pay_bill);
            this.Controls.Add(this.etransfer);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.view_accounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view_accounts;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.Button etransfer;
        private System.Windows.Forms.Button pay_bill;
    }
}