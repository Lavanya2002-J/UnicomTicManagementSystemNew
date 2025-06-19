namespace UnicomTicManagementSystem.Views
{
    partial class UserManagementForm
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(432, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 34);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(432, 139);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(216, 34);
            this.textPassword.TabIndex = 1;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(432, 218);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(216, 36);
            this.cmbRole.TabIndex = 2;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(265, 56);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(115, 28);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "UserName:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(265, 139);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(106, 28);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password:";
            this.labelPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(265, 226);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(59, 28);
            this.labelRole.TabIndex = 5;
            this.labelRole.Text = "Role:";
            this.labelRole.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(358, 295);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 62;
            this.dataGridViewUsers.RowTemplate.Height = 28;
            this.dataGridViewUsers.Size = new System.Drawing.Size(404, 222);
            this.dataGridViewUsers.TabIndex = 6;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(177, 568);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(87, 32);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "ADD";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(415, 567);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(789, 566);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(627, 566);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 630);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagementForm";
            this.Text = "UserManagementForm";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUpdate;
    }
}