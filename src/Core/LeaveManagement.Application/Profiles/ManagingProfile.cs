using AutoMapper;
using LeaveManagement.Application.DTOs;
using src.Core.LeaveManagement.Domain.Entities;

namespace LeaveManagement.Application.Profiles;

public class ManagingProfile : Profile
{
    public ManagingProfile()
    {
        CreateMap<LeaveType, LeaveTypeDTO>().ReverseMap();
        CreateMap<LeaveAllocation, LeaveAllocationDTO>().ReverseMap();
        CreateMap<LeaveRequest, LeaveRequestDTO>().ReverseMap();
    }
}