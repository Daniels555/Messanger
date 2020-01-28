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
    public partial class Form_auth : Form
    {
        string serv = "server=localhost;user=root;password=;database=Holiday_Cakes;SslMode=none";
        private BindingSource bindingSource = new BindingSource();
        string role;
        public Form_auth()
        {
            InitializeComponent();
        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Conn = new MySqlConnection(serv);
                Conn.Open();
                string command = "SELECT `ID_Role` FROM `User` WHERE `Log` = '" + textBox_login.Text + "' AND `Pass` = '" + textBox_password.Text + "'";
                MySqlCommand cmd = new MySqlCommand(command, Conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    role = reader[0].ToString();
                }

                if (role == "1")
                {
                    this.Hide();
                    Form customer = new Form_customer();
                    customer.ShowDialog();
                    this.Close();
                }
                if (role == "2")
                {
                    this.Hide();
                    Form accman = new Form_accman();
                    accman.ShowDialog();
                    this.Close();
                }
                if (role == "3")
                {
                    this.Hide();
                    Form purman = new Form_purman();
                    purman.ShowDialog();
                    this.Close();
                }
                if (role == "4")
                {
                    this.Hide();
                    Form master = new Form_master();
                    master.ShowDialog();
                    this.Close();
                }
                if (role == "5")
                {
                    this.Hide();
                    Form director = new Form_director();
                    director.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form registration = new Form_registration();
            registration.ShowDialog();
            //this.Close();
        }

        private void Form_auth_Load(object sender, EventArgs e)
        {

        }

    }
}
