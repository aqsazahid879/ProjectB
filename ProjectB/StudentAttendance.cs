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
    public partial class StudentAttendance : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =DESKTOP-GLD2JPV; Initial Catalog = ProjectB; User ID =sa; Password =aqsazahid12345; MultipleActiveResultSets = True");

        public StudentAttendance()
        {
            InitializeComponent();
        }

        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAttendanceDataSet.StudentAttendance' table. You can move, or remove it, as needed.
            this.studentAttendanceTableAdapter.Fill(this.studentAttendanceDataSet.StudentAttendance);
            lblHide.Hide();


            String cmd = "SELECT Id FROM Student";
            SqlCommand command = new SqlCommand(cmd, conn);
            //command.Parameters.Add(new SqlParameter("", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbStudentId.Items.Add(reader[0]);
            }
            conn.Close();

            cmd = "SELECT Id FROM ClassAttendance";
            command = new SqlCommand(cmd, conn);
            //command.Parameters.Add(new SqlParameter("", 1));
            conn.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbattendanceID.Items.Add(reader[0]);
            }
            conn.Close();

            cmd = "SELECT LookupId FROM Lookup";
            command = new SqlCommand(cmd, conn);
            //command.Parameters.Add(new SqlParameter("", 1));
            conn.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbAttendanceStatus.Items.Add(reader[0]);
            }
            conn.Close();
            
            
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

        private void btnAddStudentAttendance_Click(object sender, EventArgs e)
        {
            bool isValidAttendanceId = isDigit(cmbattendanceID.Text);
            bool isvalidAttendanceStatus = isDigit(cmbAttendanceStatus.Text);
            bool isvalidStudentId = isDigit(cmbStudentId.Text);
            if(btnAddStudentAttendance.Text == "Add Student Attendance")
            {
                if(isValidAttendanceId && isvalidAttendanceStatus && isvalidStudentId)
                {
                    conn.Open();
                    String cmd = String.Format("INSERT INTO StudentAttendance(AttendanceId, StudentId, AttendanceStatus) values('{0}','{1}','{2}')", Convert.ToInt32(cmbattendanceID.Text), Convert.ToInt32(cmbStudentId.Text), Convert.ToInt32(cmbAttendanceStatus.Text));
                    SqlCommand command = new SqlCommand(cmd, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    cmbattendanceID.Text = "";
                    cmbAttendanceStatus.Text = "";
                    cmbStudentId.Text = "";
                    MessageBox.Show("Added Successfully");
                    conn.Close();
                }
                else
                {
                    if(isValidAttendanceId == false)
                    {
                        MessageBox.Show("Invalid Attendance Id");
                    }
                    if(isvalidAttendanceStatus == false)
                    {
                        MessageBox.Show("Invalid Attendance Status");
                    }
                    if(isvalidStudentId == false)
                    {
                        MessageBox.Show("Invalid Student Id");
                    }
                }
                
            }
            else
            {
                if (isValidAttendanceId && isvalidAttendanceStatus && isvalidStudentId)
                {
                    conn.Open();
                    string cmd = String.Format("UPDATE StudentAttendance SET AttendanceId = @AttendanceId, StudentId = @StudentId, AttendanceStatus = @AttendanceStatus WHERE AttendanceId = @AttendanceId AND StudentId = @StudentId");
                    
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("@AttendanceId", Convert.ToInt32(cmbattendanceID.Text)));
                    command.Parameters.Add(new SqlParameter("@StudentId", Convert.ToInt32(cmbStudentId.Text)));
                    command.Parameters.Add(new SqlParameter("@AttendanceStatus", Convert.ToInt32(cmbAttendanceStatus.Text)));
                    //command.Parameters.Add(new SqlParameter("@ID", Convert.ToInt32(lblHide.Text)));
                    SqlDataReader reader = command.ExecuteReader();

                    cmbattendanceID.Text = "";
                    cmbAttendanceStatus.Text = "";
                    cmbStudentId.Text = "";
                    conn.Close();
                    btnAddStudentAttendance.Text = "Add Student Attendance";
                    TabPageAddStudenAttendance.Hide();
                    TabPageViewAttendance.Show();

                    cmd = "SELECT * FROM StudentAttendance";
                    command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("0", 1));
                    conn.Open();
                    reader = command.ExecuteReader();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    GridStudentAttendance.DataSource = table;
                    conn.Close();

                }
                else
                {
                    if (isValidAttendanceId == false)
                    {
                        MessageBox.Show("Invalid Attendance Id");
                    }
                    if (isvalidAttendanceStatus == false)
                    {
                        MessageBox.Show("Invalid Attendance Status");
                    }
                    if (isvalidStudentId == false)
                    {
                        MessageBox.Show("Invalid Student Id");
                    }
                }
            }
        }

        private void btnViewStudentAttendance_Click(object sender, EventArgs e)
        {
            String cmd = "SELECT * FROM StudentAttendance";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridStudentAttendance.DataSource = table;

            conn.Close();

        }
        /// <summary>
        /// Checking that the given letter of strings are Digits
        /// </summary>
        /// <param name="Digits"></param>
        /// <returns>bool</returns>
        bool isDigit(string Digits)
        {
            bool IsDigit = false;
            foreach (char number in Digits)
            {
                if (char.IsDigit(number))
                {
                    IsDigit = true;
                }
                else
                {
                    IsDigit = false;
                }
            }
            return IsDigit;
        }

        private void GridStudentAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int AttendanceID = Convert.ToInt32(GridStudentAttendance.Rows[e.RowIndex].Cells[0].Value);
            int StudentId = Convert.ToInt32(GridStudentAttendance.Rows[e.RowIndex].Cells[1].Value);
            int AttendanceStatus = Convert.ToInt32(GridStudentAttendance.Rows[e.RowIndex].Cells[2].Value);
            var element = GridStudentAttendance.Columns["Delete"].Index;
            var update = GridStudentAttendance.Columns["Update"].Index;
            if (e.ColumnIndex == element)
            {
               
                string cmd = String.Format("DELETE FROM StudentAttendance WHERE StudentId = @StudentId AND AttendanceId = @AttendanceId");
                SqlCommand command = new SqlCommand(cmd, conn);

                command.Parameters.Add(new SqlParameter("@StudentId", StudentId));
                command.Parameters.Add(new SqlParameter("@AttendanceId", AttendanceID));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                conn.Close();

                cmd = "SELECT * FROM StudentAttendance";
                command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                conn.Open();
                reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                GridStudentAttendance.DataSource = table;
                conn.Close();


            }
            else if (e.ColumnIndex == GridStudentAttendance.Columns["Update"].Index)
            {
                lblHide.Hide();
                var item = GridStudentAttendance.Rows[e.RowIndex].Cells[0].Value;

                string cmd = String.Format("SELECT * FROM StudentAttendance WHERE AttendanceId = @AttendanceId AND StudentId = @StudentId AND AttendanceStatus = @AttendanceStatus");
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@AttendanceId", AttendanceID));
                command.Parameters.Add(new SqlParameter("@StudentId", StudentId));
                command.Parameters.Add(new SqlParameter("@AttendanceStatus", AttendanceStatus));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                Student s = new Student();

                btnAddStudentAttendance.Text = "Update Student Attendance";
                while (reader.Read())
                {
                    cmbattendanceID.Text = Convert.ToString(reader[0]);
                    cmbStudentId.Text = Convert.ToString(reader[1]);
                    cmbAttendanceStatus.Text = Convert.ToString(reader[2]);
                    
                }
                TabPageAddStudenAttendance.Show();
                conn.Close();
            }
        }
    }
}
