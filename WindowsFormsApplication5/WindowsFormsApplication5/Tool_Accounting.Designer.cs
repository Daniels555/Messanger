namespace WindowsFormsApplication5
{
    partial class Tool_Accounting
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
            this.dataGrid_Instr = new System.Windows.Forms.DataGridView();
            this.button_auth = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Provide = new System.Windows.Forms.ComboBox();
            this.comboBox_TInstr = new System.Windows.Forms.ComboBox();
            this.comboBox_DegrWer = new System.Windows.Forms.ComboBox();
            this.richTextB_Quantity = new System.Windows.Forms.RichTextBox();
            this.dateTime_Acquistions = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Instr)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Instr
            // 
            this.dataGrid_Instr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGrid_Instr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Instr.Location = new System.Drawing.Point(53, 113);
            this.dataGrid_Instr.Name = "dataGrid_Instr";
            this.dataGrid_Instr.Size = new System.Drawing.Size(586, 333);
            this.dataGrid_Instr.TabIndex = 0;
            this.dataGrid_Instr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Instr_CellContentClick);
            // 
            // button_auth
            // 
            this.button_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.button_auth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_auth.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_auth.ForeColor = System.Drawing.Color.White;
            this.button_auth.Location = new System.Drawing.Point(276, 452);
            this.button_auth.Name = "button_auth";
            this.button_auth.Size = new System.Drawing.Size(114, 34);
            this.button_auth.TabIndex = 15;
            this.button_auth.Text = "Добавить";
            this.button_auth.UseVisualStyleBackColor = false;
            this.button_auth.Click += new System.EventHandler(this.button_auth_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Name.Location = new System.Drawing.Point(53, 30);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Name.Size = new System.Drawing.Size(142, 20);
            this.textBox_Name.TabIndex = 16;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Quantity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Quantity.Location = new System.Drawing.Point(426, 80);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Quantity.Size = new System.Drawing.Size(142, 20);
            this.textBox_Quantity.TabIndex = 23;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.Color.Black;
            this.label_login.Location = new System.Drawing.Point(84, 7);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(78, 20);
            this.label_login.TabIndex = 24;
            this.label_login.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(233, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(353, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Тип инструмента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(509, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Степень износа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(450, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(274, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Дата приобретения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(154, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Поставщик";
            // 
            // comboBox_Provide
            // 
            this.comboBox_Provide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.comboBox_Provide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Provide.FormattingEnabled = true;
            this.comboBox_Provide.Location = new System.Drawing.Point(133, 80);
            this.comboBox_Provide.Name = "comboBox_Provide";
            this.comboBox_Provide.Size = new System.Drawing.Size(138, 21);
            this.comboBox_Provide.TabIndex = 32;
            // 
            // comboBox_TInstr
            // 
            this.comboBox_TInstr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.comboBox_TInstr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_TInstr.FormattingEnabled = true;
            this.comboBox_TInstr.Location = new System.Drawing.Point(349, 29);
            this.comboBox_TInstr.Name = "comboBox_TInstr";
            this.comboBox_TInstr.Size = new System.Drawing.Size(139, 21);
            this.comboBox_TInstr.TabIndex = 33;
            this.comboBox_TInstr.SelectedIndexChanged += new System.EventHandler(this.comboBox_TInstr_SelectedIndexChanged);
            // 
            // comboBox_DegrWer
            // 
            this.comboBox_DegrWer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.comboBox_DegrWer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_DegrWer.FormattingEnabled = true;
            this.comboBox_DegrWer.Location = new System.Drawing.Point(497, 29);
            this.comboBox_DegrWer.Name = "comboBox_DegrWer";
            this.comboBox_DegrWer.Size = new System.Drawing.Size(142, 21);
            this.comboBox_DegrWer.TabIndex = 34;
            // 
            // richTextB_Quantity
            // 
            this.richTextB_Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.richTextB_Quantity.Location = new System.Drawing.Point(201, 30);
            this.richTextB_Quantity.Name = "richTextB_Quantity";
            this.richTextB_Quantity.Size = new System.Drawing.Size(141, 20);
            this.richTextB_Quantity.TabIndex = 35;
            this.richTextB_Quantity.Text = "";
            // 
            // dateTime_Acquistions
            // 
            this.dateTime_Acquistions.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.dateTime_Acquistions.CalendarMonthBackground = System.Drawing.Color.Wheat;
            this.dateTime_Acquistions.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.dateTime_Acquistions.Location = new System.Drawing.Point(281, 80);
            this.dateTime_Acquistions.Name = "dateTime_Acquistions";
            this.dateTime_Acquistions.Size = new System.Drawing.Size(133, 20);
            this.dateTime_Acquistions.TabIndex = 36;
            this.dateTime_Acquistions.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 37;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tool_Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(709, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTime_Acquistions);
            this.Controls.Add(this.richTextB_Quantity);
            this.Controls.Add(this.comboBox_DegrWer);
            this.Controls.Add(this.comboBox_TInstr);
            this.Controls.Add(this.comboBox_Provide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_auth);
            this.Controls.Add(this.dataGrid_Instr);
            this.Name = "Tool_Accounting";
            this.Text = "Tool_Accounting";
            this.Load += new System.EventHandler(this.Tool_Accounting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Instr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Instr;
        private System.Windows.Forms.Button button_auth;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Provide;
        private System.Windows.Forms.ComboBox comboBox_TInstr;
        private System.Windows.Forms.ComboBox comboBox_DegrWer;
        private System.Windows.Forms.RichTextBox richTextB_Quantity;
        private System.Windows.Forms.DateTimePicker dateTime_Acquistions;
        private System.Windows.Forms.Button button1;
    }
}