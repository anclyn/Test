using Scheduling.Api.Messages._Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduling.Api.Messages
{
    public class AddScheduleStaffWebRequest : WebRequest
    {
        [Required]
        public Int16 Order { get; set; }

        [Required]
        public string CreatedBy { get; set; }
    }
}
