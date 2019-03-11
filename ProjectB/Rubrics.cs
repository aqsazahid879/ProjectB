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
            String cmd = "SELECT Id FROM Clo";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                cmbCloId.Items.Add(reader[0]);
            }
        }

        private void btnAddRubric_Click(object sender, EventArgs e)
        {
            bool isNumber = false;
            isNumber=isDigit(txtID.Text);
            if(isNumber == true)
            {

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
