
using Duler.Agent.Agent;

namespace Duler.Extensions;

public static class WebAgentExtension
{
    public static WebApplicationBuilder AddAgent(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<CalendarAgent>();

        return builder;
    }
}