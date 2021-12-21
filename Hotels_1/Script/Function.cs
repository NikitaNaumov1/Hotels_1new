using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels_1.Script
{
    class Function
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        public static MySqlConnection GetDBConnection()
        {
            string host = "c9113991.beget.tech";
            int port = 3306;
            string database = "c9113991_hotel";
            string username = "c9113991_hotel";
            string password = "Naum228";

            return GetDBConnection(host, port, database, username, password);
        }


        MySqlConnection conn = GetDBConnection();

        public bool LoginUser(string login, string password)
        {
            bool flag = false;

            string sql = String.Format("SELECT * FROM clients WHERE login = @login AND pass = @pass");
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();

            if (sqldr.HasRows)
                flag = true;

            conn.Close();

            return flag;
        }

      

        public bool RegUser(string id, string login, string password, string name, string phone)
        {
            bool flag = false;


            string sql = String.Format("INSERT INTO clients(id, login,pass,name,phone) VALUES (@id, @login,@pass,@name,@phone)");

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            conn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
                conn.Close();
            }
            return flag;

        }

        
       
        public bool Bronir(string name, string family, string otch, string birth, string pasp, string kolvo, string zaezd, string viezd, string typ, string phone, string city )
        {
            bool flag = false;
            


            string sql = String.Format("INSERT INTO Bronirovanie(name,family,otch,birth,pasp,kolvo,zaezd,viezd,typ,phone,city) VALUES (@name,@family,@otch,@birth,@pasp,@kolvo,@zaezd,@viezd,@typ,@phone,@city)");

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@family", MySqlDbType.VarChar).Value = family;
            command.Parameters.Add("@otch", MySqlDbType.VarChar).Value = otch;
            command.Parameters.Add("@birth", MySqlDbType.VarChar).Value = birth;
            command.Parameters.Add("@pasp", MySqlDbType.VarChar).Value = pasp;
            command.Parameters.Add("@kolvo", MySqlDbType.VarChar).Value = kolvo;
            command.Parameters.Add("@zaezd", MySqlDbType.VarChar).Value = zaezd;
            command.Parameters.Add("@viezd", MySqlDbType.VarChar).Value = viezd;
            command.Parameters.Add("@typ", MySqlDbType.VarChar).Value = typ;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;
            conn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
                conn.Close();
            }
            return flag;

        }
        public ArrayList AllClients()
        {
            ArrayList allclients = new ArrayList();
            conn.Open();

            string sql = String.Format("SELECT id,login,name,phone FROM clients order by name");
            MySqlCommand command = new MySqlCommand(sql, conn);
           
                MySqlDataReader sqldr = command.ExecuteReader();

                if (sqldr.HasRows)
                {
                    foreach (DbDataRecord result in sqldr)
                        allclients.Add(result);
                    conn.Close();
                }
            
         

            return allclients;
        }
        public ArrayList AllBronirovanie()
        {
            ArrayList allbronirovanie = new ArrayList();
            conn.Open();

            string sql = String.Format("SELECT name,family,otch,phone,birth,pasp,kolvo,zaezd,viezd,typ,phone FROM Bronirovanie order by name");
            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader sqldr = command.ExecuteReader();

            if (sqldr.HasRows)
            {
                foreach (DbDataRecord result in sqldr)
                    allbronirovanie.Add(result);
                conn.Close();
            }



            return allbronirovanie;
        }
        public bool uslugi(string name, string phone, string adress, string bussines, string premium, string bar, string konf, string kater, string pit3, string pit2)
        {
            bool flag = false;



            string sql = String.Format("INSERT INTO uslugi(name,phone,adress,bussines,premium,bar,konf,kater,pit3,pit2) VALUES (@name,@phone,@adress,@bussines,@premium,@bar,@konf,@kater,@pit3,@pit2)");

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adress", MySqlDbType.VarChar).Value = adress;
            command.Parameters.Add("@bussines", MySqlDbType.VarChar).Value = bussines;
            command.Parameters.Add("@premium", MySqlDbType.VarChar).Value = premium;
            command.Parameters.Add("@bar", MySqlDbType.VarChar).Value = bar;
            command.Parameters.Add("@konf", MySqlDbType.VarChar).Value = konf;
            command.Parameters.Add("@kater", MySqlDbType.VarChar).Value = kater;
            command.Parameters.Add("@pit3", MySqlDbType.VarChar).Value = pit3;
            command.Parameters.Add("@pit2", MySqlDbType.VarChar).Value = pit2;
            conn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
                conn.Close();
            }
            return flag;
        }
        public ArrayList Alluslugi()
        {
            ArrayList alluslugi = new ArrayList();
            conn.Open();

            string sql = String.Format("SELECT name,phone,adress,bussines,premium,bar,konf,kater,pit3,pit2 FROM uslugi order by name");
            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader sqldr = command.ExecuteReader();

            if (sqldr.HasRows)
            {
                foreach (DbDataRecord result in sqldr)
                    alluslugi.Add(result);
                conn.Close();
            }



            return alluslugi;
        }


    }
}
