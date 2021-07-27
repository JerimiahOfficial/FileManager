
namespace FileManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderDirectory = new System.Windows.Forms.TextBox();
            this.buttons = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFolderDialog = new FileManagerUI.FMButton();
            this.deleteDuplicates = new FileManagerUI.FMButton();
            this.renameAll = new FileManagerUI.FMButton();
            this.DeleteAll = new FileManagerUI.FMButton();
            this.folderOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.folderView = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.folderOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderDirectory
            // 
            this.folderDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.folderDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderDirectory.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderDirectory.ForeColor = System.Drawing.Color.White;
            this.folderDirectory.Location = new System.Drawing.Point(80, 5);
            this.folderDirectory.Name = "folderDirectory";
            this.folderDirectory.Size = new System.Drawing.Size(699, 21);
            this.folderDirectory.TabIndex = 1;
            // 
            // buttons
            // 
            this.buttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttons.ImageStream")));
            this.buttons.TransparentColor = System.Drawing.Color.Transparent;
            this.buttons.Images.SetKeyName(0, "icons8-trash-24.png");
            this.buttons.Images.SetKeyName(1, "icons8-design-24.png");
            this.buttons.Images.SetKeyName(2, "icons8-open-parcel-24.png");
            this.buttons.Images.SetKeyName(3, "icons8-clipboard-24.png");
            this.buttons.Images.SetKeyName(4, "icons8-search-24.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.folderDirectory);
            this.panel2.Controls.Add(this.openFolderDialog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(784, 30);
            this.panel2.TabIndex = 4;
            // 
            // openFolderDialog
            // 
            this.openFolderDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.openFolderDialog.Dock = System.Windows.Forms.DockStyle.Left;
            this.openFolderDialog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.openFolderDialog.FlatAppearance.BorderSize = 0;
            this.openFolderDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFolderDialog.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFolderDialog.Location = new System.Drawing.Point(5, 5);
            this.openFolderDialog.Name = "openFolderDialog";
            this.openFolderDialog.Size = new System.Drawing.Size(75, 20);
            this.openFolderDialog.TabIndex = 2;
            this.openFolderDialog.Text = "Open folder";
            this.openFolderDialog.UseVisualStyleBackColor = false;
            this.openFolderDialog.Click += new System.EventHandler(this.OpenFolder);
            // 
            // deleteDuplicates
            // 
            this.deleteDuplicates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.deleteDuplicates.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteDuplicates.FlatAppearance.BorderSize = 0;
            this.deleteDuplicates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDuplicates.Location = new System.Drawing.Point(5, 45);
            this.deleteDuplicates.Margin = new System.Windows.Forms.Padding(5);
            this.deleteDuplicates.Name = "deleteDuplicates";
            this.deleteDuplicates.Size = new System.Drawing.Size(190, 30);
            this.deleteDuplicates.TabIndex = 2;
            this.deleteDuplicates.Text = "Delete duplicates";
            this.deleteDuplicates.UseVisualStyleBackColor = false;
            this.deleteDuplicates.Click += new System.EventHandler(this.deleteDuplicates_Click);
            // 
            // renameAll
            // 
            this.renameAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.renameAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.renameAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.renameAll.FlatAppearance.BorderSize = 0;
            this.renameAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renameAll.Location = new System.Drawing.Point(5, 5);
            this.renameAll.Margin = new System.Windows.Forms.Padding(5);
            this.renameAll.Name = "renameAll";
            this.renameAll.Size = new System.Drawing.Size(190, 30);
            this.renameAll.TabIndex = 3;
            this.renameAll.Text = "Rename all";
            this.renameAll.UseVisualStyleBackColor = false;
            this.renameAll.Click += new System.EventHandler(this.RenameAll_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DeleteAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeleteAll.FlatAppearance.BorderSize = 0;
            this.DeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAll.Location = new System.Drawing.Point(5, 85);
            this.DeleteAll.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(190, 30);
            this.DeleteAll.TabIndex = 4;
            this.DeleteAll.Text = "Delete all";
            this.DeleteAll.UseVisualStyleBackColor = false;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // folderOptions
            // 
            this.folderOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.folderOptions.Controls.Add(this.renameAll);
            this.folderOptions.Controls.Add(this.deleteDuplicates);
            this.folderOptions.Controls.Add(this.DeleteAll);
            this.folderOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.folderOptions.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderOptions.Location = new System.Drawing.Point(584, 30);
            this.folderOptions.Name = "folderOptions";
            this.folderOptions.Size = new System.Drawing.Size(200, 531);
            this.folderOptions.TabIndex = 6;
            // 
            // folderView
            // 
            this.folderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderView.Location = new System.Drawing.Point(0, 30);
            this.folderView.Name = "folderView";
            this.folderView.Size = new System.Drawing.Size(584, 531);
            this.folderView.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.folderView);
            this.Controls.Add(this.folderOptions);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Manager";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.folderOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox folderDirectory;
        private System.Windows.Forms.ImageList buttons;
        private System.Windows.Forms.Panel panel2;
        private FileManagerUI.FMButton deleteDuplicates;
        private FileManagerUI.FMButton renameAll;
        private FileManagerUI.FMButton openFolderDialog;
        private FileManagerUI.FMButton DeleteAll;
        private System.Windows.Forms.FlowLayoutPanel folderOptions;
        private System.Windows.Forms.FlowLayoutPanel folderView;
    }
}

