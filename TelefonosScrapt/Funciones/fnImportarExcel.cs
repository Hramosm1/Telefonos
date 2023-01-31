using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace TelefonosScrapt.Funciones
{
    class fnImportarExcel
    {
        private static OleDbConnection conexionExcel(string ruta)
        {

            OleDbConnection conexion  = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source='" + ruta + "';Extended Properties='Excel 12.0 Xml;HDR=Yes'");

            return conexion;

        }

        public static bool Importar(string nombreHoja, DataGridView grid) //Importar el excel a una data table
        {
            bool flag = false;
            DataTable dt = new DataTable();
            string ruta = "";
            OleDbConnection conexion;
            OleDbDataAdapter adaptador;


            try
            {
                OpenFileDialog Explorador = new OpenFileDialog();
                Explorador.Filter = "Excel files |*.xlsx";
                Explorador.Title = "Seleccionar archivo";
                if (Explorador.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ruta = Explorador.FileName;
                }


                if(ruta != "")
                {
                    conexion = conexionExcel(ruta);

                    adaptador = new OleDbDataAdapter("select * from [" + nombreHoja + "$]", conexion);

                    adaptador.Fill(dt);

                    conexion.Close();


                    if (dt.Rows.Count > 0)
                    {

                        if (ValidarColumnas(dt))
                        {
                            MessageBox.Show("Archivo cargado correctamente.", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            flag = true;
                            grid.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Revise si el archivo cargado contiene las columnas obligatorias", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                    
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al momento de cargar el excel " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return flag;

        }


        private static Boolean ValidarColumnas(DataTable dt)
        {
            bool flag = false;
            
            String[] CamposObligatorios = { "Codigo", "Empresa", "Numero" };
            String[] CamposTabla= new string[CamposObligatorios.Length];
            int n = dt.Columns.Count - CamposObligatorios.Length;

            if (n < 0)
            {
                n = 0;
            }


            String[] ColumnasEliminar = new string[n];

            int cont = -1;
            int cont2 = -1;
            foreach (DataColumn i in dt.Columns)
            {
                if (CamposObligatorios.Contains(i.ColumnName))
                {
                    cont += 1;
                    CamposTabla[cont] = i.ColumnName;
                }
                else
                {
                    cont2 += 1;
                    ColumnasEliminar[cont2] = i.ColumnName;
                }

            }

            foreach (string i in ColumnasEliminar) 
            {
                dt.Columns.Remove(i);
                dt.AcceptChanges();
            }

            String[] CamposEnComun = CamposObligatorios.Intersect(CamposTabla).ToArray();

            if (CamposEnComun.Length == 3)
            {
                flag = true;
            }

            return flag;

        }

        

    }
}
