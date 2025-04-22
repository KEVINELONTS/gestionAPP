using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionAPP
    {
        public class Data
        {
            private MySqlConnection connection;

            // Remplace les valeurs ci-dessous par les tiennes
            private string connectionString = "server='localhost';database='bibliotheque';uid='root';pwd='';";

            public Data()
            {
                connection = new MySqlConnection(connectionString);
            }

            public MySqlConnection GetConnection()
            {
                return connection;
            }

            public void OpenConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }

            public void CloseConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        public MySqlDataReader GetDataReader(string query)
        {
            try
            {
                MySqlCommand data = new MySqlCommand(query, connection);
                return data.ExecuteReader();
            }
            catch (Exception ex) {
                throw new Exception("Requete non aboutie", ex);
            }
        }
        }
    }