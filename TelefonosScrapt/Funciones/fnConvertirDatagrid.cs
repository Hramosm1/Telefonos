using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonosScrapt.Funciones
{
    class fnConvertirDatagrid
    {

        public static DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {

                dt.Columns.Add(column.Name);
                
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }

    }
}
