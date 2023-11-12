using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp_Hotel
{
    public partial class RoomId : Form
    {
        public RoomId()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoomId_Load(object sender, EventArgs e)
        {

        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            string con = "Data Source=DESKTOP-MC9EN3Q;Initial Catalog=Hotel;Integrated Security=True";
            SqlConnection connection =new SqlConnection(con);
            //connection.Open();
            string cmd = "select * from AllCustomerReservations";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd,connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            //SqlCommand command = new SqlCommand(cmd,connection);
            //command.ExecuteNonQuery();
            //connection.Close();


        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            string con = "Data Source=DESKTOP-MC9EN3Q;Initial Catalog=Hotel;Integrated Security=True";
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string num = cusidtext.Text;
            string cmd = "select dbo.CalculateTotalAmount ("+num+") As TotalAmount";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            TotalAmount.DataSource = table;
            SqlCommand command = new SqlCommand(cmd,connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void cusidtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalAmount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roomidbutton_Click(object sender, EventArgs e)
        {
            string con = "Data Source=DESKTOP-MC9EN3Q;Initial Catalog=Hotel;Integrated Security=True";
            SqlConnection connection = new SqlConnection(con);
            string num = cusidtext.Text;

            using (SqlCommand command = new SqlCommand("usp_GetRoomDetails", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@roomID", num);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                Room_Info.DataSource = table;
            }
           
        }

        private void Room_Info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
