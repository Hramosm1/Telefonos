using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TelefonosScrapt.Funciones
{
    class fnLeerArchivos
    {

        public static string[] Archivos(string ruta)
        {
            string[] directorio = Directory.GetFiles(@ruta, "*.xlsx"); ;

            return directorio;

        }


    }
}
