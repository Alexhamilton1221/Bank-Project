namespace Bank_Account_Project
{
    partial class ETransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ETransfer));
            this.label1 = new System.Windows.Forms.Label();
            this.account_to_send_from = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.receiving_account_ID = new System.Windows.Forms.TextBox();
            this.amount_sending = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.confirm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account to Send from";
            // 
            // account_to_send_from
            // 
            this.account_to_send_from.FormattingEnabled = true;
            this.account_to_send_from.Location = new System.Drawing.Point(290, 121);
            this.account_to_send_from.Name = "account_to_send_from";
            this.account_to_send_from.Size = new System.Drawing.Size(226, 33);
            this.account_to_send_from.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Account ID to send to";
            // 
            // receiving_account_ID
            // 
            this.receiving_account_ID.Location = new System.Drawing.Point(290, 279);
            this.receiving_account_ID.Name = "receiving_account_ID";
            this.receiving_account_ID.Size = new System.Drawing.Size(226, 31);
            this.receiving_account_ID.TabIndex = 10;
            // 
            // amount_sending
            // 
            this.amount_sending.Location = new System.Drawing.Point(290, 437);
            this.amount_sending.Name = "amount_sending";
            this.amount_sending.Size = new System.Drawing.Size(226, 31);
            this.amount_sending.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Amount to send";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(28, 678);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(102, 59);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(465, 678);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(113, 60);
            this.confirm_button.TabIndex = 14;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // ETransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 767);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount_sending);
            this.Controls.Add(this.receiving_account_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.account_to_send_from);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ETransfer";
            this.Text = "ETransfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox account_to_send_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox receiving_account_ID;
        private System.Windows.Forms.TextBox amount_sending;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button confirm_button;
    }
}