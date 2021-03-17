namespace StudentDatabase
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.studentDatabaseDataSet = new StudentDatabase.StudentDatabaseDataSet();
            this.lbStudents = new System.Windows.Forms.Label();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new StudentDatabase.StudentDatabaseDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new StudentDatabase.StudentDatabaseDataSetTableAdapters.TableAdapterManager();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.regStudentBtn = new System.Windows.Forms.Button();
            this.detailStudentBtn = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnModifySubjects = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDatabaseDataSet
            // 
            this.studentDatabaseDataSet.DataSetName = "StudentDatabaseDataSet";
            this.studentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbStudents
            // 
            this.lbStudents.AutoSize = true;
            this.lbStudents.Location = new System.Drawing.Point(8, 9);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(73, 20);
            this.lbStudents.TabIndex = 1;
            this.lbStudents.Text = "Studenti:";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentDatabaseDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.StudentSubjectsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StudentDatabase.StudentDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.studentsDataGridView.DataSource = this.studentsBindingSource;
            this.studentsDataGridView.Location = new System.Drawing.Point(12, 32);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.ReadOnly = true;
            this.studentsDataGridView.RowTemplate.Height = 28;
            this.studentsDataGridView.Size = new System.Drawing.Size(815, 339);
            this.studentsDataGridView.TabIndex = 3;
            // 
            // regStudentBtn
            // 
            this.regStudentBtn.Location = new System.Drawing.Point(585, 377);
            this.regStudentBtn.Name = "regStudentBtn";
            this.regStudentBtn.Size = new System.Drawing.Size(118, 53);
            this.regStudentBtn.TabIndex = 4;
            this.regStudentBtn.Text = "Registrovat studenta";
            this.regStudentBtn.UseVisualStyleBackColor = true;
            this.regStudentBtn.Click += new System.EventHandler(this.regStudentBtn_Click);
            // 
            // detailStudentBtn
            // 
            this.detailStudentBtn.Location = new System.Drawing.Point(709, 377);
            this.detailStudentBtn.Name = "detailStudentBtn";
            this.detailStudentBtn.Size = new System.Drawing.Size(118, 53);
            this.detailStudentBtn.TabIndex = 5;
            this.detailStudentBtn.Text = "Zobrazit podrobnosti";
            this.detailStudentBtn.UseVisualStyleBackColor = true;
            this.detailStudentBtn.Click += new System.EventHandler(this.detailStudentBtn_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(461, 377);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(118, 53);
            this.btnDeleteStudent.TabIndex = 6;
            this.btnDeleteStudent.Text = "Odstranit studenta";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnModifySubjects
            // 
            this.btnModifySubjects.Location = new System.Drawing.Point(337, 377);
            this.btnModifySubjects.MaximumSize = new System.Drawing.Size(118, 53);
            this.btnModifySubjects.MinimumSize = new System.Drawing.Size(118, 53);
            this.btnModifySubjects.Name = "btnModifySubjects";
            this.btnModifySubjects.Size = new System.Drawing.Size(118, 53);
            this.btnModifySubjects.TabIndex = 7;
            this.btnModifySubjects.Text = "Upravit předměty";
            this.btnModifySubjects.UseVisualStyleBackColor = true;
            this.btnModifySubjects.Click += new System.EventHandler(this.btnModifySubjects_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdStudent";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id studenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Jméno";
            this.dataGridViewTextBoxColumn2.HeaderText = "Jméno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Příjmení";
            this.dataGridViewTextBoxColumn3.HeaderText = "Příjmení";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Datum narození";
            this.dataGridViewTextBoxColumn5.HeaderText = "Datum narození";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Třída";
            this.dataGridViewTextBoxColumn4.HeaderText = "Třída";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 442);
            this.Controls.Add(this.btnModifySubjects);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.detailStudentBtn);
            this.Controls.Add(this.regStudentBtn);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(this.lbStudents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(861, 498);
            this.MinimumSize = new System.Drawing.Size(861, 498);
            this.Name = "formMain";
            this.Text = "Databáze studentů";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDatabaseDataSet studentDatabaseDataSet;
        private System.Windows.Forms.Label lbStudents;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentDatabaseDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private StudentDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.Button regStudentBtn;
        private System.Windows.Forms.Button detailStudentBtn;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnModifySubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

