using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //содание БД
            DB data_base = new DB();
            //создание таблицы БД
            DataTable data_table = new DataTable();
            //адаптер
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //sql команда
            /*
             SELECT - выборка
             '*' - обозначает выбор всех всех записей
             FROM `users` - из таблицы 'users'
             @LP и @PU - переменные-заглушки
             */

            //String sql_command = "SELECT * FROM `users` WHERE `login` = @LU AND `password` = @PU";
            //MySqlCommand command = new MySqlCommand(sql_command, data_base.GetConnection());

            //переменые-заглушки заполняются значениями из полей формы

            //command.Parameters.Add("@LU", MySqlDbType.VarChar).Value = user_login;
            //command.Parameters.Add("@PU", MySqlDbType.VarChar).Value = user_password;
            //выбрать команду для объекта-адаптера
            // adapter.SelectCommand = command;
            //заполняем объект-Table данными, полученными после выполнения команды
            //adapter.Fill(data_table);
            MessageBox.Show("Yeeah!");
        }
    }
}
