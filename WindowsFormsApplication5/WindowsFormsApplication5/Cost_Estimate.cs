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
    public partial class Cost_Estimate : Form
    {
        string serv = "server=localhost;user=root;password=;database=Holiday_Cakes;SslMode=none";
        private BindingSource bindingSource = new BindingSource();
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();
        private BindingSource bindingSource3 = new BindingSource();
        private BindingSource bindingSource4 = new BindingSource();
        public Cost_Estimate()
        {
            InitializeComponent();
            DGVLoad();
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
            dataGrid_Product.DataSource = bindingSource;
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

        void DGVLoadIngridients()
        {
            MySqlConnection Conn = new MySqlConnection(serv);
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "SELECT `ID_Spec_Ingridient`, `Qantity` FROM `Spec_Ingridient` WHERE `ID_Product` = '" + textBox_Name.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            bindingSource1.DataSource = dataset.Tables[0];
            Ingridients.DataSource = bindingSource1;
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

        void DGVLoadDecor()
        {
            MySqlConnection Conn = new MySqlConnection(serv);
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "SELECT `Name`, `Amount` FROM `Spec_CaDecor` WHERE `ID_Product` = '"+ textBox_Name.Text +"'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            bindingSource2.DataSource = dataset.Tables[0];
            decor.DataSource = bindingSource2;
            //decor.Columns[0].Visible = false;
           // Semifinished.Columns[1].HeaderText = "Название";
           // Semifinished.Columns[2].HeaderText = "Количество";
            //dataGrid_Instr.Columns[3].HeaderText = "Тип инструмента";
            //dataGrid_Instr.Columns[4].HeaderText = "Степень износа";
            //dataGrid_Instr.Columns[5].HeaderText = "Поставщик";
            //dataGrid_Instr.Columns[6].HeaderText = "Дата приобретения";
            //dataGrid_Instr.Columns[7].HeaderText = "Количество";
            Conn.Close();
        }

        void DGVLoadOperacii()
        {
            MySqlConnection Conn = new MySqlConnection(serv);
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "SELECT `ID_Product`, `Operation`, `Serial_Number`, `Type_Equipment`, `Time_Oper` FROM `Specification_Oper` WHERE `ID_Product` = '"+ textBox_Name.Text +"'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            bindingSource3.DataSource = dataset.Tables[0];
            operacii.DataSource = bindingSource3;
            //Semifinished.Columns[0].Visible = false;
            //Semifinished.Columns[0].HeaderText = "Название";
            //Semifinished.Columns[1].HeaderText = "Описание";
            //Semifinished.Columns[2].HeaderText = "Номер";
           // Semifinished.Columns[3].HeaderText = "Тип";
            //Semifinished.Columns[4].HeaderText = "Время";
            //dataGrid_Instr.Columns[6].HeaderText = "Дата приобретения";
            //dataGrid_Instr.Columns[7].HeaderText = "Количество";
            Conn.Close();
        }

        void DGVLoadSemifinished()
        {
            MySqlConnection Conn = new MySqlConnection(serv);
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "SELECT `Name`, `Amount` FROM `Semifinished` WHERE `ID_Product` = '" + textBox_Name.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            bindingSource4.DataSource = dataset.Tables[0];
            Semifinished.DataSource = bindingSource4;
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

        private void dataGrid_Instr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ID.Text = Convert.ToString(dataGrid_Product[0, dataGrid_Product.CurrentRow.Index].Value.ToString());
            textBox_Name.Text = Convert.ToString(dataGrid_Product[1, dataGrid_Product.CurrentRow.Index].Value.ToString());
            DGVLoadDecor();
            DGVLoadSemifinished();
            DGVLoadOperacii();
            DGVLoadIngridients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_director cost = new Form_director();
            cost.ShowDialog();
            this.Close();
        }

        private void dataGrid_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
