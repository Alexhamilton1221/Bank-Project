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
    public partial class Confirm : Form
    {
        public String pub_C_ID;
        public string pub_query;
        public string[] queries;
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
     
        public Confirm(String C_ID, string query, string message, string previous_window_name)
        {
            InitializeComponent();
            // Connect to Database
            //////////////////////

            String connectionString = "server=localhost;" +
                                         "Trusted_Connection=yes;" +
                                         "database=Bank Account Project;";

            myConnection = new SqlConnection(connectionString);

            pub_C_ID = C_ID;

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
            pub_query = query;


            confirm_message.Text = message;


        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide(); //Close the current open form.
            Main_Menu Main_Menu = new Main_Menu(pub_C_ID);
            Main_Menu.ShowDialog(this);
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {

            queries = pub_query.Split('\n');

            //ConfirmMessage.Text = query;

            try
            {

                for (int i = 0; i < queries.Length; i++)
                {
                    myCommand.CommandText = $"{queries[i]}";
                    //MessageBox.Show(myCommand.CommandText, "Test");

                    myReader = myCommand.ExecuteReader();
                    myReader.Close();
                }
            }
            catch (Exception ex){ 
                MessageBox.Show(ex.ToString(), "Error");
            
            }


            this.Hide(); //Close the current open form.
            Main_Menu Main_Menu = new Main_Menu(pub_C_ID);
            Main_Menu.ShowDialog(this);
        }
    }
}
