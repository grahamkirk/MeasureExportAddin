namespace MeasureExport_ExcelAddin
{
    partial class Ribbon1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();                 //new Microsoft.Office.Tools.Ribbon.RibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();             //new Microsoft.Office.Tools.Ribbon.RibbonGroup();
            this.txtProperties = this.Factory.CreateRibbonEditBox();    //new Microsoft.Office.Tools.Ribbon.RibbonEditBox();
            this.btnSetup = this.Factory.CreateRibbonButton();          //new Microsoft.Office.Tools.Ribbon.RibbonButton();
            this.go_button = this.Factory.CreateRibbonButton();         //new Microsoft.Office.Tools.Ribbon.RibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();     //new Microsoft.Office.Tools.Ribbon.RibbonSeparator();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.go_button);
            this.group1.Items.Add(this.separator1);
            this.group1.Items.Add(this.txtProperties);
            this.group1.Items.Add(this.btnSetup);
            this.group1.Label = "Excel Export Add-in";
            this.group1.Name = "group1";
            // 
            // txtProperties
            // 
            this.txtProperties.Enabled = false;
            this.txtProperties.Label = "Properties File:";
            this.txtProperties.Name = "txtProperties";
            this.txtProperties.SizeString = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            this.txtProperties.Text = null;
            // 
            // btnSetup
            // 
            this.btnSetup.Label = "Setup";
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSetup_Click);    //new System.EventHandler<Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs>(this.btnSetup_Click);
            // 
            // go_button
            // 
            this.go_button.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.go_button.Image = global::MeasureExport_ExcelAddin.Properties.Resources._3esi_logo;
            this.go_button.Label = "Go!";
            this.go_button.Name = "go_button";
            this.go_button.ShowImage = true;
            this.go_button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.go_button_Click); //new System.EventHandler<Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs>(this.go_button_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);//new System.EventHandler<Microsoft.Office.Tools.Ribbon.RibbonUIEventArgs>(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton go_button;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox txtProperties;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSetup;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
    }

    partial class ThisRibbonCollection : Microsoft.Office.Tools.Ribbon.RibbonReadOnlyCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
