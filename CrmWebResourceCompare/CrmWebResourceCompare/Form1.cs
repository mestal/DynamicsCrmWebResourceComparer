using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrmWebResourceCompare
{
    public partial class Form1 : Form
    {

        private List<string> gitFiles; 
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.ShowDialog();
            lblPublishedWebResourcesFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.ShowDialog();
            lblGitFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxEquals.Items.Clear();
            listBoxDifferents.Items.Clear();
            listBoxNotFoundsOrMultipleFounds.Items.Clear();

            string gitPlace = lblGitFolder.Text;
            string publishedWebResourcesPlace = lblPublishedWebResourcesFolder.Text;

            /*
            LoadListBoxes(gitPlace, "Scripts", publishedWebResourcesPlace);
            LoadListBoxes(gitPlace, "processapp", publishedWebResourcesPlace);
            LoadListBoxes(gitPlace, "Content\\scripts", publishedWebResourcesPlace);
            LoadListBoxes(gitPlace, "Content\\styles", publishedWebResourcesPlace);
            LoadListBoxes(gitPlace, "ermsresources", publishedWebResourcesPlace);
            LoadListBoxes(gitPlace, "customersearch", publishedWebResourcesPlace);
            */
            LoadListBoxes(gitPlace, "", publishedWebResourcesPlace);


            labelCountEquals.Text = listBoxEquals.Items.Count.ToString();
            labelCountDifferents.Text = listBoxDifferents.Items.Count.ToString();
            labelCountNotFoundOrMultipleFounds.Text = listBoxNotFoundsOrMultipleFounds.Items.Count.ToString();
        }

        private void LoadListBoxes(string gitPlace, string gitFolderName, string publishedWebResourcesPlace)
        {
            gitFiles = new List<string>();
            LoadGitFiles($"{gitPlace}\\{gitFolderName}");

            foreach (var gitFilePath in gitFiles.Where(a => a.ToLower().EndsWith("html") || a.ToLower().EndsWith("htm") || a.ToLower().EndsWith("js") || a.ToLower().EndsWith("css")))
            {
                //var fileName = GetFileName(gitFilePath);
                var folder = gitFilePath.Replace(gitPlace, "");
                bool mainFolder = false;
                if (!folder.Substring(2).Contains("\\"))
                {
                    mainFolder = true;
                }
                folder = folder.Replace("\\", "");
                folder = folder.Replace(".", "");
                //fileName = fileName.Replace(".", "");
                var publishedFileName = "";
                if (!mainFolder)
                {
                    publishedFileName = $"etel_{folder}";
                }
                else
                {
                    publishedFileName = $"{folder}";
                }
                try
                {
                    publishedFileName = FindPublishedFile(publishedWebResourcesPlace, publishedFileName);

                    if (FileEqualWithoutSpaceCheck(gitFilePath, publishedFileName))
                    {
                        listBoxEquals.Items.Add(gitFilePath.Replace(gitPlace, ""));
                        //textEquals.Text = textEquals.Text + gitFilePath;
                    }
                    else
                    {
                        listBoxDifferents.Items.Add(gitFilePath.Replace(gitPlace, ""));
                    }
                }
                catch (Exception ex)
                {
                    listBoxNotFoundsOrMultipleFounds.Items.Add(gitFilePath.Replace(gitPlace, ""));
                }
            }
        }

        private bool FileEqual(string file1, string file2)
        {
            string[] lines1 = System.IO.File.ReadAllLines(file1);
            string[] lines2 = System.IO.File.ReadAllLines(file2);

            if (lines1.Length != lines2.Length)
                return false;

            for (var i = 0; i < lines1.Length; i ++)
            {
                if (lines1[i] != lines2[i])
                    return false;
            }

            return true;
        }

        private bool FileEqualWithoutSpaceCheck(string file1, string file2)
        {
            string[] lines1 = System.IO.File.ReadAllLines(file1);
            string[] lines2 = System.IO.File.ReadAllLines(file2);
            var lines1OneString = string.Empty;
            for (var i = 0; i < lines1.Length; i++)
            {
                lines1OneString = lines1OneString + lines1[i].Replace(" ", "");
            }

            var lines2OneString = string.Empty;
            for (var i = 0; i < lines2.Length; i++)
            {
                lines2OneString = lines2OneString + lines2[i].Replace(" ", "");
            }

            return lines1OneString == lines2OneString;
        }

        private string FindPublishedFile(string folder, string partialName)
        {
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(folder);

            if (partialName.Length > 50)
                partialName = partialName.Substring(0, 50);

            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles(partialName + "*.*");

            if (filesInDir.Length == 0 && partialName.Substring(partialName.Length - 4) == "html")
            {
                partialName = partialName.Substring(0, partialName.Length - 1);
                filesInDir = hdDirectoryInWhichToSearch.GetFiles(partialName + "*.*");
            }

            if (filesInDir.Length != 1)
            {
                throw new Exception("not found or multiple found");
            }
            return filesInDir[0].FullName;
        }



        private string GetFileName(string path)
        {
            var lastIndex = path.LastIndexOf(@"\") + 1;
            return path.Substring(lastIndex);
        }

        private void LoadGitFiles(string sDir)
        {
            foreach (string f in Directory.GetFiles(sDir))
            {
                gitFiles.Add(f);
            }
            foreach (string d in Directory.GetDirectories(sDir))
            {
                //foreach (string f in Directory.GetFiles(d))
                //{
                //    gitFiles.Add(f);
                //}
                LoadGitFiles(d);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblGitFolder.Text = @"";
            lblPublishedWebResourcesFolder.Text = @"";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (object row in listBoxDifferents.SelectedItems)
                {
                    sb.Append(row.ToString());
                    sb.AppendLine();
                }
                sb.Remove(sb.Length - 1, 1); // Just to avoid copying last empty row
                Clipboard.SetData(System.Windows.Forms.DataFormats.Text, sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (object row in listBoxEquals.SelectedItems)
                {
                    sb.Append(row.ToString());
                    sb.AppendLine();
                }
                sb.Remove(sb.Length - 1, 1); // Just to avoid copying last empty row
                Clipboard.SetData(System.Windows.Forms.DataFormats.Text, sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (object row in listBoxNotFoundsOrMultipleFounds.SelectedItems)
                {
                    sb.Append(row.ToString());
                    sb.AppendLine();
                }
                sb.Remove(sb.Length - 1, 1); // Just to avoid copying last empty row
                Clipboard.SetData(System.Windows.Forms.DataFormats.Text, sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < listBoxDifferents.Items.Count; i++)
                listBoxDifferents.SetSelected(i, true);
        }
    }
}
