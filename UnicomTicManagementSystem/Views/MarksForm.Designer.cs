namespace UnicomTicManagementSystem.Views
{
    partial class MarksForm
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
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelExam = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbExam = new System.Windows.Forms.ComboBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.dataGridViewMarks = new System.Windows.Forms.DataGridView();
            this.btnAddMark = new System.Windows.Forms.Button();
            this.btnEditMark = new System.Windows.Forms.Button();
            this.btnDeleteMark = new System.Windows.Forms.Button();
            this.btnViewMark = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(189, 64);
            this.labelStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(91, 28);
            this.labelStudent.TabIndex = 0;
            this.labelStudent.Text = "Student:";
            this.labelStudent.Click += new System.EventHandler(this.labelStudent_Click);
            // 
            // labelExam
            // 
            this.labelExam.AutoSize = true;
            this.labelExam.Location = new System.Drawing.Point(189, 133);
            this.labelExam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExam.Name = "labelExam";
            this.labelExam.Size = new System.Drawing.Size(68, 28);
            this.labelExam.TabIndex = 1;
            this.labelExam.Text = "Exam:";
            this.labelExam.Click += new System.EventHandler(this.labelExam_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(189, 199);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(69, 28);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score:";
            this.labelScore.Click += new System.EventHandler(this.labelScore_Click);
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(403, 56);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(225, 36);
            this.cmbStudent.TabIndex = 3;
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            // 
            // cmbExam
            // 
            this.cmbExam.FormattingEnabled = true;
            this.cmbExam.Location = new System.Drawing.Point(407, 130);
            this.cmbExam.Name = "cmbExam";
            this.cmbExam.Size = new System.Drawing.Size(221, 36);
            this.cmbExam.TabIndex = 4;
            this.cmbExam.SelectedIndexChanged += new System.EventHandler(this.cmbExam_SelectedIndexChanged);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(407, 196);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(221, 34);
            this.txtScore.TabIndex = 5;
            this.txtScore.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridViewMarks
            // 
            this.dataGridViewMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarks.Location = new System.Drawing.Point(324, 274);
            this.dataGridViewMarks.Name = "dataGridViewMarks";
            this.dataGridViewMarks.RowHeadersWidth = 62;
            this.dataGridViewMarks.RowTemplate.Height = 28;
            this.dataGridViewMarks.Size = new System.Drawing.Size(424, 226);
            this.dataGridViewMarks.TabIndex = 6;
            this.dataGridViewMarks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarks_CellContentClick);
            // 
            // btnAddMark
            // 
            this.btnAddMark.Location = new System.Drawing.Point(76, 535);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(111, 40);
            this.btnAddMark.TabIndex = 7;
            this.btnAddMark.Text = "ADD";
            this.btnAddMark.UseVisualStyleBackColor = true;
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // btnEditMark
            // 
            this.btnEditMark.Location = new System.Drawing.Point(258, 535);
            this.btnEditMark.Name = "btnEditMark";
            this.btnEditMark.Size = new System.Drawing.Size(103, 40);
            this.btnEditMark.TabIndex = 8;
            this.btnEditMark.Text = "EDIT";
            this.btnEditMark.UseVisualStyleBackColor = true;
            this.btnEditMark.Click += new System.EventHandler(this.btnEditMark_Click);
            // 
            // btnDeleteMark
            // 
            this.btnDeleteMark.Location = new System.Drawing.Point(425, 535);
            this.btnDeleteMark.Name = "btnDeleteMark";
            this.btnDeleteMark.Size = new System.Drawing.Size(105, 40);
            this.btnDeleteMark.TabIndex = 9;
            this.btnDeleteMark.Text = "DELETE";
            this.btnDeleteMark.UseVisualStyleBackColor = true;
            this.btnDeleteMark.Click += new System.EventHandler(this.btnDeleteMark_Click);
            // 
            // btnViewMark
            // 
            this.btnViewMark.Location = new System.Drawing.Point(618, 535);
            this.btnViewMark.Name = "btnViewMark";
            this.btnViewMark.Size = new System.Drawing.Size(101, 40);
            this.btnViewMark.TabIndex = 10;
            this.btnViewMark.Text = "VIEW";
            this.btnViewMark.UseVisualStyleBackColor = true;
            this.btnViewMark.Click += new System.EventHandler(this.btnViewMark_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(800, 535);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 630);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewMark);
            this.Controls.Add(this.btnDeleteMark);
            this.Controls.Add(this.btnEditMark);
            this.Controls.Add(this.btnAddMark);
            this.Controls.Add(this.dataGridViewMarks);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.cmbExam);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelExam);
            this.Controls.Add(this.labelStudent);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MarksForm";
            this.Text = "Marks";
            this.Load += new System.EventHandler(this.MarksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelExam;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.ComboBox cmbExam;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.DataGridView dataGridViewMarks;
        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.Button btnEditMark;
        private System.Windows.Forms.Button btnDeleteMark;
        private System.Windows.Forms.Button btnViewMark;
        private System.Windows.Forms.Button btnBack;
    }
}