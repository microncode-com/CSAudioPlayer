namespace CSAudioPlayerExample
{
    partial class frmAudioPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAudioPlayer));
            this.cmdPlay = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.trckPlayerPosition = new System.Windows.Forms.TrackBar();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.cmdID3Tags = new System.Windows.Forms.Button();
            this.lblMediaFile = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tmrMeterOut = new System.Windows.Forms.Timer(this.components);
            this.lblMeterOut = new System.Windows.Forms.Label();
            this.cboPlayerChannels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBits = new System.Windows.Forms.Label();
            this.cboPlayerBits = new System.Windows.Forms.ComboBox();
            this.lblSamplerate = new System.Windows.Forms.Label();
            this.cboPlayerSamplerate = new System.Windows.Forms.ComboBox();
            this.lblPlayerMode = new System.Windows.Forms.Label();
            this.cboPlayerMode = new System.Windows.Forms.ComboBox();
            this.lblAudioDevice = new System.Windows.Forms.Label();
            this.cboPlayerAudioDevice = new System.Windows.Forms.ComboBox();
            this.lblPositionCurrent = new System.Windows.Forms.Label();
            this.lblPositionTotal = new System.Windows.Forms.Label();
            this.tmrPlayerPosition = new System.Windows.Forms.Timer(this.components);
            this.cmdPause = new System.Windows.Forms.Button();
            this.cmdResume = new System.Windows.Forms.Button();
            this.trckVolume = new System.Windows.Forms.TrackBar();
            this.lblDecodeMode = new System.Windows.Forms.Label();
            this.cboPlayerDecodeMode = new System.Windows.Forms.ComboBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.cmdCheckLicense = new System.Windows.Forms.Button();
            this.audioPlayer1 = new CSAudioPlayer.AudioPlayer();
            this.audioVisualization1 = new CSAudioPlayer.AudioVisualization();
            this.audioMeter1 = new CSAudioPlayer.AudioMeter();
            ((System.ComponentModel.ISupportInitialize)(this.trckPlayerPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(96, 621);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(61, 23);
            this.cmdPlay.TabIndex = 1;
            this.cmdPlay.Text = "Play";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(301, 621);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(62, 23);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // trckPlayerPosition
            // 
            this.trckPlayerPosition.Location = new System.Drawing.Point(17, 522);
            this.trckPlayerPosition.Name = "trckPlayerPosition";
            this.trckPlayerPosition.Size = new System.Drawing.Size(609, 45);
            this.trckPlayerPosition.TabIndex = 3;
            this.trckPlayerPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trckPlayerPosition_MouseDown);
            this.trckPlayerPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trckPlayerPosition_MouseUp);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(27, 621);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(63, 23);
            this.cmdOpen.TabIndex = 4;
            this.cmdOpen.Text = "Open";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cmdID3Tags
            // 
            this.cmdID3Tags.Location = new System.Drawing.Point(369, 621);
            this.cmdID3Tags.Name = "cmdID3Tags";
            this.cmdID3Tags.Size = new System.Drawing.Size(101, 23);
            this.cmdID3Tags.TabIndex = 39;
            this.cmdID3Tags.Text = "ID3 Tags Editor";
            this.cmdID3Tags.UseVisualStyleBackColor = true;
            this.cmdID3Tags.Click += new System.EventHandler(this.cmdID3Tags_Click);
            // 
            // lblMediaFile
            // 
            this.lblMediaFile.Location = new System.Drawing.Point(24, 570);
            this.lblMediaFile.Name = "lblMediaFile";
            this.lblMediaFile.Size = new System.Drawing.Size(602, 36);
            this.lblMediaFile.TabIndex = 40;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tmrMeterOut
            // 
            this.tmrMeterOut.Tick += new System.EventHandler(this.tmrMeterOut_Tick);
            // 
            // lblMeterOut
            // 
            this.lblMeterOut.AutoSize = true;
            this.lblMeterOut.Location = new System.Drawing.Point(586, 17);
            this.lblMeterOut.Name = "lblMeterOut";
            this.lblMeterOut.Size = new System.Drawing.Size(28, 13);
            this.lblMeterOut.TabIndex = 43;
            this.lblMeterOut.Text = "0.00";
            // 
            // cboPlayerChannels
            // 
            this.cboPlayerChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerChannels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlayerChannels.FormattingEnabled = true;
            this.cboPlayerChannels.Location = new System.Drawing.Point(535, 433);
            this.cboPlayerChannels.Name = "cboPlayerChannels";
            this.cboPlayerChannels.Size = new System.Drawing.Size(91, 21);
            this.cboPlayerChannels.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Channels";
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Location = new System.Drawing.Point(435, 417);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(49, 13);
            this.lblBits.TabIndex = 49;
            this.lblBits.Text = "Bit depth";
            // 
            // cboPlayerBits
            // 
            this.cboPlayerBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlayerBits.FormattingEnabled = true;
            this.cboPlayerBits.Location = new System.Drawing.Point(438, 433);
            this.cboPlayerBits.Name = "cboPlayerBits";
            this.cboPlayerBits.Size = new System.Drawing.Size(91, 21);
            this.cboPlayerBits.TabIndex = 48;
            // 
            // lblSamplerate
            // 
            this.lblSamplerate.AutoSize = true;
            this.lblSamplerate.Location = new System.Drawing.Point(338, 417);
            this.lblSamplerate.Name = "lblSamplerate";
            this.lblSamplerate.Size = new System.Drawing.Size(60, 13);
            this.lblSamplerate.TabIndex = 47;
            this.lblSamplerate.Text = "Samplerate";
            // 
            // cboPlayerSamplerate
            // 
            this.cboPlayerSamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerSamplerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlayerSamplerate.FormattingEnabled = true;
            this.cboPlayerSamplerate.Location = new System.Drawing.Point(341, 433);
            this.cboPlayerSamplerate.Name = "cboPlayerSamplerate";
            this.cboPlayerSamplerate.Size = new System.Drawing.Size(91, 21);
            this.cboPlayerSamplerate.TabIndex = 46;
            // 
            // lblPlayerMode
            // 
            this.lblPlayerMode.AutoSize = true;
            this.lblPlayerMode.Location = new System.Drawing.Point(24, 355);
            this.lblPlayerMode.Name = "lblPlayerMode";
            this.lblPlayerMode.Size = new System.Drawing.Size(66, 13);
            this.lblPlayerMode.TabIndex = 53;
            this.lblPlayerMode.Text = "Player Mode";
            // 
            // cboPlayerMode
            // 
            this.cboPlayerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlayerMode.FormattingEnabled = true;
            this.cboPlayerMode.Location = new System.Drawing.Point(27, 371);
            this.cboPlayerMode.Name = "cboPlayerMode";
            this.cboPlayerMode.Size = new System.Drawing.Size(308, 21);
            this.cboPlayerMode.TabIndex = 52;
            this.cboPlayerMode.SelectedIndexChanged += new System.EventHandler(this.cboPlayerMode_SelectedIndexChanged);
            // 
            // lblAudioDevice
            // 
            this.lblAudioDevice.AutoSize = true;
            this.lblAudioDevice.Location = new System.Drawing.Point(24, 417);
            this.lblAudioDevice.Name = "lblAudioDevice";
            this.lblAudioDevice.Size = new System.Drawing.Size(71, 13);
            this.lblAudioDevice.TabIndex = 55;
            this.lblAudioDevice.Text = "Audio Device";
            // 
            // cboPlayerAudioDevice
            // 
            this.cboPlayerAudioDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerAudioDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlayerAudioDevice.FormattingEnabled = true;
            this.cboPlayerAudioDevice.Location = new System.Drawing.Point(27, 433);
            this.cboPlayerAudioDevice.Name = "cboPlayerAudioDevice";
            this.cboPlayerAudioDevice.Size = new System.Drawing.Size(308, 21);
            this.cboPlayerAudioDevice.TabIndex = 54;
            // 
            // lblPositionCurrent
            // 
            this.lblPositionCurrent.AutoSize = true;
            this.lblPositionCurrent.Location = new System.Drawing.Point(24, 493);
            this.lblPositionCurrent.Name = "lblPositionCurrent";
            this.lblPositionCurrent.Size = new System.Drawing.Size(49, 13);
            this.lblPositionCurrent.TabIndex = 56;
            this.lblPositionCurrent.Text = "00:00:00";
            // 
            // lblPositionTotal
            // 
            this.lblPositionTotal.AutoSize = true;
            this.lblPositionTotal.Location = new System.Drawing.Point(566, 493);
            this.lblPositionTotal.Name = "lblPositionTotal";
            this.lblPositionTotal.Size = new System.Drawing.Size(49, 13);
            this.lblPositionTotal.TabIndex = 57;
            this.lblPositionTotal.Text = "00:00:00";
            // 
            // tmrPlayerPosition
            // 
            this.tmrPlayerPosition.Tick += new System.EventHandler(this.tmrPlayerPosition_Tick);
            // 
            // cmdPause
            // 
            this.cmdPause.Location = new System.Drawing.Point(162, 621);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(62, 23);
            this.cmdPause.TabIndex = 58;
            this.cmdPause.Text = "Pause";
            this.cmdPause.UseVisualStyleBackColor = true;
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
            // 
            // cmdResume
            // 
            this.cmdResume.Location = new System.Drawing.Point(233, 621);
            this.cmdResume.Name = "cmdResume";
            this.cmdResume.Size = new System.Drawing.Size(62, 23);
            this.cmdResume.TabIndex = 59;
            this.cmdResume.Text = "Resume";
            this.cmdResume.UseVisualStyleBackColor = true;
            this.cmdResume.Click += new System.EventHandler(this.cmdResume_Click);
            // 
            // trckVolume
            // 
            this.trckVolume.Location = new System.Drawing.Point(591, 54);
            this.trckVolume.Maximum = 100;
            this.trckVolume.Name = "trckVolume";
            this.trckVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trckVolume.Size = new System.Drawing.Size(45, 277);
            this.trckVolume.TabIndex = 61;
            this.trckVolume.Value = 50;
            this.trckVolume.ValueChanged += new System.EventHandler(this.trckVolume_ValueChanged);
            // 
            // lblDecodeMode
            // 
            this.lblDecodeMode.AutoSize = true;
            this.lblDecodeMode.Location = new System.Drawing.Point(338, 355);
            this.lblDecodeMode.Name = "lblDecodeMode";
            this.lblDecodeMode.Size = new System.Drawing.Size(75, 13);
            this.lblDecodeMode.TabIndex = 63;
            this.lblDecodeMode.Text = "Decode Mode";
            // 
            // cboPlayerDecodeMode
            // 
            this.cboPlayerDecodeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerDecodeMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlayerDecodeMode.FormattingEnabled = true;
            this.cboPlayerDecodeMode.Location = new System.Drawing.Point(341, 371);
            this.cboPlayerDecodeMode.Name = "cboPlayerDecodeMode";
            this.cboPlayerDecodeMode.Size = new System.Drawing.Size(285, 21);
            this.cboPlayerDecodeMode.TabIndex = 62;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(610, 185);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(19, 13);
            this.lblVolume.TabIndex = 64;
            this.lblVolume.Text = "50";
            // 
            // cmdCheckLicense
            // 
            this.cmdCheckLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdCheckLicense.Image = ((System.Drawing.Image)(resources.GetObject("cmdCheckLicense.Image")));
            this.cmdCheckLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCheckLicense.Location = new System.Drawing.Point(476, 621);
            this.cmdCheckLicense.Name = "cmdCheckLicense";
            this.cmdCheckLicense.Size = new System.Drawing.Size(160, 23);
            this.cmdCheckLicense.TabIndex = 286;
            this.cmdCheckLicense.Text = "Order a license online";
            this.cmdCheckLicense.UseVisualStyleBackColor = true;
            this.cmdCheckLicense.Click += new System.EventHandler(this.cmdCheckLicense_Click);
            // 
            // audioPlayer1
            // 
            this.audioPlayer1.AudioDevice = 0;
            this.audioPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.audioPlayer1.DriveIndex = -1;
            this.audioPlayer1.FileName = null;
            this.audioPlayer1.Location = new System.Drawing.Point(270, 1);
            this.audioPlayer1.MessageArgs = null;
            this.audioPlayer1.Name = "audioPlayer1";
            this.audioPlayer1.Position = System.TimeSpan.Parse("00:00:00");
            this.audioPlayer1.ProgressArgs = null;
            this.audioPlayer1.RatingStars = 0F;
            this.audioPlayer1.RatingUser = "Windows Media Player 9 Series";
            this.audioPlayer1.SamplerateVal = 0;
            this.audioPlayer1.Size = new System.Drawing.Size(52, 52);
            this.audioPlayer1.TabIndex = 0;
            this.audioPlayer1.TagAlbum = null;
            this.audioPlayer1.TagArtists = ((System.Collections.Generic.List<string>)(resources.GetObject("audioPlayer1.TagArtists")));
            this.audioPlayer1.TagComment = null;
            this.audioPlayer1.TagComposers = ((System.Collections.Generic.List<string>)(resources.GetObject("audioPlayer1.TagComposers")));
            this.audioPlayer1.TagCopyright = null;
            this.audioPlayer1.TagGenres = ((System.Collections.Generic.List<string>)(resources.GetObject("audioPlayer1.TagGenres")));
            this.audioPlayer1.TagLyrics = null;
            this.audioPlayer1.TagPerformers = ((System.Collections.Generic.List<string>)(resources.GetObject("audioPlayer1.TagPerformers")));
            this.audioPlayer1.TagRating = ((short)(0));
            this.audioPlayer1.TagTitle = null;
            this.audioPlayer1.TagTrack = ((uint)(0u));
            this.audioPlayer1.TagYear = null;
            this.audioPlayer1.TrackIndex = -1;
            this.audioPlayer1.UserKey = "Your registration key";
            this.audioPlayer1.UserName = "Your email";
            this.audioPlayer1.Volume = 100;
            this.audioPlayer1.PlayError += new CSAudioPlayer.OnPlayErrorEventHandler(this.audioPlayer1_PlayError);
            this.audioPlayer1.PlayDone += new System.EventHandler(this.audioPlayer1_PlayDone);
            this.audioPlayer1.PlayStart += new System.EventHandler(this.audioPlayer1_PlayStart);
            // 
            // audioVisualization1
            // 
            this.audioVisualization1.BackColor = System.Drawing.Color.Black;
            this.audioVisualization1.BarCount = 50;
            this.audioVisualization1.BarSpacing = 2;
            this.audioVisualization1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.audioVisualization1.ColorBase = System.Drawing.Color.DarkRed;
            this.audioVisualization1.ColorMax = System.Drawing.Color.Snow;
            this.audioVisualization1.HighQuality = true;
            this.audioVisualization1.Interval = 40;
            this.audioVisualization1.IsXLogScale = true;
            this.audioVisualization1.Location = new System.Drawing.Point(17, 42);
            this.audioVisualization1.MaximumFrequency = 10000;
            this.audioVisualization1.Name = "audioVisualization1";
            this.audioVisualization1.Size = new System.Drawing.Size(558, 289);
            this.audioVisualization1.TabIndex = 67;
            this.audioVisualization1.UseAverage = true;
            // 
            // audioMeter1
            // 
            this.audioMeter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.audioMeter1.Location = new System.Drawing.Point(17, 12);
            this.audioMeter1.Name = "audioMeter1";
            this.audioMeter1.Size = new System.Drawing.Size(558, 23);
            this.audioMeter1.TabIndex = 65;
            // 
            // frmAudioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 664);
            this.Controls.Add(this.cmdCheckLicense);
            this.Controls.Add(this.audioPlayer1);
            this.Controls.Add(this.lblPlayerMode);
            this.Controls.Add(this.cboPlayerMode);
            this.Controls.Add(this.audioVisualization1);
            this.Controls.Add(this.audioMeter1);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblDecodeMode);
            this.Controls.Add(this.cboPlayerDecodeMode);
            this.Controls.Add(this.trckVolume);
            this.Controls.Add(this.cmdResume);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.lblPositionTotal);
            this.Controls.Add(this.lblPositionCurrent);
            this.Controls.Add(this.lblAudioDevice);
            this.Controls.Add(this.cboPlayerAudioDevice);
            this.Controls.Add(this.cboPlayerChannels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBits);
            this.Controls.Add(this.cboPlayerBits);
            this.Controls.Add(this.lblSamplerate);
            this.Controls.Add(this.cboPlayerSamplerate);
            this.Controls.Add(this.lblMeterOut);
            this.Controls.Add(this.lblMediaFile);
            this.Controls.Add(this.cmdID3Tags);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.trckPlayerPosition);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAudioPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSAudioPlayer - Full Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAudioPlayer_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trckPlayerPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSAudioPlayer.AudioPlayer audioPlayer1;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.TrackBar trckPlayerPosition;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Button cmdID3Tags;
        private System.Windows.Forms.Label lblMediaFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer tmrMeterOut;
        private System.Windows.Forms.Label lblMeterOut;
        private System.Windows.Forms.ComboBox cboPlayerChannels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.ComboBox cboPlayerBits;
        private System.Windows.Forms.Label lblSamplerate;
        private System.Windows.Forms.ComboBox cboPlayerSamplerate;
        private System.Windows.Forms.Label lblPlayerMode;
        private System.Windows.Forms.ComboBox cboPlayerMode;
        private System.Windows.Forms.Label lblAudioDevice;
        private System.Windows.Forms.ComboBox cboPlayerAudioDevice;
        private System.Windows.Forms.Label lblPositionCurrent;
        private System.Windows.Forms.Label lblPositionTotal;
        private System.Windows.Forms.Timer tmrPlayerPosition;
        private System.Windows.Forms.Button cmdPause;
        private System.Windows.Forms.Button cmdResume;
        private System.Windows.Forms.TrackBar trckVolume;
        private System.Windows.Forms.Label lblDecodeMode;
        private System.Windows.Forms.ComboBox cboPlayerDecodeMode;
        private System.Windows.Forms.Label lblVolume;
        private CSAudioPlayer.AudioMeter audioMeter1;
        private CSAudioPlayer.AudioVisualization audioVisualization1;
        private System.Windows.Forms.Button cmdCheckLicense;
    }
}

