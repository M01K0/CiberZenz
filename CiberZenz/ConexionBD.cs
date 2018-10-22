using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CiberZenz
{
    class ConexionBD
    {
        private string Server;
        private string Database;
        private string Usuario;
        private string Pass;
        private string Cadena;
        public MySqlConnection Conexion;

        public bool exito=false;

        public bool ConInicio(string server, string database, string usuario, string pass)
        {
            Server = server;
            Database = database;
            Usuario = usuario;
            Pass = pass;
            Cadena = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + usuario + ";" + "PASSWORD=" + pass + ";SslMode = none";
            Conexion = new MySqlConnection(Cadena);
            try
            {
                Conexion.Open();
                exito = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return exito;
        }



        public void Conectar()
        {
            Cadena = "SERVER=localhost;DATABASE=CiberZenz;UID=admin;PASSWORD=tacuache;SslMode = none";
            Conexion = new MySqlConnection(Cadena);
            try
            {
                Conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Cerrar()
        {
            Conexion.Close();
        }

    }
}
