using System.ClientModel;
using Microsoft.Extensions.AI;
using OpenAI;

namespace HiuAgent.Core;

class Program
{
    public static void Main()
    {
        var chatClient =
            new OpenAIClient(new ApiKeyCredential(""),
                    new OpenAIClientOptions()
                    {
                        Endpoint = new Uri("https://generativelanguage.googleapis.com/v1beta/openai/"),
                    }).GetChatClient("gpt-4o-mini")
                .AsIChatClient();
    }
}