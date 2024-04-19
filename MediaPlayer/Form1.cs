using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Music_Player : Form
    {
        string[] paths, files;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        public Music_Player()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for(int i = 0; i < files.Length; i++)
                {
                    TrackList.Items.Add(files[i]);
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Stop();
                if (audioFile != null)
                {
                    audioFile.Position = 0;
                }
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                if (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    outputDevice.Pause();
                }
                else if (outputDevice.PlaybackState == PlaybackState.Paused)
                {
                    outputDevice.Play();
                }
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if(TrackList.SelectedItem != null)
            {
                if(outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                }
                int selectedIndex = TrackList.SelectedIndex;
                if(audioFile != null)
                {
                    audioFile.Dispose();
                }
                audioFile = new AudioFileReader(paths[selectedIndex]);
                audioFile.Position = 0;
                audioFile.Volume = 1;
                outputDevice.Init(audioFile);
                outputDevice.Play();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TrackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TrackVolume_ValueChanged(object sender, EventArgs e)
        {
            if (outputDevice != null && audioFile != null)
            {
                float volume = (float)TrackVolume.Value / 100.0f;
                audioFile.Volume = volume;
            }
        }
    }
}
