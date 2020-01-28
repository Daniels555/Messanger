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
    public partial class Orders : Form
    {
        string serv = "server=localhost;user=root;password=;database=Holiday_Cakes;SslMode=none";
        private BindingSource bindingSource = new BindingSource();
        public Orders()
        {
            InitializeComponent();
            DGVLoad();
        }

        private void dataGrid_Instr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        void DGVLoad()
        {
            MySqlConnection Conn = new MySqlConnection(serv);
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "SELECT `ID_Order`, `Date`, `Name`, `ID_Status_Order`, `ID_Client`, `Cost_Order`, `Date_Performance`, `ID_Responsible_Manag` FROM `Order` WHERE 1";
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Order = new Order();
            Order.ShowDialog();
            this.Close();
        }

    }
}
