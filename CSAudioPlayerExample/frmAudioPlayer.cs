#region LICENSE
//
// Copyright (c) Microncode.com
// 
// This source is subject to the Microsoft Public License. 
// See https://opensource.org/licenses/ms-pl.html.
// All other rights reserved. 
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAudioPlayerExample
{
    /// <summary>
    /// The main sample of using the CSAudioPlayer component.
    /// 
    /// This sample uses the 3 controls of the component:
    /// *   AudioPlayer       -     For playing the audio.
    /// *   AudioVisualization  -   For displaying the audio graph.  
    /// *   AudioMeter          -   For displaying and get the meter value of the audio player.
    /// 
    /// </summary>
    public partial class frmAudioPlayer : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public frmAudioPlayer()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// When done playing event.
        /// </summary>
        private void audioPlayer1_PlayDone(object sender, EventArgs e)
        {
            //Reset the form controls:
            lblMeterOut.Text = "0";
            trckPlayerPosition.Value = 0;
            lblPositionCurrent.Text = "00:00:00";
            tmrPlayerPosition.Enabled = false;

            Console.WriteLine("Done.");
        }

        /// <summary>
        /// When start playing event.
        /// </summary>
        private void audioPlayer1_PlayStart(object sender, EventArgs e)
        {
            //Set the volume of the playing:
            audioPlayer1.Volume = trckVolume.Value;

            //Enable all the playing controls:
            EnableDisableControls(true);

            Console.WriteLine("Start.");
        }

        /// <summary>
        /// On error.
        /// </summary>
        private void audioPlayer1_PlayError(object sender, CSAudioPlayer.MessageArgs e)
        {
            //Get the error message and number:
            Console.WriteLine(e.Number + " (" + e.Number + ")");

            //Enable all the playing controls:
            EnableDisableControls(true);
        }
        

        /// <summary>
        /// Enable or disable the playing buttons.
        /// </summary>
        /// <param name="state"></param>
        void EnableDisableControls(bool state)
        {
            cmdOpen.Enabled = state;
        }

        /// <summary>
        /// Start to play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPlay_Click(object sender, EventArgs e)
        {
            if (lblMediaFile.Text == "")
                //Select the multimedia file to play:
                cmdOpen_Click(sender, e);

            //If the control is already playing, stop before replay:
            if (audioPlayer1.PlayingState != CSAudioPlayer.PlayingState.Stopped)
            {
                //If paused
                audioPlayer1.Resume();

                //Stop
                audioPlayer1.Stop();

                //Wait for the Stopped state
                while (audioPlayer1.PlayingState != CSAudioPlayer.PlayingState.Stopped)
                    Thread.Sleep(100);
            }

            //Disable all the playing controls:
            EnableDisableControls(false);

            //Just for the visual effect, if there is an image id3 tag in the source file - display the image tag in the audioVisualization1 background.
            if (audioPlayer1.TagImages.Count > 0)
            {
                //Display the id3 image tag of the file
                audioVisualization1.BackColor = Color.Transparent;
                audioVisualization1.pictureBoxGraph.BackgroundImage = audioPlayer1.TagImages[0].Image;
            }
            else
            {
                //There is no id3 image tag, just display a black background
                audioVisualization1.BackColor = Color.Black;
                audioVisualization1.pictureBoxGraph.BackgroundImage = null;
            }

            //Set the visualization of the player control:
            audioPlayer1.AudioVisualization = audioVisualization1;

            //Set the meter of the control:
            audioPlayer1.AudioMeter = audioMeter1;

            #region DecodeModeExplain
            /*
            Set the mode of the decoder, this can be the LocalCodecs which 
            will use the codecs that installed on the system, or FFMpeg 
            which will use the FFMpeg libraries. If you decide to use the 
            FFMpeg libraries, please make sure the FFMpeg folder with dll 
            files is existed under the output directory of the project:
            */
            #endregion
            audioPlayer1.DecodeMode = (CSAudioPlayer.DecodeMode)Enum.Parse(typeof(CSAudioPlayer.DecodeMode), cboPlayerDecodeMode.Text);

            //Set the sample rate to play (from 8000 to 48000):
            audioPlayer1.Samplerate = (CSAudioPlayer.Samplerate)Enum.Parse(typeof(CSAudioPlayer.Samplerate), cboPlayerSamplerate.Text);

            //Set the bit-depth to play (8, 16, 24, 32):
            audioPlayer1.Bits = (CSAudioPlayer.Bits)Enum.Parse(typeof(CSAudioPlayer.Bits), cboPlayerBits.Text);

            //Set the number of the channels to play (1 or 2):
            audioPlayer1.Channels = (CSAudioPlayer.Channels)Enum.Parse(typeof(CSAudioPlayer.Channels), cboPlayerChannels.Text);

            //Set the mode of the player (WASAPI or LineOut):
            audioPlayer1.Mode = (CSAudioPlayer.Mode)Enum.Parse(typeof(CSAudioPlayer.Mode), cboPlayerMode.Text);
            
            if (!audioPlayer1.Open(lblMediaFile.Text))
            {
                MessageBox.Show("Cannot open '" + lblMediaFile.Text + "'");
                return;
            }

            lblPositionTotal.Text = string.Format(@"{0:hh\:mm\:ss}", audioPlayer1.Length);

            //Set the audio device index to play to:
            audioPlayer1.AudioDevice = cboPlayerAudioDevice.SelectedIndex;

            //Set the multimedia file name to play:
            audioPlayer1.FileName = lblMediaFile.Text;

            //Start playing:
            audioPlayer1.Play();

            lblPositionTotal.Text = "audioPlayer1.Length";
            lblPositionTotal.Text = string.Format(@"{0:hh\:mm\:ss}", audioPlayer1.Length);

            //Start the meter timer:
            tmrMeterOut.Interval = 40;
            tmrMeterOut.Enabled = true;

            //Start the position timer:
            tmrPlayerPosition.Interval = 100;
            tmrPlayerPosition.Enabled = true;

        }

        /// <summary>
        /// Pause play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPause_Click(object sender, EventArgs e)
        {
            if (audioPlayer1.PlayingState == CSAudioPlayer.PlayingState.Playing)
                audioPlayer1.Pause();
        }

        /// <summary>
        /// Resume play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdResume_Click(object sender, EventArgs e)
        {
            if (audioPlayer1.PlayingState == CSAudioPlayer.PlayingState.Paused)
                audioPlayer1.Resume();
        }

        /// <summary>
        /// Stop to play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdStop_Click(object sender, EventArgs e)
        {
            //Stop to play.
            audioPlayer1.Stop();

            //Disable the timer of the meter:
            tmrMeterOut.Enabled = false;
        }

        /// <summary>
        /// Show the frmID3TagsEditor:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdID3Tags_Click(object sender, EventArgs e)
        {
            frmID3TagsEditor frmAllID3Tags = new frmID3TagsEditor();

            frmAllID3Tags.LoadFile(lblMediaFile.Text);
            frmAllID3Tags.ShowDialog(this);
        }

        /// <summary>
        /// Open the source file and get some details about it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            lblMediaFile.Text = openFileDialog1.FileName;

            /*
            Set the mode of the decoder, this can be the LocalCodecs which 
            will uses the codecs that installed on the system, or FFMpeg 
            which will uses the FFMpeg libraries. If you decide to use the 
            FFMpeg libraries, please make sure the FFMpeg folder with the 
            dll files is existed in the output directory of the project:
            */
            audioPlayer1.DecodeMode = (CSAudioPlayer.DecodeMode)Enum.Parse(typeof(CSAudioPlayer.DecodeMode), cboPlayerDecodeMode.Text);

            if (!audioPlayer1.Open(lblMediaFile.Text))
            {
                MessageBox.Show("Cannot open the source multimedia file.");
                return;
            }

            lblPositionTotal.Text = string.Format(@"{0:hh\:mm\:ss}", audioPlayer1.Length);

            trckPlayerPosition.Minimum = 0;
            trckPlayerPosition.Maximum = (int)audioPlayer1.Length.TotalSeconds;
            
        }

        private void tmrMeterOut_Tick(object sender, EventArgs e)
        {

            lblMeterOut.Text = audioMeter1.Meter.ToString("0.00");

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            audioPlayer1.UserName = "Your email";
            audioPlayer1.UserKey = "Your registration key";

            #region LoadAudioPlayerProperties

            //Samplerate
            cboPlayerSamplerate.DataSource = audioPlayer1.GetSamplerates();
            cboPlayerSamplerate.Text = "44100";

            //Bit depth
            cboPlayerBits.DataSource = audioPlayer1.GetBits();
            cboPlayerBits.Text = "16";

            //Channels
            cboPlayerChannels.DataSource = audioPlayer1.GetChannels();
            cboPlayerChannels.Text = "2";

            //Decoder Mode
            cboPlayerDecodeMode.DataSource = audioPlayer1.GetDecoderModes();
            cboPlayerDecodeMode.Text = "LocalCodecs";

            //Player mode
            cboPlayerMode.DataSource = audioPlayer1.GetPlayerModes();
            cboPlayerMode.SelectedItem = audioPlayer1.GetEnumValue(audioPlayer1.Mode);

            #endregion

            //Set the volume of the player to 50%
            trckVolume.Value = 50;

            //Set the audio source to the default output device by index:
            cboPlayerAudioDevice.SelectedIndex = audioPlayer1.GetDeviceDefaultIndex();

        }

        /// <summary>
        /// Seek the play to the slider position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trckPlayerPosition_MouseUp(object sender, MouseEventArgs e)
        {
            if (audioPlayer1.PlayingState == CSAudioPlayer.PlayingState.Stopped) return;

            try
            {
                audioPlayer1.Position = TimeSpan.FromSeconds(trckPlayerPosition.Value);
                tmrPlayerPosition.Enabled = true;

            }
            catch (Exception ex)
            {
                //RaiseError(ex);
            }
            finally
            {

            }
        }

        /// <summary>
        /// Disable the tmrPlayerPosition on mouse down.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trckPlayerPosition_MouseDown(object sender, MouseEventArgs e)
        {
            tmrPlayerPosition.Enabled = false;
        }

        /// <summary>
        /// Display the position of the playing operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrPlayerPosition_Tick(object sender, EventArgs e)
        {
            try
            {
                trckPlayerPosition.Value = (int)audioPlayer1.Position.TotalSeconds;

                lblPositionCurrent.Text = string.Format(@"{0:hh\:mm\:ss}", audioPlayer1.Position);

            }
            catch (Exception ex)
            {
                //RaiseError(ex);
            }
            finally
            {

            }
        }

        /// <summary>
        /// Set the volume of the player.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trckVolume_ValueChanged(object sender, EventArgs e)
        {
            audioPlayer1.Volume = trckVolume.Value;

            Console.WriteLine("audioPlayer1.Volume");
            Console.WriteLine(audioPlayer1.Volume);

            lblVolume.Text = trckVolume.Value.ToString();
            
        }

        /// <summary>
        /// Form closing event. Stop the playing process (if any) for safe exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAudioPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region SafeExit

            //Safe exit.
            if (audioPlayer1.PlayingState != CSAudioPlayer.PlayingState.Stopped)
            {
                audioPlayer1.Resume();
                audioPlayer1.Stop();

                while (audioPlayer1.PlayingState != CSAudioPlayer.PlayingState.Stopped)
                    Thread.Sleep(100);

            }

            #endregion
        }

        private void cboPlayerMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected capture mode:
            CSAudioPlayer.Mode mode = (CSAudioPlayer.Mode)Enum.Parse(typeof(CSAudioPlayer.Mode), cboPlayerMode.Text);

            //Get the audio devices:
            cboPlayerAudioDevice.DataSource = audioPlayer1.GetDevices(mode);

            //Try to set the default device:
            int default_device_index = audioPlayer1.GetDeviceDefaultIndex(mode);

            if (default_device_index != -1)
                //Set the default device index:
                cboPlayerAudioDevice.SelectedIndex = default_device_index;
            else
                //LineIn will always return -1:
                cboPlayerAudioDevice.SelectedIndex = 0;
        }

        /// <summary>
        /// Check the license.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCheckLicense_Click(object sender, EventArgs e)
        {
            if (audioPlayer1.CheckLicense())
                MessageBox.Show("Registration is OK");
        }

    }
}
