using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Scheduling.Data.Models
{
    public partial class StaffScheduleList
    {
        [Key]
        public int StaffId { get; set; }
        public short Order { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
