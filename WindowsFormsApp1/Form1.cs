using System;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String LAname,LAnameT;
        string filepathname, directory;
        string filePath = string.Empty;
        string Destination;
        bool Flag = false;
        public Form1()
        {
            InitializeComponent();
            LAnameT = Directory.GetCurrentDirectory();
            Directory2.Text = LAnameT;

        }
      
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
        
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                ListFiles.Text += file;
                ListFiles.Text += Environment.NewLine;
            }

            // ListFiles.Items.Add(file.ToString());
        }


        private void Unzip_Click(object sender, EventArgs e)
        {
            Destination = Directory1.Text;
            bool exists = System.IO.Directory.Exists(Destination);

            if (!exists)
                System.IO.Directory.CreateDirectory(Destination);

            unziptemp(filepathname, Destination);
        }

        private void OpenF_Click(object sender, EventArgs e)
        {
          
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = LAname;
                openFileDialog.Filter = "zip files (*.zip)|*.zip";//|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    directory=System.IO.Path.GetDirectoryName(filePath);
                }
            }
           string nameFile=(Path.GetFileNameWithoutExtension(filePath));
            Directory1.Text = directory + "\\" + nameFile; ;
            filepathname = filePath;
        }

        private void OpenDir_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fd1 = new FolderBrowserDialog();
                //fd1.ShowDialog();
                if (fd1.ShowDialog() == DialogResult.OK)
                {
                    Directory1.Text = fd1.SelectedPath;
                    LAname = Directory1.Text;
                }
            }
            catch
            {

            }
        }

        private void SaveDir_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fd1 = new FolderBrowserDialog();
                //fd1.ShowDialog();
                if (fd1.ShowDialog() == DialogResult.OK)
                {
                    Directory2.Text = fd1.SelectedPath;
                    LAnameT = Directory2.Text;
                }
            }
            catch
            {

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ListFiles.SelectedText = "";
            ReadLineTextBox();
        }
        private void DeleteaLine(int a_line)
        {
            int start_index = ListFiles.GetFirstCharIndexFromLine(a_line);
            int count = ListFiles.Lines[a_line].Length;

            // Eat new line chars
            if (a_line < ListFiles.Lines.Length - 1)
            {
                count += ListFiles.GetFirstCharIndexFromLine(a_line + 1) -
                    ((start_index + count - 1) + 1);
            }

            ListFiles.Text = ListFiles.Text.Remove(start_index, count);
        }
        private void ReadLineTextBox()
        {
            String[] lines = ListFiles.Text.Split('\n');

            int line=lines.Length;
            if (line > 1)
            {
                for (int i = 0; i < line-1; i++)
                {
                    if (lines[i] == "")
                    {
                        DeleteaLine(i);
                    }
                }
            }
            else
            {
                Flag = false;
            }
        }

        private void AddFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fd1 = new FolderBrowserDialog();
                if (fd1.ShowDialog() == DialogResult.OK)
                {

                    ListFiles.Text += fd1.SelectedPath;
                    ListFiles.Text += Environment.NewLine;
                    directory = fd1.SelectedPath;
                    if (directory!= null && new DirectoryInfo(directory).FullName != new DirectoryInfo(directory).Root.FullName)
                    {
                        DirectoryInfo dir_info = new DirectoryInfo(directory);
                        string tempdir = dir_info.Name;  // System32
                        Zipfilename.Text = tempdir;
                        int k = tempdir.Length;
                        int l = directory.Length;
                        directory = directory.Remove(l - k, k);
                        Directory2.Text = directory;
                    }
                    else
                    {
                        directory = fd1.SelectedPath;
                        Directory2.Text = directory;
                    }

                    Flag = true;
                }
            }
            catch
            {

            }
        }

        private void Zip_Click(object sender, EventArgs e)
        {
            string lastFolderName = "wetfetcet123";

            if (LAnameT != null && new DirectoryInfo(LAnameT).FullName != new DirectoryInfo(LAnameT).Root.FullName)
            {
                DirectoryInfo dir_info = new DirectoryInfo(LAnameT);
                lastFolderName = dir_info.Name;  // System32
                                     // lastFolderName = "C:\\" + Path.GetFileName(Path.GetDirectoryName(LAnameT)); returns the last folder of a file
            }

            bool exists = System.IO.Directory.Exists(@"C:wetfetcet123\\" + lastFolderName);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(@"C:\\wetfetcet123\\" + lastFolderName);
            }
            else
            {
                DeleteDir(@"C:\\wetfetcet123\\" + lastFolderName);
            }

            String[] lines = ListFiles.Text.Split('\n');

            int line = lines.Length;
            if (line > 1)
            {
                for (int i = 0; i < line - 1; i++)
                {
                    if (lines[i] != "")
                    {
                        FileAttributes attr = System.IO.File.GetAttributes(@lines[i]);

                        if (attr.HasFlag(FileAttributes.Directory))
                        {
                            Copy(lines[i], @"C:\\wetfetcet123\\" + lastFolderName);
                        }
                        else
                        {
                            string Fname = Path.GetFileName(lines[i]);
                            System.IO.File.Copy(lines[i], @"C:\\wetfetcet123\\" + lastFolderName +"\\"+ Fname);
                        }
                    }
                }

                zipfilestoarchive("C:\\wetfetcet123\\" + lastFolderName, Directory2.Text);
          
            }
            if (System.IO.Directory.Exists("C:wetfetcet123\\" + lastFolderName))
            {

                DeleteDir(@"C:\\wetfetcet123\\" + lastFolderName);
            }
        }


        private void zipfilestoarchive(string startPath, string zipPath)
        {
            String ZipFname = Zipfilename.Text;
            if(ZipFname=="")
            {
                ZipFname = "temp.zip";
            }
            else
            {
                ZipFname = ZipFname + ".zip";
            }
            if (!System.IO.File.Exists(zipPath + "\\" + ZipFname))
            {
                ZipFile.CreateFromDirectory(startPath, zipPath + "\\" + ZipFname);
                MessageBox.Show("The file zipped successfully in:" + zipPath + "\\" + ZipFname);
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("The file"+ ZipFname +"EXISTS. Do you want to OVERLAY?","or No to Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        System.IO.Compression.ZipFile.ExtractToDirectory(zipPath + "\\" + ZipFname, startPath);
                        System.IO.File.Delete(zipPath + "\\" + ZipFname);
                        ZipFile.CreateFromDirectory(startPath, zipPath + "\\" + ZipFname);
                        MessageBox.Show("The file zipped successfully in:" + zipPath + "\\" + ZipFname);
                    }
                    catch
                    {
                        MessageBox.Show("The file zip was usuccessful. A file to compress with the same name exist in the zipped file");
                    }
                }
                else
                {
                    MessageBox.Show("The file zip was usuccessful");
                }
            }

            DeleteDir(startPath);
        }
        private void AddFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = LAnameT;
                openFileDialog.Filter = "files (*.*)|*.*";//|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                        ListFiles.Text += filePath;
                        ListFiles.Text += Environment.NewLine;

                    directory = System.IO.Path.GetDirectoryName(filePath);
                    if (directory != null && new DirectoryInfo(directory).FullName != new DirectoryInfo(directory).Root.FullName)
                    {
                        DirectoryInfo dir_info = new DirectoryInfo(directory);
                        string tempdir = dir_info.Name;  // System32
                        Zipfilename.Text = tempdir;
                        int k = tempdir.Length;
                        int l = directory.Length;
                        directory = directory.Remove(l - k, k);
                        Directory2.Text = directory;
                    }
                    else
                    {
                        Directory2.Text = directory;
                    }
                    
                    Flag = true;
                }
            }

        }
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            string sF = "";
            if (source != null && (source).FullName != (source).Root.FullName)
            {
              DirectoryInfo dir_info = (source);
              sF = dir_info.Name;  // System32
                                                          // lastFolderName = "C:\\" + Path.GetFileName(Path.GetDirectoryName(LAnameT)); returns the last folder of a file
            }
            string targetFullName = target.FullName + "\\" + sF;
            DirectoryInfo taRGETdir_info = new DirectoryInfo(targetFullName);

            Directory.CreateDirectory(targetFullName);
            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", targetFullName, fi.Name);
                fi.CopyTo(Path.Combine(targetFullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    taRGETdir_info.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
        private static void CopyFilesRecursively(string sourcePath, string targetPath)
            {
                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                {
                System.IO.File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
            }

     
        private void unziptemp(string newPath, string DestinationPath)
        {
            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(newPath, DestinationPath);// extensions\System.IO.Compression.FileSystem

                MessageBox.Show("The file unzipped successfully in:"+ DestinationPath);
            }
            catch
            {
                MessageBox.Show("Change directory, Unzip will not ovelay exsisting files");

            }


        }

       
        private void DeleteDir(string Path)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path);//delete temp folder in C://....
            foreach (System.IO.FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (System.IO.DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
            System.IO.Directory.Delete(Path);
        }
    }
}
