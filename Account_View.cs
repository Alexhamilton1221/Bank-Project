using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank_Account_Project
{

    public partial class Account_View : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public String pub_C_ID;
        public Account_View(String C_ID)
        {
            InitializeComponent();
            pub_C_ID = C_ID;
            String connectionString = "server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=Bank Account Project;";


            myConnection = new SqlConnection(connectionString);


            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Connect command to Connection

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
            myCommand.CommandText += $"select * from Accounts where C_ID ={pub_C_ID}"; // Get all accounts for customer
            myReader = myCommand.ExecuteReader();


            while (myReader.Read()) // Populate Account List Box
            {
                string account_type = myReader["account_type"].ToString().Replace(" ", String.Empty);
                string balance = myReader["balance"].ToString().Replace(" ", String.Empty);

                account_list.Items.Add(account_type + "       Account Balance  $" + balance);
            }
            myReader.Close();


        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide(); // Close the current open form.
            Main_Menu Main_Menu = new Main_Menu(pub_C_ID);
            Main_Menu.ShowDialog(this);
        }

        private void account_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            pay_bill.Show();
            transaction_list.Items.Clear();
            try
            {

                if (account_list.SelectedItem != null)
                {
                    string[] tokens = account_list.SelectedItem.ToString().Split(' ');
                    String account_type = tokens[0];




                    //MessageBox.Show(account_type);

                    String account_chosen = account_list.SelectedItem.ToString();

                    if (all_transactions.Checked == true)
                    {
                        // Get transactions from account
                        myCommand.CommandText = $"select * from Bank_Transaction as Bank where A_ID in " +
                            $"(select A_ID from Accounts as Acc where account_type = '{account_type}' and Bank.CH_ID = '{pub_C_ID}' and Bank.CH_ID = Acc.C_ID) ";
                        myReader = myCommand.ExecuteReader();


                        while (myReader.Read())
                        {
                            String date_init = myReader["date_initialized"].ToString();
                            String[] date_init_tok = date_init.Split(' ');

                            String cost = myReader["cost"].ToString();
                            String trans_type = myReader["trans_type"].ToString().Replace(" ", String.Empty);
                            String status = myReader["is_completed"].ToString().Replace(" ", String.Empty);
                            String T_ID = myReader["T_ID"].ToString().Replace(" ", String.Empty);

                            if (status == "true")
                            {
                                status = "Completed Transaction";

                            }
                            else { 
                            
                            status = "Pending Transaction";
                            
                            }


                            transaction_list.Items.Add(T_ID +"  |  "+ date_init_tok[0] + "  |  $" + cost + "  |  " + trans_type + "  |  "  + status);
                        }


                        myReader.Close();

                    }
                    else if (complete_transations.Checked == true)
                    {

                        // Get transactions from account
                        myCommand.CommandText = $"select * from Bank_Transaction as Bank where A_ID in " +
                            $"(select A_ID from Accounts as Acc where account_type = '{account_type}' and Bank.CH_ID = '{pub_C_ID}' and Bank.CH_ID = Acc.C_ID) and is_completed='true'";
                        myReader = myCommand.ExecuteReader();


                        while (myReader.Read())
                        {
                            String date_init = myReader["date_initialized"].ToString();
                            String[] date_init_tok = date_init.Split(' ');

                            String cost = myReader["cost"].ToString();
                            String trans_type = myReader["trans_type"].ToString().Replace(" ", String.Empty);
                            String T_ID = myReader["T_ID"].ToString().Replace(" ", String.Empty);
                            
                            
                            
                            transaction_list.Items.Add(T_ID + "  |  " + date_init_tok[0] + "  |  $" + cost + "  |  " + trans_type + "  |  ");


                        }
                       

                        myReader.Close();

                    }
                    else if (incomplete_transations.Checked == true)
                    {

                        // Get transactions from account
                        myCommand.CommandText = $"select * from Bank_Transaction as Bank where A_ID in " +
                            $"(select A_ID from Accounts as Acc where account_type = '{account_type}' and Bank.CH_ID = '{pub_C_ID}' and Bank.CH_ID = Acc.C_ID) and is_completed='false'";
                        myReader = myCommand.ExecuteReader();


                        while (myReader.Read())
                        {
                            String date_init = myReader["date_initialized"].ToString();
                            String[] date_init_tok = date_init.Split(' ');

                            String cost = myReader["cost"].ToString();
                            String trans_type = myReader["trans_type"].ToString().Replace(" ", String.Empty);

                            String T_ID = myReader["T_ID"].ToString().Replace(" ", String.Empty);
                            transaction_list.Items.Add(T_ID + "  |  " + date_init_tok[0] + "  |  $" + cost + "  |  " + trans_type + "  |  ");
                        }


                        myReader.Close();
                    }


                }
            }
            catch
            {
                this.Close();

            }


        }

        private void all_transactions_CheckedChanged(object sender, EventArgs e)
        {
            pay_bill.Show();

            transaction_list.Items.Clear();
            try
            {

                if (account_list.SelectedItem != null)
                {
                    string[] tokens = account_list.SelectedItem.ToString().Split(' ');
                    String account_type = tokens[0];

                    //MessageBox.Show(account_type);

                    String account_chosen = account_list.SelectedItem.ToString();

                    // Get transactions from account
                    myCommand.CommandText = $"select * from Bank_Transaction as Bank where A_ID in " +
                        $"(select A_ID from Accounts as Acc where account_type = '{account_type}' and Bank.CH_ID = '{pub_C_ID}' and Bank.CH_ID = Acc.C_ID) ";
                    myReader = myCommand.ExecuteReader();


                    while (myReader.Read())
                    {
                        String date_init = myReader["date_initialized"].ToString();
                        String[] date_init_tok = date_init.Split(' ');

                        String cost = myReader["cost"].ToString();
                        String trans_type = myReader["trans_type"].ToString().Replace(" ", String.Empty);
                        String status = myReader["is_completed"].ToString().Replace(" ", String.Empty);

                        String T_ID = myReader["T_ID"].ToString().Replace(" ", String.Empty);


                        if (status == "true")
                        {
                            status = "Completed Transaction";

                        }
                        else
                        {

                            status = "Pending Transaction";

                        }

                        transaction_list.Items.Add(T_ID + "  |  " + date_init_tok[0] + "  |  $" + cost + "  |  " + trans_type + "  |  " + status);
                    }


                    myReader.Close();

                }
            }

            catch
            {
                this.Close();
            }

        }

        private void complete_transations_CheckedChanged(object sender, EventArgs e)
        {
            pay_bill.Hide();
            transaction_list.Items.Clear();
            try
            {

                if (account_list.SelectedItem != null)
                {
                    string[] tokens = account_list.SelectedItem.ToString().Split(' ');
                    String account_type = tokens[0];



                    // Get transactions from account
                    myCommand.CommandText = $"select * from Bank_Transaction as Bank where A_ID in " +
                        $"(select A_ID from Accounts as Acc where account_type = '{account_type}' and Bank.CH_ID = '{pub_C_ID}' and Bank.CH_ID = Acc.C_ID) and is_completed='true'";
                    myReader = myCommand.ExecuteReader();


                    while (myReader.Read())
                    {
                        String date_init = myReader["date_initialized"].ToString();
                        String[] date_init_tok = date_init.Split(' ');

                        String cost = myReader["cost"].ToString();
                        String trans_type = myReader["trans_type"].ToString().Replace(" ", String.Empty);

                        String T_ID = myReader["T_ID"].ToString().Replace(" ", String.Empty);
                        transaction_list.Items.Add(T_ID + "  |  " + date_init_tok[0] + "  |  $" + cost + "  |  " + trans_type + "  |  ");
                    }


                    myReader.Close();

                }

            }
            catch
            {
                this.Close();

            }
        }

        private void incomplete_transations_CheckedChanged(object sender, EventArgs e)
        {
            pay_bill.Show();

            transaction_list.Items.Clear();
            try
            {

                if (account_list.SelectedItem != null)
                {
                    string[] tokens = account_list.SelectedItem.ToString().Split(' ');
                    String account_type = tokens[0];


                    // Get transactions from account
                    myCommand.CommandText = $"select * from Bank_Transaction as Bank where A_ID in " +
                        $"(select A_ID from Accounts as Acc where account_type = '{account_type}' and Bank.CH_ID = '{pub_C_ID}' and Bank.CH_ID = Acc.C_ID) and is_completed='false'";
                    myReader = myCommand.ExecuteReader();


                    while (myReader.Read())
                    {
                        String date_init = myReader["date_initialized"].ToString();
                        String[] date_init_tok = date_init.Split(' ');

                        String cost = myReader["cost"].ToString();
                        String trans_type = myReader["trans_type"].ToString().Replace(" ", String.Empty);


                        String T_ID = myReader["T_ID"].ToString().Replace(" ", String.Empty);
                        transaction_list.Items.Add(T_ID + "  |  " + date_init_tok[0] + "  |  $" + cost + "  |  " + trans_type + "  |  ");
                    }


                    myReader.Close();



                }
            }
            catch
            {
                this.Close();

            }
        }
        
        private void pay_bill_Click(object sender, EventArgs e)
        {
            try
            {

                if (transaction_list.SelectedItem != null)
                {
                    string[] acc_tokens = account_list.SelectedItem.ToString().Split(' ');

                    string[] trans_tokens = transaction_list.SelectedItem.ToString().Split(' ');

                    String acc_type = acc_tokens[0];
                    String T_ID = trans_tokens[0];
                    String cost = trans_tokens[8].Replace("$", String.Empty);
                    String status = "";
                    if (all_transactions.Checked == true)
                    {
                         status = trans_tokens[16];

                    }
                    else if (complete_transations.Checked == true)
                    {
                        status = "Completed";


                    }
                    else {
                        status = "Pending";

                    }


                    //for (int i = 0; i < tokens.Length; i++) {MessageBox.Show(tokens[i]); }
                    // MessageBox.Show(trans_tokens[16], "Warning");

                    //MessageBox.Show(cost, "Warning");

                    if (status == "Completed")
                    {
                        MessageBox.Show("This bill has already been processed.", "Warning");

                    }
                    else if (status == "Pending")
                    {

                        //Query to check if first account has sufficient funds for transfer
                        myCommand.CommandText = $"select balance from Accounts where C_ID={pub_C_ID} and account_type='{acc_type}'"; // Take from first account
                        var acc_bal = myCommand.ExecuteScalar();
                        
                        //MessageBox.Show($"testing here is CID {pub_C_ID} and here is account_type {acc_type}", "TEST");

                        //MessageBox.Show($"testing here is balance {acc_bal} and here is cost {cost}", "TEST");


                        if (Convert.ToInt32(acc_bal) < Convert.ToInt32(cost))
                        {

                            MessageBox.Show($"Insufficient funds in the account {acc_type} to pay bill.", "Warning");

                        }
                        else
                        {   //This is where transaction is completed

                            myCommand.CommandText = $"update Bank_Transaction set is_completed='true' where T_ID={T_ID}"; // Set status to complete
                            myCommand.CommandText += $"\nupdate Accounts set balance = balance-{cost} where C_ID={pub_C_ID} and account_type='{acc_type}'"; // Take from account



                            String message = $"Are you sure you want to process this bill? \nThe bill will be paid using the balance from the account {acc_type}.";






                            this.Hide(); //Close the current open form.
                            Confirm Confirm = new Confirm(pub_C_ID, myCommand.CommandText, message, "Account_View");
                            Confirm.ShowDialog(this);

                        }

                    }
                }

            }
            catch
            {


            }
        }
    }
}