namespace WindowsFormsApplication5
{
    partial class List_Decoration
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Quant = new System.Windows.Forms.TextBox();
            this.textBox_purchprice = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.comboBox_Unit = new System.Windows.Forms.ComboBox();
            this.comboBox_Provider = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Delivery = new System.Windows.Forms.TextBox();
            this.textBox_Art = new System.Windows.Forms.TextBox();
            this.button_auth = new System.Windows.Forms.Button();
            this.dataGrid_Ingr = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Ingr)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Name.Location = new System.Drawing.Point(216, 36);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Name.Size = new System.Drawing.Size(142, 20);
            this.textBox_Name.TabIndex = 78;
            // 
            // textBox_Quant
            // 
            this.textBox_Quant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Quant.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Quant.Location = new System.Drawing.Point(364, 36);
            this.textBox_Quant.Name = "textBox_Quant";
            this.textBox_Quant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Quant.Size = new System.Drawing.Size(142, 20);
            this.textBox_Quant.TabIndex = 76;
            // 
            // textBox_purchprice
            // 
            this.textBox_purchprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_purchprice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_purchprice.Location = new System.Drawing.Point(128, 87);
            this.textBox_purchprice.Name = "textBox_purchprice";
            this.textBox_purchprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_purchprice.Size = new System.Drawing.Size(142, 20);
            this.textBox_purchprice.TabIndex = 75;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.Color.Black;
            this.label_login.Location = new System.Drawing.Point(99, 14);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(70, 20);
            this.label_login.TabIndex = 74;
            this.label_login.Text = "Артикул";
            // 
            // comboBox_Unit
            // 
            this.comboBox_Unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.comboBox_Unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Unit.FormattingEnabled = true;
            this.comboBox_Unit.Location = new System.Drawing.Point(512, 36);
            this.comboBox_Unit.Name = "comboBox_Unit";
            this.comboBox_Unit.Size = new System.Drawing.Size(142, 21);
            this.comboBox_Unit.TabIndex = 73;
            this.comboBox_Unit.SelectedIndexChanged += new System.EventHandler(this.comboBox_Unit_SelectedIndexChanged);
            // 
            // comboBox_Provider
            // 
            this.comboBox_Provider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.comboBox_Provider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Provider.FormattingEnabled = true;
            this.comboBox_Provider.Location = new System.Drawing.Point(287, 87);
            this.comboBox_Provider.Name = "comboBox_Provider";
            this.comboBox_Provider.Size = new System.Drawing.Size(138, 21);
            this.comboBox_Provider.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(456, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Срок доставки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(307, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Поставщик";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(152, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 69;
            this.label7.Text = "Закуп. цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(529, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Ед. измерения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(388, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(228, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Наименование";
            // 
            // textBox_Delivery
            // 
            this.textBox_Delivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Delivery.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Delivery.Location = new System.Drawing.Point(441, 87);
            this.textBox_Delivery.Name = "textBox_Delivery";
            this.textBox_Delivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Delivery.Size = new System.Drawing.Size(142, 20);
            this.textBox_Delivery.TabIndex = 65;
            // 
            // textBox_Art
            // 
            this.textBox_Art.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Art.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Art.Location = new System.Drawing.Point(67, 36);
            this.textBox_Art.Name = "textBox_Art";
            this.textBox_Art.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Art.Size = new System.Drawing.Size(142, 20);
            this.textBox_Art.TabIndex = 64;
            // 
            // button_auth
            // 
            this.button_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.button_auth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_auth.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_auth.ForeColor = System.Drawing.Color.White;
            this.button_auth.Location = new System.Drawing.Point(287, 460);
            this.button_auth.Name = "button_auth";
            this.button_auth.Size = new System.Drawing.Size(114, 34);
            this.button_auth.TabIndex = 63;
            this.button_auth.Text = "Добавить";
            this.button_auth.UseVisualStyleBackColor = false;
            // 
            // dataGrid_Ingr
            // 
            this.dataGrid_Ingr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGrid_Ingr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Ingr.Location = new System.Drawing.Point(68, 120);
            this.dataGrid_Ingr.Name = "dataGrid_Ingr";
            this.dataGrid_Ingr.Size = new System.Drawing.Size(586, 333);
            this.dataGrid_Ingr.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 61;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.Location = new System.Drawing.Point(68, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(32, 20);
            this.textBox3.TabIndex = 77;
            // 
            // List_Decoration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(723, 505);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Quant);
            this.Controls.Add(this.textBox_purchprice);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.comboBox_Unit);
            this.Controls.Add(this.comboBox_Provider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Delivery);
            this.Controls.Add(this.textBox_Art);
            this.Controls.Add(this.button_auth);
            this.Controls.Add(this.dataGrid_Ingr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Name = "List_Decoration";
            this.Text = "List_Decoration";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Ingr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Quant;
        private System.Windows.Forms.TextBox textBox_purchprice;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.ComboBox comboBox_Unit;
        private System.Windows.Forms.ComboBox comboBox_Provider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Delivery;
        private System.Windows.Forms.TextBox textBox_Art;
        private System.Windows.Forms.Button button_auth;
        private System.Windows.Forms.DataGridView dataGrid_Ingr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
    }
}