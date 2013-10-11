using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using Foo.Media;

namespace Foo.App.ManagedPlayer
{
    public partial class MainForm : Form
    {
        ListViewItem song;
    
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddSongs(String[] fileNames)
        {
            foreach (String fileName in fileNames)
            {
                ListViewItem newItem = new ListViewItem();
                newItem.SubItems.Add(Path.GetFileName(fileName));
                newItem.Tag = fileName;
                lvSongs.Items.Add(newItem);
            }
        }
        
        private void tsmOpen_Click(object sender, EventArgs e)
        {
            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                removeSongs(false);
                AddSongs(fileBrowser.FileNames);
                PlaySongAt(0);
            }
        }

        private void PlaySongAt(int index)
        {
            if(index > lvSongs.Items.Count - 1) return;
            if(song!=null)song.Text="";
            song = lvSongs.Items[index];
            soundPlayer.Open((string)song.Tag);
            soundPlayer.Play();
            song.Text = ">";
        }

        private void lvSongs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lvSongs.SelectedIndices.Count != 0) PlaySongAt(lvSongs.SelectedIndices[0]);
        }

        private void tsmAddFiles_Click(object sender, EventArgs e)
        {
            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                AddSongs(fileBrowser.FileNames);
            }    
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if(lvSongs.Items.Count!=0)
                if (soundPlayer.IsOpen)
                {
                    if (soundPlayer.State != PlayBackState.Play) 
                        soundPlayer.Play();
                    else
                        soundPlayer.Pause();
                }
                else
                {
                    if (lvSongs.SelectedIndices.Count != 0) 
                        PlaySongAt(lvSongs.SelectedIndices[0]);
                }     
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void soundPlayer_LengthChanged(object sender, EventArgs e)
        {
            tbPosition.Maximum = soundPlayer.Length;
        }

        private void soundPlayer_PositionChanged(object sender, EventArgs e)
        {
            tbPosition.Value = soundPlayer.Position;
        }

        private void soundPlayer_StateChanged(object sender, EventArgs e)
        {
           btnPlayPause.Text = (soundPlayer.State != PlayBackState.Play) ? "Play" : "Pause";
        }

        private void tbPosition_Scroll(object sender, EventArgs e)
        {
            soundPlayer.Seek(tbPosition.Value);
        }

        private void tsmRemove_Click(object sender, EventArgs e)
        {
            removeSongs(true);
        }

        private void removeSongs(bool selected)
        {
         if(selected)
             foreach (ListViewItem item in lvSongs.SelectedItems)
            {
                if (item == song) soundPlayer.Close();
                lvSongs.Items.Remove(item);
            }
          else
            foreach (ListViewItem item in lvSongs.Items)
            {
                if (item == song) soundPlayer.Close();
                lvSongs.Items.Remove(item);
            }
        }

        private void tsmAddFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                String[] supportedExtensions = { "*.wma", "*.wav", "*.mp3" };
                List<String> fileNames = new List<String>();
                foreach (string ext in supportedExtensions)
                    fileNames.AddRange(Directory.GetFiles(folderBrowser.SelectedPath, ext));
                AddSongs(fileNames.ToArray());
            }
        }

        private void lvSongs_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) removeSongs(true);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if(song!=null)
            {
                int index = song.Index;
                if(index==lvSongs.Items.Count-1)
                    index=0;
                else
                    index++;
                if(soundPlayer.State == PlayBackState.Play)PlaySongAt(index);
            }
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            if(song!=null)
            {
                int index = song.Index;
                if (index == 0)
                    index = lvSongs.Items.Count - 1;
                else
                    index--;
                if (soundPlayer.State == PlayBackState.Play) PlaySongAt(index);
            }
        }
    }
}
