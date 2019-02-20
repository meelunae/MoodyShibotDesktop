using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace EleunameBot
{
    public partial class TTS : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        string result = "";

        public TTS()
        {
            this.FormClosing += new FormClosingEventHandler(TTS_FormClosing);
            InitializeComponent();
        }

        private void TTS_Load(object sender, EventArgs e)
        {

            //properties
            synth.Volume = 50;
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoice("Microsoft Zira Desktop");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var current = synth.GetCurrentlySpokenPrompt();

            if (current != null)
            {
                synth.SpeakAsyncCancel(current);
            }
            if (textBox1.Text.ToString() != "")
            {
                synth.SpeakAsync(textBox1.Text);
            }
            else
            {
                MessageBox.Show("You need to write something in the text box!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                result = System.IO.File.ReadAllText(openFileDialog1.FileName);
                label3.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var current = synth.GetCurrentlySpokenPrompt();

            if (current != null)
            {
                synth.SpeakAsyncCancel(current);
            }
            if (label3.Text.ToString() != "")
            {
                synth.SpeakAsync(result);
            }
        }

        private void TTS_FormClosing(object sender, FormClosingEventArgs e)
        {
            var current = synth.GetCurrentlySpokenPrompt();
            synth.SpeakAsyncCancel(current);
        }

    }
}
