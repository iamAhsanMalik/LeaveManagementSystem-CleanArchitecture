using AutoMapper;
using LeaveManagement.Application.Contracts.Persistence;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.Features.LeaveType.Request.Queries;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveType.Handlers.Queries;

public class GetLeaveTypeRequestHandler : IRequestHandler<GetLeaveTypeRequest, LeaveTypeDTO>
{
  private readonly ILeaveTypeRepository _leaveTypeRepository;
  private readonly IMapper _mapper;

  public GetLeaveTypeRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
  {
    _leaveTypeRepository = leaveTypeRepository;
    _mapper = mapper;
  }
  public async Task<LeaveTypeDTO> Handle(GetLeaveTypeRequest request, CancellationToken cancellationToken)
  {
    return _mapper.Map<LeaveTypeDTO>(await _leaveTypeRepository.GetAsync(request.Id));
  }
}
