namespace MediaPlayer
{
    partial class Music_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music_Player));
            this.PreviewButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.NextButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.StopButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PlayButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PauseButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.OpenFileButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TrackList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.PictureArt = new System.Windows.Forms.PictureBox();
            this.TrackVolume = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Volume = new System.Windows.Forms.Label();
            this.LabelVolume = new System.Windows.Forms.Label();
            this.ExitButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.StartMusicLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.EndMusicLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ProgressBarMusic = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArt)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(13, 444);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(109, 27);
            this.PreviewButton.TabIndex = 0;
            this.PreviewButton.Values.Text = "Prev";
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(128, 444);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(109, 27);
            this.NextButton.TabIndex = 1;
            this.NextButton.Values.Text = "Next";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(473, 444);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(126, 27);
            this.StopButton.TabIndex = 2;
            this.StopButton.Values.Text = "Stop";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(243, 444);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(109, 27);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Values.Text = "Play";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(358, 444);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(109, 27);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Values.Text = "Pause";
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(605, 444);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(223, 27);
            this.OpenFileButton.TabIndex = 5;
            this.OpenFileButton.Values.Text = "Open";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // TrackList
            // 
            this.TrackList.Location = new System.Drawing.Point(269, 172);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(622, 225);
            this.TrackList.TabIndex = 7;
            this.TrackList.SelectedIndexChanged += new System.EventHandler(this.TrackList_SelectedIndexChanged);
            // 
            // PictureArt
            // 
            this.PictureArt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PictureArt.Image = ((System.Drawing.Image)(resources.GetObject("PictureArt.Image")));
            this.PictureArt.Location = new System.Drawing.Point(13, 172);
            this.PictureArt.Name = "PictureArt";
            this.PictureArt.Size = new System.Drawing.Size(225, 225);
            this.PictureArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureArt.TabIndex = 8;
            this.PictureArt.TabStop = false;
            // 
            // TrackVolume
            // 
            this.TrackVolume.DrawBackground = true;
            this.TrackVolume.Location = new System.Drawing.Point(905, 188);
            this.TrackVolume.Maximum = 100;
            this.TrackVolume.Name = "TrackVolume";
            this.TrackVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackVolume.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.TrackVolume.Size = new System.Drawing.Size(27, 193);
            this.TrackVolume.TabIndex = 10;
            this.TrackVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackVolume.ValueChanged += new System.EventHandler(this.TrackVolume_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAppToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutAppToolStripMenuItem
            // 
            this.aboutAppToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.aboutAppToolStripMenuItem.Name = "aboutAppToolStripMenuItem";
            this.aboutAppToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.aboutAppToolStripMenuItem.Text = "About app";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Volume.Location = new System.Drawing.Point(898, 384);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(48, 13);
            this.Volume.TabIndex = 13;
            this.Volume.Text = "Volume";
            // 
            // LabelVolume
            // 
            this.LabelVolume.AutoSize = true;
            this.LabelVolume.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVolume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelVolume.Location = new System.Drawing.Point(902, 172);
            this.LabelVolume.Name = "LabelVolume";
            this.LabelVolume.Size = new System.Drawing.Size(37, 13);
            this.LabelVolume.TabIndex = 14;
            this.LabelVolume.Text = "100%";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(835, 444);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(111, 25);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Values.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // waveViewer1
            // 
            this.waveViewer1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.waveViewer1.Location = new System.Drawing.Point(128, 27);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 128;
            this.waveViewer1.Size = new System.Drawing.Size(700, 136);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 17;
            this.waveViewer1.WaveStream = null;
            // 
            // StartMusicLabel
            // 
            this.StartMusicLabel.Location = new System.Drawing.Point(51, 91);
            this.StartMusicLabel.Name = "StartMusicLabel";
            this.StartMusicLabel.Size = new System.Drawing.Size(40, 20);
            this.StartMusicLabel.TabIndex = 19;
            this.StartMusicLabel.Values.Text = "00:00";
            // 
            // EndMusicLabel
            // 
            this.EndMusicLabel.Location = new System.Drawing.Point(852, 91);
            this.EndMusicLabel.Name = "EndMusicLabel";
            this.EndMusicLabel.Size = new System.Drawing.Size(40, 20);
            this.EndMusicLabel.TabIndex = 20;
            this.EndMusicLabel.Values.Text = "00:00";
            // 
            // ProgressBarMusic
            // 
            this.ProgressBarMusic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ProgressBarMusic.Location = new System.Drawing.Point(13, 423);
            this.ProgressBarMusic.Name = "ProgressBarMusic";
            this.ProgressBarMusic.Size = new System.Drawing.Size(933, 15);
            this.ProgressBarMusic.TabIndex = 21;
            // 
            // Music_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(958, 483);
            this.Controls.Add(this.ProgressBarMusic);
            this.Controls.Add(this.EndMusicLabel);
            this.Controls.Add(this.StartMusicLabel);
            this.Controls.Add(this.waveViewer1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LabelVolume);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.TrackVolume);
            this.Controls.Add(this.PictureArt);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Music_Player";
            this.Text = "Music Player Project ";
            ((System.ComponentModel.ISupportInitialize)(this.PictureArt)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton PreviewButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton NextButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton StopButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton PlayButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton PauseButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton OpenFileButton;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox TrackList;
        private System.Windows.Forms.PictureBox PictureArt;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar TrackVolume;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label LabelVolume;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ExitButton;
        private NAudio.Gui.WaveViewer waveViewer1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel StartMusicLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel EndMusicLabel;
        private System.Windows.Forms.ProgressBar ProgressBarMusic;
    }
}

