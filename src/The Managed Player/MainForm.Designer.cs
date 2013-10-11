namespace Foo.App.ManagedPlayer
{
    partial class MainForm
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.lvSongs = new System.Windows.Forms.ListView();
            this.clhPlaying = new System.Windows.Forms.ColumnHeader();
            this.clhFilename = new System.Windows.Forms.ColumnHeader();
            this.tool = new System.Windows.Forms.Panel();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnRewind = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.tbPosition = new System.Windows.Forms.TrackBar();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.fileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.soundPlayer = new Foo.Media.SoundPlayer();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosition)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lvSongs);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tool);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(341, 443);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(341, 467);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "tscMain";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menu);
            // 
            // lvSongs
            // 
            this.lvSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhPlaying,
            this.clhFilename});
            this.lvSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSongs.FullRowSelect = true;
            this.lvSongs.Location = new System.Drawing.Point(0, 0);
            this.lvSongs.Name = "lvSongs";
            this.lvSongs.ShowGroups = false;
            this.lvSongs.Size = new System.Drawing.Size(341, 330);
            this.lvSongs.TabIndex = 1;
            this.lvSongs.UseCompatibleStateImageBehavior = false;
            this.lvSongs.View = System.Windows.Forms.View.Details;
            this.lvSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSongs_MouseDoubleClick);
            this.lvSongs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvSongs_KeyUp);
            // 
            // clhPlaying
            // 
            this.clhPlaying.Text = "";
            this.clhPlaying.Width = 20;
            // 
            // clhFilename
            // 
            this.clhFilename.Text = "Filename";
            this.clhFilename.Width = 307;
            // 
            // tool
            // 
            this.tool.Controls.Add(this.btnForward);
            this.tool.Controls.Add(this.btnRewind);
            this.tool.Controls.Add(this.btnPlayPause);
            this.tool.Controls.Add(this.tbPosition);
            this.tool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tool.Location = new System.Drawing.Point(0, 330);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(341, 113);
            this.tool.TabIndex = 0;
            // 
            // btnForward
            // 
            this.btnForward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForward.Location = new System.Drawing.Point(214, 54);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnRewind
            // 
            this.btnRewind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRewind.Location = new System.Drawing.Point(52, 54);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(75, 23);
            this.btnRewind.TabIndex = 2;
            this.btnRewind.Text = "Rewind";
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayPause.Location = new System.Drawing.Point(133, 43);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 45);
            this.btnPlayPause.TabIndex = 1;
            this.btnPlayPause.Text = "Play";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // tbPosition
            // 
            this.tbPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPosition.Location = new System.Drawing.Point(12, 6);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(317, 45);
            this.tbPosition.TabIndex = 0;
            this.tbPosition.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbPosition.Scroll += new System.EventHandler(this.tbPosition_Scroll);
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(341, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen,
            this.tsmAddFiles,
            this.tsmAddFolder,
            this.tsmRemove,
            this.toolStripMenuItem1,
            this.tsmExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmOpen
            // 
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(152, 22);
            this.tsmOpen.Text = "Open";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // tsmAddFiles
            // 
            this.tsmAddFiles.Name = "tsmAddFiles";
            this.tsmAddFiles.Size = new System.Drawing.Size(152, 22);
            this.tsmAddFiles.Text = "Add Files";
            this.tsmAddFiles.Click += new System.EventHandler(this.tsmAddFiles_Click);
            // 
            // tsmAddFolder
            // 
            this.tsmAddFolder.Name = "tsmAddFolder";
            this.tsmAddFolder.Size = new System.Drawing.Size(152, 22);
            this.tsmAddFolder.Text = "Add Folder";
            this.tsmAddFolder.Click += new System.EventHandler(this.tsmAddFolder_Click);
            // 
            // tsmRemove
            // 
            this.tsmRemove.Name = "tsmRemove";
            this.tsmRemove.Size = new System.Drawing.Size(152, 22);
            this.tsmRemove.Text = "Remove";
            this.tsmRemove.Click += new System.EventHandler(this.tsmRemove_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(152, 22);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // fileBrowser
            // 
            this.fileBrowser.Filter = "Music files (*.mp3,*.wma,*.wav)|*.mp3;*.wma;*.wav |All files (*.*)|*.*";
            this.fileBrowser.Multiselect = true;
            // 
            // soundPlayer
            // 
            this.soundPlayer.PositionChanged += new System.EventHandler(this.soundPlayer_PositionChanged);
            this.soundPlayer.StateChanged += new System.EventHandler(this.soundPlayer_StateChanged);
            this.soundPlayer.LengthChanged += new System.EventHandler(this.soundPlayer_LengthChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 467);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(349, 501);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Managed Player";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosition)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ListView lvSongs;
        private System.Windows.Forms.Panel tool;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.TrackBar tbPosition;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmAddFiles;
        private System.Windows.Forms.ToolStripMenuItem tsmAddFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.OpenFileDialog fileBrowser;
        private System.Windows.Forms.ToolStripMenuItem tsmRemove;
        private System.Windows.Forms.ColumnHeader clhPlaying;
        private System.Windows.Forms.ColumnHeader clhFilename;
        private Foo.Media.SoundPlayer soundPlayer;
    }
}

