using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace rrrrrrrr
{
    public partial class PowerMusicAward : Form
    {
        public PowerMusicAward()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            Search.TextChanged += textBox1_TextChanged;
        }

        string search_name = "";
            
        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `список песен` WHERE 1=1", DB.getConnection());
            command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = search_name;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.label2.BackColor = System.Drawing.Color.Cyan;
            dataGridView1.DataSource = table;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search_name = Search.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (true) MessageBox.Show(
                 search_name,
                 "ВНИМАНИЕ!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_name = Search.Text;

            DataBase DB = new DataBase();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `список песен` WHERE `Песня` = @sn", DB.getConnection());
            command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = search_name;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                ;
            else MessageBox.Show(
               "Ни одна подходящая запись не найдена!",
               "ВНИМАНИЕ!",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1);

            dataGridView1.DataSource = table;
        }
       
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Singer_Click(object sender, EventArgs e)
        {
            search_name = Search.Text;

            DataBase DB = new DataBase();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `список песен` WHERE `Исполнитель/Группа` = @sn", DB.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = search_name;
      
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            ;
            else MessageBox.Show(
               "Ни одна подходящая запись не найдена!",
               "ВНИМАНИЕ!",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1);

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Приложение для поиска песен из базы данных. Введите имя исполнителя или название песни в поисковую строку и выбирете, по какому критерию искать.",
               "Справка",
               MessageBoxButtons.OK,
               MessageBoxIcon.None,
               MessageBoxDefaultButton.Button1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
                MessageBox.Show(
               "Разработчики приложения: Макарова А.",
               "О разработчиках",
               MessageBoxButtons.OK,
               MessageBoxIcon.None,
               MessageBoxDefaultButton.Button2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}



