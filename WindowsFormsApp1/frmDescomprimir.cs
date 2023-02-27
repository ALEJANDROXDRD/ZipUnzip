using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO.Compression;
namespace WindowsFormsApp1
{
    public partial class frmDescomprimir : Form
    {
        String LAname, LAnameT;
        string filepathname, directory;
        string filePath = string.Empty;
        string Destination;
        bool Flag = false;
        public frmDescomprimir()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRutaArchivo_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtRutaGuar.Text=="")
            {
                MessageBox.Show("Seleccione una ruta de guardado");
                txtRutaGuar.Focus();
            }
            else if(txtRutaArchivo.Text=="")
            {
                MessageBox.Show("Seleccione una archivo que desee descromprimir");
                txtRutaArchivo.Focus();
            }
            else if (txtRutaArchivo.Text=="" && txtRutaGuar.Text=="")
            {
                MessageBox.Show("Porfavor rellene los campos solicitados");
            }
            else 
            { 
            Destination = txtRutaGuar.Text;
            bool exists = System.IO.Directory.Exists(Destination);

            if (!exists)
                System.IO.Directory.CreateDirectory(Destination);

            unziptemp(filepathname, Destination);

            }
        }
        private void unziptemp(string newPath, string DestinationPath)
        {
            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(newPath, DestinationPath);

                MessageBox.Show("El archivo se a descomprimido correctamente en:" + DestinationPath);
                Form menu = new frmMenu();
                menu.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Seleccione una ruta para guardar la descompresion");

            }


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

        private void rjButton1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = LAname;
                openFileDialog.Filter = "zip files (*.zip)|*.zip";//|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    directory = System.IO.Path.GetDirectoryName(filePath);
                }
            }
            string nameFile = (Path.GetFileNameWithoutExtension(filePath));
            txtRutaArchivo.Text = directory + "\\" + nameFile; ;
            filepathname = filePath;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cancelar el proceso?","Cancelar descompresion",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Form menu = new frmMenu();
                menu.Show();
                this.Close();
            }
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
