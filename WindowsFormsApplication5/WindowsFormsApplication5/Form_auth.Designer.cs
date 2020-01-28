namespace WindowsFormsApplication5
{
    partial class Form_auth
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_auth = new System.Windows.Forms.Button();
            this.button_reg = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_auth
            // 
            this.button_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.button_auth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_auth.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_auth.ForeColor = System.Drawing.Color.White;
            this.button_auth.Location = new System.Drawing.Point(55, 176);
            this.button_auth.Name = "button_auth";
            this.button_auth.Size = new System.Drawing.Size(175, 34);
            this.button_auth.TabIndex = 0;
            this.button_auth.Text = "Авторизироваться";
            this.button_auth.UseVisualStyleBackColor = false;
            this.button_auth.Click += new System.EventHandler(this.button_auth_Click);
            // 
            // button_reg
            // 
            this.button_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.button_reg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_reg.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reg.ForeColor = System.Drawing.Color.White;
            this.button_reg.Location = new System.Drawing.Point(55, 216);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(175, 34);
            this.button_reg.TabIndex = 1;
            this.button_reg.Text = "Зарегистрироваться";
            this.button_reg.UseVisualStyleBackColor = false;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_login.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.ForeColor = System.Drawing.Color.White;
            this.textBox_login.Location = new System.Drawing.Point(96, 70);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 28);
            this.textBox_login.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.ForeColor = System.Drawing.Color.White;
            this.textBox_password.Location = new System.Drawing.Point(96, 124);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 28);
            this.textBox_password.TabIndex = 3;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.Color.Black;
            this.label_login.Location = new System.Drawing.Point(116, 47);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(54, 20);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "Логин";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.ForeColor = System.Drawing.Color.Black;
            this.label_password.Location = new System.Drawing.Point(116, 101);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(65, 20);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Пароль";
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_error.ForeColor = System.Drawing.Color.Black;
            this.label_error.Location = new System.Drawing.Point(104, 9);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(85, 20);
            this.label_error.TabIndex = 6;
            this.label_error.Text = "Состояние";
            // 
            // Form_auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.button_auth);
            this.Name = "Form_auth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form_auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_auth;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_error;
    }
}

