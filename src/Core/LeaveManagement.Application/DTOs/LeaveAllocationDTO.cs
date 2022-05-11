using LeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Application.DTOs;

public class LeaveAllocationDTO : BaseDTO<int>
{
  public int NumberOfDays { get; set; }
  public LeaveTypeDTO LeaveTypeDTO { get; set; } = default!;
  public int LeaveTypeId { get; set; }
  public int Period { get; set; }
  public string? EmployeeId { get; set; }
}
