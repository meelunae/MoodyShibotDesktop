using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EleunameBot
{
    public partial class Poll : Form
    {
        public static bool PollRunning = false;
        public static string myConnectionString = "sqlcreds";
        public static string answer1 = "";
        public static string answer2 = "";
        public static int count2 = 0;
        public static int count1 = 0;
        public static double percentage1 = 0;
        public static double percentage2 = 0;
        public static double max = 0;
        public static int pointsaw = 0; //points awarded with the question
        public static List<string> voters = new List<string>();
        public static List<string> ans1vote = new List<string>();
        public static List<string> ans2vote = new List<string>();
        public Poll()
        {
            InitializeComponent();
        }

        private void Poll_Load(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            PollRunning = true;
            timer1.Enabled = true;
            timer1.Start();
            answer1 = answer1Text.Text;
            answer2 = answer2Text.Text;
            pointsaw = int.Parse(pointsNumber.Text);
            Form1.client.SendMessage(Form1.client.JoinedChannels[0], "Question: " + questionText.Text + " Possible answers: " + answer1 + "/" + answer2 + ". You have 45 seconds to answer. This question is worth " + pointsaw + "points.");

        }

        private void cancelPoll_Click(object sender, EventArgs e)
        {
            max = count1 + count2;
            percentage1 = (count1/max ) * 100;
            percentage2 = (count2 / max) * 100;
            Form1.client.SendMessage(Form1.client.JoinedChannels[0], "Poll cancelled, the answers submitted until now are not valid.");
            pointsaw = 0;
            max = 0;
            count1 = 0;
            count2 = 0;
            voters.Clear();
            questionText.Clear();
            answer1Text.Clear();
            answer2Text.Clear();
            timer1.Enabled = false;
            PollRunning = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            max = count1 + count2;
            percentage1 = (count1 / max) * 100;
            percentage2 = (count2 / max) * 100;
            Form1.client.SendMessage(Form1.client.JoinedChannels[0], "Voting time has ended and no more answers are accepted, thanks for voting! The " + Math.Round(percentage1, 2) + "% of you voted " + answer1 + " and the " + Math.Round(percentage2, 2) + "% of you voted " + answer2 + ".");
            max = 0;
            count1 = 0;
            count2 = 0;
            voters.Clear();
            questionText.Clear();
            answer1Text.Clear();
            answer2Text.Clear();
            timer1.Enabled = false;
        }

        private void verifyAns_Click(object sender, EventArgs e)
        {
            if (PollRunning == true)
            {
                if (comboBox1.Text == "Answer 1")
                {
                    Form1.client.SendMessage(Form1.client.JoinedChannels[0], "Correct answer was " + answer1 + "! " + pointsaw + " points have been awarded to everyone who voted the correct answer!");
                    foreach (var username in ans1vote)
                    {
                        string sql = $"INSERT Users (username,points) values ('{username}', {pointsaw}) ON DUPLICATE KEY UPDATE points = points + {pointsaw}";
                        MySqlConnection cnn;
                        cnn = new MySqlConnection(myConnectionString);
                        cnn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        cmd.ExecuteNonQuery();

                        PollRunning = false;
                    }
                    foreach (var username in ans2vote)
                    {
                        string sql = $"INSERT INTO Users (username,points) values ('{username}', {pointsaw}) ON DUPLICATE KEY UPDATE points = points = points - {pointsaw}";                        MySqlConnection cnn;
                        cnn = new MySqlConnection(myConnectionString);
                        cnn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        cmd.ExecuteNonQuery();

                        PollRunning = false;
                    }
                }
                if (comboBox1.Text == "Answer 2")
                {
                    Form1.client.SendMessage(Form1.client.JoinedChannels[0], "Correct answer was " + answer2 + "! " + pointsaw + " points have been awarded to everyone who voted the correct answer!");
                    foreach (var username in ans2vote)
                    {
                        string sql = $"INSERT INTO users (username,points) values ('{username}', {pointsaw}) ON DUPLICATE KEY UPDATE points = points = points + {pointsaw}";
                        MySqlConnection cnn;
                        cnn = new MySqlConnection(myConnectionString);
                        cnn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        cmd.ExecuteNonQuery();
                    }
                    foreach (var username in ans1vote)
                    {
                        string sql = $"INSERT IGNORE INTO Users (username,points) values ('{username}', {pointsaw}) ON DUPLICATE KEY UPDATE points = points - {pointsaw}";
                        MySqlConnection cnn;
                        cnn = new MySqlConnection(myConnectionString);
                        cnn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            else
            {
                MessageBox.Show("No poll is currently running!");
            }
        }
    }
}
