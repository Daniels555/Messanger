namespace WindowsFormsApplication5
{
    partial class Order
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
            this.button4 = new System.Windows.Forms.Button();
            this.dateTime_Acquistions = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Client = new System.Windows.Forms.ComboBox();
            this.comboBox_StOrd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.dateTime_Order = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Cost_Order = new System.Windows.Forms.TextBox();
            this.comboBox_Manag = new System.Windows.Forms.ComboBox();
            this.richTextB_Name = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(262, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 33);
            this.button4.TabIndex = 42;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTime_Acquistions
            // 
            this.dateTime_Acquistions.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.dateTime_Acquistions.CalendarMonthBackground = System.Drawing.Color.Wheat;
            this.dateTime_Acquistions.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.dateTime_Acquistions.Location = new System.Drawing.Point(279, 82);
            this.dateTime_Acquistions.Name = "dateTime_Acquistions";
            this.dateTime_Acquistions.Size = new System.Drawing.Size(159, 20);
            this.dateTime_Acquistions.TabIndex = 57;
            // 
            // comboBox_Client
            // 
            this.comboBox_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.comboBox_Client.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Client.FormattingEnabled = true;
            this.comboBox_Client.Location = new System.Drawing.Point(536, 31);
            this.comboBox_Client.Name = "comboBox_Client";
            this.comboBox_Client.Size = new System.Drawing.Size(142, 21);
            this.comboBox_Client.TabIndex = 55;
            // 
            // comboBox_StOrd
            // 
            this.comboBox_StOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.comboBox_StOrd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_StOrd.FormattingEnabled = true;
            this.comboBox_StOrd.Location = new System.Drawing.Point(388, 31);
            this.comboBox_StOrd.Name = "comboBox_StOrd";
            this.comboBox_StOrd.Size = new System.Drawing.Size(139, 21);
            this.comboBox_StOrd.TabIndex = 54;
            this.comboBox_StOrd.SelectedIndexChanged += new System.EventHandler(this.comboBox_StOrd_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(456, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "ID Менеджера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(291, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Дата выполнения";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(157, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Цена заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(559, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "ID Клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(406, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Статус заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Наименование";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.Color.Black;
            this.label_login.Location = new System.Drawing.Point(44, 9);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(28, 20);
            this.label_login.TabIndex = 46;
            this.label_login.Text = "ID";
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_ID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_ID.Location = new System.Drawing.Point(38, 32);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_ID.Size = new System.Drawing.Size(39, 20);
            this.textBox_ID.TabIndex = 44;
            // 
            // dateTime_Order
            // 
            this.dateTime_Order.Location = new System.Drawing.Point(83, 33);
            this.dateTime_Order.Name = "dateTime_Order";
            this.dateTime_Order.Size = new System.Drawing.Size(151, 20);
            this.dateTime_Order.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(111, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Дата заказа";
            // 
            // textBox_Cost_Order
            // 
            this.textBox_Cost_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Cost_Order.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Cost_Order.Location = new System.Drawing.Point(132, 83);
            this.textBox_Cost_Order.Name = "textBox_Cost_Order";
            this.textBox_Cost_Order.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Cost_Order.Size = new System.Drawing.Size(138, 20);
            this.textBox_Cost_Order.TabIndex = 60;
            // 
            // comboBox_Manag
            // 
            this.comboBox_Manag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.comboBox_Manag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Manag.FormattingEnabled = true;
            this.comboBox_Manag.Location = new System.Drawing.Point(444, 81);
            this.comboBox_Manag.Name = "comboBox_Manag";
            this.comboBox_Manag.Size = new System.Drawing.Size(138, 21);
            this.comboBox_Manag.TabIndex = 53;
            // 
            // richTextB_Name
            // 
            this.richTextB_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.richTextB_Name.Location = new System.Drawing.Point(240, 32);
            this.richTextB_Name.Name = "richTextB_Name";
            this.richTextB_Name.Size = new System.Drawing.Size(141, 20);
            this.richTextB_Name.TabIndex = 56;
            this.richTextB_Name.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 61;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(692, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Cost_Order);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTime_Order);
            this.Controls.Add(this.dateTime_Acquistions);
            this.Controls.Add(this.richTextB_Name);
            this.Controls.Add(this.comboBox_Client);
            this.Controls.Add(this.comboBox_StOrd);
            this.Controls.Add(this.comboBox_Manag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.button4);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTime_Acquistions;
        private System.Windows.Forms.ComboBox comboBox_Client;
        private System.Windows.Forms.ComboBox comboBox_StOrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.DateTimePicker dateTime_Order;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Cost_Order;
        private System.Windows.Forms.ComboBox comboBox_Manag;
        private System.Windows.Forms.RichTextBox richTextB_Name;
        private System.Windows.Forms.Button button1;
    }
}