using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Tools = Microsoft.Office.Tools.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools.Excel.Extensions;
using Microsoft.VisualStudio.Tools.Applications.Runtime;

namespace MeasureExport_ExcelAddin
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            if (Directory.Exists(Properties.Settings.Default.defaultWorkingDirectory))
                GlobalVariables.workingDirectory = Properties.Settings.Default.defaultWorkingDirectory;
            else
                GlobalVariables.workingDirectory = @"C:\";

            if (Directory.Exists(Properties.Settings.Default.defaultPropertiesDirectory))
                GlobalVariables.propertiesDirectory = Properties.Settings.Default.defaultPropertiesDirectory;
            else
                GlobalVariables.propertiesDirectory = @"C:\";
            
            GlobalVariables.propertiesFile = Properties.Settings.Default.defaultPropertiesFile;
            GlobalVariables.exportVersion = Properties.Settings.Default.defaultExportVersion;

            Globals.Ribbons.Ribbon1.txtProperties.Text = GlobalVariables.propertiesFile;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public Excel.Worksheet GetActiveWorksheet()
        {
            return (Excel.Worksheet)Application.ActiveSheet;
        }


        public void GetData()
        {
            Excel.Worksheet activeWorksheet = ((Excel.Worksheet)Application.ActiveSheet);
            activeWorksheet.UsedRange.Clear();
            
            //Bind Dataset to the Active Excel Sheet.
            Microsoft.Office.Interop.Excel.Range rng = AddData(MeasureExport.ReadStream(GlobalVariables.workingDirectory, GlobalVariables.propertiesDirectory, GlobalVariables.propertiesFile), activeWorksheet);

            //Autosize the columns based on the resulting data
            activeWorksheet.Columns.EntireColumn.AutoFit();
        }


        //
        // SOURCE: http://allfaq.org/forums/p/8203/16365.aspx
        //
        private Microsoft.Office.Interop.Excel.Range AddData(System.Data.DataTable dataTable, Excel.Worksheet activeWorksheet)
        {
            //create the object to store the column names
            object[,] columnNames;

            columnNames = new object[1, dataTable.Columns.Count];

            //get a range object that the columns will be added to
            Microsoft.Office.Interop.Excel.Range columnsNamesRange = (Microsoft.Office.Interop.Excel.Range)activeWorksheet.get_Range(activeWorksheet.Cells[1, 1]
           , activeWorksheet.Cells[1, dataTable.Columns.Count]);

            //a simple assignement allows the data to be transferred quickly
            columnsNamesRange.Value2 = columnNames;

            //release the columsn range object now it is finished with
            columnsNamesRange = null;

            //create the object to store the dataTable data
            object[,] rowData;
            rowData = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //insert the data into the object[,]
            for (int iRow = 0; iRow < dataTable.Rows.Count; iRow++)
            {
                for (int iCol = 0; iCol < dataTable.Columns.Count; iCol++)
                {
                    rowData[iRow, iCol] = dataTable.Rows[iRow][iCol];
                }
            }

            //get a range to add the table data into 
            //it is one row down to avoid the previously added columns
            Microsoft.Office.Interop.Excel.Range dataCells = (Microsoft.Office.Interop.Excel.Range)activeWorksheet.get_Range(activeWorksheet.Cells[1, 1],
            activeWorksheet.Cells[dataTable.Rows.Count, dataTable.Columns.Count]);

            //assign data to worksheet
            dataCells.Value2 = rowData;

            //release range
            dataCells = null;

            //return the range to the new data
            return activeWorksheet.get_Range(activeWorksheet.Cells[1, 1],
            activeWorksheet.Cells[dataTable.Rows.Count + 1, dataTable.Columns.Count]);
        }


        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
