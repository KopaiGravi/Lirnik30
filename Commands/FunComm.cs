using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;
using System.Threading.Tasks;

namespace DiscordBotTemplate.Commands
{
    public class FunComm : ApplicationCommandModule
    {
        [SlashCommand("Слава_Україні", "Базована команда")]
        public async Task Baze(InteractionContext ctx)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource,
                new DiscordInteractionResponseBuilder().WithContent("Бот каже: "));

            var embedMessage = new DiscordEmbedBuilder()
            {
                Title = "Героям_Слава!"
            };
            await ctx.Channel.SendMessageAsync(embed: embedMessage);
        }
    }
}
