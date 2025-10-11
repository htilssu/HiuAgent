using System.Text.Json;
using Microsoft.Agents.AI;
using Microsoft.Extensions.Logging;
using OpenAI;
using OpenAI.Chat;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace HiuAgent.Core.Agent;

public class CalendarAgent: OpenAIChatClientAgent
{


    public CalendarAgent(ChatClient client, string? instructions = null, string? name = null, string? description = null, ILoggerFactory? loggerFactory = null) : base(client, instructions, name, description, loggerFactory)
    {
    }

    public CalendarAgent(ChatClient client, ChatClientAgentOptions options, ILoggerFactory? loggerFactory = null) : base(client, options, loggerFactory)
    {
    }
}