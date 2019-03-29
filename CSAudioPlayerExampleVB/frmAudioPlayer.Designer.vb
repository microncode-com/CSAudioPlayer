<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudioPlayer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAudioPlayer))
        Me.cmdCheckLicense = New System.Windows.Forms.Button()
        Me.lblPlayerMode = New System.Windows.Forms.Label()
        Me.tmrPlayerPosition = New System.Windows.Forms.Timer(Me.components)
        Me.cboPlayerMode = New System.Windows.Forms.ComboBox()
        Me.tmrMeterOut = New System.Windows.Forms.Timer(Me.components)
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.lblDecodeMode = New System.Windows.Forms.Label()
        Me.cboPlayerDecodeMode = New System.Windows.Forms.ComboBox()
        Me.trckVolume = New System.Windows.Forms.TrackBar()
        Me.cmdResume = New System.Windows.Forms.Button()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.lblPositionTotal = New System.Windows.Forms.Label()
        Me.lblPositionCurrent = New System.Windows.Forms.Label()
        Me.lblAudioDevice = New System.Windows.Forms.Label()
        Me.cboPlayerAudioDevice = New System.Windows.Forms.ComboBox()
        Me.cboPlayerChannels = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblBits = New System.Windows.Forms.Label()
        Me.cboPlayerBits = New System.Windows.Forms.ComboBox()
        Me.lblSamplerate = New System.Windows.Forms.Label()
        Me.cboPlayerSamplerate = New System.Windows.Forms.ComboBox()
        Me.lblMeterOut = New System.Windows.Forms.Label()
        Me.lblMediaFile = New System.Windows.Forms.Label()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmdID3Tags = New System.Windows.Forms.Button()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.trckPlayerPosition = New System.Windows.Forms.TrackBar()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.AudioPlayer1 = New CSAudioPlayer.AudioPlayer()
        Me.AudioMeter1 = New CSAudioPlayer.AudioMeter()
        Me.AudioVisualization1 = New CSAudioPlayer.AudioVisualization()
        CType(Me.trckVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trckPlayerPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCheckLicense
        '
        Me.cmdCheckLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdCheckLicense.Image = CType(resources.GetObject("cmdCheckLicense.Image"), System.Drawing.Image)
        Me.cmdCheckLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCheckLicense.Location = New System.Drawing.Point(478, 623)
        Me.cmdCheckLicense.Name = "cmdCheckLicense"
        Me.cmdCheckLicense.Size = New System.Drawing.Size(160, 23)
        Me.cmdCheckLicense.TabIndex = 312
        Me.cmdCheckLicense.Text = "Order a license online"
        Me.cmdCheckLicense.UseVisualStyleBackColor = True
        '
        'lblPlayerMode
        '
        Me.lblPlayerMode.AutoSize = True
        Me.lblPlayerMode.Location = New System.Drawing.Point(26, 357)
        Me.lblPlayerMode.Name = "lblPlayerMode"
        Me.lblPlayerMode.Size = New System.Drawing.Size(66, 13)
        Me.lblPlayerMode.TabIndex = 301
        Me.lblPlayerMode.Text = "Player Mode"
        '
        'tmrPlayerPosition
        '
        '
        'cboPlayerMode
        '
        Me.cboPlayerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayerMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPlayerMode.FormattingEnabled = True
        Me.cboPlayerMode.Location = New System.Drawing.Point(29, 373)
        Me.cboPlayerMode.Name = "cboPlayerMode"
        Me.cboPlayerMode.Size = New System.Drawing.Size(308, 21)
        Me.cboPlayerMode.TabIndex = 300
        '
        'tmrMeterOut
        '
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(612, 187)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(19, 13)
        Me.lblVolume.TabIndex = 311
        Me.lblVolume.Text = "50"
        '
        'lblDecodeMode
        '
        Me.lblDecodeMode.AutoSize = True
        Me.lblDecodeMode.Location = New System.Drawing.Point(340, 357)
        Me.lblDecodeMode.Name = "lblDecodeMode"
        Me.lblDecodeMode.Size = New System.Drawing.Size(75, 13)
        Me.lblDecodeMode.TabIndex = 310
        Me.lblDecodeMode.Text = "Decode Mode"
        '
        'cboPlayerDecodeMode
        '
        Me.cboPlayerDecodeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayerDecodeMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPlayerDecodeMode.FormattingEnabled = True
        Me.cboPlayerDecodeMode.Location = New System.Drawing.Point(343, 373)
        Me.cboPlayerDecodeMode.Name = "cboPlayerDecodeMode"
        Me.cboPlayerDecodeMode.Size = New System.Drawing.Size(285, 21)
        Me.cboPlayerDecodeMode.TabIndex = 309
        '
        'trckVolume
        '
        Me.trckVolume.Location = New System.Drawing.Point(593, 56)
        Me.trckVolume.Maximum = 100
        Me.trckVolume.Name = "trckVolume"
        Me.trckVolume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trckVolume.Size = New System.Drawing.Size(45, 277)
        Me.trckVolume.TabIndex = 308
        Me.trckVolume.Value = 50
        '
        'cmdResume
        '
        Me.cmdResume.Location = New System.Drawing.Point(235, 623)
        Me.cmdResume.Name = "cmdResume"
        Me.cmdResume.Size = New System.Drawing.Size(62, 23)
        Me.cmdResume.TabIndex = 307
        Me.cmdResume.Text = "Resume"
        Me.cmdResume.UseVisualStyleBackColor = True
        '
        'cmdPause
        '
        Me.cmdPause.Location = New System.Drawing.Point(164, 623)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(62, 23)
        Me.cmdPause.TabIndex = 306
        Me.cmdPause.Text = "Pause"
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'lblPositionTotal
        '
        Me.lblPositionTotal.AutoSize = True
        Me.lblPositionTotal.Location = New System.Drawing.Point(568, 495)
        Me.lblPositionTotal.Name = "lblPositionTotal"
        Me.lblPositionTotal.Size = New System.Drawing.Size(49, 13)
        Me.lblPositionTotal.TabIndex = 305
        Me.lblPositionTotal.Text = "00:00:00"
        '
        'lblPositionCurrent
        '
        Me.lblPositionCurrent.AutoSize = True
        Me.lblPositionCurrent.Location = New System.Drawing.Point(26, 495)
        Me.lblPositionCurrent.Name = "lblPositionCurrent"
        Me.lblPositionCurrent.Size = New System.Drawing.Size(49, 13)
        Me.lblPositionCurrent.TabIndex = 304
        Me.lblPositionCurrent.Text = "00:00:00"
        '
        'lblAudioDevice
        '
        Me.lblAudioDevice.AutoSize = True
        Me.lblAudioDevice.Location = New System.Drawing.Point(26, 419)
        Me.lblAudioDevice.Name = "lblAudioDevice"
        Me.lblAudioDevice.Size = New System.Drawing.Size(71, 13)
        Me.lblAudioDevice.TabIndex = 303
        Me.lblAudioDevice.Text = "Audio Device"
        '
        'cboPlayerAudioDevice
        '
        Me.cboPlayerAudioDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayerAudioDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPlayerAudioDevice.FormattingEnabled = True
        Me.cboPlayerAudioDevice.Location = New System.Drawing.Point(29, 435)
        Me.cboPlayerAudioDevice.Name = "cboPlayerAudioDevice"
        Me.cboPlayerAudioDevice.Size = New System.Drawing.Size(308, 21)
        Me.cboPlayerAudioDevice.TabIndex = 302
        '
        'cboPlayerChannels
        '
        Me.cboPlayerChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayerChannels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPlayerChannels.FormattingEnabled = True
        Me.cboPlayerChannels.Location = New System.Drawing.Point(537, 435)
        Me.cboPlayerChannels.Name = "cboPlayerChannels"
        Me.cboPlayerChannels.Size = New System.Drawing.Size(91, 21)
        Me.cboPlayerChannels.TabIndex = 299
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(534, 419)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(51, 13)
        Me.label1.TabIndex = 298
        Me.label1.Text = "Channels"
        '
        'lblBits
        '
        Me.lblBits.AutoSize = True
        Me.lblBits.Location = New System.Drawing.Point(437, 419)
        Me.lblBits.Name = "lblBits"
        Me.lblBits.Size = New System.Drawing.Size(49, 13)
        Me.lblBits.TabIndex = 297
        Me.lblBits.Text = "Bit depth"
        '
        'cboPlayerBits
        '
        Me.cboPlayerBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayerBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPlayerBits.FormattingEnabled = True
        Me.cboPlayerBits.Location = New System.Drawing.Point(440, 435)
        Me.cboPlayerBits.Name = "cboPlayerBits"
        Me.cboPlayerBits.Size = New System.Drawing.Size(91, 21)
        Me.cboPlayerBits.TabIndex = 296
        '
        'lblSamplerate
        '
        Me.lblSamplerate.AutoSize = True
        Me.lblSamplerate.Location = New System.Drawing.Point(340, 419)
        Me.lblSamplerate.Name = "lblSamplerate"
        Me.lblSamplerate.Size = New System.Drawing.Size(60, 13)
        Me.lblSamplerate.TabIndex = 295
        Me.lblSamplerate.Text = "Samplerate"
        '
        'cboPlayerSamplerate
        '
        Me.cboPlayerSamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayerSamplerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPlayerSamplerate.FormattingEnabled = True
        Me.cboPlayerSamplerate.Location = New System.Drawing.Point(343, 435)
        Me.cboPlayerSamplerate.Name = "cboPlayerSamplerate"
        Me.cboPlayerSamplerate.Size = New System.Drawing.Size(91, 21)
        Me.cboPlayerSamplerate.TabIndex = 294
        '
        'lblMeterOut
        '
        Me.lblMeterOut.AutoSize = True
        Me.lblMeterOut.Location = New System.Drawing.Point(588, 19)
        Me.lblMeterOut.Name = "lblMeterOut"
        Me.lblMeterOut.Size = New System.Drawing.Size(28, 13)
        Me.lblMeterOut.TabIndex = 293
        Me.lblMeterOut.Text = "0.00"
        '
        'lblMediaFile
        '
        Me.lblMediaFile.Location = New System.Drawing.Point(26, 572)
        Me.lblMediaFile.Name = "lblMediaFile"
        Me.lblMediaFile.Size = New System.Drawing.Size(602, 36)
        Me.lblMediaFile.TabIndex = 292
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'cmdID3Tags
        '
        Me.cmdID3Tags.Location = New System.Drawing.Point(371, 623)
        Me.cmdID3Tags.Name = "cmdID3Tags"
        Me.cmdID3Tags.Size = New System.Drawing.Size(101, 23)
        Me.cmdID3Tags.TabIndex = 291
        Me.cmdID3Tags.Text = "ID3 Tags Editor"
        Me.cmdID3Tags.UseVisualStyleBackColor = True
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(29, 623)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(63, 23)
        Me.cmdOpen.TabIndex = 290
        Me.cmdOpen.Text = "Open"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'trckPlayerPosition
        '
        Me.trckPlayerPosition.Location = New System.Drawing.Point(19, 524)
        Me.trckPlayerPosition.Name = "trckPlayerPosition"
        Me.trckPlayerPosition.Size = New System.Drawing.Size(609, 45)
        Me.trckPlayerPosition.TabIndex = 289
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(303, 623)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(62, 23)
        Me.cmdStop.TabIndex = 288
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'cmdPlay
        '
        Me.cmdPlay.Location = New System.Drawing.Point(98, 623)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(61, 23)
        Me.cmdPlay.TabIndex = 287
        Me.cmdPlay.Text = "Play"
        Me.cmdPlay.UseVisualStyleBackColor = True
        '
        'AudioPlayer1
        '
        Me.AudioPlayer1.AudioDevice = 0
        Me.AudioPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AudioPlayer1.DriveIndex = -1
        Me.AudioPlayer1.FileName = Nothing
        Me.AudioPlayer1.Location = New System.Drawing.Point(502, 12)
        Me.AudioPlayer1.MessageArgs = Nothing
        Me.AudioPlayer1.Name = "AudioPlayer1"
        Me.AudioPlayer1.Position = System.TimeSpan.Parse("00:00:00")
        Me.AudioPlayer1.ProgressArgs = Nothing
        Me.AudioPlayer1.RatingStars = 0!
        Me.AudioPlayer1.RatingUser = "Windows Media Player 9 Series"
        Me.AudioPlayer1.SamplerateVal = 0
        Me.AudioPlayer1.Size = New System.Drawing.Size(52, 52)
        Me.AudioPlayer1.TabIndex = 313
        Me.AudioPlayer1.TagAlbum = Nothing
        Me.AudioPlayer1.TagArtists = CType(resources.GetObject("AudioPlayer1.TagArtists"), System.Collections.Generic.List(Of String))
        Me.AudioPlayer1.TagComment = Nothing
        Me.AudioPlayer1.TagComposers = CType(resources.GetObject("AudioPlayer1.TagComposers"), System.Collections.Generic.List(Of String))
        Me.AudioPlayer1.TagCopyright = Nothing
        Me.AudioPlayer1.TagGenres = CType(resources.GetObject("AudioPlayer1.TagGenres"), System.Collections.Generic.List(Of String))
        Me.AudioPlayer1.TagLyrics = Nothing
        Me.AudioPlayer1.TagPerformers = CType(resources.GetObject("AudioPlayer1.TagPerformers"), System.Collections.Generic.List(Of String))
        Me.AudioPlayer1.TagRating = CType(0, Short)
        Me.AudioPlayer1.TagTitle = Nothing
        Me.AudioPlayer1.TagTrack = CType(0UI, UInteger)
        Me.AudioPlayer1.TagYear = Nothing
        Me.AudioPlayer1.TrackIndex = -1
        Me.AudioPlayer1.UserKey = "Your registration key"
        Me.AudioPlayer1.UserName = "Your email"
        Me.AudioPlayer1.Volume = 100
        '
        'AudioMeter1
        '
        Me.AudioMeter1.Location = New System.Drawing.Point(29, 19)
        Me.AudioMeter1.Name = "AudioMeter1"
        Me.AudioMeter1.Size = New System.Drawing.Size(556, 31)
        Me.AudioMeter1.TabIndex = 315
        '
        'AudioVisualization1
        '
        Me.AudioVisualization1.BarCount = 50
        Me.AudioVisualization1.BarSpacing = 2
        Me.AudioVisualization1.ColorBase = System.Drawing.Color.DarkRed
        Me.AudioVisualization1.ColorMax = System.Drawing.Color.Snow
        Me.AudioVisualization1.HighQuality = True
        Me.AudioVisualization1.Interval = 40
        Me.AudioVisualization1.IsXLogScale = True
        Me.AudioVisualization1.Location = New System.Drawing.Point(29, 56)
        Me.AudioVisualization1.MaximumFrequency = 10000
        Me.AudioVisualization1.Name = "AudioVisualization1"
        Me.AudioVisualization1.Size = New System.Drawing.Size(558, 277)
        Me.AudioVisualization1.TabIndex = 314
        Me.AudioVisualization1.UseAverage = True
        '
        'frmAudioPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 664)
        Me.Controls.Add(Me.AudioPlayer1)
        Me.Controls.Add(Me.AudioMeter1)
        Me.Controls.Add(Me.AudioVisualization1)
        Me.Controls.Add(Me.cmdCheckLicense)
        Me.Controls.Add(Me.lblPlayerMode)
        Me.Controls.Add(Me.cboPlayerMode)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.lblDecodeMode)
        Me.Controls.Add(Me.cboPlayerDecodeMode)
        Me.Controls.Add(Me.trckVolume)
        Me.Controls.Add(Me.cmdResume)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.lblPositionTotal)
        Me.Controls.Add(Me.lblPositionCurrent)
        Me.Controls.Add(Me.lblAudioDevice)
        Me.Controls.Add(Me.cboPlayerAudioDevice)
        Me.Controls.Add(Me.cboPlayerChannels)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblBits)
        Me.Controls.Add(Me.cboPlayerBits)
        Me.Controls.Add(Me.lblSamplerate)
        Me.Controls.Add(Me.cboPlayerSamplerate)
        Me.Controls.Add(Me.lblMeterOut)
        Me.Controls.Add(Me.lblMediaFile)
        Me.Controls.Add(Me.cmdID3Tags)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.trckPlayerPosition)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdPlay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAudioPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSAudioPlayer - VB Full Example"
        CType(Me.trckVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trckPlayerPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cmdCheckLicense As Button
    Private WithEvents lblPlayerMode As Label
    Private WithEvents tmrPlayerPosition As Timer
    Private WithEvents cboPlayerMode As ComboBox
    Private WithEvents tmrMeterOut As Timer
    Private WithEvents lblVolume As Label
    Private WithEvents lblDecodeMode As Label
    Private WithEvents cboPlayerDecodeMode As ComboBox
    Private WithEvents trckVolume As TrackBar
    Private WithEvents cmdResume As Button
    Private WithEvents cmdPause As Button
    Private WithEvents lblPositionTotal As Label
    Private WithEvents lblPositionCurrent As Label
    Private WithEvents lblAudioDevice As Label
    Private WithEvents cboPlayerAudioDevice As ComboBox
    Private WithEvents cboPlayerChannels As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents lblBits As Label
    Private WithEvents cboPlayerBits As ComboBox
    Private WithEvents lblSamplerate As Label
    Private WithEvents cboPlayerSamplerate As ComboBox
    Private WithEvents lblMeterOut As Label
    Private WithEvents lblMediaFile As Label
    Private WithEvents openFileDialog1 As OpenFileDialog
    Private WithEvents cmdID3Tags As Button
    Private WithEvents cmdOpen As Button
    Private WithEvents trckPlayerPosition As TrackBar
    Private WithEvents cmdStop As Button
    Private WithEvents cmdPlay As Button
    Friend WithEvents AudioPlayer1 As CSAudioPlayer.AudioPlayer
    Friend WithEvents AudioVisualization1 As CSAudioPlayer.AudioVisualization
    Friend WithEvents AudioMeter1 As CSAudioPlayer.AudioMeter
End Class
