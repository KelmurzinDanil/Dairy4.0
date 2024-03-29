namespace studentDiary
{
    partial class LessonCardWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NoteCardLesson = new System.Windows.Forms.TextBox();
            this.SaveCardLessonBtn = new System.Windows.Forms.Button();
            this.NameCardLesson = new System.Windows.Forms.TextBox();
            this.ProfessorNameCardLesson = new System.Windows.Forms.TextBox();
            this.DataNameCardLesson = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО преподавателя ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(15, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(9, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Заметки";
            // 
            // NoteCardLesson
            // 
            this.NoteCardLesson.Location = new System.Drawing.Point(17, 265);
            this.NoteCardLesson.Multiline = true;
            this.NoteCardLesson.Name = "NoteCardLesson";
            this.NoteCardLesson.Size = new System.Drawing.Size(457, 191);
            this.NoteCardLesson.TabIndex = 5;
            // 
            // SaveCardLessonBtn
            // 
            this.SaveCardLessonBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SaveCardLessonBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveCardLessonBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveCardLessonBtn.Location = new System.Drawing.Point(336, 472);
            this.SaveCardLessonBtn.Name = "SaveCardLessonBtn";
            this.SaveCardLessonBtn.Size = new System.Drawing.Size(138, 42);
            this.SaveCardLessonBtn.TabIndex = 7;
            this.SaveCardLessonBtn.Text = "Сохранить";
            this.SaveCardLessonBtn.UseVisualStyleBackColor = false;
            // 
            // NameCardLesson
            // 
            this.NameCardLesson.Location = new System.Drawing.Point(12, 48);
            this.NameCardLesson.Name = "NameCardLesson";
            this.NameCardLesson.ReadOnly = true;
            this.NameCardLesson.Size = new System.Drawing.Size(294, 22);
            this.NameCardLesson.TabIndex = 8;
            // 
            // ProfessorNameCardLesson
            // 
            this.ProfessorNameCardLesson.Location = new System.Drawing.Point(12, 115);
            this.ProfessorNameCardLesson.Name = "ProfessorNameCardLesson";
            this.ProfessorNameCardLesson.ReadOnly = true;
            this.ProfessorNameCardLesson.Size = new System.Drawing.Size(294, 22);
            this.ProfessorNameCardLesson.TabIndex = 10;
            // 
            // DataNameCardLesson
            // 
            this.DataNameCardLesson.Location = new System.Drawing.Point(12, 183);
            this.DataNameCardLesson.Name = "DataNameCardLesson";
            this.DataNameCardLesson.ReadOnly = true;
            this.DataNameCardLesson.Size = new System.Drawing.Size(294, 22);
            this.DataNameCardLesson.TabIndex = 11;
            // 
            // LessonCardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(502, 534);
            this.Controls.Add(this.DataNameCardLesson);
            this.Controls.Add(this.ProfessorNameCardLesson);
            this.Controls.Add(this.NameCardLesson);
            this.Controls.Add(this.SaveCardLessonBtn);
            this.Controls.Add(this.NoteCardLesson);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "LessonCardWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NoteCardLesson;
        private System.Windows.Forms.Button SaveCardLessonBtn;
        private System.Windows.Forms.TextBox NameCardLesson;
        private System.Windows.Forms.TextBox ProfessorNameCardLesson;
        private System.Windows.Forms.TextBox DataNameCardLesson;
    }
}