using System;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;
using System.Drawing;

namespace Raspberry
{
    public partial class RaspberryForm : Form
    {
        public static DiscordSocketClient _client;
        public RaspberryForm()
        {
            InitializeComponent();   
        }
        private void Raspberry_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Raspberry_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (DisconnectButton.Text == "Quit")
            {
                Environment.Exit(0);
            }
            else
            {
                _client.StopAsync();
                ConnectButton.Enabled = true;
                DisconnectButton.Text = "Quit";
            }
        }
        public Task Log(LogMessage msg)
        {
            System.Console.WriteLine(msg);
            ConsoleBox.AppendText(msg.ToString());
            return Task.CompletedTask;
        }

        private void RaspberryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Environment.Exit(0); }
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            
            _client = new DiscordSocketClient(new DiscordSocketConfig()
            { LogLevel = LogSeverity.Verbose });
            _client.Log += Log;
            ConsoleBox.AppendText("Connecting..." + "\n");
            
            string token = Program.Token();
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
            ConnectButton.Enabled = false;
            DisconnectButton.Text = "Disconnect";
            await Task.Delay(-1);
        }
    }
}
