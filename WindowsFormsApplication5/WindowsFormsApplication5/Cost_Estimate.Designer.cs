namespace WindowsFormsApplication5
{
    partial class Cost_Estimate
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
            this.dataGrid_Product = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Ingridients = new System.Windows.Forms.DataGridView();
            this.Semifinished = new System.Windows.Forms.DataGridView();
            this.decor = new System.Windows.Forms.DataGridView();
            this.operacii = new System.Windows.Forms.DataGridView();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ingridients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Semifinished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacii)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Product
            // 
            this.dataGrid_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Product.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGrid_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Product.Location = new System.Drawing.Point(12, 71);
            this.dataGrid_Product.Name = "dataGrid_Product";
            this.dataGrid_Product.Size = new System.Drawing.Size(272, 384);
            this.dataGrid_Product.TabIndex = 1;
            this.dataGrid_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Product_CellClick);
            this.dataGrid_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Instr_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 38;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ingridients
            // 
            this.Ingridients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Ingridients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ingridients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ingridients.Location = new System.Drawing.Point(314, 71);
            this.Ingridients.Name = "Ingridients";
            this.Ingridients.Size = new System.Drawing.Size(340, 172);
            this.Ingridients.TabIndex = 39;
            // 
            // Semifinished
            // 
            this.Semifinished.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Semifinished.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Semifinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Semifinished.Location = new System.Drawing.Point(314, 289);
            this.Semifinished.Name = "Semifinished";
            this.Semifinished.Size = new System.Drawing.Size(340, 166);
            this.Semifinished.TabIndex = 40;
            // 
            // decor
            // 
            this.decor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.decor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.decor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.decor.Location = new System.Drawing.Point(676, 71);
            this.decor.Name = "decor";
            this.decor.Size = new System.Drawing.Size(340, 172);
            this.decor.TabIndex = 41;
            // 
            // operacii
            // 
            this.operacii.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.operacii.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.operacii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operacii.Location = new System.Drawing.Point(676, 289);
            this.operacii.Name = "operacii";
            this.operacii.Size = new System.Drawing.Size(340, 166);
            this.operacii.TabIndex = 42;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(26, 31);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(29, 20);
            this.textBox_ID.TabIndex = 43;
            this.textBox_ID.Visible = false;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(71, 31);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 44;
            this.textBox_Name.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 45;
            this.textBox1.Visible = false;
            // 
            // Cost_Estimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1027, 500);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.operacii);
            this.Controls.Add(this.decor);
            this.Controls.Add(this.Semifinished);
            this.Controls.Add(this.Ingridients);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid_Product);
            this.Name = "Cost_Estimate";
            this.Text = "Cost_Estimate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ingridients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Semifinished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Product;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Ingridients;
        private System.Windows.Forms.DataGridView Semifinished;
        private System.Windows.Forms.DataGridView decor;
        private System.Windows.Forms.DataGridView operacii;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox1;
    }
}