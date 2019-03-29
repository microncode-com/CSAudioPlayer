Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CSAudioPlayerExample
    Public Partial Class frmAudioPlayer
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub audioPlayer1_PlayDone(ByVal sender As Object, ByVal e As EventArgs)
            lblMeterOut.Text = "0"
            trckPlayerPosition.Value = 0
            lblPositionCurrent.Text = "00:00:00"
            tmrPlayerPosition.Enabled = False
            Console.WriteLine("Done.")
        End Sub

        Private Sub audioPlayer1_PlayStart(ByVal sender As Object, ByVal e As EventArgs)
            audioPlayer1.Volume = trckVolume.Value
            EnableDisableControls(True)
            Console.WriteLine("Start.")
        End Sub

        Private Sub audioPlayer1_PlayError(ByVal sender As Object, ByVal e As CSAudioPlayer.MessageArgs)
            Console.WriteLine(e.Number & " (" & e.Number & ")")
            EnableDisableControls(True)
        End Sub

        Private Sub EnableDisableControls(ByVal state As Boolean)
            cmdOpen.Enabled = state
        End Sub

        Private Sub cmdPlay_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lblMediaFile.Text Is "" Then cmdOpen_Click(sender, e)

            If audioPlayer1.PlayingState <> CSAudioPlayer.PlayingState.Stopped Then
                audioPlayer1.[Resume]()
                audioPlayer1.[Stop]()

                While audioPlayer1.PlayingState <> CSAudioPlayer.PlayingState.Stopped
                    Thread.Sleep(100)
                End While
            End If

            EnableDisableControls(False)

            If audioPlayer1.TagImages.Count > 0 Then
                audioVisualization1.BackColor = Color.Transparent
                audioVisualization1.pictureBoxGraph.BackgroundImage = audioPlayer1.TagImages(0).Image
            Else
                audioVisualization1.BackColor = Color.Black
                audioVisualization1.pictureBoxGraph.BackgroundImage = Nothing
            End If

            audioPlayer1.AudioVisualization = audioVisualization1
            audioPlayer1.AudioMeter = audioMeter1
            audioPlayer1.DecodeMode = CType([Enum].Parse(GetType(CSAudioPlayer.DecodeMode), cboPlayerDecodeMode.Text), CSAudioPlayer.DecodeMode)
            audioPlayer1.Samplerate = CType([Enum].Parse(GetType(CSAudioPlayer.Samplerate), cboPlayerSamplerate.Text), CSAudioPlayer.Samplerate)
            audioPlayer1.Bits = CType([Enum].Parse(GetType(CSAudioPlayer.Bits), cboPlayerBits.Text), CSAudioPlayer.Bits)
            audioPlayer1.Channels = CType([Enum].Parse(GetType(CSAudioPlayer.Channels), cboPlayerChannels.Text), CSAudioPlayer.Channels)
            audioPlayer1.Mode = CType([Enum].Parse(GetType(CSAudioPlayer.Mode), cboPlayerMode.Text), CSAudioPlayer.Mode)

            If Not audioPlayer1.Open(lblMediaFile.Text) Then
                MessageBox.Show("Cannot open '" & lblMediaFile.Text & "'")
                Return
            End If

            lblPositionTotal.Text = String.Format("{0:hh\:mm\:ss}", audioPlayer1.Length)
            audioPlayer1.AudioDevice = cboPlayerAudioDevice.SelectedIndex
            audioPlayer1.FileName = lblMediaFile.Text
            audioPlayer1.Play()
            lblPositionTotal.Text = "audioPlayer1.Length"
            lblPositionTotal.Text = String.Format("{0:hh\:mm\:ss}", audioPlayer1.Length)
            tmrMeterOut.Interval = 40
            tmrMeterOut.Enabled = True
            tmrPlayerPosition.Interval = 100
            tmrPlayerPosition.Enabled = True
        End Sub

        Private Sub cmdPause_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioPlayer1.PlayingState = CSAudioPlayer.PlayingState.Playing Then audioPlayer1.Pause()
        End Sub

        Private Sub cmdResume_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioPlayer1.PlayingState = CSAudioPlayer.PlayingState.Paused Then audioPlayer1.[Resume]()
        End Sub

        Private Sub cmdStop_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioPlayer1.[Stop]()
            tmrMeterOut.Enabled = False
        End Sub

        Private Sub cmdID3Tags_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lblMediaFile.Text Is "" Then Return
            Dim frmAllID3Tags As frmID3TagsEditor = New frmID3TagsEditor()
            frmAllID3Tags.LoadFile(lblMediaFile.Text)
            frmAllID3Tags.ShowDialog(Me)
        End Sub

        Private Sub cmdOpen_Click(ByVal sender As Object, ByVal e As EventArgs)
            If openFileDialog1.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
                Return
            End If

            lblMediaFile.Text = openFileDialog1.FileName
            audioPlayer1.DecodeMode = CType([Enum].Parse(GetType(CSAudioPlayer.DecodeMode), cboPlayerDecodeMode.Text), CSAudioPlayer.DecodeMode)

            If Not audioPlayer1.Open(lblMediaFile.Text) Then
                MessageBox.Show("Cannot open the source multimedia file.")
                Return
            End If

            lblPositionTotal.Text = String.Format("{0:hh\:mm\:ss}", audioPlayer1.Length)
            trckPlayerPosition.Minimum = 0
            trckPlayerPosition.Maximum = CInt(audioPlayer1.Length.TotalSeconds)
        End Sub

        Private Sub tmrMeterOut_Tick(ByVal sender As Object, ByVal e As EventArgs)
            lblMeterOut.Text = audioMeter1.Meter.ToString("0.00")
        End Sub

        Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs)
            cboPlayerSamplerate.DataSource = audioPlayer1.GetSamplerates()
            cboPlayerSamplerate.Text = "44100"
            cboPlayerBits.DataSource = audioPlayer1.GetBits()
            cboPlayerBits.Text = "16"
            cboPlayerChannels.DataSource = audioPlayer1.GetChannels()
            cboPlayerChannels.Text = "2"
            cboPlayerDecodeMode.DataSource = audioPlayer1.GetDecoderModes()
            cboPlayerDecodeMode.Text = "LocalCodecs"
            cboPlayerMode.DataSource = audioPlayer1.GetPlayerModes()
            cboPlayerMode.SelectedItem = audioPlayer1.GetEnumValue(audioPlayer1.Mode)
            trckVolume.Value = 50
            cboPlayerAudioDevice.SelectedIndex = audioPlayer1.GetDeviceDefaultIndex()
        End Sub

        Private Sub trckPlayerPosition_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            If audioPlayer1.PlayingState = CSAudioPlayer.PlayingState.Stopped Then Return

            Try
                audioPlayer1.Position = TimeSpan.FromSeconds(trckPlayerPosition.Value)
                tmrPlayerPosition.Enabled = True
            Catch ex As Exception
            Finally
            End Try
        End Sub

        Private Sub trckPlayerPosition_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            tmrPlayerPosition.Enabled = False
        End Sub

        Private Sub tmrPlayerPosition_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Try
                trckPlayerPosition.Value = CInt(audioPlayer1.Position.TotalSeconds)
                lblPositionCurrent.Text = String.Format("{0:hh\:mm\:ss}", audioPlayer1.Position)
            Catch ex As Exception
            Finally
            End Try
        End Sub

        Private Sub trckVolume_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            audioPlayer1.Volume = trckVolume.Value
            Console.WriteLine("audioPlayer1.Volume")
            Console.WriteLine(audioPlayer1.Volume)
            lblVolume.Text = trckVolume.Value.ToString()
        End Sub

        Private Sub frmAudioPlayer_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            If audioPlayer1.PlayingState <> CSAudioPlayer.PlayingState.Stopped Then
                audioPlayer1.[Resume]()
                audioPlayer1.[Stop]()

                While audioPlayer1.PlayingState <> CSAudioPlayer.PlayingState.Stopped
                    Thread.Sleep(100)
                End While
            End If
        End Sub

        Private Sub cboPlayerMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim mode As CSAudioPlayer.Mode = CType([Enum].Parse(GetType(CSAudioPlayer.Mode), cboPlayerMode.Text), CSAudioPlayer.Mode)
            cboPlayerAudioDevice.DataSource = audioPlayer1.GetDevices(mode)
            Dim default_device_index As Integer = audioPlayer1.GetDeviceDefaultIndex(mode)

            If default_device_index <> -1 Then
                cboPlayerAudioDevice.SelectedIndex = default_device_index
            Else
                cboPlayerAudioDevice.SelectedIndex = 0
            End If
        End Sub

        Private Sub cmdCheckLicense_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioPlayer1.CheckLicense() Then MessageBox.Show("Registration is OK")
        End Sub
    End Class
End Namespace
