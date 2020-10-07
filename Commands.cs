using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task BotHelp()
        {
            await ReplyAsync("BOT HELP: \n Use * as prefix \n help \n commands");
        }

        [Command("commands")]
        public async Task BotCommands()
        {
            await ReplyAsync("BOT COMMANDS: \n Use * as prefix \n ping \n roll \n agenda \n puntjes \n saus ");
        }

        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Pong");
        }

        [Command("roll")]
        public async Task Roll()
        {
            Random dobbelsteen = new Random();
            await ReplyAsync("Your roll: " + dobbelsteen.Next(0, 7));
        }

        [Command("agenda")]
        public async Task Agenda()
        {
            await ReplyAsync("https://kolvw.caspr.be/LeerlingApp/Agenda");
        }

        [Command("puntjes")]
        public async Task Puntenboek()
        {
            await ReplyAsync("https://kolvw.caspr.be/LeerlingApp/Puntenboek");
        }

        [Command("saus")]
        public async Task Saus()
        {
            await ReplyAsync("Mag ik u ticketje zien?");
        }
    }
}
