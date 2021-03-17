namespace StudentDatabase
{
    partial class formCustomizeStudentSubjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCustomizeStudentSubjects));
            this.lsAcStudentSubjects = new System.Windows.Forms.ListBox();
            this.lsAllStudentSubjects = new System.Windows.Forms.ListBox();
            this.btnRemoveStudentSubject = new System.Windows.Forms.Button();
            this.btnAddStudentSubjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsAcStudentSubjects
            // 
            this.lsAcStudentSubjects.FormattingEnabled = true;
            this.lsAcStudentSubjects.HorizontalScrollbar = true;
            this.lsAcStudentSubjects.ItemHeight = 20;
            this.lsAcStudentSubjects.Location = new System.Drawing.Point(12, 12);
            this.lsAcStudentSubjects.MaximumSize = new System.Drawing.Size(193, 304);
            this.lsAcStudentSubjects.MinimumSize = new System.Drawing.Size(193, 304);
            this.lsAcStudentSubjects.Name = "lsAcStudentSubjects";
            this.lsAcStudentSubjects.Size = new System.Drawing.Size(193, 304);
            this.lsAcStudentSubjects.TabIndex = 0;
            this.lsAcStudentSubjects.SelectedIndexChanged += new System.EventHandler(this.lsAcStudentSubjects_SelectedIndexChanged);
            // 
            // lsAllStudentSubjects
            // 
            this.lsAllStudentSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lsAllStudentSubjects.FormattingEnabled = true;
            this.lsAllStudentSubjects.HorizontalScrollbar = true;
            this.lsAllStudentSubjects.ItemHeight = 20;
            this.lsAllStudentSubjects.Location = new System.Drawing.Point(236, 12);
            this.lsAllStudentSubjects.MaximumSize = new System.Drawing.Size(193, 304);
            this.lsAllStudentSubjects.MinimumSize = new System.Drawing.Size(193, 304);
            this.lsAllStudentSubjects.Name = "lsAllStudentSubjects";
            this.lsAllStudentSubjects.Size = new System.Drawing.Size(193, 304);
            this.lsAllStudentSubjects.TabIndex = 1;
            // 
            // btnRemoveStudentSubject
            // 
            this.btnRemoveStudentSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveStudentSubject.Location = new System.Drawing.Point(12, 322);
            this.btnRemoveStudentSubject.Name = "btnRemoveStudentSubject";
            this.btnRemoveStudentSubject.Size = new System.Drawing.Size(120, 64);
            this.btnRemoveStudentSubject.TabIndex = 2;
            this.btnRemoveStudentSubject.Text = "Odebrat předmět";
            this.btnRemoveStudentSubject.UseVisualStyleBackColor = true;
            this.btnRemoveStudentSubject.Click += new System.EventHandler(this.btnRemoveStudentSubject_Click);
            // 
            // btnAddStudentSubjects
            // 
            this.btnAddStudentSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudentSubjects.Location = new System.Drawing.Point(236, 322);
            this.btnAddStudentSubjects.Name = "btnAddStudentSubjects";
            this.btnAddStudentSubjects.Size = new System.Drawing.Size(120, 64);
            this.btnAddStudentSubjects.TabIndex = 3;
            this.btnAddStudentSubjects.Text = "Přidat předmět";
            this.btnAddStudentSubjects.UseVisualStyleBackColor = true;
            this.btnAddStudentSubjects.Click += new System.EventHandler(this.btnAddStudentSubjects_Click);
            // 
            // formCustomizeStudentSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 398);
            this.Controls.Add(this.btnAddStudentSubjects);
            this.Controls.Add(this.btnRemoveStudentSubject);
            this.Controls.Add(this.lsAllStudentSubjects);
            this.Controls.Add(this.lsAcStudentSubjects);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(463, 454);
            this.MinimumSize = new System.Drawing.Size(463, 454);
            this.Name = "formCustomizeStudentSubjects";
            this.Text = "Databáze studentů";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsAcStudentSubjects;
        private System.Windows.Forms.ListBox lsAllStudentSubjects;
        private System.Windows.Forms.Button btnRemoveStudentSubject;
        private System.Windows.Forms.Button btnAddStudentSubjects;
    }
}