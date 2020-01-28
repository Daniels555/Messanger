namespace WindowsFormsApplication5
{
    partial class List_Ingridient
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_Unit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Gost = new System.Windows.Forms.TextBox();
            this.textBox_Art = new System.Windows.Forms.TextBox();
            this.button_auth = new System.Windows.Forms.Button();
            this.dataGrid_Ingr = new System.Windows.Forms.DataGridView();
            this.label_login = new System.Windows.Forms.Label();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.textBox_Quant = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Pack = new System.Windows.Forms.TextBox();
            this.textBox_Charact = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Ingr)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 40;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox_Unit
            // 
            this.comboBox_Unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.comboBox_Unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Unit.FormattingEnabled = true;
            this.comboBox_Unit.Location = new System.Drawing.Point(389, 35);
            this.comboBox_Unit.Name = "comboBox_Unit";
            this.comboBox_Unit.Size = new System.Drawing.Size(142, 21);
            this.comboBox_Unit.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(374, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "ГОСТ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(213, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(58, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(406, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Ед. измерения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(566, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(251, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Наименование";
            // 
            // textBox_Gost
            // 
            this.textBox_Gost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Gost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Gost.Location = new System.Drawing.Point(327, 92);
            this.textBox_Gost.Name = "textBox_Gost";
            this.textBox_Gost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Gost.Size = new System.Drawing.Size(142, 20);
            this.textBox_Gost.TabIndex = 44;
            // 
            // textBox_Art
            // 
            this.textBox_Art.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Art.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Art.Location = new System.Drawing.Point(90, 36);
            this.textBox_Art.Name = "textBox_Art";
            this.textBox_Art.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Art.Size = new System.Drawing.Size(142, 20);
            this.textBox_Art.TabIndex = 43;
            // 
            // button_auth
            // 
            this.button_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.button_auth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_auth.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_auth.ForeColor = System.Drawing.Color.White;
            this.button_auth.Location = new System.Drawing.Point(365, 465);
            this.button_auth.Name = "button_auth";
            this.button_auth.Size = new System.Drawing.Size(114, 34);
            this.button_auth.TabIndex = 42;
            this.button_auth.Text = "Добавить";
            this.button_auth.UseVisualStyleBackColor = false;
            this.button_auth.Click += new System.EventHandler(this.button_auth_Click);
            // 
            // dataGrid_Ingr
            // 
            this.dataGrid_Ingr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGrid_Ingr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Ingr.Location = new System.Drawing.Point(47, 126);
            this.dataGrid_Ingr.Name = "dataGrid_Ingr";
            this.dataGrid_Ingr.Size = new System.Drawing.Size(704, 333);
            this.dataGrid_Ingr.TabIndex = 41;
            this.dataGrid_Ingr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Instr_CellContentClick);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.Color.Black;
            this.label_login.Location = new System.Drawing.Point(122, 14);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(70, 20);
            this.label_login.TabIndex = 56;
            this.label_login.Text = "Артикул";
            // 
            // textBox_Type
            // 
            this.textBox_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Type.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Type.Location = new System.Drawing.Point(14, 92);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Type.Size = new System.Drawing.Size(142, 20);
            this.textBox_Type.TabIndex = 57;
            // 
            // textBox_Quant
            // 
            this.textBox_Quant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Quant.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Quant.Location = new System.Drawing.Point(542, 36);
            this.textBox_Quant.Name = "textBox_Quant";
            this.textBox_Quant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Quant.Size = new System.Drawing.Size(142, 20);
            this.textBox_Quant.TabIndex = 58;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.Location = new System.Drawing.Point(91, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(32, 20);
            this.textBox3.TabIndex = 59;
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Name.Location = new System.Drawing.Point(239, 36);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Name.Size = new System.Drawing.Size(142, 20);
            this.textBox_Name.TabIndex = 60;
            // 
            // textBox_Pack
            // 
            this.textBox_Pack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Pack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Pack.Location = new System.Drawing.Point(485, 92);
            this.textBox_Pack.Name = "textBox_Pack";
            this.textBox_Pack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Pack.Size = new System.Drawing.Size(142, 20);
            this.textBox_Pack.TabIndex = 61;
            // 
            // textBox_Charact
            // 
            this.textBox_Charact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Charact.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Charact.Location = new System.Drawing.Point(643, 92);
            this.textBox_Charact.Name = "textBox_Charact";
            this.textBox_Charact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Charact.Size = new System.Drawing.Size(142, 20);
            this.textBox_Charact.TabIndex = 62;
            // 
            // textBox_Price
            // 
            this.textBox_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.textBox_Price.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Price.Location = new System.Drawing.Point(170, 92);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Price.Size = new System.Drawing.Size(142, 20);
            this.textBox_Price.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(522, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Фасовка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(651, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Характеристики";
            // 
            // List_Ingridient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(811, 511);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Charact);
            this.Controls.Add(this.textBox_Pack);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Quant);
            this.Controls.Add(this.textBox_Type);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.comboBox_Unit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Gost);
            this.Controls.Add(this.textBox_Art);
            this.Controls.Add(this.button_auth);
            this.Controls.Add(this.dataGrid_Ingr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Name = "List_Ingridient";
            this.Text = "List_Ingridient";
            this.Load += new System.EventHandler(this.List_Ingridient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Ingr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_Unit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Gost;
        private System.Windows.Forms.TextBox textBox_Art;
        private System.Windows.Forms.Button button_auth;
        private System.Windows.Forms.DataGridView dataGrid_Ingr;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_Quant;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Pack;
        private System.Windows.Forms.TextBox textBox_Charact;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}