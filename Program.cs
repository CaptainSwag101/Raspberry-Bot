using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.WebSocket;
using Discord.Commands;

namespace Raspberry
{
    public class Program
    {
        public static void Main()
            => new Program().MainAsync().GetAwaiter().GetResult();
        public async Task MainAsync()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WarningForm());
            Application.Run(new RaspberryForm());
            await Task.Delay(-1);

        }
        public static string Token() //Grabs Bot Token from token.txt
        {
            string token = "";
            if (File.Exists("token.txt"))
                token = File.ReadAllText("token.txt");
            else
                File.CreateText("token.txt").Close();
            return token;
        }

        /*
        public static Task Log(LogMessage msg)
        {
            RaspberryForm.Invoke((Action)delegate
            {
                ConsoleBox.AppendText(msg + "\n");
            });
            return null;
        }
        */
    }
}

/*
public async Task MainAsync()
{
    _client = new DiscordSocketClient();
    _client.Log += Log;
    _client.Ready += Ready;
    string token = Token();
    await _client.LoginAsync(TokenType.Bot, token);
    await _client.StartAsync();
    await Task.Delay(-1);
}

        public async Task Ready()
        {
            if (!Application.OpenForms.OfType<RaspberryForm>().Any())
            {
                Raspberry.RaspberryForm form = new Raspberry.RaspberryForm();
                await Task.Run(() => { form.ShowDialog(); });
            }
        }
*/