using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;


namespace rrrrrrrr
{
    class DataBase
    {

        //подключение к базе данных
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=коллекция музыки");
    

        // соединение с бд
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }


        // закрывает соеденение с бд
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }


        // возвращает соединение
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
