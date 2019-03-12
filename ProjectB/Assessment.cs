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
            if(isdigit == true && isnumber == true)
            {
                conn.Open();
                String cmd = String.Format("INSERT INTO Assessment(Title, DateCreated, TotalMarks, TotalWeightage) values('{0}','{1}','{2}', '{3}')", txtTitle.Text, DateTime.Now, Convert.ToInt32(txtMarks.Text), Convert.ToInt32(txtTotalWeightage.Text));
                SqlCommand command = new SqlCommand(cmd, conn);
                SqlDataReader reader = command.ExecuteReader();
                txtTitle.Text = "";
                txtMarks.Text = "";
                txtTotalWeightage.Text = "";
                conn.Close();
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
    }
}
