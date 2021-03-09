using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling.Services
{
    public interface IStaffScheduleServices
    {
        Task<AddStaffScheduleResponse> AddStaffScheduleAsync(AddStaffScheduleRequest request);

        Task<GetStaffScheduleResponse> GetStaffScheduleAsync();
    }
}
