using System.Collections.Specialized;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Media;
using System.Diagnostics;
using System.Runtime.InteropServices;
using TwitchLib;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Api;
using TwitchLib.Api.Models.Helix.Users.GetUsersFollows;
using TwitchLib.Api.Models.v5.Subscriptions;
using MySql.Data.MySqlClient;
namespace EleunameBot
{
    public partial class Form1 : Form
    {
        #region Variables
        public static TwitchClient client;
        public static Random rnd = new Random();
        public static TwitchAPI api;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        ConnectionCredentials credentials = new ConnectionCredentials("moodyshibot", "oauth:6bfjh01v62ssekfyc2x1j33bi9f1oz");
        OnNewSubscriberArgs args = new OnNewSubscriberArgs();
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        const int MOD_CONTROL = 0x0002;
        const int MOD_SHIFT = 0x0004;
        const int WM_HOTKEY = 0x0312;
        public int subscriptionbonus = 2500;
        public static string[] songhistory = null;
        public int wincount = 0;
        public int losecount = 0;
        public double maximum = 0;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new TwitchClient();
            client.Initialize(credentials, "peachyinu");
            Control.CheckForIllegalCrossThreadCalls = false;
            client.OnJoinedChannel += onJoinedChannel;
            client.OnMessageReceived += onMessageReceived;
            client.Connect();
            RegisterHotKey(this.Handle, 1, MOD_SHIFT, (int)Keys.F10);
            RegisterHotKey(this.Handle, 2, MOD_SHIFT, (int)Keys.F11);
            RegisterHotKey(this.Handle, 3, MOD_SHIFT, (int)Keys.F1);
            RegisterHotKey(this.Handle, 4, MOD_CONTROL, (int)Keys.F12);
            RegisterHotKey(this.Handle, 5, MOD_SHIFT, (int)Keys.F9);
            RegisterHotKey(this.Handle, 6, MOD_SHIFT, (int)Keys.F8);

        }

        #region Hotkey Stuff
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 1)
            {
                player.SoundLocation = @"whyworry.wav";
                player.Play();
            }


            if (m.Msg == WM_HOTKEY && (int)m.WParam == 2)
            {
                player.SoundLocation = @"suck.wav";
                player.Play();
            }
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 5)
            {
                player.SoundLocation = @"mii.wav";
                player.Play();
            }

            if (m.Msg == WM_HOTKEY && (int)m.WParam == 6)
            {
                player.SoundLocation = @"remember.wav";
                player.Play();
            }
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 3)
            {
                player.Stop();
            }
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 4)
            {

            }
        }
        #endregion

        private void onJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            chatBox.Text = chatBox.Text + "Successfully connected to Twitch!" + Environment.NewLine;
        }
        private void onMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            chatBox.Text = chatBox.Text + e.ChatMessage.Username + ": " + e.ChatMessage.Message + Environment.NewLine;
            if(e.ChatMessage.Message.Contains("has requested") && e.ChatMessage.Username == "moodyshibot")
            {
                
                listBox1.Items.Add(e.ChatMessage.Message);
            }
            if (Poll.PollRunning == true)
                { 
                if(e.ChatMessage.Message.Equals(Poll.answer1, StringComparison.CurrentCultureIgnoreCase))
                {
                 
                    if (!Poll.voters.Contains(e.ChatMessage.Username))
                    {
                        Poll.voters.Add(e.ChatMessage.Username);
                        Poll.ans1vote.Add(e.ChatMessage.Username);
                        Poll.count1 = Poll.count1 + 1;
                        listBox2.Items.Add(e.ChatMessage.Username + " voted " + Poll.answer1);
                    }
                }  
            if (e.ChatMessage.Message.Equals(Poll.answer2, StringComparison.CurrentCultureIgnoreCase))
            {
                if (!Poll.voters.Contains(e.ChatMessage.Username))
                    {
                    Poll.voters.Add(e.ChatMessage.Username);
                    Poll.ans2vote.Add(e.ChatMessage.Username);
                    Poll.count2 = Poll.count2 + 1;
                    listBox2.Items.Add(e.ChatMessage.Username + " voted " + Poll.answer2);
                    }
                }
            }
            }
        private void Poll_Click(object sender, EventArgs e)
        {
            Poll f = new Poll();
            f.ShowDialog();
        } 

        private void timer1_Tick(object sender, EventArgs e)
        {
            //client.SendMessage(client.JoinedChannels[0], "Potato");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            chatBox.SelectionStart = chatBox.Text.Length;
            chatBox.ScrollToCaret();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TTS frm = new TTS();
            frm.Show();
        }
    }
}
