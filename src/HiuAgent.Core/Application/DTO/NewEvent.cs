using HiuAgent.Core.Domains.Enums;

namespace HiuAgent.Core.Application.DTO;

public record NewEvent
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public LoopType LoopType { get; set; } = LoopType.None;
}