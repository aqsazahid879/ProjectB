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
                tabAddCLO.Hide();
                tabViewCLO.Show();

                conn.Open();
                 cmd = String.Format("SELECT * FROM Clo");
                command = new SqlCommand(cmd, conn);
                reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridCLO.DataSource = table;
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
            var element = gridCLO.Columns["Delete"].Index;
            var update = gridCLO.Columns["Update"].Index;
            if (e.ColumnIndex == element)
            {
                int ID;
                ID = Convert.ToInt32(gridCLO.Rows[e.RowIndex].Cells[0].Value);
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
            else if(e.ColumnIndex == gridCLO.Columns["Update"].Index)
            {
                var item = gridCLO.Rows[e.RowIndex].Cells[0].Value;
                //int IdOfItem;
                //var SecondItem = gridStudentInformation.Rows[e.RowIndex].Cells[6].Value;
                string cmd = String.Format("SELECT * FROM Clo WHERE Id = @item");
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@item", item));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                Student s = new Student();
                //tabControl1.SelectedTab = tabControl1.TabPages["View Student"].Show;
                
                btnAddCLO.Text = "Update CLO";
                while (reader.Read())
                {
                    lblId.Text = Convert.ToString(reader[0]);
                    txtName.Text = Convert.ToString(reader[1]);
                    
                }
                tabAddCLO.Show();
                conn.Close();
            }




/*
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
            conn.Close();*/
        }

        private void CLO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet1.Clo);
            lblId.Hide();
        }

        private void tabAddCLO_Click(object sender, EventArgs e)
        {
            
        }

    
    }
}
