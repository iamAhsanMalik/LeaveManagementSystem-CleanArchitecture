using AutoMapper;
using LeaveManagement.Application.Contracts.Persistence;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.Features.LeaveType.Request.Queries;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveType.Handlers.Queries;

public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, IReadOnlyList<LeaveTypeDTO>>
{
  private readonly ILeaveTypeRepository _leaveTypeRepository;
  private readonly IMapper _mapper;

  public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
  {
    _leaveTypeRepository = leaveTypeRepository;
    _mapper = mapper;
  }
  public async Task<IReadOnlyList<LeaveTypeDTO>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
  {
    return _mapper.Map<IReadOnlyList<LeaveTypeDTO>>(await _leaveTypeRepository.GetAllAsync());
  }
}
