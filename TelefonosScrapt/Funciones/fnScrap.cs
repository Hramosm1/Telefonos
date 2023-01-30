using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Data;
using System.Windows.Forms;

namespace TelefonosScrapt.Funciones
{
    class fnScrap
    {
      
        public static void InvestigacionTelefonos(DataTable Investigacion, DataGridView grid)
        {
            string idEmpresa,codigo,numero;
            DataTable dt = new DataTable();
            string[] Variables,Valores;
            DataTable resultados = Investigacion;
            int cont = -1;

            if (resultados.Columns.Contains("Compania") == false)
            {
                resultados.Columns.Add("Compania");
            }

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.telefonosguatemala.com");
            

            foreach (DataRow i in Investigacion.Rows)
            {
                cont += 1;

                try
                {
                    idEmpresa = i["idEmpresa"].ToString();
                    codigo = i["codigo"].ToString();
                    numero = i["numero"].ToString();
                    
                    // Validar duplicados
                    Variables = new string[2];
                    Valores = new string[2];

                    Variables[0] = "@opcion";
                    Valores[0] = "1";
                    Variables[1] = "@numero";
                    Valores[1] = numero;

                    dt = Conexion.ConexionBaseDatos.Consulta("sp_guardarTelefonos", Variables, Valores);

                    if (dt.Rows.Count > 0)
                    {

                        if (dt.Rows[0]["Resultado"].ToString() == "0")
                        {
                            while (driver.PageSource.Contains("Teléfonos Guatemala") == false) //Esperar que cargue la pagina
                            {

                            }

                            System.Threading.Thread.Sleep(5000); //Esperar 5 seg

                            var TextoTelefono = driver.FindElement(By.XPath("//*[@id='telefono']")); //Obtengo la caja de texto de numero
                            var Boton = driver.FindElement(By.XPath("//*[@id='formulario']/div/div[1]/div[2]/input"));//Obtengo el boton de buscar

                            TextoTelefono.SendKeys(numero);//Enviamos el numero a la caja de texto de numero
                            Boton.Submit();//Presiono el boton
                            var respuesta = driver.FindElement(By.XPath("/html/body/div[1]/article/div/div/div/form/div/div[2]/div/input")).GetAttribute("value"); //Obtengo la respuesta de la consulta
                            
                            if (respuesta == "")
                            {
                                resultados.Rows[cont]["Compania"] = "SIN RESULTADOS";
                            }
                            else
                            {
                                resultados.Rows[cont]["Compania"] = respuesta; //Ingreso la respuesta a la grid con la data
                            }
                            

                            if (respuesta != "")
                            {
                                Variables = new string[5];
                                Valores = new string[5];

                                Variables[0] = "@opcion";
                                Valores[0] = "2";
                                Variables[1] = "@numero";
                                Valores[1] = numero;
                                Variables[2] = "@noPrestamo";
                                Valores[2] = codigo;
                                Variables[3] = "@idEmpresa";
                                Valores[3] = idEmpresa;
                                Variables[4] = "@compania";
                                Valores[4] = respuesta;

                                Conexion.ConexionBaseDatos.Consulta("sp_guardarTelefonos", Variables, Valores);

                            }
                        }
                        else
                        {
                            var respuesta = dt.Rows[0]["Compania"].ToString();
                            resultados.Rows[cont]["Compania"] = respuesta;
                        }

                    }

                }
                catch(Exception ex)
                {
                    resultados.Rows[cont]["Compania"] = ex.Message;
                }
                

                driver.Navigate().Refresh();
                
            }
            driver.Quit();
            grid.DataSource = resultados;

        }

        
    }
}
