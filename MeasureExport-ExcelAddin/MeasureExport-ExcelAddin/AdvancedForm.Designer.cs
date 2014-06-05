namespace MeasureExport_ExcelAddin
{
    partial class formProperties
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProperties));
            this.btnBrowseWorkingDir = new System.Windows.Forms.Button();
            this.listProperties = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorkingDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPropertyFileLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowsePropertyFile = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowseWorkingDir
            // 
            this.btnBrowseWorkingDir.Location = new System.Drawing.Point(421, 8);
            this.btnBrowseWorkingDir.Name = "btnBrowseWorkingDir";
            this.btnBrowseWorkingDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseWorkingDir.TabIndex = 2;
            this.btnBrowseWorkingDir.Text = "Browse";
            this.btnBrowseWorkingDir.UseVisualStyleBackColor = true;
            this.btnBrowseWorkingDir.Click += new System.EventHandler(this.btnBrowseWorkingDir_Click);
            // 
            // listProperties
            // 
            this.listProperties.FormattingEnabled = true;
            this.listProperties.Location = new System.Drawing.Point(161, 62);
            this.listProperties.Name = "listProperties";
            this.listProperties.Size = new System.Drawing.Size(254, 121);
            this.listProperties.TabIndex = 5;
            this.listProperties.DoubleClick += new System.EventHandler(this.listProperties_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Export Measure Location:";
            // 
            // txtWorkingDirectory
            // 
            this.txtWorkingDirectory.Location = new System.Drawing.Point(161, 10);
            this.txtWorkingDirectory.Name = "txtWorkingDirectory";
            this.txtWorkingDirectory.Size = new System.Drawing.Size(254, 20);
            this.txtWorkingDirectory.TabIndex = 1;
            this.txtWorkingDirectory.Leave += new System.EventHandler(this.txtWorkingDirectory_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Property Files:";
            // 
            // txtPropertyFileLocation
            // 
            this.txtPropertyFileLocation.Location = new System.Drawing.Point(161, 36);
            this.txtPropertyFileLocation.Name = "txtPropertyFileLocation";
            this.txtPropertyFileLocation.Size = new System.Drawing.Size(254, 20);
            this.txtPropertyFileLocation.TabIndex = 3;
            this.txtPropertyFileLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPropertyFileLocation_KeyDown);
            this.txtPropertyFileLocation.Leave += new System.EventHandler(this.txtPropertyFileLocation_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Property File Location:";
            // 
            // btnBrowsePropertyFile
            // 
            this.btnBrowsePropertyFile.Location = new System.Drawing.Point(421, 33);
            this.btnBrowsePropertyFile.Name = "btnBrowsePropertyFile";
            this.btnBrowsePropertyFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePropertyFile.TabIndex = 4;
            this.btnBrowsePropertyFile.Text = "Browse";
            this.btnBrowsePropertyFile.UseVisualStyleBackColor = true;
            this.btnBrowsePropertyFile.Click += new System.EventHandler(this.btnBrowsePropertyFile_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(421, 160);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "Edit File";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "(Double Click to Activate)";
            // 
            // btnHelp
            // 
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(6, 179);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(41, 26);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // formProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 210);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtPropertyFileLocation);
            this.Controls.Add(this.txtWorkingDirectory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listProperties);
            this.Controls.Add(this.btnBrowsePropertyFile);
            this.Controls.Add(this.btnBrowseWorkingDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formProperties";
            this.Text = "Measure Export Properties";
            this.Load += new System.EventHandler(this.formProperties_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formProperties_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkingDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseWorkingDir;
        private System.Windows.Forms.TextBox txtPropertyFileLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowsePropertyFile;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHelp;

    }
}