using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MeasureExport_ExcelAddin
{
    public class MeasureExport
    {
        /* Read the measure export CSV stream 
         * INPUTS: Measure Export Path; Properties File Path; Properties File Name
         * OUTPUT: Datatable containing the parsed CSV Dataset
         */
        public static DataTable ReadStream(string measureExportPath, string propertiesFilePath, string propertiesFile)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            p.StartInfo.WorkingDirectory = measureExportPath;

            if (GlobalVariables.exportVersion == "x64")
                p.StartInfo.FileName = "\"" + measureExportPath + @"\exportMeasure_amd64.exe" + "\""; //64-bit version
            else
                p.StartInfo.FileName = "\"" + measureExportPath + @"\exportMeasure.exe" + "\""; //32-bit version

            p.StartInfo.Arguments = "-p " + "\"" + propertiesFilePath + "\\" + propertiesFile + "\"";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            StreamReader myStreamReader = p.StandardOutput;
            StreamReader myErrorReader = p.StandardError;

            DataTable myDataTable = CsvParser.Parse(myStreamReader);

            // READ ERROR STREAM
            string error = myErrorReader.ReadToEnd();
            if (error != "")
            {
                myDataTable.Columns.Add("Error", typeof(string));
                myDataTable.Rows.Add(error);
            }

            p.Close();
            return myDataTable;
        }

        /* Returns the Measure Export Help Text 
         * INPUTS: Measure Export Path
         * OUTPUT: string that contains the HELP TEXT for the measure export
         */
        public static string GetHelp(string measureExportPath)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            p.StartInfo.WorkingDirectory = measureExportPath;
            p.StartInfo.FileName = "\"" + measureExportPath + @"\exportMeasure.exe" + "\"";
            p.StartInfo.Arguments = "--help";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            StreamReader myStreamReader = p.StandardOutput;
            string helpText = myStreamReader.ReadToEnd();

            p.Close();
            return helpText;
        }

        public static bool CheckExport(string measureExportPath)
        {
            if (Directory.Exists(measureExportPath))
                if (File.Exists(measureExportPath + "/exportMeasure.exe"))
                    return true;
            return false;
        }
    }
}
