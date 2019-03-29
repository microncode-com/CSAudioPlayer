#Region "LICENSE"
'
' Copyright (c) Microncode.com
' 
' This source is subject to the Microsoft Public License. 
' See https://opensource.org/licenses/ms-pl.html.
' All other rights reserved. 
' 
' THIS CODE And INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED Or IMPLIED, INCLUDING BUT Not LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY And/Or FITNESS FOR A PARTICULAR PURPOSE. 
'
#End Region

Imports System.Threading

Public Class frmAudioPlayer

    ''' <summary>
    ''' When done playing event.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioPlayer1_PlayDone(sender As Object, e As EventArgs) Handles AudioPlayer1.PlayDone

        'Reset the form controls:
        lblMeterOut.Text = "0"
        trckPlayerPosition.Value = 0
        lblPositionCurrent.Text = "00:00:00"
        tmrPlayerPosition.Enabled = False
        Console.WriteLine("Done.")

    End Sub

    ''' <summary>
    ''' On error.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioPlayer1_PlayError(sender As Object, e As CSAudioPlayer.MessageArgs) Handles AudioPlayer1.PlayError

        Console.WriteLine(e.Number & " (" & e.Number & ")")
        EnableDisableControls(True)

    End Sub

    Private Sub AudioPlayer1_PlayPaused(sender As Object, e As EventArgs) Handles AudioPlayer1.PlayPaused

    End Sub

    Private Sub AudioPlayer1_PlayProgress(sender As Object, e As CSAudioPlayer.ProgressArgs) Handles AudioPlayer1.PlayProgress

    End Sub

    ''' <summary>
    ''' When start playing event.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioPlayer1_PlayStart(sender As Object, e As EventArgs) Handles AudioPlayer1.PlayStart

        'Set the volume of the playing
        AudioPlayer1.Volume = trckVolume.Value

        'Enable all the playing controls
        EnableDisableControls(True)

        Console.WriteLine("Start.")

    End Sub

    Private Sub AudioPlayer1_PlayStopped(sender As Object, e As EventArgs) Handles AudioPlayer1.PlayStopped

    End Sub

    Private Sub EnableDisableControls(ByVal state As Boolean)
        cmdOpen.Enabled = state
    End Sub

    Private Sub frmAudioPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AudioPlayer1.UserName = "Your email"
        AudioPlayer1.UserKey = "Your registration key"

#Region "LoadAudioPlayerProperties"

        'Samplerate
        cboPlayerSamplerate.DataSource = AudioPlayer1.GetSamplerates()
        cboPlayerSamplerate.Text = "44100"

        'Bit depth
        cboPlayerBits.DataSource = AudioPlayer1.GetBits()
        cboPlayerBits.Text = "16"

        'Channels
        cboPlayerChannels.DataSource = AudioPlayer1.GetChannels()
        cboPlayerChannels.Text = "2"

        'Decoder Mode
        cboPlayerDecodeMode.DataSource = AudioPlayer1.GetDecoderModes()
        cboPlayerDecodeMode.Text = "LocalCodecs"

        'Player mode
        cboPlayerMode.DataSource = AudioPlayer1.GetPlayerModes()
        cboPlayerMode.SelectedItem = AudioPlayer1.GetEnumValue(AudioPlayer1.Mode)

#End Region


        'Set the volume of the player to 50%
        trckVolume.Value = 50

        'Set the volume of the player to 50%
        cboPlayerAudioDevice.SelectedIndex = AudioPlayer1.GetDeviceDefaultIndex()

    End Sub

    ''' <summary>
    ''' Start to play.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click

        'Select the multimedia file to play:
        If lblMediaFile.Text = "" Then cmdOpen_Click(sender, e)

        'If the control is already playing, stop before replay:
        If AudioPlayer1.PlayingState <> CSAudioPlayer.PlayingState.Stopped Then

            'If paused
            AudioPlayer1.[Resume]()

            'Stop
            AudioPlayer1.[Stop]()

            'Wait for the Stopped state
            While AudioPlayer1.PlayingState <> CSAudioPlayer.PlayingState.Stopped
                Thread.Sleep(100)
            End While

        End If

        'Disable all the playing controls:
        EnableDisableControls(False)

        'Just for the visual effect, if there is an image id3 tag in the source file - display the image tag in the audioVisualization1 background.
        If AudioPlayer1.TagImages.Count > 0 Then

            'Display the id3 image tag of the file
            AudioVisualization1.BackColor = Color.Transparent
            AudioVisualization1.pictureBoxGraph.BackgroundImage = AudioPlayer1.TagImages(0).Image

        Else

            'There is no id3 image tag, just display a black background
            AudioVisualization1.BackColor = Color.Black
            AudioVisualization1.pictureBoxGraph.BackgroundImage = Nothing

        End If

        'Set the visualization of the player control:
        AudioPlayer1.AudioVisualization = AudioVisualization1

        'Set the meter of the control:
        AudioPlayer1.AudioMeter = AudioMeter1

