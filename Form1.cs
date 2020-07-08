// testing command:
//INSERT INTO studentinfo(sid, firstname, lastname, ssn, dob, gender)
//VALUES("", "Hong", "Huynh", 111995555, "1999-6-18", "F");

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL_CSharp_XAMPP_Winforms
{
	public partial class FormUI : Form
	{
		public FormUI()
		{
			InitializeComponent();
		}

		private void FormUI_Load(object sender, EventArgs e)
		{

		}

		private void btnExecQuery_Click(object sender, EventArgs e)
		{
			runQuery();
		}

		private void runQuery()
		{
			string query = txtCmdBox.Text;

			if (query == "")
			{
				MessageBox.Show("Please insert a sql query!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// initiate the MySQLConnection to the database in XAMPP
			string MySQLConnectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=dbstudentmanager";

			MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

			// limit the execution time of the query
			commandDatabase.CommandTimeout = 60;

			try
			{
				// Open the database
				databaseConnection.Open();

				// Execute the query
				MySqlDataReader myReader = commandDatabase.ExecuteReader();

				if (myReader.HasRows)
				{
					MessageBox.Show("Your query generated results, please see the console");

					while (myReader.Read())
					{
						Console.WriteLine(myReader.GetString(0) + " - " +		// sid
										  myReader.GetString(1) + " - " +		// firstname
										  myReader.GetString(2) + " - " +		// lastname
										  myReader.GetString(3) + " - " +		// ssn
										  myReader.GetString(4) + " - " +		// dob
										  myReader.GetString(5) + " - " +		// gender
										  myReader.GetString(6) + " - " +		// race
										  myReader.GetString(7) + " - " +		// photo filename
										  myReader.GetString(8)					// submissions filenames
										 );
					}
				}
				else
				{
					MessageBox.Show("No rows found.");
				}

				// Finally close the connection
				databaseConnection.Close();
			}
			catch (Exception e)
			{
				// Show any error message
				MessageBox.Show("Query error " + e.Message);
			}
		}
	}
}
