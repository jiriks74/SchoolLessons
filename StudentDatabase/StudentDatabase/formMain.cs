using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentDatabase
{
    public partial class formMain : Form
    {
        //Sqlconnection variable
        SqlConnection connection;
        //Connection string, get's values from ./Propeties Settings.settings
        private string connectionString = ConfigurationManager.ConnectionStrings["StudentDatabase.Properties.Settings.StudentDatabaseConnectionString"].ConnectionString;
        private int StudentID;

        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        private void fillDataGrid()
        {
            // TODO: This line of code loads data into the 'studentDatabaseDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentDatabaseDataSet.Students);
        }

        private void detailStudentBtn_Click(object sender, EventArgs e)
        {
            
            StudentID = Convert.ToInt32(studentsDataGridView.Rows[studentsDataGridView.CurrentRow.Index].Cells[0].Value);

            if( StudentID == 0)
            {
                MessageBox.Show("Není vybrán student!", "Databáze studentů", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            formDetail frmDetail = new formDetail(StudentID);
            frmDetail.ShowDialog();

            fillDataGrid();
        }

        private void regStudentBtn_Click(object sender, EventArgs e)
        {
            formRegisterStudent frmRegisterStudent = new formRegisterStudent();
            frmRegisterStudent.ShowDialog();

            fillDataGrid();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            StudentID = Convert.ToInt32(studentsDataGridView.Rows[studentsDataGridView.CurrentRow.Index].Cells[0].Value);
            DialogResult deleteResult = MessageBox.Show("Opravdu chcete odstranit studenta?", "Databáze studentů", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(deleteResult == DialogResult.Yes)
            {
                StudentID = Convert.ToInt32(studentsDataGridView.Rows[studentsDataGridView.CurrentRow.Index].Cells[0].Value);
                string queryStudDel = "delete from Students " +
                    "where IdStudent = @AcStudentID";

                using (connection = new SqlConnection(this.connectionString)) //here you configure the connecton
                using (SqlCommand commandAcStudSub = new SqlCommand(queryStudDel, connection)) //here you setup the sql command to get the data
                {
                    connection.Open();
                    commandAcStudSub.Parameters.AddWithValue("@AcStudentID", this.StudentID);
                    commandAcStudSub.ExecuteScalar();
                }
            }
            else
            {

            }
            fillDataGrid();
        }

        private void btnModifySubjects_Click(object sender, EventArgs e)
        {
            formModifySubjects frmModifySubjects = new formModifySubjects();
            frmModifySubjects.ShowDialog();
        }
    }
}
