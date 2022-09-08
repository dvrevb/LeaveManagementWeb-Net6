using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            //CreateMap<LeaveType, LeaveTypeVM>().ForMember(dest => dest.LeaveTypeId, opt => opt.MapFrom(src => src.Id)).ReverseMap();    // source dest
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();   
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationEditVM>().ReverseMap();
        
        }
        
    }
}
