using src.Core.LeaveManagement.Domain.Common;

namespace src.Core.LeaveManagement.Domain.Entities;

public class LeaveType : BaseDomainEntity<int>
{
  public string? Name { get; set; }
  public int DefaultDays { get; set; }
}
