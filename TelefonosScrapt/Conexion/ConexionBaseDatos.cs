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

        private static SqlConnection conectar() // Realizar la conexion a la base de datos
        {
            string Server = ""
                , Database = ""
                , User = ""
                , Password = "";

#if DEBUG && !UAT

            Server = "192.168.8.8";
            Database = "Salud";
            User = "investigacion";
            Password = "vWCZ3UHg";

#elif TRACE && !UAT

            Server = "192.168.8.6";
            Database = "Salud";
            User = "investigacion";
            Password = "vWCZ3UHg";

#elif UAT 

            Server = "192.168.8.27";
            Database = "Salud";
            User = "investigacion";
            Password = "vWCZ3UHg";
            
#endif

            string CadenaConexion = "SERVER=" + Server + ";DATABASE="+Database+";USER="+User+";PASSWORD="+Password+";Integrated security=true";

            SqlConnection cn = new SqlConnection(CadenaConexion);

            return cn;

        }

        public static DataTable Consulta(String sp, String[] Variables, String[] Valores) //Realizamos la ejecucion de un procedimiento almacenado
        {
            DataTable Consulta = new DataTable();
            try
            {
                
                conectar().Open();

                SqlCommand comando = conectar().CreateCommand();
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

                conectar().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, comuniquese con soporte "+ ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return Consulta;


        }


    }
}
