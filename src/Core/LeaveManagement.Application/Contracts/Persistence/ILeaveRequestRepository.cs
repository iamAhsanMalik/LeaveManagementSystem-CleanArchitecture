using src.Core.LeaveManagement.Domain.Entities;

namespace LeaveManagement.Application.Contracts.Persistence;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<LeaveRequest> GetLeaveRequestAsync<T>(T id);
    Task<List<LeaveRequest>> GetLeaveRequestsAsync();
    Task ChangeApprovalStatusAsync(LeaveRequest leaveRequest, bool? ApprovalStatus);
}