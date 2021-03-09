using Scheduling.InfraStructure.Messaging;
using Scheduling.Services.Models;
using System.Collections.Generic;

namespace Scheduling.Services
{
    public class GetStaffScheduleResponse : Response
    {
         public List<StaffScheduleModel> Data { get; set; }
    }
}