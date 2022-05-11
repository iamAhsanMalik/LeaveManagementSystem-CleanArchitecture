using LeaveManagement.Application.DTOs;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveType.Request.Queries;

public record GetLeaveTypeRequest(int Id) : IRequest<LeaveTypeDTO>;

// public class GetLeaveTypeRequest : IRequest<LeaveTypeDTO>
// {
//   public int Id { get; set; }
// }