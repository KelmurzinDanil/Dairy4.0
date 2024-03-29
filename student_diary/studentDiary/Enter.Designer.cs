namespace studentDiary
{
    partial class OpenWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuthorizationButton1 = new System.Windows.Forms.Button();
            this.RegistrationButton2 = new System.Windows.Forms.Button();
            this.AuthorizationText = new System.Windows.Forms.Label();
            this.RegistrationText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthorizationButton1
            // 
            this.AuthorizationButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AuthorizationButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AuthorizationButton1.Location = new System.Drawing.Point(218, 96);
            this.AuthorizationButton1.Name = "AuthorizationButton1";
            this.AuthorizationButton1.Size = new System.Drawing.Size(263, 71);
            this.AuthorizationButton1.TabIndex = 0;
            this.AuthorizationButton1.Text = "Войти";
            this.AuthorizationButton1.UseVisualStyleBackColor = false;
            this.AuthorizationButton1.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // RegistrationButton2
            // 
            this.RegistrationButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RegistrationButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistrationButton2.Location = new System.Drawing.Point(218, 275);
            this.RegistrationButton2.Name = "RegistrationButton2";
            this.RegistrationButton2.Size = new System.Drawing.Size(272, 85);
            this.RegistrationButton2.TabIndex = 1;
            this.RegistrationButton2.Text = "Зарегистрироваться";
            this.RegistrationButton2.UseVisualStyleBackColor = false;
            this.RegistrationButton2.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // AuthorizationText
            // 
            this.AuthorizationText.AutoSize = true;
            this.AuthorizationText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationText.Location = new System.Drawing.Point(194, 34);
            this.AuthorizationText.Name = "AuthorizationText";
            this.AuthorizationText.Size = new System.Drawing.Size(305, 27);
            this.AuthorizationText.TabIndex = 2;
            this.AuthorizationText.Text = "Есть аккаунт? Скорее заходи!\r\n";
            // 
            // RegistrationText
            // 
            this.RegistrationText.AutoSize = true;
            this.RegistrationText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationText.Location = new System.Drawing.Point(138, 213);
            this.RegistrationText.Name = "RegistrationText";
            this.RegistrationText.Size = new System.Drawing.Size(455, 27);
            this.RegistrationText.TabIndex = 3;
            this.RegistrationText.Text = "Нет аккаунта? Тогда скорее присоединяйся!";
            // 
            // OpenWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(695, 394);
            this.Controls.Add(this.RegistrationText);
            this.Controls.Add(this.AuthorizationText);
            this.Controls.Add(this.RegistrationButton2);
            this.Controls.Add(this.AuthorizationButton1);
            this.Name = "OpenWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthorizationButton1;
        private System.Windows.Forms.Button RegistrationButton2;
        private System.Windows.Forms.Label AuthorizationText;
        private System.Windows.Forms.Label RegistrationText;
    }
}

