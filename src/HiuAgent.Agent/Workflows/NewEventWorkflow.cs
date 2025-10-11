using HiuAgent.Core.Application.DTO;
using Microsoft.Agents.AI.Workflows;
using Microsoft.Agents.AI.Workflows.Reflection;
using Microsoft.Extensions.AI;

namespace HiuAgent.Core.Workflows;

public class NewEventWorkflow : Workflow<NewEvent>
{

    public NewEventWorkflow(string startExecutorId) : base(startExecutorId)
    {
    }
}