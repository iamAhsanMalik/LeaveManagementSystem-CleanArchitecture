using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Core.LeaveManagement.Domain.Common;

namespace src.Core.LeaveManagement.Domain.Entities;

public class LeaveAllocation : BaseDomainEntity<int>
{
  public int NumberOfDays { get; set; }
  public LeaveType LeaveType { get; set; } = default!;
  public int LeaveTypeId { get; set; }
  public int Period { get; set; }
  public string? EmployeeId { get; set; }
}
