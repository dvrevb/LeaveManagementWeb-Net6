namespace LeaveManagement.Web.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
        public List<LeaveAllocationVM> LeaveALlocations { get; set; }
    }
}
