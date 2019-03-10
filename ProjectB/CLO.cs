using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class CLO : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =DESKTOP-GLD2JPV; Initial Catalog = ProjectB; User ID =sa; Password =aqsazahid12345; MultipleActiveResultSets = True");
        public CLO()
        {
            InitializeComponent();
        }

        private void btnAddCLO_Click(object sender, EventArgs e)
        {
            
            if(btnAddCLO.Text == "Add CLO")
            {
                lblId.Hide();
                DateTime date = DateTime.Now;
                conn.Open();
                string cmd = String.Format("INSERT INTO Clo(Name, DateCreated, DateUpdated) VALUES('{0}','{1}','{2}')", txtName.Text, date, date);
                SqlCommand command = new SqlCommand(cmd, conn);
                SqlDataReader reader = command.ExecuteReader();
                txtName.Text = "";
                conn.Close();
            }
            else
            {
                DateTime date = DateTime.Now;
                conn.Open();
                string Name = txtName.Text;
                int Id = Convert.ToInt32(lblId.Text);
                string cmd = String.Format("UPDATE Clo SET Name = @Name, DateUpdated = @date WHERE Id = @Id");
                //SqlCommand command = new SqlCommand(cmd, conn);
                
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@Name", Name));
                command.Parameters.Add(new SqlParameter("@date", date));
                command.Parameters.Add(new SqlParameter("@Id", Id));
                SqlDataReader reader = command.ExecuteReader();
                txtName.Text = "";
                conn.Close();
            }
        }

        private void btnViewCLO_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            conn.Open();
            string cmd = String.Format("SELECT * FROM Clo");
            SqlCommand command = new SqlCommand(cmd, conn);
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridCLO.DataSource = table;
            conn.Close();
        }

        private void gridCLO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = gridCLO.Rows[e.RowIndex].Cells[0].Value;
            string cmd = String.Format("SELECT * FROM Clo WHERE Id = @item");
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("@item", item));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            btnAddCLO.Text = "Update CLO";
            tabAddCLO.Show();
            while(reader.Read())
            {
                lblId.Text = Convert.ToString(reader[0]);
                txtName.Text = Convert.ToString(reader[1]);
            }
            conn.Close();
        }

        private void CLO_Load(object sender, EventArgs e)
        {
            lblId.Hide();
        }

        private void tabAddCLO_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            String ID = txtId.Text;
            string cmd = String.Format("DELETE FROM Clo WHERE Id = @ID");
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("@ID", ID));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            conn.Close();
            conn.Open();
            cmd = String.Format("SELECT *FROM Clo");
            reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridCLO.DataSource = table;
            conn.Close();
        }
    }
}
