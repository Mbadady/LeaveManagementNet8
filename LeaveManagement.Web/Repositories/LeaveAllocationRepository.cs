﻿using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManager, ILeaveTypeRepository leaveTypeRepository) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId
                                                      && q.LeaveTypeId == leaveTypeId
                                                      && q.Period == period);
        }

        public async Task LeaveAllocationAsync(int leaveTypeId)
        {
           var period = DateTime.Now.Year;
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);

            var allocations = new List<LeaveAllocation>();

            foreach(var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;
                var allocation = new LeaveAllocation
                {
                    NumberOfDays = leaveType.DefaultDays,
                    EmployeeId = employee.Id,
                    Period = period,
                    LeaveTypeId = leaveTypeId

                };
                allocations.Add(allocation);
            }

            await AddRangeAsync(allocations);
        }
    }
}
