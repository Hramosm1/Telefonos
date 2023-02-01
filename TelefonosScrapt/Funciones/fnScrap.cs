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
      
        public static void InvestigacionTelefonos(DataTable Investigacion, DataGridView grid,ProgressBar bar)
        {
            string Empresa,codigo,numero;
            DataTable dt = new DataTable();
            string[] Variables,Valores;
            DataTable resultados = Investigacion;
            int cont = -1;

            if (resultados.Columns.Contains("Compania") == false)
            {
                resultados.Columns.Add("Compania");
            }

            bar.Value = 0;
            bar.Maximum = Investigacion.Rows.Count;

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.telefonosguatemala.com");
            

            foreach (DataRow i in Investigacion.Rows)
            {
                cont += 1;

                try
                {
                    Empresa = i["Empresa"].ToString();
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

                            System.Threading.Thread.Sleep(250); //Esperar 5 seg

                            var TextoTelefono = driver.FindElement(By.XPath("//*[@id='telefono']")); //Obtengo la caja de texto de numero
                            var Boton = driver.FindElement(By.XPath("//*[@id='formulario']/div/div[1]/div[2]/input"));//Obtengo el boton de buscar

                            TextoTelefono.SendKeys(numero);//Enviamos el numero a la caja de texto de numero
                            Boton.Submit();//Presiono el boton
                            var respuesta = driver.FindElement(By.XPath("/html/body/div[1]/article/div/div/div/form/div/div[2]/div/input")).GetAttribute("value"); //Obtengo la respuesta de la consulta
                            
                            if (respuesta == "")
                            {
                                respuesta = "SIN RESULTADOS";
                            }

                            resultados.Rows[cont]["Compania"] = respuesta; //Ingreso la respuesta a la grid con la data
                            bar.Value = cont;

                           //Ingresó los resultados a base de datos
                            Variables = new string[5];
                            Valores = new string[5];

                            Variables[0] = "@opcion";
                            Valores[0] = "2";
                            Variables[1] = "@numero";
                            Valores[1] = numero;
                            Variables[2] = "@noPrestamo";
                            Valores[2] = codigo;
                            Variables[3] = "@Empresa";
                            Valores[3] = Empresa;
                            Variables[4] = "@compania";
                            Valores[4] = respuesta;

                            Conexion.ConexionBaseDatos.Consulta("sp_guardarTelefonos", Variables, Valores);

                        }
                        else
                        {
                            var respuesta = dt.Rows[0]["Compania"].ToString();
                            resultados.Rows[cont]["Compania"] = respuesta;
                            bar.Value = cont;
                        }

                    }

                }
                catch(Exception ex)
                {
                    resultados.Rows[cont]["Compania"] = ex.Message;
                    bar.Value = cont;
                }
                

                driver.Navigate().Refresh();
                
            }
            driver.Quit();
            grid.DataSource = resultados;
            bar.Value = bar.Maximum;
            MessageBox.Show("Investigación terminada", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        
    }
}
