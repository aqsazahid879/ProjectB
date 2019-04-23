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
    public partial class ClassAttendance : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =DESKTOP-GLD2JPV; Initial Catalog = ProjectB; User ID =sa; Password =aqsazahid12345; MultipleActiveResultSets = True");

        public ClassAttendance()
        {
            InitializeComponent();
        }

        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            if(btnAddAttendance.Text == "Add Attendance")
            {
                conn.Open();
                String cmd = String.Format("INSERT INTO ClassAttendance(AttendanceDate) values('{0}')", this.AttendanceMarking.SelectionEnd.Date);
                SqlCommand command = new SqlCommand(cmd, conn);
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Added Successfully");
                conn.Close();
            }
            else
            {
                //Update ClassAttendance Set AttendanceDate = '" + Attendencepick.SelectionEnd.Date + "' where Id = '" + id + "' ";
                string cmd = String.Format("UPDATE ClassAttendance SET AttendanceDate = @date WHERE Id = @ID");
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@date", AttendanceMarking.SelectionEnd.Date));
                
                command.Parameters.Add(new SqlParameter("@ID", Convert.ToInt32(lblHide.Text)));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                conn.Close();

                btnAddAttendance.Text = "Add Attendance";
                TabPageAddClassAttendance.Hide();
                TabPageViewClassAttendance.Show();

                cmd = "SELECT * FROM ClassAttendance";
                command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                conn.Open();
                reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                GridAttendance.DataSource = table;
                conn.Close();

            }

        }

        private void ClassAttendance_Load(object sender, EventArgs e)
        {
            lblHide.Hide();
            // TODO: This line of code loads data into the 'projectBDataSet5.ClassAttendance' table. You can move, or remove it, as needed.
            this.classAttendanceTableAdapter.Fill(this.projectBDataSet5.ClassAttendance);

        }

        private void lnkStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student s = new Student();
            this.Hide();
            s.Show();
        }

        private void lnkClo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CLO c = new CLO();
            this.Hide();
            c.Show();
        }

        private void lnkRubric_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rubrics c = new Rubrics();
            this.Hide();
            c.Show();
        }

        private void lnkRubricLevel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RubricLevel c = new RubricLevel();
            this.Hide();
            c.Show();
        }

        private void lnkAssessment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Assessment c = new Assessment();
            this.Hide();
            c.Show();
        }

        private void lnkAssessmentComponent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AssessmentComponent c = new AssessmentComponent();
            this.Hide();
            c.Show();
        }

        private void lnkClassAttendance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClassAttendance c = new ClassAttendance();
            this.Hide();
            c.Show();
        }

        private void lnkStudentResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentResult c = new StudentResult();
            this.Hide();
            c.Show();
        }

        private void lnkStudentAttendance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentAttendance c = new StudentAttendance();
            this.Hide();
            c.Show();
        }

        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            String cmd = "SELECT * FROM ClassAttendance";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridAttendance.DataSource = table;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(GridAttendance.Rows[e.RowIndex].Cells[0].Value);
            var element = GridAttendance.Columns["Delete"].Index;
            var update = GridAttendance.Columns["Update"].Index;
            if (e.ColumnIndex == element)
            {

                string cmd = String.Format("DELETE FROM StudentAttendance WHERE AttendanceId = @id");
                SqlCommand command = new SqlCommand(cmd, conn);

                command.Parameters.Add(new SqlParameter("@id", ID));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                conn.Close();

                conn.Open();
                cmd = String.Format("DELETE FROM ClassAttendance WHERE Id = @id1");
                command.Parameters.Add(new SqlParameter("@id1", ID));
                reader = command.ExecuteReader();
                conn.Close();
                cmd = "SELECT * FROM ClassAttendance";
                command = new SqlCommand(cmd, conn);
                
                conn.Open();
                reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                GridAttendance.DataSource = table;
                conn.Close();


            }
            else if (e.ColumnIndex == GridAttendance.Columns["Update"].Index)
            {
                lblHide.Hide();
                var item = GridAttendance.Rows[e.RowIndex].Cells[0].Value;

                string cmd = String.Format("SELECT * FROM ClassAttendance WHERE Id = @item");
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@item", item));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                Student s = new Student();

                btnAddAttendance.Text = "Update Attendance";
                while (reader.Read())
                {
                    lblHide.Text = Convert.ToString(reader[0]);
                    string d = Convert.ToString(reader[1]);
                    DateTime date = Convert.ToDateTime(d);
                    AttendanceMarking.SetDate(date);
                }
                TabPageAddClassAttendance.Show();
                conn.Close();
            }
        }
    }
}
