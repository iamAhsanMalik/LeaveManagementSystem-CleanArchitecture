using src.Core.LeaveManagement.Domain.Common;
namespace src.Core.LeaveManagement.Domain.Entities;

public class LeaveRequest : BaseDomainEntity<int>
{
  public DateTime StartDate { get; set; }
  public DateTime EndDate { get; set; }
  public LeaveType LeaveType { get; set; } = default!;
  public int FKLeaveTypeId { get; set; }
  public DateTime DateRequested { get; set; }
  public string? RequestComments { get; set; }
  public DateTime DateActioned { get; set; }
  public bool? Approved { get; set; }
  public bool Cancelled { get; set; }
  public string? RequestingEmployeeId { get; set; }
}
