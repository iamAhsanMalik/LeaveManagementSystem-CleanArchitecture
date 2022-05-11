using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.DTOs.Common;

namespace LeaveManagement.Application.DTOs;

public class LeaveTypeDTO : BaseDTO<int>
{
  public string? Name { get; set; }
  public int DefaultDays { get; set; }
}
