using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace CiberZenz
{
    public partial class InicioSesion : Form
    {
        public static string Nombres;
        public static string Apellidos;
        public static string Nickname;
        public static string Correo;

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta apunto de cerrar\n¿Esta Seguro?", 
                "Inicio de Sesion:", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            ConexionBD Con = new ConexionBD();
            string Contraseña = Txt_Contraseña.Text;
            string Usuario = Txt_Usuario.Text;

            if (!string.IsNullOrEmpty(Usuario) || !string.IsNullOrEmpty(Contraseña))
            {
                try
                {
                    Con.Conectar();

                    string Query = @"select * from usuarios where nickname='" + Usuario + "' and contrasena='" + Contraseña + "';";
                    MySqlCommand Cmd = new MySqlCommand(Query, Con.Conexion);
                    MySqlDataReader Lector = Cmd.ExecuteReader();
                    if (Lector.HasRows)
                    {
                        while (Lector.Read())
                        {
                            Nombres = Convert.ToString(Lector["nombres"]);
                            Apellidos = Convert.ToString(Lector["apellidos"]);
                            Nickname = Convert.ToString(Lector["nickname"]);
                            Correo = Convert.ToString(Lector["correo"]);
                        }

                        MessageBox.Show("Exito al ingresar!\nBienvenido " + Nombres + "",
                        "Inicio Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        new Menu().Show();
                    }
                    else
                    {
                        MessageBox.Show("¡Error!, ¡El usuario o contraseña no son correctos!",
                        "Inicio Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
            else
            {
                MessageBox.Show("¡Error!, ¡Favor de llenar ambos espacios!",
                        "Inicio Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Librerias para darle movimiento a la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Evento
        private void InicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
