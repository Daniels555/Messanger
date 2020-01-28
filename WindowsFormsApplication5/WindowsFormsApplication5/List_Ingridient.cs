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
    public partial class List_Ingridient : Form
    {
        int id_Unit;
        int id_Provider;
        string serv = "server=localhost;user=root;password=;database=Holiday_Cakes;SslMode=none";
        private BindingSource bindingSource = new BindingSource();
        public List_Ingridient()
        {
            InitializeComponent();
            DGVLoad();
            Select_Unit();
        }

        void Select_Unit()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(serv);
                conn.Open();
                string command = "SELECT `Units` FROM `Ingridients` WHERE 1";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                comboBox_Unit.Items.Add(reader[0].ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Search_Unit()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(serv);
                conn.Open();
                string command = "SELECT `Units` FROM `Ingridients` WHERE `Name` = '" + comboBox_Unit.Text.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                id_Unit = Convert.ToInt16(reader[0].ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void List_Ingridient_Load(object sender, EventArgs e)
        {

        }

        private void dataGrid_Instr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Art.Text = Convert.ToString(dataGrid_Ingr[0, dataGrid_Ingr.CurrentRow.Index].Value.ToString());
            textBox_Name.Text = Convert.ToString(dataGrid_Ingr[1, dataGrid_Ingr.CurrentRow.Index].Value.ToString());
            textBox_Quant.Text = Convert.ToString(dataGrid_Ingr[2, dataGrid_Ingr.CurrentRow.Index].Value.ToString());
            comboBox_Unit.Text = Convert.ToString(dataGrid_Ingr[3, dataGrid_Ingr.CurrentRow.Index].Value.ToString());
            textBox_Type.Text = Convert.ToString(dataGrid_Ingr[4, dataGrid_Ingr.CurrentRow.Index].Value.ToString());
            textBox_Gost.Text = Convert.ToString(dataGrid_Ingr[6, dataGrid_Ingr.CurrentRow.Index].Value.ToString());
        }

        void DGVLoad()
        {
            MySqlConnection Conn = new MySqlConnection(serv);
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "SELECT `Articul`,`Name`,`Units`,`Quantity`,`Type`,`Price`,`Gost`, `Packing`, `Characters` FROM `Ingridients` WHERE 1";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            bindingSource.DataSource = dataset.Tables[0];
            dataGrid_Ingr.DataSource = bindingSource;
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

        private void button_auth_Click(object sender, EventArgs e)
        {
            Search_Unit();
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=Holiday_Cakes;SslMode=none");
            connection.Open();
            MySqlCommand myCommand = new MySqlCommand(String.Format("INSERT INTO `Ingridients`(`Articul`,`Name`,`Units`,`Quantity`,`Type`,`Price`,`Gost`, `Packing`, `Characters`) VALUES ('" + textBox_Art.Text + "', '" + textBox_Name + "', '" + comboBox_Unit.Text + "', '" + textBox_Quant.Text + "',  '" + textBox_Type.Text + "', '" + textBox_Price.Text + "', '" + textBox_Gost.Text + "', '" + textBox_Pack.Text + "', '" + textBox_Charact.Text + "')"), connection);
            myCommand.ExecuteScalar();
            connection.Close();
            MessageBox.Show("Запись добавлена");
            {
                DGVLoad();
            }
        }
    }
}
