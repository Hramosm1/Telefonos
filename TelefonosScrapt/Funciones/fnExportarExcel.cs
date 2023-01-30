using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


namespace TelefonosScrapt.Funciones
{
    class fnExportarExcel
    {

        public static void Exportar(DataGridView grid)
        {
            try
            {
                SaveFileDialog explorador = new SaveFileDialog();

                explorador.Filter = "Excel (*.xls)|*xls";
                explorador.FileName = "ReporteInvestigacion";

                if (explorador.ShowDialog() == DialogResult.OK)
                {

                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Workbook libros_trabajo;
                    Worksheet detalle;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    detalle = (Worksheet)libros_trabajo.Worksheets.get_Item(1);


                    for (int h = 0; h < grid.Columns.Count; h++)
                    {

                        detalle.Cells[1, h + 1] = grid.Columns[h].HeaderText.ToString();

                    }

                    for (int i = 1; i < (grid.Rows.Count + 1); i++)
                    {
                        for (int j = 0; j < grid.Columns.Count; j++)
                        {

                            detalle.Cells[i + 1, j + 1] = grid.Rows[i - 1].Cells[j].Value;

                        }

                    }

                    libros_trabajo.SaveAs(explorador.FileName, XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    MessageBox.Show("Reporte generado correctamente", "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al exportar el reporte " + ex.Message, "Teléfonos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
