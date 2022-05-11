using AutoMapper;
using LeaveManagement.Application.Contracts.Persistence;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.Features.LeaveAllocation.Request.Queries;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveAllocation.Handlers.Queries;

public class GetLeaveAllocationRequestHandler : IRequestHandler<GetLeaveAllocationRequest, LeaveAllocationDTO>
{
  private readonly IMapper _mapper;
  private readonly ILeaveAllocationRepository _leaveAllocationRepository;

  public GetLeaveAllocationRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
  {
    _leaveAllocationRepository = leaveAllocationRepository;
    _mapper = mapper;
  }
  public async Task<LeaveAllocationDTO> Handle(GetLeaveAllocationRequest request, CancellationToken cancellationToken)
  {
    return _mapper.Map<LeaveAllocationDTO>(await _leaveAllocationRepository.GetLeaveAllocationAsync<int>(request.Id));
  }
}
