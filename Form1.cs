using NAudio.Wave;
using NAudio.Wave.SampleProviders;
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


namespace MediaPlayer
{
    public partial class Music_Player : Form
    {
        List<string> paths = new List<string>();
        List<string> files = new List<string>();
        private WaveOutEvent outputDevice = new WaveOutEvent();
        private AudioFileReader audioFile;
        public Music_Player()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Stop();
            }

            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }

            if (outputDevice != null)
            {
                outputDevice.Dispose();
                outputDevice = null;
            }

            Application.Exit();
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    files.Add(file);
                    paths.Add(file);
                    TrackList.Items.Add(file);
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
            PlaySelectedTrack();
        }
        private void PlaySelectedTrack()
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
            }

            if (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Stop();
            }

            if (TrackList.SelectedIndex >= 0 && TrackList.SelectedIndex < paths.Count)
            {
                if (audioFile != null)
                {
                    audioFile.Dispose();
                }

                audioFile = new AudioFileReader(paths[TrackList.SelectedIndex]);
                audioFile.Position = 0;
                outputDevice.Init(audioFile);
                outputDevice.Play();
            }
        }
        private void NextButton_Click(object sender, EventArgs e)
        {

            if (TrackList.SelectedIndex < TrackList.Items.Count - 1)
            {
                TrackList.SelectedIndex++;
                PlaySelectedTrack();
            }
            else
            {
                TrackList.SelectedIndex = 0;
                PlaySelectedTrack();
            }
        }
        private void PreviewButton_Click(object sender, EventArgs e)
        {
            if (TrackList.SelectedIndex > 0)
            {
                TrackList.SelectedIndex--;
                PlaySelectedTrack();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
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
