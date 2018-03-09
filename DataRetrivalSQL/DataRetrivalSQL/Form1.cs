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

namespace DataRetrivalSQL
{
    public partial class Form1 : Form
       
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Define connection string
            const string connString = @"Server=PL13\MTCDBDEV; Database=AdventureWorks2012;Trusted_Connection=True;";
            try
            {
                // Define the connection using the connection string.
                SqlConnection sqlConn = new SqlConnection(connString);

                // Define a data adapter to pull the data from the server using the connection and a stored procedure.
                SqlDataAdapter sqlDA = new SqlDataAdapter("sp_VendorsAddresses", sqlConn);

                // Declare an empty data table to hold the data.
                DataTable dtEmployees = new DataTable();

                // Fill the data table using the data adapter.
                sqlDA.Fill(dtEmployees);

                // Use the data table as the data source for a data grid control.
                dataGridView1.DataSource = dtEmployees;
            }
            catch
            {
                MessageBox.Show("You done goofed up!");
            }
        }
    }
}
