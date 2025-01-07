using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication2
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            textHost.Text = "localhost";
            textPort.Text = "3307";
            textUser.Text = "root";
            textPass.Text = "pass";
            textDatabase.Text = "transactions";

        }
        protected void Esemeny(object sender, EventArgs e)
        {
            // Ide jön az eseménykezelő logika
            Response.Write("<p>Esemény sikeresen lefutott!</p>");

            string ConnectionString = $"server={textHost.Text};port={textPort.Text};database={textDatabase.Text};user={textUser.Text};password={textPass.Text};";
            MySqlConnection MyConn2 = new MySqlConnection(ConnectionString);
            string sqlQuery = $"select * from {textDatabase.Text}.accounts;";
            try
            {
                MyConn2.Open();
                MySqlCommand MyCommand2 = new MySqlCommand(sqlQuery, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                dataGridView1.DataBind();
            }
            catch (Exception ex)
            {

                //MessageBox.Show($"Hiba az adatbázis kapcsolódásakor: {ex.Message}");
                //MessageBox.Show($"Hiba az adatbázis kapcsolódásakor: {ex.Message}", "MySQL kapcsolódási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}