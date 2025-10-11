using HiuAgent.Core.Application.DTO;
using Microsoft.Agents.AI.Workflows;

namespace HiuAgent.Core.Workflows;

public class EventUpdateWorkflow : Workflow<EventUpdate>
{

    public EventUpdateWorkflow(string startExecutorId) : base(startExecutorId)
    {
    }
}