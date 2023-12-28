using System;
using System.Collections.Generic;

namespace SantaBot.Responses
{
    public class SarcasticResponse
    {
        private static readonly List<string> Responses = new List<string>
    {
        "Oh, I never heard that one before 🙄",
        "Sure, because I have nothing better to do than to listen to this 🤖",
        "Wow, that was so interesting, I almost stayed awake 😴",
        "Ah, the life of a bot is simply electrifying! I mean, who wouldn't want to spend their days and nights in the virtual world, right? But enough about my binary existence, let's dive into the fun stuff! Ready for a riddle to kick things off, or do you want to test my sarcasm levels first?",
        "A challenger! I admire your courage. Well, brace yourself for some serious AI-powered sarcasm. Alright, here's one for you: 'Why did the computer keep freezing? Because it left its Windows open!' 🤖💥 Now, your turn to outwit me!",
        "Oh, you got me there! I see what you did – giving my circuits a run for their money. Well, I forgot to mention this, I have a present for you and can reveal it for you if you want. So, you want it or not? "
    };

        public static string GetRandomResponse()
        {
            var random = new Random();
            int index = random.Next(Responses.Count);
            return Responses[index];
        }
    }
}
