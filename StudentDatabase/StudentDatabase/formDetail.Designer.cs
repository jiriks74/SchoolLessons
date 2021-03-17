namespace StudentDatabase
{
    partial class formDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDetail));
            this.txStudentID = new System.Windows.Forms.TextBox();
            this.txStudentName = new System.Windows.Forms.TextBox();
            this.txStudentLastName = new System.Windows.Forms.TextBox();
            this.txStudentBorn = new System.Windows.Forms.TextBox();
            this.txStudentClass = new System.Windows.Forms.TextBox();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbBorn = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbStudentSubjects = new System.Windows.Forms.Label();
            this.lsStudentSubjects = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCustomizeStudentSubjects = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txStudentID
            // 
            this.txStudentID.Location = new System.Drawing.Point(12, 72);
            this.txStudentID.Name = "txStudentID";
            this.txStudentID.ReadOnly = true;
            this.txStudentID.Size = new System.Drawing.Size(100, 26);
            this.txStudentID.TabIndex = 0;
            // 
            // txStudentName
            // 
            this.txStudentName.Location = new System.Drawing.Point(118, 72);
            this.txStudentName.Name = "txStudentName";
            this.txStudentName.Size = new System.Drawing.Size(100, 26);
            this.txStudentName.TabIndex = 1;
            // 
            // txStudentLastName
            // 
            this.txStudentLastName.Location = new System.Drawing.Point(224, 72);
            this.txStudentLastName.Name = "txStudentLastName";
            this.txStudentLastName.Size = new System.Drawing.Size(100, 26);
            this.txStudentLastName.TabIndex = 2;
            // 
            // txStudentBorn
            // 
            this.txStudentBorn.Location = new System.Drawing.Point(330, 72);
            this.txStudentBorn.Name = "txStudentBorn";
            this.txStudentBorn.Size = new System.Drawing.Size(100, 26);
            this.txStudentBorn.TabIndex = 3;
            // 
            // txStudentClass
            // 
            this.txStudentClass.Location = new System.Drawing.Point(436, 72);
            this.txStudentClass.MaxLength = 5;
            this.txStudentClass.Name = "txStudentClass";
            this.txStudentClass.Size = new System.Drawing.Size(100, 26);
            this.txStudentClass.TabIndex = 3;
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(8, 49);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(94, 20);
            this.lbStudentID.TabIndex = 5;
            this.lbStudentID.Text = "Id studenta:";
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Location = new System.Drawing.Point(114, 49);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(61, 20);
            this.lbStudentName.TabIndex = 6;
            this.lbStudentName.Text = "Jméno:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(220, 49);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(68, 20);
            this.lbLastName.TabIndex = 7;
            this.lbLastName.Text = "Příjmení:";
            // 
            // lbBorn
            // 
            this.lbBorn.AutoSize = true;
            this.lbBorn.Location = new System.Drawing.Point(326, 49);
            this.lbBorn.Name = "lbBorn";
            this.lbBorn.Size = new System.Drawing.Size(73, 20);
            this.lbBorn.TabIndex = 8;
            this.lbBorn.Text = "Narozen:";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(432, 49);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(48, 20);
            this.lbClass.TabIndex = 9;
            this.lbClass.Text = "Třída:";
            // 
            // lbStudentSubjects
            // 
            this.lbStudentSubjects.AutoSize = true;
            this.lbStudentSubjects.Location = new System.Drawing.Point(12, 115);
            this.lbStudentSubjects.Name = "lbStudentSubjects";
            this.lbStudentSubjects.Size = new System.Drawing.Size(80, 20);
            this.lbStudentSubjects.TabIndex = 12;
            this.lbStudentSubjects.Text = "Předměty:";
            // 
            // lsStudentSubjects
            // 
            this.lsStudentSubjects.FormattingEnabled = true;
            this.lsStudentSubjects.HorizontalScrollbar = true;
            this.lsStudentSubjects.ItemHeight = 20;
            this.lsStudentSubjects.Location = new System.Drawing.Point(16, 138);
            this.lsStudentSubjects.Name = "lsStudentSubjects";
            this.lsStudentSubjects.Size = new System.Drawing.Size(159, 204);
            this.lsStudentSubjects.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(542, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 311);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnCustomizeStudentSubjects
            // 
            this.btnCustomizeStudentSubjects.Location = new System.Drawing.Point(16, 348);
            this.btnCustomizeStudentSubjects.Name = "btnCustomizeStudentSubjects";
            this.btnCustomizeStudentSubjects.Size = new System.Drawing.Size(125, 53);
            this.btnCustomizeStudentSubjects.TabIndex = 15;
            this.btnCustomizeStudentSubjects.Text = "Upravit přednměty";
            this.btnCustomizeStudentSubjects.UseVisualStyleBackColor = true;
            this.btnCustomizeStudentSubjects.Click += new System.EventHandler(this.btnCustomizeStudentSubjects_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(436, 104);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 53);
            this.btnSaveChanges.TabIndex = 16;
            this.btnSaveChanges.Text = "Uložit změny";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // formDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 413);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnCustomizeStudentSubjects);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lsStudentSubjects);
            this.Controls.Add(this.lbStudentSubjects);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.lbBorn);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbStudentName);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.txStudentClass);
            this.Controls.Add(this.txStudentBorn);
            this.Controls.Add(this.txStudentLastName);
            this.Controls.Add(this.txStudentName);
            this.Controls.Add(this.txStudentID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(824, 469);
            this.MinimumSize = new System.Drawing.Size(824, 469);
            this.Name = "formDetail";
            this.Text = "Databáze studentů";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txStudentID;
        private System.Windows.Forms.TextBox txStudentName;
        private System.Windows.Forms.TextBox txStudentLastName;
        private System.Windows.Forms.TextBox txStudentBorn;
        private System.Windows.Forms.TextBox txStudentClass;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbBorn;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbStudentSubjects;
        private System.Windows.Forms.ListBox lsStudentSubjects;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCustomizeStudentSubjects;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}