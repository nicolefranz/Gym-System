using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GymManagement
{
    public partial class NewMember : Form
    {
        //database connection link
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bimbi\Documents\Database.accdb";

        public NewMember()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using(OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO Member ([First Name], [Last Name], [Contact No], Birthday, Email, Address) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)";
                
                    using (OleDbCommand cmd = new OleDbCommand(insertQuery,conn))
                    {
                        cmd.Parameters.AddWithValue("@Value1", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@Value2", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@Value3", txtContact.Text);
                        cmd.Parameters.AddWithValue("@Value4", txtBirthday.Text);
                        cmd.Parameters.AddWithValue("@Value5", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Value6", txtAddress.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data added successfully!");
                ClearForm();

            }catch(Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtBirthday.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }
    }
}
