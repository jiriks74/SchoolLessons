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
    public partial class formCustomizeStudentSubjects : Form
    {

        SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["StudentDatabase.Properties.Settings.StudentDatabaseConnectionString"].ConnectionString;
        private int StudentID;

        public formCustomizeStudentSubjects(int IdStudent)
        {
            InitializeComponent();
            StudentID = IdStudent;
            publishAllSubjects();
            publishAcSubjects();
        }

        private void publishAllSubjects()
        {
            string queryAllSub = "select * from Subjects";

            using (connection = new SqlConnection(this.connectionString))
            using (SqlCommand commandAllSub = new SqlCommand(queryAllSub, connection))
            using(SqlDataAdapter adapterAllSub = new SqlDataAdapter(commandAllSub))
            {

                DataTable AllSubjectsTable = new DataTable();
                adapterAllSub.Fill(AllSubjectsTable);

                AllSubjectsTable.DefaultView.Sort = "Id (Zkratka předmětu)";

                lsAllStudentSubjects.DisplayMember = "Název";
                lsAllStudentSubjects.ValueMember = "Id (Zkratka předmětu)";
                lsAllStudentSubjects.DataSource = AllSubjectsTable;
            }
        }

        private void btnAddStudentSubjects_Click(object sender, EventArgs e)
        {
            string queryStudSub = "if NOT EXISTS(SELECT Subjects.[Id (Zkratka předmětu)]  " +
                "FROM Subjects " +
                "inner join StudentSubjects on Subjects.[Id (Zkratka předmětu)] = StudentSubjects.SubjectID " +
                "WHERE StudentSubjects.StudentID = @AcStudent and Subjects.[Id (Zkratka předmětu)] = @AcSubject) " +
                "INSERT INTO StudentSubjects VALUES (@AcStudent, @AcSubject)";

            using (connection = new SqlConnection(this.connectionString))
            using (SqlCommand commandAcStudSub = new SqlCommand(queryStudSub, connection))
            {
                connection.Open();

                commandAcStudSub.Parameters.AddWithValue("@AcStudent", StudentID);
                commandAcStudSub.Parameters.AddWithValue("@AcSubject", this.lsAllStudentSubjects.SelectedValue);

                commandAcStudSub.ExecuteScalar();
            }
            publishAcSubjects();
        }

        private void publishAcSubjects()
        {
            string queryStudSub = "select Subjects.[Id (Zkratka předmětu)], Subjects.Název from Subjects " +
                "inner join StudentSubjects on SubjectID = Subjects.[Id (Zkratka předmětu)] " +
                "where StudentSubjects.StudentID = @AcStudentID";

            using (connection = new SqlConnection(this.connectionString))
            using (SqlCommand commandAcStudSub = new SqlCommand(queryStudSub, connection))
            using (SqlDataAdapter adapterStudSub = new SqlDataAdapter(commandAcStudSub))
            {
                commandAcStudSub.Parameters.AddWithValue("@AcStudentID", StudentID);

                DataTable AcSubjectTable = new DataTable();
                adapterStudSub.Fill(AcSubjectTable);

                AcSubjectTable.DefaultView.Sort = "Id (Zkratka předmětu)";

                lsAcStudentSubjects.DisplayMember = "Název";
                lsAcStudentSubjects.ValueMember = "Id (Zkratka předmětu)";
                lsAcStudentSubjects.DataSource = AcSubjectTable;
            }
        }

        private void btnRemoveStudentSubject_Click(object sender, EventArgs e)
        {
            string queryStudSub = "delete from StudentSubjects " +
                "where StudentID = @AcStudent and SubjectID = @AcSubject ";

            using (connection = new SqlConnection(this.connectionString))
            using (SqlCommand commandAcStudSub = new SqlCommand(queryStudSub, connection))
            {
                connection.Open();

                commandAcStudSub.Parameters.AddWithValue("@AcStudent", StudentID);
                commandAcStudSub.Parameters.AddWithValue("@AcSubject", this.lsAcStudentSubjects.SelectedValue);

                commandAcStudSub.ExecuteScalar();
            }
            publishAcSubjects();
        }

        private void lsAcStudentSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
