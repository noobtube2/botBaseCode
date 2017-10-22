using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            new CommandHandler();

            await _client.LoginAsync(TokenType.Bot, "MzcxNjg2Mjk0MTkyOTE0NDM0.DM5e0Q.0GTIaDCHGlmDGHtj_MpCk0FpzJI");

            await _client.StartAsync();

            _handler = new CommandHandler();

            await _handler.InitializeAsync(_client);

            await Task.Delay(-1);
        }

    }

}