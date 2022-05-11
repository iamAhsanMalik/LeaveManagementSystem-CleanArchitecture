using AutoMapper;
using LeaveManagement.Application.Contracts.Persistence;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.Features.LeaveAllocation.Request.Queries;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveAllocation.Handlers.Queries;

public class GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, IReadOnlyList<LeaveAllocationDTO>>
{
  private readonly IMapper _mapper;
  private readonly ILeaveAllocationRepository _leaveAllocationRepository;

  public GetLeaveAllocationListRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
  {
    _leaveAllocationRepository = leaveAllocationRepository;
    _mapper = mapper;
  }
  public async Task<IReadOnlyList<LeaveAllocationDTO>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
  {
    return _mapper.Map<IReadOnlyList<LeaveAllocationDTO>>(await _leaveAllocationRepository.GetAllAsync());
  }
}
