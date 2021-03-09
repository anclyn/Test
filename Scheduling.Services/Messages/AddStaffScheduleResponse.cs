using System;

namespace Scheduling.Services
{
    public class AddStaffScheduleResponse
    {
        public int StaffId { get; set; }

        public int Order { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; }
    }
}