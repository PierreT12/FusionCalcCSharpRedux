using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project_Redux
{
    
    class DbAccess
    {
        public string path = "Data Source=C:\\finaL_Database_2.db;New=False;";


       

     public DbAccess(string path, SQLiteConnection databaseConnection)
      {
            path = this.path;
            databaseConnection = new SQLiteConnection(path);
            
      }

     public List<string>GetAllPersonas(SQLiteConnection liteConnection)
      {
            List<string> list = new List<string>();
            liteConnection.ConnectionString = path;

            string query = "Select Name FROM Personas_Final ORDER BY Level ASC";

            SQLiteCommand cmd = new SQLiteCommand(query, liteConnection);
            liteConnection.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add($"{reader.GetString(0)}");
            }
            liteConnection.Close();
            return list;
      }



     public Persona GetSinglePersona(SQLiteConnection liteConnection, string name)
        {
            Persona selection = new Persona();
            string query = String.Format("SELECT Personas_Final.name, " +
                    "Arcana.name, " +
                    "Personas_Final.Level, " +
                    "Personas_Final.Fuseable, " +
                    "Personas_Final.SpecialFusion, " +
                    "Personas_Final.Max_SL, " +
                    "Personas_Final.Treasure " +
                    "FROM Personas_Final " +
                    "INNER JOIN Arcana " +
                    "ON Arcana.Arcana_ID = Personas_Final.Arcana " +
                    "WHERE Personas_Final.Name = '{0}'", name);


            liteConnection.ConnectionString = path;


            SQLiteCommand cmd = new SQLiteCommand(query, liteConnection);
            liteConnection.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                
                selection.m_name = $"{reader.GetString(0).ToString()}";
                selection.m_arcana = $"{reader.GetString(1).ToString()}";
                string str = $"{reader.GetInt32(2).ToString()}";
                selection.m_level = int.Parse(str);
                selection.m_fuseable = Convert.ToBoolean( $"{reader.GetString(3)}");
                selection.m_sFusion = Convert.ToBoolean($"{reader.GetString(4)}");
                selection.m_maxSL = Convert.ToBoolean($"{reader.GetString(5)}");
                selection.m_treasure = Convert.ToBoolean($"{reader.GetString(6)}");

            }

            liteConnection.Close();


            return selection;

        }

       

     public byte[] GetImage(SQLiteConnection connection, string name)
        {
            byte[] imagebytes;

            string query = String.Format("SELECT Personas_Final.Image " +
                    "FROM Personas_Final " +
                    "INNER JOIN Arcana " +
                    "ON Arcana.Arcana_ID = Personas_Final.Arcana " +
                    "WHERE Personas_Final.Name = '{0}'", name);

            connection.ConnectionString = path;


            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            connection.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();

            imagebytes = (byte[])reader["Image"];
                
            connection.Close();

            


           return imagebytes;
        }



     public List<string> GetMagic(SQLiteConnection connection, string name)
        {
            List<string> list = new List<string>();
            string query = String.Format("SELECT Str_Wea_Final.Phys, " +
                    "Str_Wea_Final.Gun, " +
                    "Str_Wea_Final.Fire, " +
                    "Str_Wea_Final.Ice, " +
                    "Str_Wea_Final.Electric, " +
                    "Str_Wea_Final.Wind, " +
                    "Str_Wea_Final.Psych, " +
                    "Str_Wea_Final.Nuke, " +
                    "Str_Wea_Final.Bless, " +
                    "Str_Wea_Final.Curse " +
                    "FROM Personas_Final " +
                    "INNER JOIN Str_Wea_Final " +
                    "ON Str_Wea_Final.Str_Wea_ID = Personas_Final.Str_Wea_ID " +
                    "WHERE Name = '{0}'", name);

            connection.ConnectionString = path;


            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            connection.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add($"{reader.GetString(0)}");
                list.Add($"{reader.GetString(1)}");
                list.Add($"{reader.GetString(2)}");
                list.Add($"{reader.GetString(3)}");
                list.Add($"{reader.GetString(4)}");
                list.Add($"{reader.GetString(5)}");
                list.Add($"{reader.GetString(6)}");
                list.Add($"{reader.GetString(7)}");
                list.Add($"{reader.GetString(8)}");
                list.Add($"{reader.GetString(9)}");
            }
            connection.Close();
            return list;
        }

     public List<string> GetStats(SQLiteConnection connection, string name)
        {
            List<string> list = new List<string>();

            string query = String.Format("SELECT Stats_Final.Strength, " +
                    "Stats_Final.Magic, " +
                    "Stats_Final.Endureance, " +
                    "Stats_Final.Agility, " +
                    "Stats_Final.Luck " +
                    "FROM Personas_Final " +
                    "INNER JOIN Stats_Final " +
                    "ON Stats_Final.Stat_ID = Personas_Final.Stat_ID " +
                    "WHERE Name = '{0}' ", name);

            connection.ConnectionString = path;


            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            connection.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add($"{reader.GetString(0)}");
                list.Add($"{reader.GetString(1)}");
                list.Add($"{reader.GetString(2)}");
                list.Add($"{reader.GetString(3)}");
                list.Add($"{reader.GetString(4)}");
            }

            connection.Close();
            return list;
        }
    }
}
