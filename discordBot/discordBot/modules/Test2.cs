using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord.Net;

namespace discordBot.Modules
{
    public class Test2 : ModuleBase<SocketCommandContext>
    {
        [Command("Test")]

        public async Task Asdasd()
        {
            await Context.Channel.SendMessageAsync("test success!");
        }


        [Command("English")]
        public async Task Asdf()
        {
            await Context.User.
        }
    }
}
