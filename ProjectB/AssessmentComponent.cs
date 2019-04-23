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
    public partial class AssessmentComponent : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =DESKTOP-GLD2JPV; Initial Catalog = ProjectB; User ID =sa; Password =aqsazahid12345; MultipleActiveResultSets = True");
        public AssessmentComponent()
        {
            InitializeComponent();
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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddAssessmentComponent_Click(object sender, EventArgs e)
        {
            
            bool isValidTotalMarks = isDigit(txtTotalMarks.Text);
            bool IsValidRubricId = isDigit(cmbRubricId.Text);
            bool isValidAssessmentId = isDigit(cmbAssessmentId.Text);
            if(btnAddAssessmentComponent.Text == "Add Assessment Component")
            {
                if(IsValidRubricId && isValidAssessmentId && isValidTotalMarks )
                {
                    conn.Open();
                    String cmd = String.Format("INSERT INTO AssessmentComponent(Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}' )", txtName.Text, Convert.ToInt32(cmbRubricId.Text), Convert.ToInt32(txtTotalMarks.Text), DateTime.Now, DateTime.Now, Convert.ToInt32(cmbAssessmentId.Text));
                    SqlCommand command = new SqlCommand(cmd, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    txtName.Text = "";
                    txtTotalMarks.Text = "";
                    cmbRubricId.Text = "";
                    cmbAssessmentId.Text = "";
                    MessageBox.Show("Added Successfully");
                    conn.Close();

                }
                else
                {
                    if(isValidAssessmentId == false)
                    {
                        MessageBox.Show("Invalid Assessment Id");
                    }
                    if(IsValidRubricId == false)
                    {
                        MessageBox.Show("Invalid Rubric Id");
                    }
                    if(isValidTotalMarks == false)
                    {
                        MessageBox.Show("Invalid Total Marks");
                    }
                }
            }
            else
            {
                if (IsValidRubricId && isValidAssessmentId && isValidTotalMarks)
                {
                    
                    conn.Open();
                    
                    string cmd = String.Format("UPDATE AssessmentComponent SET Name = @name, RubricId = @RubricId, TotalMarks = @mark, DateUpdated = @date, AssessmentId = @AssessmentId WHERE Id = @ID");

                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("@name", txtName.Text));
                    command.Parameters.Add(new SqlParameter("@RubricId", Convert.ToInt32(cmbRubricId.Text)));
                    command.Parameters.Add(new SqlParameter("@mark", Convert.ToInt32(txtTotalMarks.Text)));
                    command.Parameters.Add(new SqlParameter("@date", DateTime.Now));
                    command.Parameters.Add(new SqlParameter("@AssessmentId", Convert.ToInt32(cmbAssessmentId.Text)));
                    command.Parameters.Add(new SqlParameter("@ID", Convert.ToInt32(lblHide.Text)));
                    SqlDataReader reader = command.ExecuteReader();

                    txtName.Text = "";
                    txtTotalMarks.Text = "";
                    cmbAssessmentId.Text = "";
                    cmbRubricId.Text = "";
                    conn.Close();
                    btnAddAssessmentComponent.Text = "Add Assessment Component";
                    TabAddAssessmentComponent.Hide();
                    TabViewAssessmentComponent.Show();

                    cmd = "SELECT * FROM AssessmentComponent";
                    command = new SqlCommand(cmd, conn);
                    
                    conn.Open();
                    reader = command.ExecuteReader();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    GridAssessmentComponent.DataSource = table;
                    conn.Close();


                }
                else
                {
                    if (isValidAssessmentId == false)
                    {
                        MessageBox.Show("Invalid Assessment Id");
                    }
                    if (IsValidRubricId == false)
                    {
                        MessageBox.Show("Invalid Rubric Id");
                    }
                    if (isValidTotalMarks == false)
                    {
                        MessageBox.Show("Invalid Total Marks");
                    }
                }
            }
        }
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

        private void AssessmentComponent_Load(object sender, EventArgs e)
        {
            lblHide.Hide();
            // TODO: This line of code loads data into the 'assessmentComponentDataSet.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.assessmentComponentDataSet.AssessmentComponent);
            String cmd = "SELECT Id FROM Rubric";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbRubricId.Items.Add(reader[0]);
            }
            conn.Close();

            cmd = "SELECT Id FROM Assessment";
            command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbAssessmentId.Items.Add(reader[0]);
            }
            conn.Close();

        }

        private void GridAssessmentComponent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(GridAssessmentComponent.Rows[e.RowIndex].Cells[0].Value);
            var element = GridAssessmentComponent.Columns["Delete"].Index;
            var update = GridAssessmentComponent.Columns["Update"].Index;
            if (e.ColumnIndex == element)
            {
                string cmd = String.Format("DELETE FROM StudentResult where AssessmentComponentId = @id");
                
                SqlCommand command = new SqlCommand(cmd, conn);

                command.Parameters.Add(new SqlParameter("@id", ID));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                conn.Close();
                cmd = "Delete from AssessmentComponent where Id = @id";
                command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@id", ID));
                conn.Open();
                reader = command.ExecuteReader();
                conn.Close();
                cmd = "SELECT * FROM AssessmentComponent";
                command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                conn.Open();
                reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                GridAssessmentComponent.DataSource = table;
                conn.Close();


            }
            else if (e.ColumnIndex == GridAssessmentComponent.Columns["Update"].Index)
            {
                lblHide.Hide();
                var item = GridAssessmentComponent.Rows[e.RowIndex].Cells[0].Value;

                string cmd = String.Format("SELECT * FROM AssessmentComponent WHERE Id = @item");
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@item", item));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                Student s = new Student();

                btnAddAssessmentComponent.Text = "Update Assessment Component";
                while (reader.Read())
                {
                    lblHide.Text = Convert.ToString(reader[0]);
                    txtName.Text = Convert.ToString(reader[1]);
                    cmbRubricId.Text = Convert.ToString(reader[2]);
                    txtTotalMarks.Text = Convert.ToString(reader[3]);
                    cmbAssessmentId.Text = Convert.ToString(reader[6]);
                }
                TabAddAssessmentComponent.Show();
                conn.Close();
            }
        }

        private void btnViewAssessmentComponent_Click(object sender, EventArgs e)
        {
            String cmd = "SELECT * FROM AssessmentComponent";
            SqlCommand command = new SqlCommand(cmd, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridAssessmentComponent.DataSource = table;
            conn.Close();
        }
    }
}
