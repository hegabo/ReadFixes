using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadFixes
{
    public partial class FrmReadFixes : Form
    {
        public FrmReadFixes()
        {
            InitializeComponent();
        }

        private string[] FileNames;

        private void RadSourceFolder_CheckedChanged(object sender, EventArgs e)
        {
            chkSubfolders.Enabled = radSourceFolder.Checked;
            txtSource.Enabled = radSourceFolder.Checked;
            txtSource.Text = "";
            FileNames = null;
        }

        private void BtnSource_Click(object sender, EventArgs e)
        {
            if (radSourceFiles.Checked)
            {
                using (OpenFileDialog dlgOpen = new OpenFileDialog())
                {
                    dlgOpen.Title = "Open file";
                    dlgOpen.DefaultExt = "npc";
                    dlgOpen.Filter = "NaviPac Fix File (*.npc)|*.npc";
                    dlgOpen.Multiselect = true;

                    if (dlgOpen.ShowDialog() == DialogResult.OK)
                    {
                        //strInitialDirectory = Path.GetDirectoryName(dlgOpen.FileName);
                        txtSource.Text = dlgOpen.FileNames.Length + " files selected";
                    }
                    FileNames = dlgOpen.FileNames;
                }
            }
            else if (radSourceFolder.Checked)
            {
                using (FolderBrowserDialog dlgSourceFolder = new FolderBrowserDialog())
                {
                    if (txtSource.Text != "")
                    {
                        try
                        {
                            dlgSourceFolder.SelectedPath = txtSource.Text;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    if (dlgSourceFolder.ShowDialog() == DialogResult.OK)
                    {
                        txtSource.Text = dlgSourceFolder.SelectedPath;
                    }
                }
            }
            btnExport.Enabled = true;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (StreamWriter StmExport = new StreamWriter(txtTarget.Text))
            {
                // Write header
                StmExport.Write("FileName,FixTime,Count,CountFiltered,MedEasting,MedNorthing,MedHeight,AvgEasting,AvgrNorthing,AvgHeight,SDEasting,SDNorthing,SDHeight,ErrorEasting,ErrorNorthing,ErrorHeight,");
                if (chkSamples.Checked)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        StmExport.Write("Sample " + i + " Easting,Sample " + i + " Northing,Sample " + i + " Heghit,Sample " + i + "Filtered,");
                    }
                }
                StmExport.Write("\n");


                if (radSourceFiles.Checked)
                {
                    for (int i = 0; i < FileNames.Length; i++)
                    {
                        WriteFix(StmExport, new Fix(FileNames[i]));
                    }
                }
                else if (radSourceFolder.Checked)
                {
                    DirectoryInfo dirSource = new DirectoryInfo(txtSource.Text);
                    //GetFolferFixes(dirSource);
                    SearchOption SubFolder;
                    if (chkSubfolders.Checked)
                    {
                        SubFolder = SearchOption.AllDirectories;
                    }
                    else
                    {
                        SubFolder = SearchOption.TopDirectoryOnly;
                    }
                    foreach (FileInfo file in dirSource.GetFiles("*.npc", SubFolder))
                    {
                        WriteFix(StmExport, new Fix(file.FullName));
                    }
                }
                StmExport.Flush();
                MessageBox.Show("Done");
            }
        }


        private void WriteFix(StreamWriter StmOutputFile, Fix fix)
        {
            StmOutputFile.Write(fix.FileName + "," + fix.FixTime.ToString("yyyy-MM-dd HH:mm:ss") + "," + fix.IntCount + "," + fix.IntCountFiltered
                + "," + fix.DblMedEasting + "," + fix.DblMedNorthing + "," + fix.DblMedHeight + "," + fix.DblAvgEasting + "," + fix.DblEAvgrNorthing + "," + fix.DblAvgHeight
                + "," + fix.DblSDEasting + "," + fix.DblSDNorthing + "," + fix.DblSDHeight + "," + fix.DblErrorEasting + "," + fix.DblErrorNorthing + "," + fix.DblErrorHeight + ",");
            if(chkSamples.Checked)
            {
                for (int i = 0; i < fix.Samples.Length; i++)
                {
                    StmOutputFile.Write(fix.Samples[i].dblEasting + "," + fix.Samples[i].dblNorthing + "," + fix.Samples[i].dblHeight + "," + fix.Samples[i].bolRejected + ",");
                }
            }
            StmOutputFile.Write("\n");
        }

        private void BtnTarget_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlgSave = new SaveFileDialog())
            {
                dlgSave.Title = "Export file";
                dlgSave.DefaultExt = "csv";
                dlgSave.Filter = "Comma Separated Values (*.csv)|*.csv";
                dlgSave.AddExtension = true;
                if (dlgSave.ShowDialog() == DialogResult.OK)
                {
                    txtTarget.Text = dlgSave.FileName;
                }
            }
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Working progress, provided as-is, for personal use. Developed by Muhammad Hegab muhammad@hegabo.com.");
        }
    }
}
