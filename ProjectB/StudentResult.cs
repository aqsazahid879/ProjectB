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

    public partial class StudentResult : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =DESKTOP-GLD2JPV; Initial Catalog = ProjectB; User ID =sa; Password =aqsazahid12345; MultipleActiveResultSets = True");

        public StudentResult()
        {
            InitializeComponent();
        }

        private void StudentResult_Load(object sender, EventArgs e)
        {
            String cmd = "SELECT Id FROM Student";
            SqlCommand command = new SqlCommand(cmd, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbStudentId.Items.Add(reader[0]);
            }
            conn.Close();

            
            // Adding Assesment Titles in combo box
            cmd = "SELECT Title FROM Assessment";
            command = new SqlCommand(cmd, conn);
            conn.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbAssessmentTitle.Items.Add(reader[0]);
            }
            conn.Close();

            // Adding RubricLevel Id
            cmd = "SELECT Id FROM RubricLevel ";
            command = new SqlCommand(cmd, conn);
            conn.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbDetails.Items.Add(reader[0]);
            }
            conn.Close();

            string cm = "SELECT StudentId From StudentResult";
            SqlCommand comm = new SqlCommand(cm, conn);
            conn.Open();
            reader = comm.ExecuteReader();
            int[] student = new int[100];
            int j = 0;
            while(reader.Read())
            {
                GridStudentResult.Columns["StudentId"].Visible = true;
                student[j] = Convert.ToInt32(reader[0]);
                j = j + 1;
            }

                conn.Close();
            string q1 = "SELECT StudentResult.AssessmentComponentId, StudentResult.StudentId, Student.FirstName As Student, Rubric.Details, Assessment.Title AS AssessmentTitle, AssessmentComponent.TotalMarks AS ComponentMarks, RubricLevel.MeasurementLevel FROM StudentResult JOIN Student On StudentResult.StudentId = Student.Id JOIN AssessmentComponent ON Assessmentcomponent.Id = StudentResult.AssessmentComponentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id Join Assessment ON Assessment.Id = AssessmentComponent.AssessmentId ";
            SqlDataAdapter d = new SqlDataAdapter(q1, conn);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridStudentResult.DataSource = dt;
            GridStudentResult.Columns["AssessmentComponentId"].Visible = true;
            GridStudentResult.Columns["StudentId"].Visible = true;

            int count = GridStudentResult.RowCount;
            for (int i = 0; i < count; i++)
            {
                double k = Convert.ToDouble(GridStudentResult.Rows[i].Cells["ComponentMarks"].Value);
                double l = Convert.ToDouble(GridStudentResult.Rows[i].Cells["MeasurementLevel"].Value);
                double marks = Convert.ToDouble((l / 4) * k);
                GridStudentResult.Rows[i].Cells["ObtainedMarks"].Value = marks;
                GridStudentResult.Rows[i].Cells["StudentId"].Value = student[i];
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

        private void cmbAssessmentTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cmd = "SELECT * FROM Assessment WHERE Title = @title";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("@title", cmbAssessmentTitle.Text));
            conn.Open();
            int query;
            query = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();

            conn.Open();
            cmd = "SELECT Id FROM AssessmentComponent WHERE AssessmentId = @AssessmentId";
            command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("@AssessmentId", query));
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                cmbAssessmentComponentId.Items.Add(reader[0]);
            }
            conn.Close();
            

        }

        private void cmbAssessmentComponentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cmd = "SELECT RubricId FROM AssessmentComponent WHERE Id =@id ";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("@id", cmbAssessmentComponentId.Text));
            conn.Open();
            int query = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            conn.Open();
            cmd = "SELECT Details FROM Rubric WHERE Id = @ID";
            command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("@ID", query));
            cmbDetails.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbDetails.Items.Add(reader[0]);
            }
            conn.Close();

        }

        private void cmbDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cmd = "SELECT Id FROM Rubric WHERE Details =@detail";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("@detail", cmbDetails.Text));
            conn.Open();
            int query = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            conn.Open();
            cmd = "SELECT MeasurementLevel FROM RubricLevel WHERE RubricId = @ID";
            command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("@ID", query));
            //cmbDetails.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbMeasurementLevel.Items.Add(reader[0]);
            }
            conn.Close();

        }

        private void cmbMeasurementLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cmd = "SELECT Id FROM RubricLevel WHERE MeasurementLevel = @level";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("@level", cmbMeasurementLevel.Text));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbRubricLevel.Items.Add(reader[0]);
            }
            conn.Close();

        }

        private void btnaddStudentResult_Click(object sender, EventArgs e)
        {
            String cmd = String.Format("INSERT INTO StudentResult(StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) values('{0}','{1}','{2}','{3}')", Convert.ToInt32(cmbStudentId.Text), Convert.ToInt32(cmbAssessmentComponentId.Text), Convert.ToInt32(cmbRubricLevel.Text), DateTime.Now.Date);
            conn.Open();
            SqlCommand command = new SqlCommand(cmd, conn);
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            cmbStudentId.Items.Clear();
            cmbRubricLevel.Items.Clear();
            cmbAssessmentTitle.Items.Clear();
            cmbAssessmentComponentId.Items.Clear();
            cmbDetails.Items.Clear();
            cmbMeasurementLevel.Items.Clear();
            MessageBox.Show("Student Result has been Added");
            conn.Close();
            string q1 = "SELECT StudentResult.AssessmentComponentId, StudentResult.StudentId, Student.FirstName As Student, Rubric.Details, Assessment.Title AS AssessmentTitle, AssessmentComponent.TotalMarks AS ComponentMarks, RubricLevel.MeasurementLevel FROM StudentResult JOIN Student On StudentResult.StudentId = Student.Id JOIN AssessmentComponent ON Assessmentcomponent.Id = StudentResult.AssessmentComponentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id Join Assessment ON Assessment.Id = AssessmentComponent.AssessmentId ";

            SqlDataAdapter d = new SqlDataAdapter(q1, conn);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridStudentResult.DataSource = dt;
            GridStudentResult.Columns["AssessmentComponentId"].Visible = false;
            //GridStudentResult.Columns["StudentId"].Visible = false;

            int count = GridStudentResult.RowCount;
            for (int i = 0; i < count; i++)
            {
                double k = Convert.ToDouble(GridStudentResult.Rows[i].Cells["ComponentMarks"].Value);
                double l = Convert.ToDouble(GridStudentResult.Rows[i].Cells["MeasurementLevel"].Value);
                double marks = Convert.ToDouble((l / 4) * k);
                GridStudentResult.Rows[i].Cells["ObtainedMarks"].Value = marks;
            }



            cmd = "SELECT Id FROM Student";
            command = new SqlCommand(cmd, conn);
            conn.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbStudentId.Items.Add(reader[0]);
            }
            conn.Close();
            // Adding Assesment Titles in combo box
            cmd = "SELECT Title FROM Assessment";
            command = new SqlCommand(cmd, conn);
            conn.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbAssessmentTitle.Items.Add(reader[0]);
            }
            conn.Close();

            // Adding RubricLevel Id
            cmd = "SELECT Id FROM RubricLevel ";
            command = new SqlCommand(cmd, conn);
            conn.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbDetails.Items.Add(reader[0]);
            }
            conn.Close();


        }

        private void btnViewStudentResult_Click(object sender, EventArgs e)
        {

            string cm = "SELECT StudentId From StudentResult";
            SqlCommand comm = new SqlCommand(cm, conn);
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            int[] student = new int[100];
            int j = 0;
            while (reader.Read())
            {
                GridStudentResult.Columns["StudentId"].Visible = true;
                student[j] = Convert.ToInt32(reader[0]);
                j = j + 1;
            }
            conn.Close();
            string q1 = "SELECT StudentResult.AssessmentComponentId, StudentResult.StudentId, Student.FirstName As Student, Rubric.Details, Assessment.Title AS AssessmentTitle, AssessmentComponent.TotalMarks AS ComponentMarks, RubricLevel.MeasurementLevel FROM StudentResult JOIN Student On StudentResult.StudentId = Student.Id JOIN AssessmentComponent ON Assessmentcomponent.Id = StudentResult.AssessmentComponentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id Join Assessment ON Assessment.Id = AssessmentComponent.AssessmentId ";
            SqlDataAdapter d = new SqlDataAdapter(q1, conn);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridStudentResult.DataSource = dt;
            GridStudentResult.Columns["AssessmentComponentId"].Visible = true;
            GridStudentResult.Columns["StudentId"].Visible = true;

            int count = GridStudentResult.RowCount;
            for (int i = 0; i < count; i++)
            {
                double k = Convert.ToDouble(GridStudentResult.Rows[i].Cells["ComponentMarks"].Value);
                double l = Convert.ToDouble(GridStudentResult.Rows[i].Cells["MeasurementLevel"].Value);
                double marks = Convert.ToDouble((l / 4) * k);
                GridStudentResult.Rows[i].Cells["ObtainedMarks"].Value = marks;
                GridStudentResult.Rows[i].Cells["StudentId"].Value = student[i];
            }

        }

        private void GridStudentResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int StudentId = Convert.ToInt32(GridStudentResult.Rows[e.RowIndex].Cells[1].Value);
            int AssessmentComponentId = Convert.ToInt32(GridStudentResult.Rows[e.RowIndex].Cells[2].Value);
            var element = GridStudentResult.Columns["Delete"].Index;
            if (e.ColumnIndex == element)
            {
                conn.Open();
                String cmd = "DELETE FROM StudentResult WHERE StudentId = @id1 and AssessmentComponentId = @id2";
                SqlCommand command = new SqlCommand(cmd, conn);
                this.GridStudentResult.Rows.RemoveAt(e.RowIndex);
                command.Parameters.Add(new SqlParameter("@id1", StudentId));
                command.Parameters.Add(new SqlParameter("@id2", AssessmentComponentId));
                SqlDataReader reader = command.ExecuteReader();
                conn.Close();
                

            }
            
        }
    }
}
