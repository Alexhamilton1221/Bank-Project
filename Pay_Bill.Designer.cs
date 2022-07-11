namespace Bank_Account_Project
{
    partial class Pay_Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay_Bill));
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.select_account = new System.Windows.Forms.ComboBox();
            this.transaction_list = new System.Windows.Forms.ListBox();
            this.confirm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Account";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(12, 711);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(107, 62);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // select_account
            // 
            this.select_account.FormattingEnabled = true;
            this.select_account.Location = new System.Drawing.Point(437, 112);
            this.select_account.Name = "select_account";
            this.select_account.Size = new System.Drawing.Size(194, 33);
            this.select_account.TabIndex = 2;
            this.select_account.SelectedIndexChanged += new System.EventHandler(this.select_account_SelectedIndexChanged);
            // 
            // transaction_list
            // 
            this.transaction_list.FormattingEnabled = true;
            this.transaction_list.ItemHeight = 25;
            this.transaction_list.Location = new System.Drawing.Point(187, 173);
            this.transaction_list.Name = "transaction_list";
            this.transaction_list.Size = new System.Drawing.Size(526, 429);
            this.transaction_list.TabIndex = 3;
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(784, 706);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(115, 67);
            this.confirm_button.TabIndex = 4;
            this.confirm_button.Text = "Pay";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // Pay_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 785);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.transaction_list);
            this.Controls.Add(this.select_account);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pay_Bill";
            this.Text = "Pay_Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.ComboBox select_account;
        private System.Windows.Forms.ListBox transaction_list;
        private System.Windows.Forms.Button confirm_button;
    }
}