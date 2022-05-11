using LeaveManagement.Application.DTOs;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveType.Request.Queries;

public record GetLeaveTypeListRequest() : IRequest<IReadOnlyList<LeaveTypeDTO>>;
