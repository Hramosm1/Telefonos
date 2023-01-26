using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TelefonosScrapt.Funciones
{
    class fnLogin
    {
        
        public static String ValidacionUsuario(string usuario,string contraseña)
        {
            string validacion = "0";
            try
            {
                String[] Variables = { "@usuario", "@password" ,"@opcion"};
                string[] Valores = { usuario, contraseña,"1"};

                DataTable dt = Conexion.ConexionBaseDatos.Consulta("scrap_Telefonos", Variables, Valores);

                if (dt.Rows.Count > 0)
                {
                    validacion = dt.Rows[0]["Resultado"].ToString();
                }

            }
            catch (Exception ex)
            {
                validacion = "Error al realizar la validación " + ex.Message;
            }

            return validacion;

        }



    }
}
