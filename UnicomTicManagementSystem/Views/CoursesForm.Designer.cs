namespace UnicomTicManagementSystem.Views
{
    partial class CoursesForm
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
            this.labelCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnEditCourseName = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewCourse = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(196, 93);
            this.labelCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(55, 19);
            this.labelCourseName.TabIndex = 0;
            this.labelCourseName.Text = "Course";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(353, 90);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(247, 26);
            this.txtCourseName.TabIndex = 1;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(298, 207);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 51;
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(430, 288);
            this.dataGridViewCourses.TabIndex = 2;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(155, 553);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(105, 32);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "ADD";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click_1);
            // 
            // btnEditCourseName
            // 
            this.btnEditCourseName.Location = new System.Drawing.Point(333, 553);
            this.btnEditCourseName.Name = "btnEditCourseName";
            this.btnEditCourseName.Size = new System.Drawing.Size(83, 31);
            this.btnEditCourseName.TabIndex = 4;
            this.btnEditCourseName.Text = "EDIT";
            this.btnEditCourseName.UseVisualStyleBackColor = true;
            this.btnEditCourseName.Click += new System.EventHandler(this.btnEditCourseName_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(494, 553);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnViewCourse
            // 
            this.btnViewCourse.Location = new System.Drawing.Point(649, 553);
            this.btnViewCourse.Name = "btnViewCourse";
            this.btnViewCourse.Size = new System.Drawing.Size(75, 32);
            this.btnViewCourse.TabIndex = 6;
            this.btnViewCourse.Text = "View";
            this.btnViewCourse.UseVisualStyleBackColor = true;
            this.btnViewCourse.Click += new System.EventHandler(this.btnViewCourse_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(804, 553);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 647);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewCourse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditCourseName);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.labelCourseName);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CoursesForm";
            this.Text = "CoursesForm";
            this.Load += new System.EventHandler(this.CoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnEditCourseName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewCourse;
        private System.Windows.Forms.Button btnBack;
    }
}