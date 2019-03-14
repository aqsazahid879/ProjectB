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
        bool IsCorrectNumber = false;
        IsCorrectNumber = isDigit(txtMeasurementLevel.Text);
            if (IsCorrectNumber == true)
            {
                conn.Open();
                String cmd = String.Format("INSERT INTO RubricLevel(RubricId, Details, MeasurementLevel) values('{0}','{1}','{2}')", Convert.ToInt32(cmbRubricID.Text), txtDetails.Text, Convert.ToInt32(txtMeasurementLevel.Text));
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("0", 1));

                SqlDataReader reader = command.ExecuteReader();
                txtDetails.Text = "";
                txtMeasurementLevel.Text = "";
                cmbRubricID.Text = "";
                conn.Close();
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
    }
}
