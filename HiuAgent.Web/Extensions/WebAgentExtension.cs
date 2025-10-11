using HiuAgent.Core.Agent;

namespace HiuAgent.Extensions;

public static class WebAgentExtension
{
    public static WebApplicationBuilder AddAgent(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<CalendarAgent>();

        return builder;
    }
}