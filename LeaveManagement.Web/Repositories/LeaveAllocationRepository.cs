using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManager, ILeaveTypeRepository leaveTypeRepository) : base(context)
        {
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
        }

        public async Task LeaveAllocationAsync(int leaveTypeId)
        {
           var period = DateTime.Now.Year;
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);

            var allocations = new List<LeaveAllocation>();

            foreach(var employee in employees)
            {
                var allocation = new LeaveAllocation
                {
                    NumberOfDays = leaveType.DefaultDays,
                    EmployeeId = employee.Id,
                    Period = period,
                    LeaveTypeId = leaveTypeId

                };

            }
        }
    }
}
