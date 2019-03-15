﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProjectB
{
    public partial class Student : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =DESKTOP-GLD2JPV; Initial Catalog = ProjectB; User ID =sa; Password =aqsazahid12345; MultipleActiveResultSets = True");
        public Student()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// This is the click event of Button of add student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (btnAddStudent.Text == "Update Student")
            {
                
                String FirstName, LastName, Contact, Email, RegistrationNumber;
                int Status;
                string ID = lblID.Text;
                if (IsValidString(txtFirstName.Text))
                {
                    if (IsValidString(txtLastName.Text) || txtLastName.Text.Length == 0)
                    {
                        if (isValidContact(txtContact.Text) || txtContact.Text.Length == 0)
                        {
                            if (isDigit(cmbStatus.Text) && isDigit(cmbStatus.Text))
                            {
                                if (IsValidEmail(txtEmail.Text) && isValidRegistrationNumber(txtRegistrationNumber.Text))
                                {
                                    FirstName = txtFirstName.Text;
                                    LastName = txtLastName.Text;
                                    Contact = txtContact.Text;
                                    Email = txtEmail.Text;
                                    RegistrationNumber = txtRegistrationNumber.Text;
                                    Status = Convert.ToInt32(cmbStatus.Text);
                                    conn.Open();
                                    string cmd = String.Format("UPDATE Student SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, RegistrationNumber = @RegistrationNumber, Status = @Status WHERE Id = @ID");
                                    SqlCommand command = new SqlCommand(cmd, conn);
                                    command.Parameters.Add(new SqlParameter("@FirstName", FirstName));
                                    command.Parameters.Add(new SqlParameter("@LastName", LastName));
                                    command.Parameters.Add(new SqlParameter("@Contact", Contact));
                                    command.Parameters.Add(new SqlParameter("@Email", Email));
                                    command.Parameters.Add(new SqlParameter("@RegistrationNumber", RegistrationNumber));
                                    command.Parameters.Add(new SqlParameter("@Status", Status));
                                    command.Parameters.Add(new SqlParameter("@Id", ID));
                                    SqlDataReader reader = command.ExecuteReader();
                                    btnAddStudent.Text = "Add Student";
                                    SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                                    txtContact.Text = "";
                                    txtEmail.Text = "";
                                    txtFirstName.Text = "";
                                    txtLastName.Text = "";
                                    txtRegistrationNumber.Text = "";
                                    cmbStatus.Text = "";
                                    conn.Close();
                                    TabADDStudent.Hide();
                                    TabViewStudent.Show();

                                    conn.Open();
                                    cmd = String.Format("SELECT *FROM Student");
                                    command = new SqlCommand(cmd, conn);
                                    reader = command.ExecuteReader();
                                    adapter = new SqlDataAdapter(cmd, conn);
                                    DataTable table = new DataTable();
                                    adapter.Fill(table);
                                    gridStudentInformation.DataSource = table;
                                    TabViewStudent.Refresh();
                                    conn.Close();
                                }
                            }
                        }
                    }
                }
                
                

            }
            else
            {
                lblID.Hide();
                String FirstName, LastName, Contact, Email, RegistrationNumber;
                int Status;
                
                if (IsValidString(txtFirstName.Text))
                {
                    if (IsValidString(txtLastName.Text) || txtLastName.Text.Length == 0)
                    {
                        if (isValidContact(txtContact.Text) || txtContact.Text.Length == 0)
                        {
                            if (isDigit(cmbStatus.Text) && isDigit(cmbStatus.Text))
                            {
                                if (IsValidEmail(txtEmail.Text) && isValidRegistrationNumber(txtRegistrationNumber.Text))
                                {
                                    ClassStudent student = new ClassStudent();
                                    student.FirstName = txtFirstName.Text;
                                    student.LastName = txtLastName.Text;
                                    student.Contact = txtContact.Text;
                                    student.Email = txtEmail.Text;
                                    student.RegistrationNumber = txtRegistrationNumber.Text;
                                    student.Status = Convert.ToInt32(cmbStatus.Text);
                                    FirstName = txtFirstName.Text = student.FirstName;
                                    LastName = txtLastName.Text = student.LastName;
                                    Contact = txtContact.Text = student.Contact;
                                    Email = txtEmail.Text = student.Email;
                                    RegistrationNumber = txtRegistrationNumber.Text = student.RegistrationNumber;
                                    Status = Convert.ToInt32(cmbStatus.Text);
                                    conn.Open();
                                    String cmd = String.Format("INSERT INTO Student(FirstName, LastName,Contact, Email, RegistrationNumber, Status) values('{0}','{1}','{2}','{3}','{4}','{5}')", FirstName, LastName, Contact, Email, RegistrationNumber, Status);
                                    SqlCommand command = new SqlCommand(cmd, conn);
                                    command.Parameters.Add(new SqlParameter("0", 1));

                                    SqlDataReader reader = command.ExecuteReader();
                                    SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                                    txtContact.Text = "";
                                    txtEmail.Text = "";
                                    txtFirstName.Text = "";
                                    txtLastName.Text = "";
                                    txtRegistrationNumber.Text = "";
                                    cmbStatus.Text = "";
                                    conn.Close();


                                }
                                else
                                {
                                    if (!IsValidEmail(txtEmail.Text))
                                    {
                                        MessageBox.Show("Invalid Email");
                                    }
                                    if (!isValidRegistrationNumber(txtRegistrationNumber.Text))
                                    {
                                        MessageBox.Show("Invalid Registration Number");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Status");
                                if (!IsValidEmail(txtEmail.Text))
                                {
                                    MessageBox.Show("Invalid Email");
                                }
                                if (!isValidRegistrationNumber(txtRegistrationNumber.Text))
                                {
                                    MessageBox.Show("Invalid Registration Number");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Contact");
                        
                            if (!IsValidEmail(txtEmail.Text))
                            {
                                MessageBox.Show("Invalid Email");
                            }
                            if (!isValidRegistrationNumber(txtRegistrationNumber.Text))
                            {
                                MessageBox.Show("Invalid Registration Number");
                            }
                            if (!isDigit(cmbStatus.Text))
                            {
                                MessageBox.Show("Invalid Status");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Last Name");
                        if (!isValidContact(txtContact.Text) && txtContact.Text.Length > 0)
                        {
                            MessageBox.Show("Invalid Contact");
                        }
                        if (!IsValidEmail(txtEmail.Text))
                        {
                            MessageBox.Show("Invalid Email");
                        }
                        if (!isValidRegistrationNumber(txtRegistrationNumber.Text))
                        {
                            MessageBox.Show("Invalid Registration Number");
                        }
                        if (!isDigit(cmbStatus.Text))
                        {
                            MessageBox.Show("Invalid Status");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid First Name");
                    if (!IsValidString(txtLastName.Text) && txtLastName.Text.Length > 0)
                    {
                        MessageBox.Show("Invalid Last Name");
                    }
                    if (!isValidContact(txtContact.Text) && txtContact.Text.Length > 0)
                    {
                        MessageBox.Show("Invalid Contact");
                    }
                    if (!IsValidEmail(txtEmail.Text))
                    {
                        MessageBox.Show("Invalid Email");
                    }
                    if (!isValidRegistrationNumber(txtRegistrationNumber.Text))
                    {
                        MessageBox.Show("Invalid Registration Number");
                    }
                    if (!isDigit(cmbStatus.Text))
                    {
                        MessageBox.Show("Invalid Status");
                    }

                }
                
            }

        }

        /// <summary>
        /// Function is validating the email
        /// </summary>
        /// <param name="emailaddress"></param>
        /// <returns></returns>
        public bool IsValidEmail(string emailaddress)
        {
            string pattren = @"^([\w\d.]+)@((\w+\.\w+)(\.\w+\.?)?)";
            if (Regex.IsMatch(txtEmail.Text, pattren))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattren = @"^([\w\d.]+)@((\w+\.\w+)(\.\w+\.?)?)";
            //string pattren = "";
            if (Regex.IsMatch(txtEmail.Text, pattren))
            {
                ErrorEmail.Clear();
            }
            else
            {
                ErrorEmail.SetError(txtEmail, "Invalid Email");
            }
        }
        /// <summary>
        /// The function is validing the string for first and last name
        /// </summary>
        /// <param name="Alphanumeric"></param>
        /// <returns></returns>
        bool IsValidString(String Alphanumeric)
        {
            string pattern = @"^(([A-Z][a-z]+[\s]{1}[A-za-z]+)|([A-Z][a-z]+))$";
            if (Regex.IsMatch(Alphanumeric, pattern))
            {
                return true;
            }
            else
            {
                return false;
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
            foreach(char number in Digits)
            {
                if(char.IsDigit(number))
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
        /// <summary>
        /// Validating the length and characters of contact number
        /// </summary>
        /// <param name="Digits"></param>
        /// <returns></returns>
        bool isValidContact(string Digits)
        {
            bool IsDigit = false;
            int length = Digits.Length;
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
            if(length == 11 && IsDigit == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        /// <summary>
        /// Checking that the given registration number if true or false
        /// </summary>
        /// <param name="RegistrationNumber"></param>
        /// <returns>true or false</returns>
        bool isValidRegistrationNumber(string RegistrationNumber)
        {
            string pattern = @"[\d]{4}[-][A-Z|a-z][A-Z|a-z][-][\d]+";
            if(Regex.IsMatch(RegistrationNumber,pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            string pattern;
            pattern = @"^(([A-Z][a-z]+[\s]{1}[A-za-z]+)|([A-Z][a-z]+))$";
            if (Regex.IsMatch(txtFirstName.Text, pattern))
            {
                ErrorFirstName.Clear();
            }
            else
            {
                ErrorFirstName.SetError(txtFirstName, "Invalid First Name");
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            string pattern;
            pattern = @"^(([A-Z][a-z]+[\s]{1}[A-za-z]+)|([A-Z][a-z]+))$";
            if (Regex.IsMatch(txtLastName.Text, pattern) || txtLastName.Text.Length == 0)
            {
                ErrorLastName.Clear();
            }
            else
            {
                ErrorLastName.SetError(txtLastName, "Invalid Last Name");
            }
        }

        private void txtContact_Leave(object sender, EventArgs e)
        {
            bool isTrue = isValidContact(txtContact.Text);
            if(isTrue == true || txtContact.Text.Length == 0)
            {
                ErrorContact.Clear();
            }
            else
            {
                ErrorContact.SetError(txtContact, "Invalid Contact");
            }
        }

        private void txtRegistrationNumber_Leave(object sender, EventArgs e)
        {
            bool isValid = isValidRegistrationNumber(txtRegistrationNumber.Text);
            if(isValid == true)
            {
                ErrorRegistrationNumber.Clear();
            }
            else
            {
                ErrorRegistrationNumber.SetError(txtRegistrationNumber, "Invalid Registration Number");
            }
        }

        private void txtStatus_Leave(object sender, EventArgs e)
        {
            bool isStatus = isDigit(cmbStatus.Text);
            if(isStatus == true)
            {
                ErrorStatus.Clear();
            }
            else
            {
                ErrorStatus.SetError(cmbStatus, "Invalid Status");
            }
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            String cmd = "SELECT * FROM Student";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridStudentInformation.DataSource = table;

            conn.Close();
        }

        
        private void gridStudentInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            




            // MessageBox.Show("success");
            
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {
            String cmd = "SELECT LookupId FROM Lookup";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbStatus.Items.Add(reader[0]);
            }
            conn.Close();


            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);
            lblID.Hide();
            conn.Open();
            cmd = String.Format("SELECT *FROM Student");
            command = new SqlCommand(cmd, conn);
            reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridStudentInformation.DataSource = table;
            TabViewStudent.Refresh();
            conn.Close();
        }

        private void gridStudentInformation_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gridStudentInformation_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //var item = gridStudentInformation.Rows[e.RowIndex].Cells[0].Value;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       
        private void TabViewStudent_Click(object sender, EventArgs e)
        {
            conn.Open();
            string cmd = String.Format("SELECT *FROM Student");
            SqlCommand command = new SqlCommand(cmd, conn);
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridStudentInformation.DataSource = table;
            TabViewStudent.Refresh();
            conn.Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void gridStudentInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var element = gridStudentInformation.Columns["Delete"].Index;
            if (e.ColumnIndex == element)
            {
                int ID;
                ID = Convert.ToInt32(gridStudentInformation.Rows[e.RowIndex].Cells[0].Value);
                string cmd = String.Format("DELETE FROM Student WHERE Id = @ID");
                SqlCommand command = new SqlCommand(cmd, conn);

                command.Parameters.Add(new SqlParameter("@ID", ID));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                conn.Close();
                conn.Open();
                cmd = String.Format("SELECT *FROM Student");
                reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridStudentInformation.DataSource = table;
                TabViewStudent.Refresh();
                conn.Close();

            }
            else
            {
                var item = gridStudentInformation.Rows[e.RowIndex].Cells[0].Value;
                //int IdOfItem;
                //var SecondItem = gridStudentInformation.Rows[e.RowIndex].Cells[6].Value;
                string cmd = String.Format("SELECT * FROM Student WHERE Id = @item");
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@item", item));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                Student s = new Student();
                //tabControl1.SelectedTab = tabControl1.TabPages["View Student"].Show;
                TabADDStudent.Show();
                btnAddStudent.Text = "Update Student";
                while (reader.Read())
                {
                    lblID.Text = Convert.ToString(reader[0]);
                    txtFirstName.Text = Convert.ToString(reader[1]);
                    txtLastName.Text = Convert.ToString(reader[2]);
                    txtContact.Text = Convert.ToString(reader[3]);
                    txtEmail.Text = Convert.ToString(reader[4]);
                    txtRegistrationNumber.Text = Convert.ToString(reader[5]);
                    cmbStatus.Text = Convert.ToString(reader[6]);
                }

                conn.Close();
            }

        }
    }
}


