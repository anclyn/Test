using System;

namespace Scheduling.Services
{
    public class AddStaffScheduleRequest
    {
        public Int16 Order { get; set; }
        
        public string CreatedBy { get; set; }
    }
}