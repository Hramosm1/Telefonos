using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityClient;
using System.Reflection;
using System.Diagnostics;

namespace TelefonosScrapt.Conexion
{
    class ConexionBaseDatos
    {

        private static SqlConnection conectar() // Realizar la cadena de conexion a la base de datos
        {
            string Server = ""
                , Database = ""
                , User = ""
                , Password = ""
                , Security = "";

#if DEBUG && !UAT

            Server = "192.168.8.8";
            Database = "Salud";
            User = "investigacion";
            Password = "vWCZ3UHg";
            Security = "true";

#elif TRACE && !UAT

            Server = "192.168.8.6";
            Database = "Salud";
            User = "investigacion";
            Password = "vWCZ3UHg";
            Security = "false";

#elif UAT 

            Server = "192.168.8.27";
            Database = "Salud";
            User = "investigacion";
            Password = "vWCZ3UHg";
            Security = "true";
            
#endif

            string CadenaConexion = "SERVER=" + Server + ";DATABASE="+Database+";USER="+User+";PASSWORD="+Password+";Integrated security=" +Security;

            SqlConnection cn = new SqlConnection(CadenaConexion);

            return cn;

        }

        public static DataTable Consulta(String sp, String[] Variables, String[] Valores) //Realizamos la ejecucion de un procedimiento almacenado
        {
            DataTable Consulta = new DataTable();
            SqlConnection conexion = conectar();
            conexion.Open();

            SqlCommand comando = conexion.CreateCommand();
            comando.CommandTimeout = 0;
            comando.CommandText = sp;
            comando.CommandType = CommandType.StoredProcedure;

            int cont = -1;
            foreach (string i in Variables)
            {   
                cont += 1;
                comando.Parameters.AddWithValue(i, Valores[cont]);
            }

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            datos.Fill(Consulta);

            conexion.Close();

            return Consulta;


        }



    }
}
