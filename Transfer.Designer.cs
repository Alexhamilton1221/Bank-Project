namespace Bank_Account_Project
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.initial_account = new System.Windows.Forms.ComboBox();
            this.destination_account = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amount_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.confirm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initial_account
            // 
            this.initial_account.FormattingEnabled = true;
            this.initial_account.Location = new System.Drawing.Point(138, 172);
            this.initial_account.Name = "initial_account";
            this.initial_account.Size = new System.Drawing.Size(229, 33);
            this.initial_account.TabIndex = 0;
            this.initial_account.SelectedIndexChanged += new System.EventHandler(this.initial_account_SelectedIndexChanged);
            // 
            // destination_account
            // 
            this.destination_account.FormattingEnabled = true;
            this.destination_account.Location = new System.Drawing.Point(138, 320);
            this.destination_account.Name = "destination_account";
            this.destination_account.Size = new System.Drawing.Size(219, 33);
            this.destination_account.TabIndex = 1;
            this.destination_account.SelectedIndexChanged += new System.EventHandler(this.destination_account_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initial Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Account";
            // 
            // amount_input
            // 
            this.amount_input.Location = new System.Drawing.Point(138, 473);
            this.amount_input.Name = "amount_input";
            this.amount_input.Size = new System.Drawing.Size(219, 31);
            this.amount_input.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(46, 570);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(104, 65);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(338, 570);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(104, 65);
            this.confirm_button.TabIndex = 7;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 676);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destination_account);
            this.Controls.Add(this.initial_account);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox initial_account;
        private System.Windows.Forms.ComboBox destination_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button confirm_button;
    }
}