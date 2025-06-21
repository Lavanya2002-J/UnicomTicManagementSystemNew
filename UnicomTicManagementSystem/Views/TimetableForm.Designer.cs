namespace UnicomTicManagementSystem.Views
{
    partial class TimetableForm
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
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelTimeSlot = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.txtTimeSlot = new System.Windows.Forms.TextBox();
            this.dataGridViewTimetable = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(283, 39);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(87, 28);
            this.labelSubject.TabIndex = 0;
            this.labelSubject.Text = "Subject:";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(283, 119);
            this.labelRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(72, 28);
            this.labelRoom.TabIndex = 1;
            this.labelRoom.Text = "Room:";
            // 
            // labelTimeSlot
            // 
            this.labelTimeSlot.AutoSize = true;
            this.labelTimeSlot.Location = new System.Drawing.Point(283, 200);
            this.labelTimeSlot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeSlot.Name = "labelTimeSlot";
            this.labelTimeSlot.Size = new System.Drawing.Size(64, 28);
            this.labelTimeSlot.TabIndex = 2;
            this.labelTimeSlot.Text = "Time:";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(461, 31);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(223, 36);
            this.cmbSubject.TabIndex = 3;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(461, 119);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(223, 36);
            this.cmbRoom.TabIndex = 4;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtTimeSlot
            // 
            this.txtTimeSlot.Location = new System.Drawing.Point(461, 194);
            this.txtTimeSlot.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeSlot.Name = "txtTimeSlot";
            this.txtTimeSlot.Size = new System.Drawing.Size(223, 34);
            this.txtTimeSlot.TabIndex = 5;
            // 
            // dataGridViewTimetable
            // 
            this.dataGridViewTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimetable.Location = new System.Drawing.Point(361, 334);
            this.dataGridViewTimetable.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTimetable.Name = "dataGridViewTimetable";
            this.dataGridViewTimetable.RowHeadersWidth = 62;
            this.dataGridViewTimetable.RowTemplate.Height = 28;
            this.dataGridViewTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTimetable.Size = new System.Drawing.Size(515, 271);
            this.dataGridViewTimetable.TabIndex = 6;
            this.dataGridViewTimetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTimetable_CellContentClick);
            this.dataGridViewTimetable.SelectionChanged += new System.EventHandler(this.dataGridViewTimetable_SelectionChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(175, 629);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 32);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(350, 629);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 32);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(539, 629);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(748, 629);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 32);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(928, 629);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 32);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(285, 249);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(62, 28);
            this.labelDate.TabIndex = 12;
            this.labelDate.Text = "Date:";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(461, 262);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(223, 34);
            this.datePicker.TabIndex = 13;
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 692);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewTimetable);
            this.Controls.Add(this.txtTimeSlot);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.labelTimeSlot);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelSubject);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            this.Load += new System.EventHandler(this.TimetableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelTimeSlot;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.TextBox txtTimeSlot;
        private System.Windows.Forms.DataGridView dataGridViewTimetable;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}