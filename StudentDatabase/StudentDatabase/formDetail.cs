using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentDatabase
{
    public partial class formDetail : Form
    {

        SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["StudentDatabase.Properties.Settings.StudentDatabaseConnectionString"].ConnectionString;
        private int StudentID;

        public formDetail(int IDStudent)
        {
            InitializeComponent();
            StudentID = IDStudent;
            publishStudent();
        }

        private void publishStudent()
        { 
            string queryStudentInfo = "select Students.IdStudent, Students.Jméno, Students.Příjmení, Students.[Datum narození], Students.Třída from Students " + 
                "where Students.IdStudent = @AcStudentID";

            string queryStudentSubjects = "select Subjects.Název, Subjects.[Id (Zkratka předmětu)] from Subjects " +
                "inner join StudentSubjects on StudentSubjects.SubjectID = Subjects.[Id (Zkratka předmětu)] " +
                "inner join Students on Students.IdStudent = StudentSubjects.StudentID " +
                "where Students.IdStudent = @AcStudentID";

            using (connection = new SqlConnection(this.connectionString))
            using (SqlCommand commandStudentInfo = new SqlCommand(queryStudentInfo, connection))
            using (SqlDataAdapter adapterStudentInfo = new SqlDataAdapter(commandStudentInfo))
            using (SqlCommand commandStudentSubjects = new SqlCommand(queryStudentSubjects, connection))
            using (SqlDataAdapter adapterStudentSubjects = new SqlDataAdapter(commandStudentSubjects))
            {
                commandStudentInfo.Parameters.AddWithValue("@AcStudentID", StudentID);
                commandStudentSubjects.Parameters.AddWithValue("@AcStudentID", StudentID);

                DataTable StudentTable = new DataTable();
                adapterStudentInfo.Fill(StudentTable);

                DateTime bornDate = Convert.ToDateTime(StudentTable.Rows[0]["Datum narození"]);

                DataTable SubjectTable = new DataTable();
                adapterStudentSubjects.Fill(SubjectTable);

                SubjectTable.DefaultView.Sort = "Id (Zkratka předmětu)";

                this.txStudentID.Text = StudentID.ToString();
                this.txStudentName.Text = StudentTable.Rows[0]["Jméno"].ToString();
                this.txStudentLastName.Text = StudentTable.Rows[0]["Příjmení"].ToString();
                this.txStudentBorn.Text = bornDate.ToString("dd/MM/yyyy");
                this.txStudentClass.Text = StudentTable.Rows[0]["Třída"].ToString();

                this.lsStudentSubjects.DisplayMember = "Název";
                this.lsStudentSubjects.ValueMember = "Id (Zkratka předmětu)";
                this.lsStudentSubjects.DataSource = SubjectTable;
            }
        }

        private void btnCustomizeStudentSubjects_Click(object sender, EventArgs e)
        {
            formCustomizeStudentSubjects CustomizeSubjects = new formCustomizeStudentSubjects(StudentID);
            CustomizeSubjects.ShowDialog();

            publishStudent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(this.txStudentName.Text == "" | this.txStudentLastName.Text == "" | this.txStudentClass.Text == "" | this.txStudentBorn.Text == "")
            {
                MessageBox.Show("Žádné pole nesmí zůstat prázdné!", "Databáze studentů", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string queryStudSub = "update Students set Jméno = @StudentName, Příjmení = @StudentLastName, Třída = @Class, [Datum narození] = @BornDate " +
                "where IdStudent = @AcIdStudent";

            using (connection = new SqlConnection(this.connectionString))
            using (SqlCommand commandAcStudSub = new SqlCommand(queryStudSub, connection))
            {
                connection.Open();

                DateTime BornDate = new DateTime();
                DateTime.TryParse(this.txStudentBorn.Text, out BornDate);

                if (BornDate.ToString() == "01.01.0001 0:00:00")
                {
                    MessageBox.Show("Neplatné datum narození!", "Databáze studentů", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                commandAcStudSub.Parameters.AddWithValue("@AcIdStudent", this.StudentID);
                commandAcStudSub.Parameters.AddWithValue("@StudentName", this.txStudentName.Text);
                commandAcStudSub.Parameters.AddWithValue("@StudentLastName", this.txStudentLastName.Text);
                commandAcStudSub.Parameters.AddWithValue("@Class", this.txStudentClass.Text);
                commandAcStudSub.Parameters.AddWithValue("@BornDate", BornDate);

                commandAcStudSub.ExecuteScalar();
            }
        }
    }
}
