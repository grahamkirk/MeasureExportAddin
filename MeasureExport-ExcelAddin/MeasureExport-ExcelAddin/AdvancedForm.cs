using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeasureExport_ExcelAddin
{
    public partial class formProperties : Form
    {
        public formProperties()
        {
            InitializeComponent();
            txtWorkingDirectory.Text = GlobalVariables.workingDirectory;
            txtPropertyFileLocation.Text = GlobalVariables.propertiesDirectory;
            cboVersion.Text = GlobalVariables.exportVersion;

            changePropertiesDirectory(txtPropertyFileLocation.Text);
        }
 
        private void btnBrowseWorkingDir_Click(object sender, EventArgs e)
        {
            openFolderBrowser();
        }

        private void openFolderBrowser()
        {
            FolderBrowserDialog workingDirectory = new FolderBrowserDialog();

            workingDirectory.SelectedPath = GlobalVariables.workingDirectory;
            workingDirectory.ShowNewFolderButton = false;
            DialogResult result = workingDirectory.ShowDialog();
            if (result == DialogResult.OK)
            {
                changeWorkingDirectory(workingDirectory.SelectedPath);
            }
        }

        private void changeWorkingDirectory(string newDir)
        {
            if (MeasureExport.CheckExport(newDir))
            {
                txtWorkingDirectory.Text = newDir;
                GlobalVariables.workingDirectory = newDir;
                Properties.Settings.Default.defaultWorkingDirectory = newDir;
                Properties.Settings.Default.Save();
            }
            else
            {
                if (displayError("The selected directory does not contain the exportMeasure.exe.  Please browse to a valid location containing exportMeasure.exe", "Invalid Directory", MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtWorkingDirectory.Text = GlobalVariables.workingDirectory;
                    openFolderBrowser();
                }
            }
        }

        private void changePropertiesDirectory(string newDir)
        {
            if (Directory.Exists(newDir))
            {
                txtPropertyFileLocation.Text = newDir;
                GlobalVariables.propertiesDirectory = newDir;
                Properties.Settings.Default.defaultPropertiesDirectory = newDir;
                Properties.Settings.Default.Save();
                getPropertyFiles();
            }
            else
            {
                if (displayError("The selected directory does not exist", "Invalid Directory", MessageBoxIcon.Error) == DialogResult.OK)
                {
                    changePropertiesDirectory(GlobalVariables.propertiesDirectory);
                }
            }
        }

        private void changeExportVersion(string newVersion)
        {
            cboVersion.Text = newVersion;
            GlobalVariables.exportVersion = newVersion;
            Properties.Settings.Default.defaultExportVersion = newVersion;
            Properties.Settings.Default.Save();
        }

        private DialogResult displayError(string message, string caption, MessageBoxIcon icon)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;

            // Display message box
            DialogResult result = MessageBox.Show(message, caption, button, icon);

            // Process message box results
            return result;
        }

        private void btnBrowsePropertyFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog propertiesDirectory = new FolderBrowserDialog();
            propertiesDirectory.SelectedPath = GlobalVariables.propertiesDirectory;
            propertiesDirectory.ShowNewFolderButton = false;
            DialogResult result = propertiesDirectory.ShowDialog();
            if (result == DialogResult.OK)
            {
                changePropertiesDirectory(propertiesDirectory.SelectedPath);
            }
        }

        private void getPropertyFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(txtPropertyFileLocation.Text);
            
            // Handle the case if Properties File directory doesn't exist
            if (!dir.Exists)
            {
                dir = new DirectoryInfo(@"C:\");
                txtPropertyFileLocation.Text = @"C:\";
                GlobalVariables.propertiesDirectory = @"C:\";
            }

            GlobalVariables.propfiles = dir.GetFiles("*.txt");
            listProperties.Items.Clear();

            foreach (FileInfo f in GlobalVariables.propfiles)
            {
                listProperties.Items.Add(f.Name);
            }
        }

        private void listProperties_DoubleClick(object sender, EventArgs e)
        {
            formProperties.ActiveForm.Close();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(GlobalVariables.propfiles[listProperties.SelectedIndex].FullName); 
        }

        private bool getSelectedPropertiesFile()
        {
            if (listProperties.SelectedItem != null)
            {
                GlobalVariables.propertiesFile = listProperties.SelectedItem.ToString();
                Globals.Ribbons.Ribbon1.txtProperties.Text = GlobalVariables.propertiesFile;
                Properties.Settings.Default.defaultPropertiesFile = GlobalVariables.propertiesFile;
                Properties.Settings.Default.Save();
                return true;
            }
            else
                return false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help window = new Help();
            window.ShowDialog();
        }

        private void txtPropertyFileLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                changePropertiesDirectory(txtPropertyFileLocation.Text);
        }

        private void formProperties_FormClosing(object sender, FormClosingEventArgs e)
        {
            getSelectedPropertiesFile();
        }

        private void txtPropertyFileLocation_Leave(object sender, EventArgs e)
        {
            changePropertiesDirectory(txtPropertyFileLocation.Text);
        }

        private void txtWorkingDirectory_Leave(object sender, EventArgs e)
        {
            changeWorkingDirectory(txtWorkingDirectory.Text);
        }

         private void formProperties_Load(object sender, EventArgs e)
        {

        }

         private void cboVersion_Leave(object sender, EventArgs e)
         {
             changeExportVersion(cboVersion.Text);
         }
    }
}
