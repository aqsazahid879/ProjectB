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
        /// <summary>
        /// Button Click Event of Add CLO.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCLO_Click(object sender, EventArgs e)
        {
            
            if(btnAddCLO.Text == "Add CLO")
            {
                bool isValidName = false;
                if(string.IsNullOrWhiteSpace(txtName.Text))
                {
                    isValidName = false;
                }
                else
                {
                    isValidName = true;
                }
                
                lblId.Hide();
                if (isExist(txtName.Text) && isValidName == true)
                {
                    ClassCLO clo = new ClassCLO();
                    clo.Name1 = txtName.Text;
                    clo.DateCreated1 = DateTime.Now;
                    clo.DateUpdated1 = DateTime.Now;
                    DateTime date = DateTime.Now;
                    conn.Open();
                    string cmd = String.Format("INSERT INTO Clo(Name, DateCreated, DateUpdated) VALUES('{0}','{1}','{2}')", txtName.Text, date, date);
                    SqlCommand command = new SqlCommand(cmd, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("CLO has been added");
                    txtName.Text = "";
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter CLO Name");
                }
                
                
                
            }
            else
            {
                bool isValidName = false;
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Invalid Name");
                    isValidName = false;
                }
                else
                {
                    isValidName = true;
                }
                if (isExist(txtName.Text) && isValidName == true)
                {
                    ClassCLO clo = new ClassCLO();
                    clo.Name1 = txtName.Text;
                    clo.DateUpdated1 = DateTime.Now;
                    DateTime date = DateTime.Now;
                    conn.Open();
                    string Name = txtName.Text;
                    int Id = Convert.ToInt32(lblId.Text);


                    string cmd = String.Format("UPDATE Clo SET Name = @Name, DateUpdated = @date WHERE Id = @Id");
                    //SqlCommand command = new SqlCommand(cmd, conn);
                    MessageBox.Show("CLO has been updated");
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
                    btnAddCLO.Text = "Add CLO";
                }
                    
            }
        }
        /// <summary>
        /// Button click of View CLO.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Cell Click Event of GRID.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridCLO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var element = gridCLO.Columns["Delete"].Index;
            var update = gridCLO.Columns["Update"].Index;
            if (e.ColumnIndex == element)
            {


                int id;
                id = Convert.ToInt32(gridCLO.Rows[e.RowIndex].Cells[0].Value);
                conn.Open();
                int[] rubric = new int[5];
                int i = 0;
                int[] assessment = new int[20];
                string qeury = "Select Id from Rubric where CLoId = '" + id + "'";
                SqlCommand com = new SqlCommand(qeury, conn);
                com.Parameters.Add(new SqlParameter("0", 1));
                SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    rubric[i] = Convert.ToInt32(r[0]);
                    i++;
                }

                foreach (int rubricid in rubric)
                {
                    int k = 0;
                    int[] rubriclvl = new int[5];
                    string qeury1 = "Select Id from RubricLevel where RubricId = " + rubricid + "";
                    SqlCommand com1 = new SqlCommand(qeury1, conn);
                    com1.Parameters.Add(new SqlParameter("0", 1));
                    SqlDataReader r1 = com1.ExecuteReader();
                    while (r1.Read())
                    {
                        rubriclvl[i] = Convert.ToInt32(r1[0]);
                        i++;
                    }
                    foreach (int levelid in rubriclvl)
                    {
                        string qeury2 = "Delete from StudentResult where RubricMeasurementId = " + levelid + "";
                        SqlCommand com2 = new SqlCommand(qeury2, conn);
                        com2.ExecuteNonQuery();

                    }
                    string qeury3 = "Delete from RubricLevel where Rubricid = " + rubricid + "";
                    SqlCommand com3 = new SqlCommand(qeury3, conn);
                    com3.ExecuteNonQuery();
                }
                foreach (int rubricid in rubric)
                {
                    int k = 0;
                    int[] assessmentlvl = new int[5];
                    string qeury1 = "Select Id from AssessmentComponent where RubricId = " + rubricid + "";
                    SqlCommand com1 = new SqlCommand(qeury1, conn);
                    com1.Parameters.Add(new SqlParameter("0", 1));
                    SqlDataReader r1 = com1.ExecuteReader();
                    while (r1.Read())
                    {
                        assessmentlvl[i] = Convert.ToInt32(r1[0]);
                        i++;
                    }
                    foreach (int assessmentid in assessmentlvl)
                    {
                        string qeury2 = "Delete from StudentResult where AssessmentComponentId = " + assessmentid + "";
                        SqlCommand com2 = new SqlCommand(qeury2, conn);
                        com2.ExecuteNonQuery();

                    }
                    string qeury3 = "Delete from AssessmentComponent where Rubricid = " + rubricid + "";
                    SqlCommand com3 = new SqlCommand(qeury3, conn);
                    com3.ExecuteNonQuery();
                }

                string qeury4 = "Delete from Rubric where Cloid = '" + id + "'";
                SqlCommand com4 = new SqlCommand(qeury4, conn);
                com4.ExecuteNonQuery();

                string qeury5 = "Delete from Clo where Id = '" + id + "'";
                SqlCommand com5 = new SqlCommand(qeury5, conn);
                com5.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Succesfully");
                String cmd = "SELECT * FROM Clo";
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                SqlDataReader reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable view = new DataTable();
                adapter.Fill(view);
                gridCLO.DataSource = view;
                conn.Close();



                //string cmd = String.Format("SELECT Id FROM Rubric WHERE CloId = @ID");
                //SqlCommand command = new SqlCommand(cmd, conn);
                //command.Parameters.Add(new SqlParameter("@ID", ID));
                //conn.Open();
                //int Rubric[] = new int[100
                //SqlDataReader reader, ReaderRubricLevel;
                //reader = command.ExecuteReader();
                //while(reader.Read())
                //{
                //    string cmd_1 = "DELETE FROM RubricLevel WHERE RubricId = @RubricID";
                //    SqlCommand command1 = new SqlCommand(cmd_1, conn);
                //    command1.Parameters.Add(new SqlParameter("@RubricID", Convert.ToInt32(reader[0])));
                //    ReaderRubricLevel = command1.ExecuteReader();
                //}
                //conn.Close();
                //conn.Open();
                //cmd = String.Format("DELETE FROM Rubric WHERE CloId in (SELECT CloId FROM Rubric WHERE CloId = @cloid)");
                //command = new SqlCommand(cmd, conn);
                //command.Parameters.Add(new SqlParameter("@cloid", ID));

                //reader = command.ExecuteReader();
                //conn.Close();

                //conn.Open();

                //cmd = String.Format("DELETE FROM Clo WHERE Id = @clo");
                //command = new SqlCommand(cmd, conn);
                //command.Parameters.Add(new SqlParameter("@clo", ID));
                //reader = command.ExecuteReader();
                //conn.Close();

                //conn.Open();
                //cmd = String.Format("SELECT * FROM Clo");
                //command = new SqlCommand(cmd, conn);
                //reader = command.ExecuteReader();
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                //DataTable table = new DataTable();
                //adapter.Fill(table);
                //gridCLO.DataSource = table;
                //conn.Close();

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
        }
        /// <summary>
        /// Built in fucntion at page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CLO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cLODataSet.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.cLODataSet.Clo);
            // TODO: This line of code loads data into the 'projectBDataSet1.Clo' table. You can move, or remove it, as needed.
            //this.cloTableAdapter.Fill(this.projectBDataSet1.Clo);
            lblId.Hide();
        }

        private void lnkStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student stu = new Student();
            this.Hide();
            stu.Show();
        }
        /// <summary>
        /// Built in fucntion link to CLO page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkClo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CLO c = new CLO();
            this.Hide();
            c.Show();
        }
        /// <summary>
        /// Built in function link to Rubric Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkRubric_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rubrics rub = new Rubrics();
            this.Hide();
            rub.Show();
        }
        /// <summary>
        /// Built In Function link to RubricLevel Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkRubricLevel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RubricLevel rubriclevel = new RubricLevel();
            this.Hide();
            rubriclevel.Show();
        }
        /// <summary>
        /// Checking that the value of the textbox exist or not
        /// </summary>
        /// <param name="alphanumeric"></param>
        /// <returns>true or false</returns>
        bool isExist(string alphanumeric)
        {
            int length;
            length = alphanumeric.Length;
            if(!string.IsNullOrWhiteSpace(alphanumeric) && length > 0)
            {
                return true;
            } 
            
            else
            {
                return false;
            }
            
        }

        private void KeyPressString(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(char.IsPunctuation(e.KeyChar)))
            {
                
            }
         }

        private void NameValdity(object sender, CancelEventArgs e)
        {
            TextBox text = sender as TextBox;
            if(string.IsNullOrWhiteSpace(text.Text)==true)
            {
                e.Cancel = false;
                return;
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
    }
}
