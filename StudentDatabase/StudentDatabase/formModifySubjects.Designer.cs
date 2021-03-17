namespace StudentDatabase
{
    partial class formModifySubjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formModifySubjects));
            this.btnRemoveStudentSubject = new System.Windows.Forms.Button();
            this.lsSubjects = new System.Windows.Forms.ListBox();
            this.txIdSubject = new System.Windows.Forms.TextBox();
            this.txNameSubject = new System.Windows.Forms.TextBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.lbIdSubject = new System.Windows.Forms.Label();
            this.lbSubjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveStudentSubject
            // 
            this.btnRemoveStudentSubject.Location = new System.Drawing.Point(105, 322);
            this.btnRemoveStudentSubject.Name = "btnRemoveStudentSubject";
            this.btnRemoveStudentSubject.Size = new System.Drawing.Size(120, 64);
            this.btnRemoveStudentSubject.TabIndex = 4;
            this.btnRemoveStudentSubject.Text = "Odebrat předmět";
            this.btnRemoveStudentSubject.UseVisualStyleBackColor = true;
            this.btnRemoveStudentSubject.Click += new System.EventHandler(this.btnRemoveStudentSubject_Click);
            // 
            // lsSubjects
            // 
            this.lsSubjects.FormattingEnabled = true;
            this.lsSubjects.HorizontalScrollbar = true;
            this.lsSubjects.ItemHeight = 20;
            this.lsSubjects.Location = new System.Drawing.Point(12, 12);
            this.lsSubjects.Name = "lsSubjects";
            this.lsSubjects.Size = new System.Drawing.Size(213, 304);
            this.lsSubjects.TabIndex = 3;
            this.lsSubjects.SelectedIndexChanged += new System.EventHandler(this.lsSubjects_SelectedIndexChanged);
            // 
            // txIdSubject
            // 
            this.txIdSubject.Location = new System.Drawing.Point(235, 42);
            this.txIdSubject.MaxLength = 4;
            this.txIdSubject.Name = "txIdSubject";
            this.txIdSubject.Size = new System.Drawing.Size(91, 26);
            this.txIdSubject.TabIndex = 5;
            // 
            // txNameSubject
            // 
            this.txNameSubject.Location = new System.Drawing.Point(235, 106);
            this.txNameSubject.Name = "txNameSubject";
            this.txNameSubject.Size = new System.Drawing.Size(157, 26);
            this.txNameSubject.TabIndex = 6;
            this.txNameSubject.TextChanged += new System.EventHandler(this.txNameSubject_TextChanged);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(292, 138);
            this.btnAddSubject.MinimumSize = new System.Drawing.Size(100, 53);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(100, 53);
            this.btnAddSubject.TabIndex = 7;
            this.btnAddSubject.Text = "Přidat předmět";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // lbIdSubject
            // 
            this.lbIdSubject.AutoSize = true;
            this.lbIdSubject.Location = new System.Drawing.Point(231, 19);
            this.lbIdSubject.Name = "lbIdSubject";
            this.lbIdSubject.Size = new System.Drawing.Size(95, 20);
            this.lbIdSubject.TabIndex = 8;
            this.lbIdSubject.Text = "Id (Zkratka):";
            // 
            // lbSubjectName
            // 
            this.lbSubjectName.AutoSize = true;
            this.lbSubjectName.Location = new System.Drawing.Point(231, 83);
            this.lbSubjectName.Name = "lbSubjectName";
            this.lbSubjectName.Size = new System.Drawing.Size(57, 20);
            this.lbSubjectName.TabIndex = 9;
            this.lbSubjectName.Text = "Název:";
            // 
            // formModifySubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 398);
            this.Controls.Add(this.lbSubjectName);
            this.Controls.Add(this.lbIdSubject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.txNameSubject);
            this.Controls.Add(this.txIdSubject);
            this.Controls.Add(this.btnRemoveStudentSubject);
            this.Controls.Add(this.lsSubjects);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(426, 454);
            this.MinimumSize = new System.Drawing.Size(426, 454);
            this.Name = "formModifySubjects";
            this.Text = "Databáze studentů";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveStudentSubject;
        private System.Windows.Forms.ListBox lsSubjects;
        private System.Windows.Forms.TextBox txIdSubject;
        private System.Windows.Forms.TextBox txNameSubject;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Label lbIdSubject;
        private System.Windows.Forms.Label lbSubjectName;
    }
}