#Region "DecodeModeExplain"
        'Set the mode of the decoder, this can be the LocalCodecs which 
        'will use the codecs that installed On the system, Or FFMpeg 
        'which will use the FFMpeg libraries. If you decide To use the 
        'FFMpeg libraries, please make sure the FFMpeg folder With dll 
        'files is existed under the output directory Of the project:
#End Region
        AudioPlayer1.DecodeMode = CType([Enum].Parse(GetType(CSAudioPlayer.DecodeMode), cboPlayerDecodeMode.Text), CSAudioPlayer.DecodeMode)

        'Set the sample rate to play (from 8000 to 48000):
        AudioPlayer1.Samplerate = CType([Enum].Parse(GetType(CSAudioPlayer.Samplerate), cboPlayerSamplerate.Text), CSAudioPlayer.Samplerate)

        'Set the bit-depth to play (8, 16, 24, 32):
        AudioPlayer1.Bits = CType([Enum].Parse(GetType(CSAudioPlayer.Bits), cboPlayerBits.Text), CSAudioPlayer.Bits)

        'Set the number of the channels to play (1 or 2):
        AudioPlayer1.Channels = CType([Enum].Parse(GetType(CSAudioPlayer.Channels), cboPlayerChannels.Text), CSAudioPlayer.Channels)

        'Set the mode of the player (WASAPI or LineOut):
        AudioPlayer1.Mode = CType([Enum].Parse(GetType(CSAudioPlayer.Mode), cboPlayerMode.Text), CSAudioPlayer.Mode)

        If Not AudioPlayer1.Open(lblMediaFile.Text) Then
            MessageBox.Show("Cannot open '" & lblMediaFile.Text & "'")
            Return
        End If

        lblPositionTotal.Text = String.Format("{0:hh\:mm\:ss}", AudioPlayer1.Length)

        'Set the audio device index to play to:
        AudioPlayer1.AudioDevice = cboPlayerAudioDevice.SelectedIndex

        'Set the multimedia file name to play:
        AudioPlayer1.FileName = lblMediaFile.Text

        'Start playing:
        AudioPlayer1.Play()


        lblPositionTotal.Text = "audioPlayer1.Length"
        lblPositionTotal.Text = String.Format("{0:hh\:mm\:ss}", AudioPlayer1.Length)

        'Start the meter timer:
        tmrMeterOut.Interval = 40
        tmrMeterOut.Enabled = True

        'Start the position timer:
        tmrPlayerPosition.Interval = 100
        tmrPlayerPosition.Enabled = True

    End Sub

    ''' <summary>
    ''' Open the source file and get some details about it.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        If openFileDialog1.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
            Return
        End If

        lblMediaFile.Text = openFileDialog1.FileName

#Region "DecodeModeExplain"
        'Set the mode of the decoder, this can be the LocalCodecs which 
        'will use the codecs that installed On the system, Or FFMpeg 
        'which will use the FFMpeg libraries. If you decide To use the 
        'FFMpeg libraries, please make sure the FFMpeg folder With dll 
        'files is existed under the output directory Of the project:
