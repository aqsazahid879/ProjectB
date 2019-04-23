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
    public partial class Assessment : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =DESKTOP-GLD2JPV; Initial Catalog = ProjectB; User ID =sa; Password =aqsazahid12345; MultipleActiveResultSets = True");

        public Assessment()
        {
            InitializeComponent();
        }

        private void btnAddAssessment_Click(object sender, EventArgs e)
        {
            bool isdigit = false;
            bool isnumber = false;
            isdigit = isDigit(txtMarks.Text);
            isnumber = isDigit(txtTotalWeightage.Text);
            if(btnAddAssessment.Text == "Add Assessment")
            {
                if (isdigit == true && isnumber == true)
                {
                    conn.Open();
                    String cmd = String.Format("INSERT INTO Assessment(Title, DateCreated, TotalMarks, TotalWeightage) values('{0}','{1}','{2}', '{3}')", txtTitle.Text, DateTime.Now, Convert.ToInt32(txtMarks.Text), Convert.ToInt32(txtTotalWeightage.Text));
                    SqlCommand command = new SqlCommand(cmd, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    txtTitle.Text = "";
                    txtMarks.Text = "";
                    txtTotalWeightage.Text = "";
                    MessageBox.Show("Added Successfully");
                    conn.Close();
                }
                else if (isdigit == false)
                {
                    MessageBox.Show("Invalid Marks");
                    if (isnumber == false)
                    {
                        MessageBox.Show("Invalid Weightage");
                    }
                }
                else if (isnumber == false)
                {
                    MessageBox.Show("Invalid Weightage");
                }
            }
            else
            {
                if (isdigit == true && isnumber == true)
                {
                    conn.Open();
                    string title = txtTitle.Text;
                    int mark = Convert.ToInt32(txtMarks.Text);
                    int weightage = Convert.ToInt32(txtTotalWeightage.Text);
                    
                    string cmd = String.Format("UPDATE AssessmentComponent SET Title = @title, TotalMarks = @mark, TotalWeightage = @weightage WHERE Id = @ID");
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("@title", title));
                    command.Parameters.Add(new SqlParameter("@mark", mark));
                    command.Parameters.Add(new SqlParameter("@weightage", weightage));
                    command.Parameters.Add(new SqlParameter("@ID", Convert.ToInt32(lblHide.Text)));
                    SqlDataReader reader = command.ExecuteReader();

                    txtTitle.Text = "";
                    txtMarks.Text = "";
                    txtTotalWeightage.Text = "";
                    conn.Close();
                    btnAddAssessment.Text = "Add Assessment";
                    tabAddAssessment.Hide();
                    tabViewAssessment.Show();

                    cmd = "SELECT * FROM Assessment";
                    command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("0", 1));
                    conn.Open();
                    reader = command.ExecuteReader();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    conn.Close();

                }
                else if (isdigit == false)
                {
                    MessageBox.Show("Invalid Marks");
                    if (isnumber == false)
                    {
                        MessageBox.Show("Invalid Weightage");
                    }
                }
                else if (isnumber == false)
                {
                    MessageBox.Show("Invalid Weightage");
                }

            }

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

        private void Assessment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assessmentDataSet.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.assessmentDataSet.Assessment);
            // TODO: This line of code loads data into the 'projectBDataSet4.Assessment' table. You can move, or remove it, as needed.
           // this.assessmentTableAdapter.Fill(this.projectBDataSet4.Assessment);
            lblHide.Hide();

        }

        private void btnviewassessment_Click(object sender, EventArgs e)
        {
            String cmd = "SELECT * FROM Assessment";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var element = dataGridView1.Columns["Delete"].Index;
            var update = dataGridView1.Columns["Update"].Index;
            if (e.ColumnIndex == element)
            {

                string cmd = String.Format("DELETE FROM Assessment WHERE Id = @id");
                SqlCommand command = new SqlCommand(cmd, conn);

                command.Parameters.Add(new SqlParameter("@id", ID));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                conn.Close();

                cmd = "SELECT * FROM Assessment";
                command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                conn.Open();
                reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                conn.Close();


            }
            else if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                lblHide.Hide();
                var item = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                string cmd = String.Format("SELECT * FROM Assessment WHERE Id = @item");
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@item", item));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                Student s = new Student();

                btnAddAssessment.Text = "Update Assessment";
                while (reader.Read())
                {
                    lblHide.Text = Convert.ToString(reader[0]);
                    txtTitle.Text = Convert.ToString(reader[1]);
                    txtMarks.Text = Convert.ToString(reader[3]);
                    txtTotalWeightage.Text = Convert.ToString(reader[4]);
                }
                tabAddAssessment.Show();
                conn.Close();
            }
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
    }
}