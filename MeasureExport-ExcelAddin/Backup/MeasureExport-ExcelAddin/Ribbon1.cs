using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace MeasureExport_ExcelAddin
{
    public partial class Ribbon1 : OfficeRibbon
    {
        public Ribbon1()
        {
            InitializeComponent();
        }

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void go_button_Click(object sender, RibbonControlEventArgs e)
        {
            //Run the Measure Export
            MeasureExport_ExcelAddin.Globals.ThisAddIn.GetData();
        }


        private void btnSetup_Click(object sender, RibbonControlEventArgs e)
        {
            //Display the Measure Export Properties Window 
            formProperties window = new formProperties();
            window.ShowDialog(); 
        }

    }
}
