namespace studentDiary
{
    partial class EditGroupForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.GroupList = new System.Windows.Forms.ComboBox();
            this.GroupListText = new System.Windows.Forms.Label();
            this.StudentList = new System.Windows.Forms.ListBox();
            this.StudentListText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.splitContainer1.Panel1.Controls.Add(this.AddGroupButton);
            this.splitContainer1.Panel1.Controls.Add(this.GroupList);
            this.splitContainer1.Panel1.Controls.Add(this.GroupListText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.StudentList);
            this.splitContainer1.Panel2.Controls.Add(this.StudentListText);
            this.splitContainer1.Size = new System.Drawing.Size(702, 671);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 0;
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddGroupButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddGroupButton.ForeColor = System.Drawing.Color.White;
            this.AddGroupButton.Location = new System.Drawing.Point(3, 612);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(228, 58);
            this.AddGroupButton.TabIndex = 2;
            this.AddGroupButton.Text = "Добавить группу";
            this.AddGroupButton.UseVisualStyleBackColor = false;
            this.AddGroupButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupList
            // 
            this.GroupList.FormattingEnabled = true;
            this.GroupList.Location = new System.Drawing.Point(0, 57);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(231, 24);
            this.GroupList.TabIndex = 1;
            this.GroupList.SelectedIndexChanged += new System.EventHandler(this.GroupList_SelectedIndexChanged);
            // 
            // GroupListText
            // 
            this.GroupListText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupListText.ForeColor = System.Drawing.Color.SlateBlue;
            this.GroupListText.Location = new System.Drawing.Point(0, 0);
            this.GroupListText.Name = "GroupListText";
            this.GroupListText.Size = new System.Drawing.Size(231, 54);
            this.GroupListText.TabIndex = 0;
            this.GroupListText.Text = "Список групп";
            // 
            // StudentList
            // 
            this.StudentList.FormattingEnabled = true;
            this.StudentList.ItemHeight = 16;
            this.StudentList.Location = new System.Drawing.Point(6, 58);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(458, 612);
            this.StudentList.TabIndex = 1;
            // 
            // StudentListText
            // 
            this.StudentListText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentListText.ForeColor = System.Drawing.Color.SlateBlue;
            this.StudentListText.Location = new System.Drawing.Point(3, 0);
            this.StudentListText.Name = "StudentListText";
            this.StudentListText.Size = new System.Drawing.Size(461, 54);
            this.StudentListText.TabIndex = 0;
            this.StudentListText.Text = "Список студентов";
            // 
            // EditGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 671);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EditGroupForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label GroupListText;
        private System.Windows.Forms.Label StudentListText;
        private System.Windows.Forms.ComboBox GroupList;
        private System.Windows.Forms.ListBox StudentList;
        private System.Windows.Forms.Button AddGroupButton;
    }
}