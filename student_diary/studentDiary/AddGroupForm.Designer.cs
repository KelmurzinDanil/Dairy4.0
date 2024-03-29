namespace studentDiary
{
    partial class AddGroupForm
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
            this.GroupNumber = new System.Windows.Forms.Label();
            this.GroupNumberText = new System.Windows.Forms.TextBox();
            this.AddedStudents = new System.Windows.Forms.Label();
            this.StudentsList = new System.Windows.Forms.Label();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.StudentsListText = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.AddedStudentsText = new System.Windows.Forms.DataGridView();
            this.TransfetBtn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsListText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddedStudentsText)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupNumber
            // 
            this.GroupNumber.AutoSize = true;
            this.GroupNumber.Location = new System.Drawing.Point(25, 13);
            this.GroupNumber.Name = "GroupNumber";
            this.GroupNumber.Size = new System.Drawing.Size(100, 16);
            this.GroupNumber.TabIndex = 0;
            this.GroupNumber.Text = "Номер группы";
            // 
            // GroupNumberText
            // 
            this.GroupNumberText.Location = new System.Drawing.Point(28, 49);
            this.GroupNumberText.Name = "GroupNumberText";
            this.GroupNumberText.Size = new System.Drawing.Size(100, 22);
            this.GroupNumberText.TabIndex = 1;
            // 
            // AddedStudents
            // 
            this.AddedStudents.AutoSize = true;
            this.AddedStudents.Location = new System.Drawing.Point(25, 103);
            this.AddedStudents.Name = "AddedStudents";
            this.AddedStudents.Size = new System.Drawing.Size(97, 16);
            this.AddedStudents.TabIndex = 2;
            this.AddedStudents.Text = "Добавленные";
            // 
            // StudentsList
            // 
            this.StudentsList.AutoSize = true;
            this.StudentsList.Location = new System.Drawing.Point(309, 13);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(126, 16);
            this.StudentsList.TabIndex = 4;
            this.StudentsList.Text = "Список студентов";
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Location = new System.Drawing.Point(28, 579);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(208, 59);
            this.AddGroupButton.TabIndex = 6;
            this.AddGroupButton.Text = "Добавить";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // StudentsListText
            // 
            this.StudentsListText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsListText.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Surname});
            this.StudentsListText.Location = new System.Drawing.Point(312, 49);
            this.StudentsListText.MultiSelect = false;
            this.StudentsListText.Name = "StudentsListText";
            this.StudentsListText.RowHeadersWidth = 51;
            this.StudentsListText.RowTemplate.Height = 24;
            this.StudentsListText.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsListText.Size = new System.Drawing.Size(300, 441);
            this.StudentsListText.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.Width = 125;
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(312, 496);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(123, 48);
            this.TransferBtn.TabIndex = 9;
            this.TransferBtn.Text = "<=";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // AddedStudentsText
            // 
            this.AddedStudentsText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddedStudentsText.Location = new System.Drawing.Point(6, 132);
            this.AddedStudentsText.MultiSelect = false;
            this.AddedStudentsText.Name = "AddedStudentsText";
            this.AddedStudentsText.RowHeadersWidth = 51;
            this.AddedStudentsText.RowTemplate.Height = 24;
            this.AddedStudentsText.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddedStudentsText.Size = new System.Drawing.Size(287, 441);
            this.AddedStudentsText.TabIndex = 10;
            // 
            // TransfetBtn2
            // 
            this.TransfetBtn2.Location = new System.Drawing.Point(489, 496);
            this.TransfetBtn2.Name = "TransfetBtn2";
            this.TransfetBtn2.Size = new System.Drawing.Size(123, 48);
            this.TransfetBtn2.TabIndex = 11;
            this.TransfetBtn2.Text = "=>";
            this.TransfetBtn2.UseVisualStyleBackColor = true;
            this.TransfetBtn2.Click += new System.EventHandler(this.TransferBtn2_Click);
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 650);
            this.Controls.Add(this.TransfetBtn2);
            this.Controls.Add(this.AddedStudentsText);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.StudentsListText);
            this.Controls.Add(this.AddGroupButton);
            this.Controls.Add(this.StudentsList);
            this.Controls.Add(this.AddedStudents);
            this.Controls.Add(this.GroupNumberText);
            this.Controls.Add(this.GroupNumber);
            this.Name = "AddGroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsListText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddedStudentsText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GroupNumber;
        private System.Windows.Forms.TextBox GroupNumberText;
        private System.Windows.Forms.Label AddedStudents;
        private System.Windows.Forms.Label StudentsList;
        private System.Windows.Forms.Button AddGroupButton;
        private System.Windows.Forms.DataGridView StudentsListText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.DataGridView AddedStudentsText;
        private System.Windows.Forms.Button TransfetBtn2;
    }
}