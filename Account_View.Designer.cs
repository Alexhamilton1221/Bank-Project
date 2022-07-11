namespace Bank_Account_Project
{
    partial class Account_View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_View));
            this.account_list = new System.Windows.Forms.ListBox();
            this.transaction_list = new System.Windows.Forms.ListBox();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.all_transactions = new System.Windows.Forms.RadioButton();
            this.complete_transations = new System.Windows.Forms.RadioButton();
            this.incomplete_transations = new System.Windows.Forms.RadioButton();
            this.pay_bill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // account_list
            // 
            this.account_list.FormattingEnabled = true;
            this.account_list.ItemHeight = 25;
            this.account_list.Location = new System.Drawing.Point(29, 108);
            this.account_list.Name = "account_list";
            this.account_list.Size = new System.Drawing.Size(426, 654);
            this.account_list.TabIndex = 0;
            this.account_list.SelectedIndexChanged += new System.EventHandler(this.account_list_SelectedIndexChanged);
            // 
            // transaction_list
            // 
            this.transaction_list.FormattingEnabled = true;
            this.transaction_list.ItemHeight = 25;
            this.transaction_list.Location = new System.Drawing.Point(563, 108);
            this.transaction_list.Name = "transaction_list";
            this.transaction_list.Size = new System.Drawing.Size(644, 654);
            this.transaction_list.TabIndex = 1;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(29, 885);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(113, 66);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Accounts";
            // 
            // all_transactions
            // 
            this.all_transactions.AutoSize = true;
            this.all_transactions.Checked = true;
            this.all_transactions.Location = new System.Drawing.Point(958, 815);
            this.all_transactions.Name = "all_transactions";
            this.all_transactions.Size = new System.Drawing.Size(197, 29);
            this.all_transactions.TabIndex = 8;
            this.all_transactions.TabStop = true;
            this.all_transactions.Text = "All Transactions";
            this.all_transactions.UseVisualStyleBackColor = true;
            this.all_transactions.CheckedChanged += new System.EventHandler(this.all_transactions_CheckedChanged);
            // 
            // complete_transations
            // 
            this.complete_transations.AutoSize = true;
            this.complete_transations.Location = new System.Drawing.Point(958, 850);
            this.complete_transations.Name = "complete_transations";
            this.complete_transations.Size = new System.Drawing.Size(276, 29);
            this.complete_transations.TabIndex = 9;
            this.complete_transations.Text = "Completed Transactions";
            this.complete_transations.UseVisualStyleBackColor = true;
            this.complete_transations.CheckedChanged += new System.EventHandler(this.complete_transations_CheckedChanged);
            // 
            // incomplete_transations
            // 
            this.incomplete_transations.AutoSize = true;
            this.incomplete_transations.Location = new System.Drawing.Point(958, 885);
            this.incomplete_transations.Name = "incomplete_transations";
            this.incomplete_transations.Size = new System.Drawing.Size(266, 29);
            this.incomplete_transations.TabIndex = 10;
            this.incomplete_transations.Text = "Incomplete Transations";
            this.incomplete_transations.UseVisualStyleBackColor = true;
            this.incomplete_transations.CheckedChanged += new System.EventHandler(this.incomplete_transations_CheckedChanged);
            // 
            // pay_bill
            // 
            this.pay_bill.Location = new System.Drawing.Point(758, 831);
            this.pay_bill.Name = "pay_bill";
            this.pay_bill.Size = new System.Drawing.Size(170, 67);
            this.pay_bill.TabIndex = 11;
            this.pay_bill.Text = "Pay Bill";
            this.pay_bill.UseVisualStyleBackColor = true;
            this.pay_bill.Click += new System.EventHandler(this.pay_bill_Click);
            // 
            // Account_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 995);
            this.Controls.Add(this.pay_bill);
            this.Controls.Add(this.incomplete_transations);
            this.Controls.Add(this.complete_transations);
            this.Controls.Add(this.all_transactions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.transaction_list);
            this.Controls.Add(this.account_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account_View";
            this.Text = "Account_View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox account_list;
        private System.Windows.Forms.ListBox transaction_list;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton all_transactions;
        private System.Windows.Forms.RadioButton complete_transations;
        private System.Windows.Forms.RadioButton incomplete_transations;
        private System.Windows.Forms.Button pay_bill;
    }
}