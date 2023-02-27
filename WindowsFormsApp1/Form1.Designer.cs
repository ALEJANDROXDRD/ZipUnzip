
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenF = new System.Windows.Forms.Button();
            this.Directory1 = new System.Windows.Forms.TextBox();
            this.Unzip = new System.Windows.Forms.Button();
            this.OpenDir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddFile = new System.Windows.Forms.Button();
            this.AddFolder = new System.Windows.Forms.Button();
            this.Zip = new System.Windows.Forms.Button();
            this.SaveDir = new System.Windows.Forms.Button();
            this.Directory2 = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Zipfilename = new System.Windows.Forms.TextBox();
            this.ListFiles = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenF
            // 
            this.OpenF.Location = new System.Drawing.Point(148, 85);
            this.OpenF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenF.Name = "OpenF";
            this.OpenF.Size = new System.Drawing.Size(100, 28);
            this.OpenF.TabIndex = 0;
            this.OpenF.Text = "OpenFile";
            this.OpenF.UseVisualStyleBackColor = true;
            this.OpenF.Click += new System.EventHandler(this.OpenF_Click);
            // 
            // Directory1
            // 
            this.Directory1.Location = new System.Drawing.Point(39, 44);
            this.Directory1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Directory1.Name = "Directory1";
            this.Directory1.Size = new System.Drawing.Size(796, 22);
            this.Directory1.TabIndex = 1;
            // 
            // Unzip
            // 
            this.Unzip.Location = new System.Drawing.Point(275, 85);
            this.Unzip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Unzip.Name = "Unzip";
            this.Unzip.Size = new System.Drawing.Size(100, 28);
            this.Unzip.TabIndex = 2;
            this.Unzip.Text = "Unzip";
            this.Unzip.UseVisualStyleBackColor = true;
            this.Unzip.Click += new System.EventHandler(this.Unzip_Click);
            // 
            // OpenDir
            // 
            this.OpenDir.Location = new System.Drawing.Point(735, 10);
            this.OpenDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenDir.Name = "OpenDir";
            this.OpenDir.Size = new System.Drawing.Size(101, 27);
            this.OpenDir.TabIndex = 3;
            this.OpenDir.Text = "....";
            this.OpenDir.UseVisualStyleBackColor = true;
            this.OpenDir.Click += new System.EventHandler(this.OpenDir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.sign100;
            this.pictureBox1.Location = new System.Drawing.Point(701, 372);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 102);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AddFile
            // 
            this.AddFile.Location = new System.Drawing.Point(149, 396);
            this.AddFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(100, 28);
            this.AddFile.TabIndex = 6;
            this.AddFile.Text = "Add File";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // AddFolder
            // 
            this.AddFolder.Location = new System.Drawing.Point(257, 396);
            this.AddFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddFolder.Name = "AddFolder";
            this.AddFolder.Size = new System.Drawing.Size(100, 28);
            this.AddFolder.TabIndex = 7;
            this.AddFolder.Text = "AddFolder";
            this.AddFolder.UseVisualStyleBackColor = true;
            this.AddFolder.Click += new System.EventHandler(this.AddFolder_Click);
            // 
            // Zip
            // 
            this.Zip.Location = new System.Drawing.Point(149, 432);
            this.Zip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(100, 28);
            this.Zip.TabIndex = 8;
            this.Zip.Text = "Zip";
            this.Zip.UseVisualStyleBackColor = true;
            this.Zip.Click += new System.EventHandler(this.Zip_Click);
            // 
            // SaveDir
            // 
            this.SaveDir.Location = new System.Drawing.Point(736, 4);
            this.SaveDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveDir.Name = "SaveDir";
            this.SaveDir.Size = new System.Drawing.Size(101, 27);
            this.SaveDir.TabIndex = 10;
            this.SaveDir.Text = "....";
            this.SaveDir.UseVisualStyleBackColor = true;
            this.SaveDir.Click += new System.EventHandler(this.SaveDir_Click);
            // 
            // Directory2
            // 
            this.Directory2.Location = new System.Drawing.Point(40, 34);
            this.Directory2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Directory2.Name = "Directory2";
            this.Directory2.Size = new System.Drawing.Size(796, 22);
            this.Directory2.TabIndex = 9;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(365, 396);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 28);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Directory to UnZip Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Directory to Save Zip File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Zip Filename";
            // 
            // Zipfilename
            // 
            this.Zipfilename.Location = new System.Drawing.Point(257, 434);
            this.Zipfilename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Zipfilename.Name = "Zipfilename";
            this.Zipfilename.Size = new System.Drawing.Size(319, 22);
            this.Zipfilename.TabIndex = 18;
            // 
            // ListFiles
            // 
            this.ListFiles.EnableAutoDragDrop = true;
            this.ListFiles.Location = new System.Drawing.Point(40, 66);
            this.ListFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(796, 304);
            this.ListFiles.TabIndex = 13;
            this.ListFiles.Text = "";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.Zipfilename);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SaveDir);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Zip);
            this.panel1.Controls.Add(this.Directory2);
            this.panel1.Controls.Add(this.AddFolder);
            this.panel1.Controls.Add(this.ListFiles);
            this.panel1.Controls.Add(this.AddFile);
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 497);
            this.panel1.TabIndex = 19;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel2.Controls.Add(this.OpenF);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.OpenDir);
            this.panel2.Controls.Add(this.Unzip);
            this.panel2.Controls.Add(this.Directory1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 153);
            this.panel2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "ZipUnzip";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenF;
        private System.Windows.Forms.TextBox Directory1;
        private System.Windows.Forms.Button Unzip;
        private System.Windows.Forms.Button OpenDir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddFile;
        private System.Windows.Forms.Button AddFolder;
        private System.Windows.Forms.Button Zip;
        private System.Windows.Forms.Button SaveDir;
        private System.Windows.Forms.TextBox Directory2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Zipfilename;
        private System.Windows.Forms.RichTextBox ListFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

