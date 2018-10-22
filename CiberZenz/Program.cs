using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CiberZenz
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        // [STAThread]        


       public static ConexionBD Con = new ConexionBD();
        static void Main()
        {
            if (Con.ConInicio("localhost", "CiberZenz", "admin", "tacuache")== true)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Presentacion());
            }
        }
    }
}
