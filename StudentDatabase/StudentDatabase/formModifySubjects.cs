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
    public partial class formModifySubjects : Form
    {
        //Create sqlconnection variable
        SqlConnection connection;

        //Here you have to put the connectionstring, so it'll connect to database
        private string connectionString = ConfigurationManager.ConnectionStrings["StudentDatabase.Properties.Settings.StudentDatabaseConnectionString"].ConnectionString;

        public formModifySubjects()
        {
            InitializeComponent();
            publishAllSubjects();
        }

        private void publishAllSubjects()
        {
            string queryAllSub = "select * from Subjects";

            using (connection = new SqlConnection(this.connectionString)) //Initialize connection variable with connectionString
            using (SqlCommand commandAllSub = new SqlCommand(queryAllSub, connection)) //Create SqlCommand, so you can execute it on connect
            using (SqlDataAdapter adapterAllSub = new SqlDataAdapter(commandAllSub)) //Connect to database using adapter, so you won't have to take care of disconnecting from database
            {

                DataTable AllSubjectsTable = new DataTable(); // Create datatable variable
                adapterAllSub.Fill(AllSubjectsTable); // Load data to the datatable

                AllSubjectsTable.DefaultView.Sort = "Id (Zkratka předmětu)"; // Sort the table

                //This just displays the data in the window
                lsSubjects.DisplayMember = "Název"; 
                lsSubjects.ValueMember = "Id (Zkratka předmětu)";
                lsSubjects.DataSource = AllSubjectsTable;
            } //After everything in SqlDataAdapter executes, the connection closes automatically, you won't need to take care of that
        }

        private void btnRemoveStudentSubject_Click(object sender, EventArgs e)
        {
            string queryStudSub = "delete from Subjects " +
                "where [Id (Zkratka předmětu)] = @AcSubject ";

            using (connection = new SqlConnection(this.connectionString))
            using (SqlCommand command = new SqlCommand(queryStudSub, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@AcSubject", this.lsSubjects.SelectedValue);

                command.ExecuteScalar();
            }
            publishAllSubjects();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if(this.txIdSubject.Text == "" | this.txNameSubject.Text == "")
            {
                MessageBox.Show("Žádné pole nesmí zůstat prázndé!", "Databáze studentů", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string queryStudSub = "if NOT EXISTS(SELECT Subjects.[Id (Zkratka předmětu)], Subjects.Název FROM Subjects " +
                "WHERE Subjects.[Id (Zkratka předmětu)] = @SubjectID) " +
                "INSERT INTO Subjects([Id (Zkratka předmětu)], Název) VALUES (@SubjectID, @SubjectName)";

            using (connection = new SqlConnection(this.connectionString))
            using (SqlCommand commandAcStudSub = new SqlCommand(queryStudSub, connection))
            {
                connection.Open();

                commandAcStudSub.Parameters.AddWithValue("@SubjectID", this.txIdSubject.Text);
                commandAcStudSub.Parameters.AddWithValue("@SubjectName", this.txNameSubject.Text);

                commandAcStudSub.ExecuteScalar();
            }
            this.txIdSubject.Text = "";
            this.txNameSubject.Text = "";
            publishAllSubjects();
        }

        private void lsSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txNameSubject_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
