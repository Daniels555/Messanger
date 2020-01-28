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
    public partial class Workshop : Form
    {
        public static Bitmap BM = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        private int _RowsDoc = 0;
        private int _OfsetX = 10;
        private int _OfsetY = 20;
        private Size _PicSize = new Size(100, 100);
        private string _DataStr = string.Empty;
        private Font _MainText = new Font("Arial", 12);
        public Workshop()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox3.Image, new Point());
            e.Graphics.DrawImage(pictureBox4.Image, new Point());
            e.Graphics.DrawImage(pictureBox5.Image, new Point());
            e.Graphics.DrawImage(pictureBox6.Image, new Point());
        }
        Point mousePos;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            mousePos = e.Location;

        }
        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox6.Location = new Point(pictureBox6.Left + dx, pictureBox6.Top + dy);
            }
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox5.Location = new Point(pictureBox5.Left + dx, pictureBox5.Top + dy);
            }
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox4.Location = new Point(pictureBox4.Left + dx, pictureBox4.Top + dy);
            }
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox3.Location = new Point(pictureBox3.Left + dx, pictureBox3.Top + dy);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Заготовительный цех")
            {
                pictureBoxData.Image = Image.FromFile("Q:/4й курс/461/_Общая/тренировки WSR/Демэкзамен1/Ресурсы - Сессия 2/Цеха/Заготовительный цех.png");
                label3.Text = comboBox1.Text;
            }
            if (comboBox1.SelectedItem.ToString() == "Механический цех")
            {
                pictureBoxData.Image = Image.FromFile("Q:/4й курс/461/_Общая/тренировки WSR/Демэкзамен1/Ресурсы - Сессия 2/Цеха/Механический цех.png");
                label3.Text = comboBox1.Text;
            }
            if (comboBox1.SelectedItem.ToString() == "Покрасочный цех")
            {
                pictureBoxData.Image = Image.FromFile("Q:/4й курс/461/_Общая/тренировки WSR/Демэкзамен1/Ресурсы - Сессия 2/Цеха/Покрасочный цех.png");
                label3.Text = comboBox1.Text;
            }
            if (comboBox1.SelectedItem.ToString() == "Сборочный цех")
            {
                pictureBoxData.Image = Image.FromFile("Q:/4й курс/461/_Общая/тренировки WSR/Демэкзамен1/Ресурсы - Сессия 2/Цеха/Сборочный цех.png");
                label3.Text = comboBox1.Text;
            }
            if (comboBox1.SelectedItem.ToString() == "Упаковочный цех")
            {
                pictureBoxData.Image = Image.FromFile("Q:/4й курс/461/_Общая/тренировки WSR/Демэкзамен1/Ресурсы - Сессия 2/Цеха/Упаковочный цех.png");
                label3.Text = comboBox1.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics GH = Graphics.FromImage(BM as Image);
            GH.CopyFromScreen(415, 285, 285, 395, BM.Size);

            Form_auth SI = new Form_auth();

            SI.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Workshop_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox1.Location = new Point(pictureBox1.Left + dx, pictureBox1.Top + dy);
            }
        }
        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox7.Location = new Point(pictureBox7.Left + dx, pictureBox7.Top + dy);
            }
        }
        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox8.Location = new Point(pictureBox8.Left + dx, pictureBox8.Top + dy);
            }
        }
        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox9.Location = new Point(pictureBox9.Left + dx, pictureBox9.Top + dy);
            }
        }
        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox10.Location = new Point(pictureBox10.Left + dx, pictureBox10.Top + dy);
            }
        }
        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox15.Location = new Point(pictureBox15.Left + dx, pictureBox15.Top + dy);
            }
        }
        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox16.Location = new Point(pictureBox16.Left + dx, pictureBox16.Top + dy);
            }
        }
        private void pictureBox17_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox17.Location = new Point(pictureBox17.Left + dx, pictureBox17.Top + dy);
            }
        }
        private void pictureBox25_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox25.Location = new Point(pictureBox25.Left + dx, pictureBox25.Top + dy);
            }
        }
        private void pictureBox26_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox26.Location = new Point(pictureBox26.Left + dx, pictureBox26.Top + dy);
            }
        }
        private void pictureBox24_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox24.Location = new Point(pictureBox24.Left + dx, pictureBox24.Top + dy);
            }
        }
        private void pictureBox18_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox18.Location = new Point(pictureBox18.Left + dx, pictureBox18.Top + dy);
            }
        }
        private void pictureBox19_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox19.Location = new Point(pictureBox19.Left + dx, pictureBox19.Top + dy);
            }
        }
        private void pictureBox20_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox20.Location = new Point(pictureBox20.Left + dx, pictureBox20.Top + dy);
            }
        }
        private void pictureBox21_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox21.Location = new Point(pictureBox21.Left + dx, pictureBox21.Top + dy);
            }
        }
        private void pictureBox22_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox22.Location = new Point(pictureBox22.Left + dx, pictureBox22.Top + dy);
            }
        }
        private void pictureBox23_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox23.Location = new Point(pictureBox23.Left + dx, pictureBox23.Top + dy);
            }
        }
    }
}
