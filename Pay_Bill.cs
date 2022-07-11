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
    public partial class Pay_Bill : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public String pub_C_ID;
        public Pay_Bill(String C_ID)
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

                myCommand.CommandText = $"select account_type from Accounts where C_ID='{pub_C_ID}'"; // Get all Accounts where it doesnt match second one
                myReader = myCommand.ExecuteReader();

                while (myReader.Read()) // Populate Initial Account dropdown
                {

                    select_account.Items.Add(myReader["account_type"].ToString().Trim(' '));

                }
                myReader.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }


        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide(); //Close the current open form.
            Main_Menu Main_Menu = new Main_Menu(pub_C_ID);
            Main_Menu.ShowDialog(this);
        }

        private void select_account_SelectedIndexChanged(object sender, EventArgs e)
        {
            transaction_list.Items.Clear(); //Clear Listbox

            if (select_account.SelectedItem != null)
            {
                string[] tokens = select_account.SelectedItem.ToString().Split(' ');
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

        private void confirm_button_Click(object sender, EventArgs e)
        {
            if (transaction_list.SelectedItem != null)
            {
                string[] trans_tokens = transaction_list.SelectedItem.ToString().Split(' ');

                String T_ID = trans_tokens[0];
                String cost = trans_tokens[8].Replace("$", String.Empty);

                string[] acc_tokens = select_account.SelectedItem.ToString().Split(' ');
                String acc_type = acc_tokens[0];

                //Query to check if first account has sufficient funds for transfer
                myCommand.CommandText = $"select balance from Accounts where C_ID={pub_C_ID} and account_type='{acc_type}'"; // Take from first account
                    var acc_bal = myCommand.ExecuteScalar();


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
            
        
    
}
