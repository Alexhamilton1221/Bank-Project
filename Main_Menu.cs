using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account_Project
{
    public partial class Main_Menu : Form
    {

        public String pub_C_ID;

        public Main_Menu(String C_ID)
        {
            InitializeComponent();
            pub_C_ID = C_ID;
            
        }

        private void view_accounts_Click(object sender, EventArgs e)
        {
            this.Hide(); //Close the current open form.
            Account_View Account_View = new Account_View(pub_C_ID);
            Account_View.ShowDialog(this);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide(); //Close the current open form.
            Login Login = new Login();
            Login.ShowDialog(this);
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            this.Hide(); //Close the current open form.
            Transfer Transfer = new Transfer(pub_C_ID);
            Transfer.ShowDialog(this);
        }

        private void etransfer_Click(object sender, EventArgs e)
        {
            this.Hide(); //Close the current open form.
            ETransfer ETransfer = new ETransfer(pub_C_ID);
            ETransfer.ShowDialog(this);
        }

        private void pay_bill_Click(object sender, EventArgs e)
        {
            this.Hide(); //Close the current open form.
            Pay_Bill Pay_Bill = new Pay_Bill(pub_C_ID);
            Pay_Bill.ShowDialog(this);
        }
    }

}
