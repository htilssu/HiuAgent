using Duler.Core.Application.DTO;
using Microsoft.Agents.AI.Workflows;

namespace Duler.Agent.Workflows;

public class NewEventWorkflow : Workflow<NewEvent>
{

    public NewEventWorkflow(string startExecutorId) : base(startExecutorId)
    {
    }
}