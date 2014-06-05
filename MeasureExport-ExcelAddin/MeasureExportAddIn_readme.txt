Global Variables:
Working Directory - Where Measure Export is located
Properties Directory - Where to look for the Property Files
Properties File - The selected Property File


Classes: 

CsvParser.cs
- Parse the CSV Stream into a datatable

AdvancedForm.cs
- The controlling form
- Define the working directories and property files

ThisAddIn.cs
- The Excel component (shows up in the Ribbon Excel 2007+)

MeasureExport.cs
- Contains the code that interfaces with the esi.manage measure export streams