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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewCourse = new System.Windows.Forms.Button();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(354, 129);
            this.dataGridViewCourses.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 62;
            this.dataGridViewCourses.RowTemplate.Height = 28;
            this.dataGridViewCourses.Size = new System.Drawing.Size(320, 210);
            this.dataGridViewCourses.TabIndex = 0;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(113, 466);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(100, 32);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Location = new System.Drawing.Point(314, 466);
            this.btnEditCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(100, 32);
            this.btnEditCourse.TabIndex = 2;
            this.btnEditCourse.Text = "Edit";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(511, 466);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewCourse
            // 
            this.btnViewCourse.Location = new System.Drawing.Point(710, 463);
            this.btnViewCourse.Name = "btnViewCourse";
            this.btnViewCourse.Size = new System.Drawing.Size(141, 35);
            this.btnViewCourse.TabIndex = 4;
            this.btnViewCourse.Text = "ViewCourse";
            this.btnViewCourse.UseVisualStyleBackColor = true;
            this.btnViewCourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(312, 41);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(395, 34);
            this.txtCourseName.TabIndex = 5;
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 630);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.btnViewCourse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.dataGridViewCourses);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CoursesForm";
            this.Text = "CoursesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewCourse;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}