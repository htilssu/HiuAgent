using Duler.Core.Application.DTO;
using Microsoft.Agents.AI.Workflows;

namespace Duler.Agent.Workflows;

public class EventUpdateWorkflow : Workflow<EventUpdate>
{

    public EventUpdateWorkflow(string startExecutorId) : base(startExecutorId)
    {
    }
}