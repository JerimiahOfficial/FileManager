
namespace FileManagerUI
{
    partial class file
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(file));
            this.FileName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Location = new FileManagerUI.FMButton();
            this.Open = new FileManagerUI.FMButton();
            this.Rename = new FileManagerUI.FMButton();
            this.Copy = new FileManagerUI.FMButton();
            this.Delete = new FileManagerUI.FMButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileName
            // 
            this.FileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.FileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileName.Location = new System.Drawing.Point(0, 0);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(300, 30);
            this.FileName.TabIndex = 0;
            this.FileName.Text = "Filename";
            this.FileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FileName);
            this.panel1.Controls.Add(this.Location);
            this.panel1.Controls.Add(this.Open);
            this.panel1.Controls.Add(this.Rename);
            this.panel1.Controls.Add(this.Copy);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 30);
            this.panel1.TabIndex = 6;
            // 
            // Location
            // 
            this.Location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Location.Dock = System.Windows.Forms.DockStyle.Right;
            this.Location.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Location.FlatAppearance.BorderSize = 0;
            this.Location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Location.Image = ((System.Drawing.Image)(resources.GetObject("Location.Image")));
            this.Location.Location = new System.Drawing.Point(300, 0);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(30, 30);
            this.Location.TabIndex = 1;
            this.Location.UseVisualStyleBackColor = false;
            this.Location.Click += new System.EventHandler(this.Location_Click);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Open.Dock = System.Windows.Forms.DockStyle.Right;
            this.Open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Open.FlatAppearance.BorderSize = 0;
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.Location = new System.Drawing.Point(330, 0);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(30, 30);
            this.Open.TabIndex = 2;
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Rename
            // 
            this.Rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Rename.Dock = System.Windows.Forms.DockStyle.Right;
            this.Rename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Rename.FlatAppearance.BorderSize = 0;
            this.Rename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rename.Image = ((System.Drawing.Image)(resources.GetObject("Rename.Image")));
            this.Rename.Location = new System.Drawing.Point(360, 0);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(30, 30);
            this.Rename.TabIndex = 3;
            this.Rename.UseVisualStyleBackColor = false;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Copy.Dock = System.Windows.Forms.DockStyle.Right;
            this.Copy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Copy.FlatAppearance.BorderSize = 0;
            this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy.Image = ((System.Drawing.Image)(resources.GetObject("Copy.Image")));
            this.Copy.Location = new System.Drawing.Point(390, 0);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(30, 30);
            this.Copy.TabIndex = 4;
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Location = new System.Drawing.Point(420, 0);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(30, 30);
            this.Delete.TabIndex = 5;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // file
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "file";
            this.Size = new System.Drawing.Size(450, 30);
            this.Load += new System.EventHandler(this.file_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FileName;
        private FMButton Location;
        private FMButton Open;
        private FMButton Rename;
        private FMButton Copy;
        private FMButton Delete;
        private System.Windows.Forms.Panel panel1;
    }
}
