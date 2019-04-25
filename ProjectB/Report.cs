﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;

namespace ProjectB
{
    public partial class Report : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =DESKTOP-GLD2JPV; Initial Catalog = ProjectB; User ID =sa; Password =aqsazahid12345; MultipleActiveResultSets = True");
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT Student.RegistrationNumber, Clo.Name AS CLONAME, Rubric.Details AS RubricDetails, RubricLevel.MeasurementLevel, AssessmentComponent.Name, AssessmentComponent.TotalMarks AS ComponentMarks FROM StudentResult JOIN Student ON StudentResult.StudentId = Student.Id JOIN StudentAttendance ON Student.Id = StudentAttendance.StudentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN AssessmentComponent ON StudentResult.AssessmentComponentId = AssessmentComponent.Id JOIN Rubric ON AssessmentComponent.RubricId = Rubric.Id JOIN Clo ON Rubric.CloId = Clo.Id";
            SqlDataAdapter d = new SqlDataAdapter(query1, conn);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
            int count = dataGridView1.RowCount;
            for (int i = 0; i < count; i++)
            {
                double k = Convert.ToDouble(dataGridView1.Rows[i].Cells["ComponentMarks"].Value);
                double l = Convert.ToDouble(dataGridView1.Rows[i].Cells["MeasurementLevel"].Value);
                double marks = Convert.ToDouble((l / 4) * k);
                dataGridView1.Rows[i].Cells["ObtainedMarks"].Value = marks;
            }

            string query2 = "SELECT Student.RegistrationNumber, Assessment.Title, AssessmentComponent.Name As AssessmentComponent, RubricLevel.MeasurementLevel, AssessmentComponent.TotalMarks AS ComponentMarks FROM StudentResult JOIN Student ON StudentResult.StudentId = Student.Id JOIN StudentAttendance ON Student.Id = StudentAttendance.StudentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN AssessmentComponent ON StudentResult.AssessmentComponentId = AssessmentComponent.Id JOIN Assessment ON AssessmentComponent.AssessmentId = Assessment.Id";
            SqlDataAdapter d1 = new SqlDataAdapter(query2, conn);
            DataTable dt1 = new DataTable();
            d1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            int count1 = dataGridView2.RowCount;
            for (int i = 0; i < count; i++)
            {
                double k = Convert.ToDouble(dataGridView2.Rows[i].Cells["ComponentMarks"].Value);
                double l = Convert.ToDouble(dataGridView2.Rows[i].Cells["MeasurementLevel"].Value);
                double marks = Convert.ToDouble((l / 4) * k);
                dataGridView2.Rows[i].Cells["Marks"].Value = marks;
            }
        }

        public void exportgridtopdf(DataGridView d, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable1 = new PdfPTable(d.Columns.Count);

            pdftable1.DefaultCell.Padding = 2;
            pdftable1.WidthPercentage = 100;
            pdftable1.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable1.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);


            //Header
            foreach (DataGridViewColumn column in d.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdftable1.AddCell(cell);

            }

            // Data Row
            foreach (DataGridViewRow row in d.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable1.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialogue = new SaveFileDialog();
            savefiledialogue.FileName = filename;
            savefiledialogue.DefaultExt = ".pdf";
            if (savefiledialogue.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialogue.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable1);
                    pdfdoc.Close();
                    stream.Close();
                    MessageBox.Show("PDF generated and saved to your PC.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportgridtopdf(dataGridView1, "Clo wise Report Evaluation:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exportgridtopdf(dataGridView2, "Attendence wise Report Evaluation");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            this.Hide();
            s.Show();
        }
    }
}
