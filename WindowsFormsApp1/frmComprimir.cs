using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class frmComprimir : Form
    {
        String LAname, LAnameT;
        string filepathname, directory;
        string filePath = string.Empty;
        string Destination;
        bool Flag = false;
        public frmComprimir()
        {
            InitializeComponent();
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlCabecera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = LAnameT;
                openFileDialog.Filter = "files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    rhtRutasarc.Text += filePath;
                    rhtRutasarc.Text += Environment.NewLine;

                    directory = System.IO.Path.GetDirectoryName(filePath);
                    if (directory != null && new DirectoryInfo(directory).FullName != new DirectoryInfo(directory).Root.FullName)
                    {
                        DirectoryInfo dir_info = new DirectoryInfo(directory);
                        string tempdir = dir_info.Name;
                        txtNombre.Text = tempdir;
                    }
                    else
                    {
                        txtRutaGuar.Text = directory;
                    }

                    Flag = true;
                }
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fd1 = new FolderBrowserDialog();
                if (fd1.ShowDialog() == DialogResult.OK)
                {

                    rhtRutasarc.Text += fd1.SelectedPath;
                    rhtRutasarc.Text += Environment.NewLine;
                    directory = fd1.SelectedPath;
                    if (directory != null && new DirectoryInfo(directory).FullName != new DirectoryInfo(directory).Root.FullName)
                    {
                        DirectoryInfo dir_info = new DirectoryInfo(directory);
                        string tempdir = dir_info.Name;
                        txtNombre.Text = tempdir;
                    }
                    else
                    {
                        directory = fd1.SelectedPath;
                        txtRutaGuar.Text = directory;
                    }

                    Flag = true;
                }
            }
            catch
            {

            }
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            rhtRutasarc.SelectedText = "";
            ReadLineTextBox();
        }
        private void DeleteaLine(int a_line)
        {
            int start_index = rhtRutasarc.GetFirstCharIndexFromLine(a_line);
            int count = rhtRutasarc.Lines[a_line].Length;
            if (a_line < rhtRutasarc.Lines.Length - 1)
            {
                count += rhtRutasarc.GetFirstCharIndexFromLine(a_line + 1) -
                    ((start_index + count - 1) + 1);
            }

            rhtRutasarc.Text = rhtRutasarc.Text.Remove(start_index, count);
        }
        private void ReadLineTextBox()
        {
            String[] lines = rhtRutasarc.Text.Split('\n');

            int line = lines.Length;
            if (line > 1)
            {
                for (int i = 0; i < line - 1; i++)
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

        private void rhtRutasarc_Enter(object sender, EventArgs e)
        {
            rhtRutasarc.ReadOnly = true;
        }

        private void rhtRutasarc_Leave(object sender, EventArgs e)
        {
            rhtRutasarc.ReadOnly = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cancelar el proceso?", "Cancelar compresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form menu = new frmMenu();
                menu.Show();
                this.Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
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

            String[] lines = rhtRutasarc.Text.Split('\n');

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
                            System.IO.File.Copy(lines[i], @"C:\\wetfetcet123\\" + lastFolderName + "\\" + Fname);
                        }
                    }
                }

                zipfilestoarchive("C:\\wetfetcet123\\" + lastFolderName, txtRutaGuar.Text);

            }
            if (System.IO.Directory.Exists("C:wetfetcet123\\" + lastFolderName))
            {

                DeleteDir(@"C:\\wetfetcet123\\" + lastFolderName);
            }
        }
        private void zipfilestoarchive(string startPath, string zipPath)
        {
            String ZipFname = txtNombre.Text;
            if (ZipFname == "")
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
                MessageBox.Show("Se a realizado la compresion de forma correcta en: " + zipPath + "\\" + ZipFname);
                Form menu = new frmMenu();
                menu.Show();
                this.Close();
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("El archivo " + ZipFname + " ya existe. Desea reemplazarlo?", "or No to Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        System.IO.Compression.ZipFile.ExtractToDirectory(zipPath + "\\" + ZipFname, startPath);
                        System.IO.File.Delete(zipPath + "\\" + ZipFname);
                        ZipFile.CreateFromDirectory(startPath, zipPath + "\\" + ZipFname);
                        MessageBox.Show("Se a realizado la compresion de forma correcta en: " + zipPath + "\\" + ZipFname);
                        Form menu = new frmMenu();
                        menu.Show();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("La compresion se ha realizado de forma exitosa");
                    }
                }
                else
                {
                    MessageBox.Show("Sucedio un fallo al momento de realizar la compresion");
                }
            }

            DeleteDir(startPath);
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
        private void rjButton3_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fd1 = new FolderBrowserDialog();
                if (fd1.ShowDialog() == DialogResult.OK)
                {
                    txtRutaGuar.Text = fd1.SelectedPath;
                    LAname = txtRutaGuar.Text;
                }
            }
            catch
            {
                MessageBox.Show("La ruta seleccionada no existe");
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            Form menu = new frmMenu();
            menu.Show();
            this.Close();
        }

    }
}
