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
    public partial class RubricLevel : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =DESKTOP-GLD2JPV; Initial Catalog = ProjectB; User ID =sa; Password =aqsazahid12345; MultipleActiveResultSets = True");
        public RubricLevel()
        {
            InitializeComponent();
        }

        private void RubricLevel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rubricLevelData.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.rubricLevelData.RubricLevel);
            lblHide.Hide();
            btnAddRubricLevel.Text = "Add Rubric Level";
            // TODO: This line of code loads data into the 'projectBDataSet3.RubricLevel' table. You can move, or remove it, as needed.
            //this.rubricLevelTableAdapter.Fill(this.projectBDataSet3.RubricLevel);
            String cmd = "SELECT Id from Rubric";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbRubricID.Items.Add(reader[0]);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
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

        private void btnAddRubricLevel_Click(object sender, EventArgs e)
        {
            if(btnAddRubricLevel.Text == "Add Rubric Level")
            {
                bool IsCorrectNumber = false;
                IsCorrectNumber = isDigit(txtMeasurementLevel.Text);
                if (IsCorrectNumber == true)
                {
                    conn.Open();
                    String cmd = String.Format("INSERT INTO RubricLevel(RubricId, Details, MeasurementLevel) values('{0}','{1}','{2}')", Convert.ToInt32(cmbRubricID.Text), txtDetails.Text, Convert.ToInt32(txtMeasurementLevel.Text));
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("0", 1));

                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Added Successfully");
                    txtDetails.Text = "";
                    txtMeasurementLevel.Text = "";
                    cmbRubricID.Text = "";
                    conn.Close();
                }
            }
            else
            {
                if(isDigit(txtMeasurementLevel.Text))
                {
                    conn.Open();
                    int RubriciD = Convert.ToInt32(cmbRubricID.Text);
                    string Detail = txtDetails.Text;
                    int MeasurementLevel = Convert.ToInt32(txtMeasurementLevel.Text);
                    string cmd = String.Format("UPDATE RubricLevel SET RubricId = @RubricID, Details = @Detail, MeasurementLevel = @level WHERE Id = @ID");
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("@Detail", Detail));
                    command.Parameters.Add(new SqlParameter("@RubricID", RubriciD));
                    command.Parameters.Add(new SqlParameter("@level", MeasurementLevel));
                    command.Parameters.Add(new SqlParameter("Id", Convert.ToInt32(lblHide.Text)));
                    SqlDataReader reader = command.ExecuteReader();

                    txtDetails.Text = "";
                    txtMeasurementLevel.Text = "";
                    cmbRubricID.Text = "";
                    conn.Close();
                    btnAddRubricLevel.Text = "Add Rubric Level";
                    TabAddRubricLevel.Hide();
                    TabViewRubricLevel.Show();

                    cmd = "SELECT * FROM RubricLevel";
                    command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("0", 1));
                    conn.Open();
                    reader = command.ExecuteReader();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    gridRubricLevel.DataSource = table;
                    conn.Close();

                }
            }

            
        }

        private void lnkRubricLevel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RubricLevel rubriclevel = new RubricLevel();
            this.Hide();
            rubriclevel.Show();
        }

        private void lnkRubric_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rubrics rub = new Rubrics();
            this.Hide();
            rub.Show();
        }

        

        private void lnkClo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CLO c = new CLO();
            this.Hide();
            c.Show();
        }

        private void lnkStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student stu = new Student();
            this.Hide();
            stu.Show();
        }

        private void btnViewRubricLevel_Click(object sender, EventArgs e)
        {
            String cmd = "SELECT * FROM RubricLevel";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridRubricLevel.DataSource = table;
            conn.Close();
        }

        private void TabViewRubricLevel_Click(object sender, EventArgs e)
        {
            String cmd = "SELECT * FROM RubricLevel";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridRubricLevel.DataSource = table;
            conn.Close();
        }

        private void gridRubricLevel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = ID = Convert.ToInt32(gridRubricLevel.Rows[e.RowIndex].Cells[0].Value);
            var element = gridRubricLevel.Columns["Delete"].Index;
            var update = gridRubricLevel.Columns["Update"].Index;
            if (e.ColumnIndex == element)
            {

                string cmd;
                cmd = "Delete from StudentResult where RubricMeasurementId = @id";
                SqlCommand command = new SqlCommand(cmd, conn);

                command.Parameters.Add(new SqlParameter("@id", ID));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                conn.Close();


                cmd = String.Format("DELETE FROM RubricLevel WHERE Id = @id");
                command = new SqlCommand(cmd, conn);

                command.Parameters.Add(new SqlParameter("@id", ID));
                conn.Open();
                reader = command.ExecuteReader();
                conn.Close();

                cmd = "SELECT * FROM RubricLevel";
                command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                conn.Open();
                reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridRubricLevel.DataSource = table;
                conn.Close();


            }
            else if (e.ColumnIndex == gridRubricLevel.Columns["Update"].Index)
            {
                lblHide.Hide(); 
                var item = gridRubricLevel.Rows[e.RowIndex].Cells[0].Value;
                
                string cmd = String.Format("SELECT * FROM RubricLevel WHERE Id = @item");
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@item", item));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                Student s = new Student();
                
                btnAddRubricLevel.Text = "Update Rubric";
                while (reader.Read())
                {
                    lblHide.Text = Convert.ToString(reader[0]);
                    cmbRubricID.Text = Convert.ToString(reader[1]);
                    txtDetails.Text = Convert.ToString(reader[2]);
                    txtMeasurementLevel.Text = Convert.ToString(reader[3]);
                }
                TabAddRubricLevel.Show();
                conn.Close();
            }



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

        private void lnkClassAttendance_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
