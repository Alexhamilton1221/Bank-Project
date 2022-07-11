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
    public partial class Login : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Login()
        {
            InitializeComponent();

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
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "select trim(username) as Usr, trim(password) as Pass from Customer";
                myReader = myCommand.ExecuteReader();

                String user_name = username_entry.Text.ToString();
                String password = password_entry.Text.ToString();
                int incorrect = 0;

                while (myReader.Read())
                {
                    if (user_name == myReader["Usr"].ToString() && password == myReader["Pass"].ToString())
                    {

                        //Find C_ID of user
                        //MessageBox.Show(user_name,password);
                        myReader.Close();

                        myCommand.CommandText = $"select C_ID from Customer where username='{user_name}' and " +
                                                           $"password='{password}'";
                        myReader = myCommand.ExecuteReader();

                        while (myReader.Read())
                        {
                            String C_ID = myReader["C_ID"].ToString();

                            this.Hide(); //Close the current open form.
                            Main_Menu Main_Menu = new Main_Menu(C_ID);
                            Main_Menu.ShowDialog(this);
                        }
                    }
                    else
                        incorrect = 1;
                        

                }

                myReader.Close();

                if (incorrect == 1) {

                    MessageBox.Show("Incorrect username or password", "Error");

                }
            }
            catch 
            {
                //MessageBox.Show(ex.ToString(),"Error");
                this.Close();

            }

        }
       
        private void create_user_Click(object sender, EventArgs e)
        {
            this.Hide(); //Close the current open form.
            Create_User Create_Account = new Create_User();
            Create_Account.ShowDialog(this);
        }

        private void test_login_Click(object sender, EventArgs e)
        {
            String C_ID = "001";
            this.Hide(); //Close the current open form.
            Main_Menu Main_Menu = new Main_Menu(C_ID);
            Main_Menu.ShowDialog(this);
        }
    }



}
