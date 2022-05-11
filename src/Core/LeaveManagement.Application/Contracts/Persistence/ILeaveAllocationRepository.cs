using src.Core.LeaveManagement.Domain.Entities;

namespace LeaveManagement.Application.Contracts.Persistence;

public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
{
    Task<LeaveAllocation> GetLeaveAllocationAsync<T>(T id);
    Task<List<LeaveAllocation>> GetLeaveAllocationsAsync();
    Task<bool> AllocationExistsAsync(string userId, int leaveTypeId, int period);
    Task AddAllocationsAsync(List<LeaveAllocation> allocations);
    Task<LeaveAllocation> GetUserAllocationsAsync(string userId, int leaveTypeId);
}