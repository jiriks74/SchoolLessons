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
    public partial class formRegisterStudent : Form
    {
        SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["StudentDatabase.Properties.Settings.StudentDatabaseConnectionString"].ConnectionString;
        private int StudentID;

        public formRegisterStudent()
        {
            InitializeComponent();
        }

        private void formRegisterStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            if (this.txStudentName.Text == "" | this.txStudentLastName.Text == "" | this.txStudentClass.Text == "" | this.txStudentBorn.Text == "")
            {
                MessageBox.Show("Žádné pole nesmí zůstat prázdné!", "Databáze studentů", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string queryStudSub = "if NOT EXISTS(SELECT Students.IdStudent from Students where Students.IdStudent = @StudentID) insert into Students (IdStudent, Jméno, Příjmení, Třída, [Datum narození]) values (@StudentID, @StudentName, @StudentLastName, @Class, @BornDate)";

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

                int.TryParse(this.txStudentID.Text, out StudentID);

                if(StudentID == 0)
                {
                    MessageBox.Show("Id studenta musí být číslo (Nesmí být pouze 0)!", "Databáze studentů", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                commandAcStudSub.Parameters.AddWithValue("@StudentID", this.StudentID);
                commandAcStudSub.Parameters.AddWithValue("@StudentName", this.txStudentName.Text);
                commandAcStudSub.Parameters.AddWithValue("@StudentLastName", this.txStudentLastName.Text);
                commandAcStudSub.Parameters.AddWithValue("@Class", this.txStudentClass.Text);
                commandAcStudSub.Parameters.AddWithValue("@BornDate", BornDate);

                commandAcStudSub.ExecuteScalar();
            }
            this.txStudentID.Text = "";
            this.txStudentName.Text = "";
            this.txStudentLastName.Text = "";
            this.txStudentBorn.Text = "";
            this.txStudentClass.Text = "";
        }
    }
}
