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
            string validacion = "";
            try
            {
                if (usuario != "" & contraseña != "")
                {
                    String[] Variables = { "@usuario", "@password" };
                    string[] Valores = { usuario, contraseña };

                    DataTable dt = Conexion.ConexionBaseDatos.Consulta("sp_loginTelefonos", Variables, Valores);

                    if (dt.Rows.Count > 0)
                    {
                        validacion = dt.Rows[0]["Resultado"].ToString();
                    }
                }
                else
                {
                    validacion = "2";
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