#End Region
        AudioPlayer1.DecodeMode = CType([Enum].Parse(GetType(CSAudioPlayer.DecodeMode), cboPlayerDecodeMode.Text), CSAudioPlayer.DecodeMode)

        If Not AudioPlayer1.Open(lblMediaFile.Text) Then
            MessageBox.Show("Cannot open the source multimedia file.")
            Return
        End If

        lblPositionTotal.Text = String.Format("{0:hh\:mm\:ss}", AudioPlayer1.Length)
        trckPlayerPosition.Minimum = 0
        trckPlayerPosition.Maximum = CInt(AudioPlayer1.Length.TotalSeconds)

    End Sub

    ''' <summary>
    ''' Pause play.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdPause_Click(sender As Object, e As EventArgs) Handles cmdPause.Click

        If AudioPlayer1.PlayingState = CSAudioPlayer.PlayingState.Playing Then AudioPlayer1.Pause()

    End Sub

    ''' <summary>
    ''' Resume play.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdResume_Click(sender As Object, e As EventArgs) Handles cmdResume.Click

        If AudioPlayer1.PlayingState = CSAudioPlayer.PlayingState.Paused Then AudioPlayer1.[Resume]()

    End Sub

    ''' <summary>
    ''' Stop to play.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click

        'Stop to play.
        AudioPlayer1.Stop()

        'Disable the timer of the meter
        tmrMeterOut.Enabled = False

    End Sub

    Private Sub tmrMeterOut_Tick(sender As Object, e As EventArgs) Handles tmrMeterOut.Tick

        lblMeterOut.Text = AudioMeter1.Meter.ToString("0.00")

    End Sub

    ''' <summary>
    ''' Seek the play to the slider position.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub trckPlayerPosition_MouseUp(sender As Object, e As MouseEventArgs) Handles trckPlayerPosition.MouseUp

        If AudioPlayer1.PlayingState = CSAudioPlayer.PlayingState.Stopped Then Return

        Try
            AudioPlayer1.Position = TimeSpan.FromSeconds(trckPlayerPosition.Value)
            tmrPlayerPosition.Enabled = True
        Catch ex As Exception

        Finally

        End Try

    End Sub

    ''' <summary>
    ''' Disable the tmrPlayerPosition on mouse down.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub trckPlayerPosition_MouseDown(sender As Object, e As MouseEventArgs) Handles trckPlayerPosition.MouseDown

        tmrPlayerPosition.Enabled = False

    End Sub

    ''' <summary>
    ''' Display the position of the playing operation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmrPlayerPosition_Tick(sender As Object, e As EventArgs) Handles tmrPlayerPosition.Tick
        Try
            trckPlayerPosition.Value = CInt(AudioPlayer1.Position.TotalSeconds)
            lblPositionCurrent.Text = String.Format("{0:hh\:mm\:ss}", AudioPlayer1.Position)
        Catch ex As Exception
        Finally
        End Try
    End Sub

    ''' <summary>
    ''' Set the volume of the player.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub trckVolume_ValueChanged(sender As Object, e As EventArgs) Handles trckVolume.ValueChanged

        AudioPlayer1.Volume = trckVolume.Value
        Console.WriteLine("audioPlayer1.Volume")
        Console.WriteLine(AudioPlayer1.Volume)
        lblVolume.Text = trckVolume.Value.ToString()

    End Sub

    ''' <summary>
    ''' Form closing event. Stop the playing process (if any) for safe exit.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAudioPlayer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

#Region "SafeExit"

        If AudioPlayer1.PlayingState <> CSAudioPlayer.PlayingState.Stopped Then
            AudioPlayer1.[Resume]()
            AudioPlayer1.[Stop]()

            While AudioPlayer1.PlayingState <> CSAudioPlayer.PlayingState.Stopped
                Thread.Sleep(100)
            End While
        End If

#End Region

    End Sub

    Private Sub cboPlayerMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPlayerMode.SelectedIndexChanged

        'Get the selected capture mode:
        Dim mode As CSAudioPlayer.Mode = CType([Enum].Parse(GetType(CSAudioPlayer.Mode), cboPlayerMode.Text), CSAudioPlayer.Mode)

        'Get the audio devices:
        cboPlayerAudioDevice.DataSource = AudioPlayer1.GetDevices(mode)

        'Try to set the default device:
        Dim default_device_index As Integer = AudioPlayer1.GetDeviceDefaultIndex(mode)

        If default_device_index <> -1 Then
            'Set the default device index:
            cboPlayerAudioDevice.SelectedIndex = default_device_index
        Else
            'LineIn will always return -1:
            cboPlayerAudioDevice.SelectedIndex = 0
        End If

    End Sub

    ''' <summary>
    ''' Check the license.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdCheckLicense_Click(sender As Object, e As EventArgs) Handles cmdCheckLicense.Click
        If AudioPlayer1.CheckLicense() Then MessageBox.Show("Registration is OK")
    End Sub

End Class
