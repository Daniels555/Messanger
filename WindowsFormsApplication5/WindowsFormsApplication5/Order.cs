using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Order : Form
    {
        int ID_StOrd;
        int ID_Client;
        int ID_Manag;

        string serv = "server=localhost;user=root;password=;database=Holiday_Cakes;SslMode=none";
        private BindingSource bindingSource = new BindingSource();
        public Order()
        {
            InitializeComponent();
           // Select_StOrd();
            Select_Client();
            Select_Manag();
        }

        //void Select_StOrd()
        //{
        //    try
        //    {
        //        MySqlConnection conn = new MySqlConnection(serv);
        //        conn.Open();
        //        string command = "SELECT `Name` FROM `Status_Order` WHERE 1";
        //        MySqlCommand cmd = new MySqlCommand(command, conn);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        comboBox_StOrd.Items.Add(reader[0].ToString());
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //void Search_StOrd()
        //{
        //    try
        //    {
        //        MySqlConnection conn = new MySqlConnection(serv);
        //        conn.Open();
        //        string command = "SELECT `ID_Status_Order` FROM `Status_Order` WHERE `Name` = '" + comboBox_StOrd.Text.ToString() + "'";
        //        MySqlCommand cmd = new MySqlCommand(command, conn);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        ID_StOrd = Convert.ToInt16(reader[0].ToString());
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        void Select_Client()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(serv);
                conn.Open();
                string command = "SELECT `Full_Name` FROM `User` WHERE `ID_Role` = '1'";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    comboBox_Client.Items.Add(reader[0].ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Search_Client()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(serv);
                conn.Open();
                string command = "SELECT `ID_User` FROM `User` WHERE `Full_Name` = '" + comboBox_StOrd.Text.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    ID_Client = Convert.ToInt16(reader[0].ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Select_Manag()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(serv);
                conn.Open();
                string command = "SELECT `Full_Name` FROM `User` WHERE `ID_Role` = '2'";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    comboBox_Manag.Items.Add(reader[0].ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Search_Manag()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(serv);
                conn.Open();
                string command = "SELECT `ID_User` FROM `User` WHERE `Full_Name` = '" + comboBox_StOrd.Text.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    ID_Manag = Convert.ToInt16(reader[0].ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            dateTime_Acquistions.Format = DateTimePickerFormat.Custom;
            dateTime_Acquistions.CustomFormat = "yyyy-MM-dd";
        }

        private void dataGrid_Instr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Search_StOrd();
            Search_Client();
            Search_Manag();
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=Holiday_Cakes;SslMode=none");
            connection.Open();
            MySqlCommand myCommand = new MySqlCommand(String.Format("INSERT INTO `Order` VALUES (NULL, '" + dateTime_Order.Value + "', '" + richTextB_Name.Text + "', '" + ID_StOrd + "', '" + ID_Client + "', '" + textBox_Cost_Order.Text + "', '" + dateTime_Acquistions.Value + "', '" + ID_Manag + "')"), connection);
            myCommand.ExecuteScalar();
            connection.Close();
            MessageBox.Show("Запись добавлена");
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Orders = new Orders();
            Orders.ShowDialog();
            this.Close();
        }

        private void comboBox_StOrd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }
