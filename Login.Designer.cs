namespace Bank_Account_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username_entry = new System.Windows.Forms.TextBox();
            this.password_entry = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.create_user = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_entry
            // 
            this.username_entry.Location = new System.Drawing.Point(228, 219);
            this.username_entry.Name = "username_entry";
            this.username_entry.Size = new System.Drawing.Size(271, 31);
            this.username_entry.TabIndex = 0;
            // 
            // password_entry
            // 
            this.password_entry.Location = new System.Drawing.Point(228, 426);
            this.password_entry.Name = "password_entry";
            this.password_entry.Size = new System.Drawing.Size(271, 31);
            this.password_entry.TabIndex = 1;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(298, 519);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(91, 47);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // create_user
            // 
            this.create_user.Location = new System.Drawing.Point(273, 588);
            this.create_user.Name = "create_user";
            this.create_user.Size = new System.Drawing.Size(142, 55);
            this.create_user.TabIndex = 3;
            this.create_user.Text = "Create User";
            this.create_user.UseVisualStyleBackColor = true;
            this.create_user.Click += new System.EventHandler(this.create_user_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 7.875F);
            this.label2.Location = new System.Drawing.Point(63, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 945);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create_user);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_entry);
            this.Controls.Add(this.username_entry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_entry;
        private System.Windows.Forms.TextBox password_entry;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button create_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

