
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleBarIcon = new System.Windows.Forms.PictureBox();
            this.TitleBarLabel = new System.Windows.Forms.Label();
            this.TitleBarClose = new FileManagerUI.FMButton();
            this.TitleBarWindowState = new FileManagerUI.FMButton();
            this.TitleBarMinimize = new FileManagerUI.FMButton();
            this.panel2.SuspendLayout();
            this.folderOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBarIcon)).BeginInit();
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
            this.folderDirectory.Size = new System.Drawing.Size(697, 21);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.folderDirectory);
            this.panel2.Controls.Add(this.openFolderDialog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 31);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(782, 30);
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
            this.folderOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.folderOptions.Controls.Add(this.renameAll);
            this.folderOptions.Controls.Add(this.deleteDuplicates);
            this.folderOptions.Controls.Add(this.DeleteAll);
            this.folderOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.folderOptions.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderOptions.Location = new System.Drawing.Point(583, 61);
            this.folderOptions.Name = "folderOptions";
            this.folderOptions.Size = new System.Drawing.Size(200, 499);
            this.folderOptions.TabIndex = 6;
            // 
            // folderView
            // 
            this.folderView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.folderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderView.Location = new System.Drawing.Point(1, 61);
            this.folderView.Name = "folderView";
            this.folderView.Size = new System.Drawing.Size(582, 499);
            this.folderView.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.TitleBarMinimize);
            this.panel1.Controls.Add(this.TitleBarWindowState);
            this.panel1.Controls.Add(this.TitleBarClose);
            this.panel1.Controls.Add(this.TitleBarLabel);
            this.panel1.Controls.Add(this.TitleBarIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 30);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragStart);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragStop);
            // 
            // TitleBarIcon
            // 
            this.TitleBarIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleBarIcon.Image = ((System.Drawing.Image)(resources.GetObject("TitleBarIcon.Image")));
            this.TitleBarIcon.Location = new System.Drawing.Point(0, 0);
            this.TitleBarIcon.Name = "TitleBarIcon";
            this.TitleBarIcon.Size = new System.Drawing.Size(30, 30);
            this.TitleBarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TitleBarIcon.TabIndex = 0;
            this.TitleBarIcon.TabStop = false;
            // 
            // TitleBarLabel
            // 
            this.TitleBarLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleBarLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBarLabel.Location = new System.Drawing.Point(30, 0);
            this.TitleBarLabel.Name = "TitleBarLabel";
            this.TitleBarLabel.Size = new System.Drawing.Size(75, 30);
            this.TitleBarLabel.TabIndex = 1;
            this.TitleBarLabel.Text = "File Manager";
            this.TitleBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TitleBarClose
            // 
            this.TitleBarClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.TitleBarClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TitleBarClose.FlatAppearance.BorderSize = 0;
            this.TitleBarClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBarClose.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TitleBarClose.Location = new System.Drawing.Point(752, 0);
            this.TitleBarClose.Name = "TitleBarClose";
            this.TitleBarClose.Size = new System.Drawing.Size(30, 30);
            this.TitleBarClose.TabIndex = 2;
            this.TitleBarClose.Tag = "0";
            this.TitleBarClose.Text = "r";
            this.TitleBarClose.UseVisualStyleBackColor = true;
            this.TitleBarClose.Click += new System.EventHandler(this.TitleBarOptions);
            // 
            // TitleBarWindowState
            // 
            this.TitleBarWindowState.Dock = System.Windows.Forms.DockStyle.Right;
            this.TitleBarWindowState.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TitleBarWindowState.FlatAppearance.BorderSize = 0;
            this.TitleBarWindowState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBarWindowState.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TitleBarWindowState.Location = new System.Drawing.Point(722, 0);
            this.TitleBarWindowState.Name = "TitleBarWindowState";
            this.TitleBarWindowState.Size = new System.Drawing.Size(30, 30);
            this.TitleBarWindowState.TabIndex = 3;
            this.TitleBarWindowState.Tag = "1";
            this.TitleBarWindowState.Text = "1";
            this.TitleBarWindowState.UseVisualStyleBackColor = true;
            this.TitleBarWindowState.Click += new System.EventHandler(this.TitleBarOptions);
            // 
            // TitleBarMinimize
            // 
            this.TitleBarMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.TitleBarMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TitleBarMinimize.FlatAppearance.BorderSize = 0;
            this.TitleBarMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBarMinimize.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TitleBarMinimize.Location = new System.Drawing.Point(692, 0);
            this.TitleBarMinimize.Name = "TitleBarMinimize";
            this.TitleBarMinimize.Size = new System.Drawing.Size(30, 30);
            this.TitleBarMinimize.TabIndex = 4;
            this.TitleBarMinimize.Tag = "2";
            this.TitleBarMinimize.Text = "0";
            this.TitleBarMinimize.UseVisualStyleBackColor = true;
            this.TitleBarMinimize.Click += new System.EventHandler(this.TitleBarOptions);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.folderView);
            this.Controls.Add(this.folderOptions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Manager";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.folderOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitleBarIcon)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox TitleBarIcon;
        private System.Windows.Forms.Label TitleBarLabel;
        private FileManagerUI.FMButton TitleBarClose;
        private FileManagerUI.FMButton TitleBarMinimize;
        private FileManagerUI.FMButton TitleBarWindowState;
    }
}

