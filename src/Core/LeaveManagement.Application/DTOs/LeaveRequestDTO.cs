using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.DTOs.Common;

namespace LeaveManagement.Application.DTOs;

public class LeaveRequestDTO : BaseDTO<int>
{
  public DateTime StartDate { get; set; }
  public DateTime EndDate { get; set; }
  public LeaveTypeDTO LeaveTypeDTO { get; set; } = default!;
  public int FKLeaveTypeId { get; set; }
  public DateTime DateRequested { get; set; }
  public string? RequestComments { get; set; }
  public DateTime DateActioned { get; set; }
  public bool? Approved { get; set; }
  public bool Cancelled { get; set; }
  public string? RequestingEmployeeId { get; set; }
}
