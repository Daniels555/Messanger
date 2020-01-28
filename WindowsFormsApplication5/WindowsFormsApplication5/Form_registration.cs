using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication5
{
    public partial class Form_registration : Form
    {
        public Form_registration()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Form_registration_Load(object sender, EventArgs e)
        {

            
        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text != "" || textBox_password.Text != "")
            {
                const string message = "Вы уверены что хотите добавить данные?";
                const string caption = "Добавление";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {

                }
                else
                {
                    MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=Holiday_Cakes;SslMode=none");
                    connection.Open();
                    MySqlCommand myCommand = new MySqlCommand(String.Format("INSERT INTO User (`Log`, `Pass`, `ID_Role`, `Full_Name`) VALUES ('" + textBox_login.Text + "', '" + textBox_password.Text + "', '1', '" + textBox_FullName.Text + "')"), connection);
                    myCommand.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Запись добавлена");
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Данные должны содержать номер телефона или адрес электронной почты");
            }
        }

        private void comboBox_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }
