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
    public partial class Tool_Accounting : Form
    {
        int id_TInstr;
        int ID_DegrWer;

        string serv = "server=localhost;user=root;password=;database=Holiday_Cakes;SslMode=none";
        private BindingSource bindingSource = new BindingSource();

        public Tool_Accounting()
        {
            InitializeComponent();
            DGVLoad();
            Select_TInstr();
            Select_DegrWer();

        }

        void Select_TInstr()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(serv);
                conn.Open();
                string command = "SELECT `Name` FROM `Type_Instrument` WHERE 1";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    comboBox_TInstr.Items.Add(reader[0].ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Search_TInstr()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(serv);
                conn.Open();
                string command = "SELECT `ID_Type_Instrument` FROM `Type_Instrument` WHERE `Name` = '" + comboBox_TInstr.Text.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    id_TInstr = Convert.ToInt16(reader[0].ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Select_DegrWer()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(serv);
                conn.Open();
                string command = "SELECT `Name` FROM `Degree_of_Wear` WHERE 1";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    comboBox_DegrWer.Items.Add(reader[0].ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Search_DegrWer()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(serv);
                conn.Open();
                string command = "SELECT `Degree_of_Wear` FROM `ID_Degree_of_Wear` WHERE `Name` = '" + comboBox_DegrWer.Text.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                ID_DegrWer = Convert.ToInt16(reader[0].ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGrid_Instr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Name.Text = Convert.ToString(dataGrid_Instr[0, dataGrid_Instr.CurrentRow.Index].Value.ToString());
            richTextB_Quantity.Text = Convert.ToString(dataGrid_Instr[1, dataGrid_Instr.CurrentRow.Index].Value.ToString());
            comboBox_TInstr.Text = Convert.ToString(dataGrid_Instr[2, dataGrid_Instr.CurrentRow.Index].Value.ToString());
            comboBox_DegrWer.Text = Convert.ToString(dataGrid_Instr[3, dataGrid_Instr.CurrentRow.Index].Value.ToString());
            comboBox_Provide.Text = Convert.ToString(dataGrid_Instr[4, dataGrid_Instr.CurrentRow.Index].Value.ToString());
            dateTime_Acquistions.Text = Convert.ToString(dataGrid_Instr[5, dataGrid_Instr.CurrentRow.Index].Value.ToString());
            textBox_Quantity.Text = Convert.ToString(dataGrid_Instr[6, dataGrid_Instr.CurrentRow.Index].Value.ToString());
        }

        void DGVLoad()
        {
            MySqlConnection Conn = new MySqlConnection(serv);
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "SELECT `ID_Product`, `Name` FROM `Product` WHERE 1";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            bindingSource.DataSource = dataset.Tables[0];
            dataGrid_Instr.DataSource = bindingSource;
            //dataGrid_Instr.Columns[0].Visible = false;
            //dataGrid_Instr.Columns[1].HeaderText = "Название";
            //dataGrid_Instr.Columns[2].HeaderText = "Описание";
            //dataGrid_Instr.Columns[3].HeaderText = "Тип инструмента";
            //dataGrid_Instr.Columns[4].HeaderText = "Степень износа";
            //dataGrid_Instr.Columns[5].HeaderText = "Поставщик";
            //dataGrid_Instr.Columns[6].HeaderText = "Дата приобретения";
            //dataGrid_Instr.Columns[7].HeaderText = "Количество";
            Conn.Close();
            
        }
        private void Tool_Accounting_Load(object sender, EventArgs e)
        {
            dateTime_Acquistions.Format = DateTimePickerFormat.Custom;
            dateTime_Acquistions.CustomFormat = "yyyy-MM-dd";

           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            Search_TInstr();
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=Holiday_Cakes;SslMode=none");
            connection.Open();
            MySqlCommand myCommand = new MySqlCommand(String.Format("INSERT INTO `Tool_Accounting`(`Name`, `ID_Type_Instrument`, `ID_Degree_Of_Wear`, `ID_Provider`, `Date_Buy`, `Quantity`) VALUES ('" + textBox_Name.Text + "', '" + id_TInstr + "', '" + comboBox_DegrWer.Text + "', '" + comboBox_Provide.Text + "', '" + dateTime_Acquistions.Text + "', '" + textBox_Quantity.Text + "')"), connection);
            myCommand.ExecuteScalar();
            connection.Close();
            MessageBox.Show("Запись добавлена");
            {
                DGVLoad();
            }
        }

        private void comboBox_TInstr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form auth = new Form_auth();
            auth.ShowDialog();
            this.Close();
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

