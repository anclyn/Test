using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduling.Services.Models
{
    public class StaffScheduleModel
    {
        public int StaffId { get; set; }

        public Int16 Order { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; }
    }
}
