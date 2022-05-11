using LeaveManagement.Application.DTOs;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveAllocation.Request.Queries;

public record GetLeaveAllocationListRequest() : IRequest<IReadOnlyList<LeaveAllocationDTO>>;
