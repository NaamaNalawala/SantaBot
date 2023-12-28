// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.18.1

using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using SantaBot.Responses;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SantaBot.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var userMessage = turnContext.Activity.Text;
            string replyText;

            if (userMessage.Contains("weather"))
            {
                replyText = "I'm a bot, not a weather station 🌦️";
            }
            else
            {
                replyText = SarcasticResponse.GetRandomResponse();
            }

            await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Hey there, you unsuspecting victim of sibling shenanigans! As the new year unfolds, I've been bestowed with the honor of entertaining you with wit, sarcasm, and a few mind-bending riddles. But first, how's life treating you in the tech-savvy realm of Hyderabad?";
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                }
            }
        }
    }
}
