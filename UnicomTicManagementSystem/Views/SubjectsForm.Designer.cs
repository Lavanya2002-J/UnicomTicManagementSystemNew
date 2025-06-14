namespace UnicomTicManagementSystem.Views
{
    partial class SubjectsForm
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
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.comboCourse = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddSubjects = new System.Windows.Forms.Button();
            this.btnEditSubjects = new System.Windows.Forms.Button();
            this.btnDeleteSubjects = new System.Windows.Forms.Button();
            this.btnBackSubjects = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(264, 53);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(271, 34);
            this.txtSubjectName.TabIndex = 0;
            this.txtSubjectName.TextChanged += new System.EventHandler(this.txtSubjectName_TextChanged);
            // 
            // comboCourse
            // 
            this.comboCourse.FormattingEnabled = true;
            this.comboCourse.Location = new System.Drawing.Point(264, 127);
            this.comboCourse.Name = "comboCourse";
            this.comboCourse.Size = new System.Drawing.Size(271, 36);
            this.comboCourse.TabIndex = 1;
            this.comboCourse.SelectedIndexChanged += new System.EventHandler(this.comboCourse_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(222, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(396, 249);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnAddSubjects
            // 
            this.btnAddSubjects.Location = new System.Drawing.Point(131, 537);
            this.btnAddSubjects.Name = "btnAddSubjects";
            this.btnAddSubjects.Size = new System.Drawing.Size(98, 44);
            this.btnAddSubjects.TabIndex = 3;
            this.btnAddSubjects.Text = "ADD";
            this.btnAddSubjects.UseVisualStyleBackColor = true;
            this.btnAddSubjects.Click += new System.EventHandler(this.btnAddSubjects_Click);
            // 
            // btnEditSubjects
            // 
            this.btnEditSubjects.Location = new System.Drawing.Point(309, 541);
            this.btnEditSubjects.Name = "btnEditSubjects";
            this.btnEditSubjects.Size = new System.Drawing.Size(105, 37);
            this.btnEditSubjects.TabIndex = 4;
            this.btnEditSubjects.Text = "EDIT";
            this.btnEditSubjects.UseVisualStyleBackColor = true;
            this.btnEditSubjects.Click += new System.EventHandler(this.btnEditSubjects_Click);
            // 
            // btnDeleteSubjects
            // 
            this.btnDeleteSubjects.Location = new System.Drawing.Point(511, 541);
            this.btnDeleteSubjects.Name = "btnDeleteSubjects";
            this.btnDeleteSubjects.Size = new System.Drawing.Size(107, 42);
            this.btnDeleteSubjects.TabIndex = 5;
            this.btnDeleteSubjects.Text = "DELETE";
            this.btnDeleteSubjects.UseVisualStyleBackColor = true;
            this.btnDeleteSubjects.Click += new System.EventHandler(this.btnDeleteSubjects_Click);
            // 
            // btnBackSubjects
            // 
            this.btnBackSubjects.Location = new System.Drawing.Point(702, 546);
            this.btnBackSubjects.Name = "btnBackSubjects";
            this.btnBackSubjects.Size = new System.Drawing.Size(97, 37);
            this.btnBackSubjects.TabIndex = 6;
            this.btnBackSubjects.Text = "BACK";
            this.btnBackSubjects.UseVisualStyleBackColor = true;
            this.btnBackSubjects.Click += new System.EventHandler(this.btnBackSubjects_Click);
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 630);
            this.Controls.Add(this.btnBackSubjects);
            this.Controls.Add(this.btnDeleteSubjects);
            this.Controls.Add(this.btnEditSubjects);
            this.Controls.Add(this.btnAddSubjects);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboCourse);
            this.Controls.Add(this.txtSubjectName);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            this.Load += new System.EventHandler(this.SubjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.ComboBox comboCourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddSubjects;
        private System.Windows.Forms.Button btnEditSubjects;
        private System.Windows.Forms.Button btnDeleteSubjects;
        private System.Windows.Forms.Button btnBackSubjects;
    }
}