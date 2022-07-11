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
    public partial class ETransfer : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public String pub_C_ID;

        public ETransfer(String C_ID)
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

                //populate dropdown
                myCommand.CommandText = $"select account_type from Accounts where C_ID='{pub_C_ID}'"; // Get all Branches where it doesnt match second one
                myReader = myCommand.ExecuteReader();

                while (myReader.Read()) // Populate Initial Account dropdown
                {
                    account_to_send_from.Items.Add(myReader["account_type"].ToString().Trim(' '));
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {

            this.Hide(); //Close the current open form.
            Main_Menu Main_Menu = new Main_Menu(pub_C_ID);
            Main_Menu.ShowDialog(this);
        }
        //String send_acc_id = receiving_account_ID.Text.Replace(" ", String.Empty);//Id for account to sent to
        //float amount = float.Parse(amount_sending.Text); //Amount of money to send

        //myCommand.CommandText = $"select account_type from Accounts where A_ID={send_acc_id}"; // Find accout to send to
        //var send_acc_type = myCommand.ExecuteScalar();


        //myCommand.CommandText = $"select balance from Accounts where C_ID={pub_C_ID} and account_type='{send_acc_type}'"; // Get balance from sending account
        //var init_bal = myCommand.ExecuteScalar();

        private void confirm_button_Click(object sender, EventArgs e)
        {
            String acc_to_send_from = account_to_send_from.Text.Replace(" ", String.Empty);//name of acc to send from
            float amount = float.Parse(amount_sending.Text); //Amount of money to send to another account


            myCommand.CommandText = $"select balance from Accounts where C_ID={pub_C_ID} and account_type='{acc_to_send_from}'"; // Find accout to send to
            var initial_account_balance = myCommand.ExecuteScalar();

            if (Convert.ToInt32(initial_account_balance) < amount)
            {

                MessageBox.Show($"Insufficient funds in {acc_to_send_from} to transfer.", "Warning");

            }
            else {
                //Query to add to transactions
                //First, Generate T_ID

                myCommand.CommandText = "select MAX(T_ID)+1 as T_ID from Bank_Transaction;"; // Find highest T_ID and generate new one
                var T_ID = myCommand.ExecuteScalar();
                //var T_ID_2= Convert.ToInt32(T_ID.Value)+1;
                //var T_ID_2 = ((int)T_ID + 1).ToString();
                var T_ID_2 = T_ID + 1.ToString();
                //T_ID = $"00{T_ID}";
                //T_ID_2 = $"00{T_ID_2}";

                myReader.Close();

                //Get date for transfer
                DateTime today = DateTime.Today;

                //Find A_ID for accounts
                myCommand.CommandText = $"select A_ID from Accounts where C_ID='{pub_C_ID}' and account_type='{acc_to_send_from}'"; // Find A_ID for acc 1
                myReader = myCommand.ExecuteReader();
                string A_ID_1 = "";
                while (myReader.Read())
                {
                    A_ID_1 = $"{myReader["A_ID"].ToString()}";

                }
                myReader.Close();
                string A_ID_2 = receiving_account_ID.Text;



                myCommand.CommandText = $"select account_type from Accounts where A_ID={receiving_account_ID.Text}"; // get account type for second account
                var acc_to_send_to = myCommand.ExecuteScalar();


                myCommand.CommandText = $"select C_ID from Accounts where A_ID={receiving_account_ID.Text}"; // get C_ID for second account
                var recieving_CID = myCommand.ExecuteScalar();






                //then use T_ID and make 2 new transactions
                myCommand.CommandText = $"insert into Bank_Transaction values('{T_ID}',-{amount},'{today}','{today}','true','{pub_C_ID}','{A_ID_1}','etransfer')"; // Take from first account
                myCommand.CommandText += $"insert into Bank_Transaction values('{T_ID_2}',{amount},'{today}','{today}','true','{recieving_CID}','{A_ID_2}','etransfer')"; // Take from first account


                //Queries for transfering money
                myCommand.CommandText += $"update Accounts set balance = balance-{amount} where C_ID={pub_C_ID} and account_type='{acc_to_send_from}'"; // Take from first account
                myCommand.CommandText += $"\nupdate Accounts set balance = balance+{amount} where C_ID={recieving_CID} and account_type='{acc_to_send_to}'"; // Add to second account
                                                                                                                                                        //Take both queries and pass to confirm screen

                String message = $"Are you sure you would like to Etransfer ${amount} from {acc_to_send_from} to {acc_to_send_to}?";

                this.Hide(); //Close the current open form.
                Confirm Confirm = new Confirm(pub_C_ID, myCommand.CommandText, message, "Main_Menu");
                Confirm.ShowDialog(this);



                //String send_acc_id = receiving_account_ID.Text.Replace(" ", String.Empty);//Id for account to sent to

                //myCommand.CommandText += $"select account_type from Accounts where A_ID={send_acc_id}"; // Find accout to send to
            }
        }
    }
}
