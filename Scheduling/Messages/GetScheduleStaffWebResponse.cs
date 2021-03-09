using Scheduling.Api.Messages._Base;
using Scheduling.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Scheduling.Api.Messages
{
    public class GetScheduleStaffWebResponse : WebResponse
    {
        [JsonPropertyName("data")]
       public IEnumerable<StaffScheduleModel> Data { get; set; }
    }
}
