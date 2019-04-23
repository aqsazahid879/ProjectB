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
    
    public partial class Rubrics : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =DESKTOP-GLD2JPV; Initial Catalog = ProjectB; User ID =sa; Password =aqsazahid12345; MultipleActiveResultSets = True");
        public Rubrics()
        {
            InitializeComponent();
        }

        private void Rubrics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet2.Rubric' table. You can move, or remove it, as needed.
            //this.rubricTableAdapter.Fill(this.projectBDataSet2.Rubric);
            String cmd = "SELECT Id FROM Clo";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                cmbCloId.Items.Add(reader[0]);
            }
            conn.Close();
        }

        private void btnAddRubric_Click(object sender, EventArgs e)
        {
            bool isNumber = false;
            isNumber=isDigit(txtID.Text);
            bool isID = false;
            if(txtID.Text.Length > 0 && isNumber == true)
            {
                isID = true;
            }
            else
            {
                MessageBox.Show("Please Enter a valid ID");
            }
            bool IsValidDetail = false;
            if(txtDetail.Text.Length > 0)
            {
                IsValidDetail = true;
            }
            else
            {
                IsValidDetail = false;
                MessageBox.Show("Please Enter detail of rubric");
            }
            bool isCloId;
            if(cmbCloId.Text.Length >0 && isDigit(cmbCloId.Text))
            {
                isCloId = true;
            }
            else
            {
                isCloId = false;
                MessageBox.Show("Please Enter Valid CLOID");
            }
            bool isValidDetail2 = false;
            if (string.IsNullOrWhiteSpace(txtDetail.Text))
            {
                MessageBox.Show("Invalid Detail");
                isValidDetail2 = false;
            }
            else
            {
                
                isValidDetail2 = true;
            }

            if (isNumber == true && btnAddRubric.Text == "Add Rubric" && IsValidDetail == true && isDigit(cmbCloId.Text) && isValidDetail2)
            {
                bool isIDExist = false;
                string cmd = "SELECT Id FROM Rubric";
                SqlCommand command = new SqlCommand(cmd, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int Id = Convert.ToInt32(txtID.Text);
                    if(Id == Convert.ToInt32(reader[0]))
                    {
                        isIDExist = true;
                        MessageBox.Show("Rubric Id already exists");
                        break;
                    }
                }
                conn.Close();
                if(isIDExist == false)
                {
                    string detail;
                    int id, CloID;
                    detail = txtDetail.Text;
                    id = Convert.ToInt32(txtID.Text);
                    CloID = Convert.ToInt32(cmbCloId.Text);

                    conn.Open();
                    cmd = String.Format("INSERT INTO Rubric(Id, Details, CloId) values('{0}','{1}','{2}')", id, detail, CloID);
                    command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("0", 1));

                    reader = command.ExecuteReader();
                    MessageBox.Show("Rubric has been added");
                    txtID.Text = "";
                    txtDetail.Text = "";
                    cmbCloId.Text = "";
                    conn.Close();

                }


            }
            else if(btnAddRubric.Text == "Update Rubric" && IsValidDetail && isValidDetail2)
            {
                if(isDigit(txtID.Text) == true)
                {
                    
                    conn.Open();
                    string Detail = txtDetail.Text;
                    int Id = Convert.ToInt32(txtID.Text);
                    int cloid = Convert.ToInt32(cmbCloId.Text);
                    string cmd = String.Format("UPDATE Rubric SET Id = @Id, Details = @Detail, CloId = @cloid WHERE Id = @Id");
                    //SqlCommand command = new SqlCommand(cmd, conn);

                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("@Detail", Detail));
                    command.Parameters.Add(new SqlParameter("@cloid", cloid));
                    command.Parameters.Add(new SqlParameter("@Id", Id));
                    SqlDataReader reader = command.ExecuteReader();
                    txtID.Text = "";
                    txtDetail.Text = "";
                    cmbCloId.Text = "";
                    conn.Close();
                    tabAddRubric.Hide();
                    tabViewRubric.Show();
                    lblId.Show();
                    txtID.Show();
                    btnAddRubric.Text = "Add Rubric";
                    conn.Open();
                    cmd = String.Format("SELECT * FROM Rubric");
                    command = new SqlCommand(cmd, conn);
                    reader = command.ExecuteReader();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    gridViewRubrics.DataSource = table;
                    conn.Close();
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

        private void btnViewRubric_Click(object sender, EventArgs e)
        {
            String cmd = "SELECT * FROM Rubric";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridViewRubrics.DataSource = table;
            conn.Close();
        }

        private void gridViewRubrics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var element = gridViewRubrics.Columns["Delete"].Index;
            var update = gridViewRubrics.Columns["Update"].Index;
            if (e.ColumnIndex == element)
            {
                int ID;
                ID = Convert.ToInt32(gridViewRubrics.Rows[e.RowIndex].Cells[0].Value);
                string cmd = String.Format("DELETE FROM RubricLevel WHERE RubricId IN(SELECT RubricId FROM RubricLevel WHERE RubricId = @ID)");
                SqlCommand command = new SqlCommand(cmd, conn);

                command.Parameters.Add(new SqlParameter("@ID", ID));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                conn.Close();

                cmd = String.Format("DELETE FROM Rubric WHERE Id = @ID1");
                command = new SqlCommand(cmd, conn);

                command.Parameters.Add(new SqlParameter("@ID1", ID));
                conn.Open();
                reader = command.ExecuteReader();
                conn.Close();


                conn.Open();
                cmd = String.Format("SELECT *FROM Rubric");
                reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridViewRubrics.DataSource = table;
                conn.Close();

            }
            else if (e.ColumnIndex == gridViewRubrics.Columns["Update"].Index)
            {
                lblId.Hide(); txtID.Hide();
                var item = gridViewRubrics.Rows[e.RowIndex].Cells[0].Value;
                //int IdOfItem;
                //var SecondItem = gridStudentInformation.Rows[e.RowIndex].Cells[6].Value;
                string cmd = String.Format("SELECT * FROM Rubric WHERE Id = @item");
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@item", item));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                Student s = new Student();
                //tabControl1.SelectedTab = tabControl1.TabPages["View Student"].Show;

                btnAddRubric.Text = "Update Rubric";
                while (reader.Read())
                {
                    txtID.Text = Convert.ToString(reader[0]);
                    txtDetail.Text = Convert.ToString(reader[1]);
                    cmbCloId.Text = Convert.ToString(reader[2]);

                }
                tabAddRubric.Show();
                conn.Close();
            }

        }

        private void lnkStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student stu = new Student();
            this.Hide();
            stu.Show();
        }

        private void lnkClo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CLO c = new CLO();
            this.Hide();
            c.Show();
        }

        private void lnkRubric_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rubrics rub = new Rubrics();
            this.Hide();
            rub.Show();
        }

        private void lnkRubricLevel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RubricLevel rubriclevel = new RubricLevel();
            this.Hide();
            rubriclevel.Show();
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
