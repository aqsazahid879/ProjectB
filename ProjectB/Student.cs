using System;
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
            String FirstName, LastName, Contact, Email, RegistrationNumber;
            int Status;
            if(IsValidString(txtFirstName.Text))
            {
                if (IsValidString(txtLastName.Text))
                {
                    if (isValidContact(txtContact.Text))
                    {
                        if(isDigit(txtStatus.Text) && isDigit(txtStatus.Text))
                        {
                            if(IsValidEmail(txtEmail.Text) && isValidRegistrationNumber(txtRegistrationNumber.Text))
                            {
                                FirstName = txtFirstName.Text;
                                LastName = txtLastName.Text;
                                Contact = txtContact.Text;
                                Email = txtEmail.Text;
                                RegistrationNumber = txtRegistrationNumber.Text;
                                Status = Convert.ToInt32(txtStatus.Text);
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
                                txtStatus.Text = "";
                                conn.Close();
                            }
                        }
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
        /// Checking that the given letter of strings are gigits
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
            if (Regex.IsMatch(txtLastName.Text, pattern))
            {
                ErrorLastName.Clear();
            }
            else
            {
                ErrorLastName.SetError(txtLastName, "Invalid First Name");
            }
        }

        private void txtContact_Leave(object sender, EventArgs e)
        {
            bool isTrue = isValidContact(txtContact.Text);
            if(isTrue == true)
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
            bool isStatus = isDigit(txtStatus.Text);
            if(isStatus == true)
            {
                ErrorStatus.Clear();
            }
            else
            {
                ErrorStatus.SetError(txtStatus, "Invalid Status");
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

        private void gridStudentInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridStudentInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = gridStudentInformation.Rows[e.RowIndex].Cells[0].Value;
            string cmd = String.Format("SELECT * FROM Student WHERE Id = @item");
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("@item", item));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            while(reader.Read())
            {
                txtFirstName.Text = Convert.ToString(reader[1]);
                txtLastName.Text = Convert.ToString(reader[2]);
                txtContact.Text = Convert.ToString(reader[3]);
                txtEmail.Text = Convert.ToString(reader[4]);
                txtRegistrationNumber.Text = Convert.ToString(reader[5]);
                txtStatus.Text = Convert.ToString(reader[6]);
            }
            MessageBox.Show("success");
            conn.Close();
        }
    }
}


