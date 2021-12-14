using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Controlador
{
    public class Libreria
    {
        public static DataSet Herramientas(string cmd)
        {
            MySqlConnection conexion = new MySqlConnection(@"server=localhost;user id=root;database=inventario_db_pa; pwd=051101");
            conexion.Open();

            DataSet data = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd, conexion);

            dataAdapter.Fill(data);

            conexion.Close();
            return data;
        }
    }
}
