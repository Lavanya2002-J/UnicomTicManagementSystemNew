namespace UnicomTicManagementSystem.Views
{
    partial class AdminDashboard
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
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewExam = new System.Windows.Forms.Button();
            this.btnViewMarks = new System.Windows.Forms.Button();
            this.btnViewTimetable = new System.Windows.Forms.Button();
            this.btnViewRooms = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(396, 132);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(190, 32);
            this.btnCourses.TabIndex = 0;
            this.btnCourses.Text = "View Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Location = new System.Drawing.Point(396, 188);
            this.btnSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(190, 32);
            this.btnSubjects.TabIndex = 1;
            this.btnSubjects.Text = "View Subjects";
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(396, 253);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(190, 32);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "ViewStudents";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(396, 603);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 37);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME ADMIN";
            // 
            // btnViewExam
            // 
            this.btnViewExam.Location = new System.Drawing.Point(396, 316);
            this.btnViewExam.Name = "btnViewExam";
            this.btnViewExam.Size = new System.Drawing.Size(190, 37);
            this.btnViewExam.TabIndex = 5;
            this.btnViewExam.Text = "ViewExams";
            this.btnViewExam.UseVisualStyleBackColor = true;
            this.btnViewExam.Click += new System.EventHandler(this.btnViewExam_Click);
            // 
            // btnViewMarks
            // 
            this.btnViewMarks.Location = new System.Drawing.Point(396, 388);
            this.btnViewMarks.Name = "btnViewMarks";
            this.btnViewMarks.Size = new System.Drawing.Size(190, 33);
            this.btnViewMarks.TabIndex = 6;
            this.btnViewMarks.Text = "ViewMarks";
            this.btnViewMarks.UseVisualStyleBackColor = true;
            this.btnViewMarks.Click += new System.EventHandler(this.btnViewMarks_Click);
            // 
            // btnViewTimetable
            // 
            this.btnViewTimetable.Location = new System.Drawing.Point(396, 531);
            this.btnViewTimetable.Name = "btnViewTimetable";
            this.btnViewTimetable.Size = new System.Drawing.Size(190, 34);
            this.btnViewTimetable.TabIndex = 7;
            this.btnViewTimetable.Text = "ViewTimetable";
            this.btnViewTimetable.UseVisualStyleBackColor = true;
            this.btnViewTimetable.Click += new System.EventHandler(this.btnViewTimetable_Click);
            // 
            // btnViewRooms
            // 
            this.btnViewRooms.Location = new System.Drawing.Point(396, 459);
            this.btnViewRooms.Name = "btnViewRooms";
            this.btnViewRooms.Size = new System.Drawing.Size(190, 35);
            this.btnViewRooms.TabIndex = 8;
            this.btnViewRooms.Text = "View Rooms";
            this.btnViewRooms.UseVisualStyleBackColor = true;
            this.btnViewRooms.Click += new System.EventHandler(this.btnViewRooms_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(396, 66);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(190, 36);
            this.btnManageUsers.TabIndex = 9;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 667);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnViewRooms);
            this.Controls.Add(this.btnViewTimetable);
            this.Controls.Add(this.btnViewMarks);
            this.Controls.Add(this.btnViewExam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnCourses);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewExam;
        private System.Windows.Forms.Button btnViewMarks;
        private System.Windows.Forms.Button btnViewTimetable;
        private System.Windows.Forms.Button btnViewRooms;
        private System.Windows.Forms.Button btnManageUsers;
    }
}