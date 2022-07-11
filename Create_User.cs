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
    public partial class Create_User : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Create_User()
        {
            InitializeComponent();
            date_of_birth_input.Format = DateTimePickerFormat.Custom;  /*Make custom format for date time picker*/
            //date_of_birth_input.CustomFormat = "mm/dd/yyyy";
            date_of_birth_input.CustomFormat = "MM/dd/yyyy";
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

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide(); //Close the current open form.
            Login Login = new Login();
            Login.ShowDialog(this);
        }

        private void finish_account_Click(object sender, EventArgs e)
        {


            try
            {
                //Generate C_ID
                myCommand.CommandText = "select MAX(C_ID)+1 as C_ID from Customer;"; // Find highest C_ID and generate new one
                myReader = myCommand.ExecuteReader();



                string C_ID = "";
                while (myReader.Read())
                {
                    C_ID = $"00{myReader["C_ID"].ToString()}";

                }
                myReader.Close();

                //All initial fields
                String fname = first_name.Text;
                String lname = last_name.Text;
                String age = age_input.Value.ToString();
                String phn_nbr = phone_number.Text;
                String city = city_input.Text;
                String provence = provence_input.Text;
                String address = address_input.Text;
                String postal_code = postal_code_input.Text;
                String country = country_input.Text;
                String DOB = date_of_birth_input.Value.ToString();
                String username = username_input.Text;
                String password = password_input.Text;


                if (fname != "" && lname != "" && age != "" && phn_nbr != "" && city != "" && provence != ""
                    && address != "" && postal_code != "" && country != "" && DOB != "" && username != ""
                    && password != ""
                    )
                {


                    myCommand.CommandText = $"insert into Customer values ('{C_ID}','{fname}','{lname}'" +
                        $",'{age}','{phn_nbr}','{address}','{city}','{provence}','{country}','{DOB}'" +
                        $",'{username}','{password}')";

                    myReader = myCommand.ExecuteReader();

                    myReader.Close();
                    MessageBox.Show($"{fname}'s account has been successfully created.");

                    this.Hide(); // Close current form
                    Login Login = new Login();
                    Login.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Please enter valid inputs to all the fields.", "Error");
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid inputs to all the fields.", "Error");

            }

        }
    }
}
//