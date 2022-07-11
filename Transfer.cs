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
    public partial class Transfer : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public String pub_C_ID;
        public int init_bal;

        public Transfer(String C_ID)
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

                //populate both dropdowns
                myCommand.CommandText = $"select account_type from Accounts where C_ID='{pub_C_ID}'"; // Get all Branches where it doesnt match second one
                myReader = myCommand.ExecuteReader();

                while (myReader.Read()) // Populate Initial Account dropdown
                {
                    initial_account.Items.Add(myReader["account_type"].ToString().Trim(' '));
                }
                myReader.Close();

                //populate both dropdowns
                myCommand.CommandText = $"select account_type from Accounts where C_ID='{pub_C_ID}'"; // Get all Branches where it doesnt match second one
                myReader = myCommand.ExecuteReader();

                while (myReader.Read()) // Populate Destination Account dropdown
                {
                    destination_account.Items.Add(myReader["account_type"].ToString().Trim(' '));
                }
                myReader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }



        }

        private void initial_account_SelectedIndexChanged(object sender, EventArgs e)
        {
            destination_account.Items.Clear(); //Clear combobox 2
            myCommand.CommandText = $"select account_type from Accounts where C_ID='{pub_C_ID}'"; // Get all Accounts where it doesnt match second one
            myReader = myCommand.ExecuteReader();

            while (myReader.Read()) // Populate Initial Account dropdown
            {
                if (myReader["account_type"].ToString().Trim(' ') != initial_account.Text)
                {
                    destination_account.Items.Add(myReader["account_type"].ToString().Trim(' '));
                }
            }
            myReader.Close();


        }

        private void destination_account_SelectedIndexChanged(object sender, EventArgs e)
        {
            initial_account.Items.Clear(); //Clear combobox 1
            myCommand.CommandText = $"select account_type from Accounts where C_ID='{pub_C_ID}'"; // Get all Branches where it doesnt match second one
            myReader = myCommand.ExecuteReader();

            while (myReader.Read()) // Populate Destination Account dropdown
            {
                initial_account.Items.Add(myReader["account_type"].ToString().Trim(' '));

            }
            myReader.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide(); //Close the current open form.
            Main_Menu Main_Menu = new Main_Menu(pub_C_ID);
            Main_Menu.ShowDialog(this);
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            try
            {


                //Get fields
                String init_acc = initial_account.Text.Replace(" ", String.Empty);
                String dest_acc = destination_account.Text.Replace(" ", String.Empty);
                float amount = float.Parse(amount_input.Text);

                //Query to check if first account has sufficient funds for transfer
                myCommand.CommandText = $"select balance from Accounts where C_ID={pub_C_ID} and account_type='{init_acc}'"; // Take from first account
                var init_bal = myCommand.ExecuteScalar();



                if (Convert.ToInt32(init_bal) < amount)
                {

                    MessageBox.Show($"Insufficient funds in {init_acc} to transfer.", "Warning");
                   
                }
                else
                {
                    //Query to add to transactions

                    //First, Generate T_ID

                    myCommand.CommandText = "select MAX(T_ID)+1 as T_ID from Bank_Transaction;"; // Find highest T_ID and generate new one
                    var T_ID = myCommand.ExecuteScalar();
                    //var T_ID_2= Convert.ToInt32(T_ID.Value)+1;
                    //var T_ID_2 = T_ID + 1.ToString();
                    //var T_ID_2 = ((int)T_ID + 1).ToString();
                    var T_ID_2 = T_ID + 1.ToString();

                    //T_ID = $"00{T_ID}";
                    //T_ID_2 = $"00{T_ID_2}";

                    myReader.Close();

                    //make second T_ID
                    // string T_ID_2 = Int32.Parse("1234");

                    //Get date for transfer
                    DateTime today = DateTime.Today;


                    //Find A_ID for accounts
                    myCommand.CommandText = $"select A_ID from Accounts where C_ID='{pub_C_ID}' and account_type='{init_acc}'"; // Find A_ID for acc 1
                    myReader = myCommand.ExecuteReader();
                    string A_ID_1 = "";
                    while (myReader.Read())
                    {
                        A_ID_1 = $"{myReader["A_ID"].ToString()}";

                    }
                    myReader.Close();

                    myCommand.CommandText = $"select A_ID from Accounts where C_ID='{pub_C_ID}' and account_type='{dest_acc}'"; // Find A_ID for acc 2
                    myReader = myCommand.ExecuteReader();
                    string A_ID_2 = "";
                    while (myReader.Read())
                    {
                        A_ID_2 = $"{myReader["A_ID"].ToString()}";

                    }
                    myReader.Close();


                    //then use T_ID and make 2 new transactions
                    myCommand.CommandText = $"insert into Bank_Transaction values('{T_ID}',-{amount},'{today}','{today}','true','{pub_C_ID}','{A_ID_1}','transfer')"; // Take from first account
                    myCommand.CommandText += $"insert into Bank_Transaction values('{T_ID_2}',{amount},'{today}','{today}','true','{pub_C_ID}','{A_ID_2}','transfer')"; // Take from first account


                    //Queries for transfering money
                    myCommand.CommandText += $"update Accounts set balance = balance-{amount} where C_ID={pub_C_ID} and account_type='{init_acc}'"; // Take from first account
                    myCommand.CommandText += $"\nupdate Accounts set balance = balance+{amount} where C_ID={pub_C_ID} and account_type='{dest_acc}'"; // Add to second account
                                                                                                                                                      //Take both queries and pass to confirm screen

                    String message = $"Are you sure you would like to transfer ${amount} from {init_acc} to {dest_acc}?";

                    this.Hide(); //Close the current open form.
                    Confirm Confirm = new Confirm(pub_C_ID, myCommand.CommandText, message, "Main_Menu");
                    Confirm.ShowDialog(this);

                }
            

                
            }
            catch (Exception exe) {

                MessageBox.Show("Please fill all fields.","Warning");
                MessageBox.Show(exe.ToString(), "Error");
            }


        }
    }
    }

