namespace StudentDatabase
{
    partial class formRegisterStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegisterStudent));
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbBorn = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.txStudentClass = new System.Windows.Forms.TextBox();
            this.txStudentBorn = new System.Windows.Forms.TextBox();
            this.txStudentLastName = new System.Windows.Forms.TextBox();
            this.txStudentName = new System.Windows.Forms.TextBox();
            this.txStudentID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(445, 64);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 53);
            this.btnSaveChanges.TabIndex = 27;
            this.btnSaveChanges.Text = "Uložit změny";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(432, 9);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(48, 20);
            this.lbClass.TabIndex = 26;
            this.lbClass.Text = "Třída:";
            // 
            // lbBorn
            // 
            this.lbBorn.AutoSize = true;
            this.lbBorn.Location = new System.Drawing.Point(326, 9);
            this.lbBorn.Name = "lbBorn";
            this.lbBorn.Size = new System.Drawing.Size(92, 20);
            this.lbBorn.TabIndex = 25;
            this.lbBorn.Text = "Narozen(a):";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(220, 9);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(68, 20);
            this.lbLastName.TabIndex = 24;
            this.lbLastName.Text = "Příjmení:";
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Location = new System.Drawing.Point(114, 9);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(61, 20);
            this.lbStudentName.TabIndex = 23;
            this.lbStudentName.Text = "Jméno:";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(8, 9);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(94, 20);
            this.lbStudentID.TabIndex = 22;
            this.lbStudentID.Text = "Id studenta:";
            // 
            // txStudentClass
            // 
            this.txStudentClass.Location = new System.Drawing.Point(436, 32);
            this.txStudentClass.MaxLength = 5;
            this.txStudentClass.Name = "txStudentClass";
            this.txStudentClass.Size = new System.Drawing.Size(100, 26);
            this.txStudentClass.TabIndex = 21;
            // 
            // txStudentBorn
            // 
            this.txStudentBorn.Location = new System.Drawing.Point(330, 32);
            this.txStudentBorn.Name = "txStudentBorn";
            this.txStudentBorn.Size = new System.Drawing.Size(100, 26);
            this.txStudentBorn.TabIndex = 20;
            // 
            // txStudentLastName
            // 
            this.txStudentLastName.Location = new System.Drawing.Point(224, 32);
            this.txStudentLastName.Name = "txStudentLastName";
            this.txStudentLastName.Size = new System.Drawing.Size(100, 26);
            this.txStudentLastName.TabIndex = 19;
            // 
            // txStudentName
            // 
            this.txStudentName.Location = new System.Drawing.Point(118, 32);
            this.txStudentName.Name = "txStudentName";
            this.txStudentName.Size = new System.Drawing.Size(100, 26);
            this.txStudentName.TabIndex = 18;
            // 
            // txStudentID
            // 
            this.txStudentID.Location = new System.Drawing.Point(12, 32);
            this.txStudentID.Name = "txStudentID";
            this.txStudentID.Size = new System.Drawing.Size(100, 26);
            this.txStudentID.TabIndex = 17;
            // 
            // formRegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 129);
            this.Controls.Add(this.btnSaveChanges);
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
            this.MaximumSize = new System.Drawing.Size(570, 185);
            this.MinimumSize = new System.Drawing.Size(570, 185);
            this.Name = "formRegisterStudent";
            this.Text = "Databáze studentů";
            this.Load += new System.EventHandler(this.formRegisterStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbBorn;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.TextBox txStudentClass;
        private System.Windows.Forms.TextBox txStudentBorn;
        private System.Windows.Forms.TextBox txStudentLastName;
        private System.Windows.Forms.TextBox txStudentName;
        private System.Windows.Forms.TextBox txStudentID;
    }
}