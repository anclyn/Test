using Scheduling.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduling.Api.Messages._Extension
{
    public static class ScheduledOrderExtension
    {
        public static AddStaffScheduleRequest AsRequest(this AddScheduleStaffWebRequest webRequest)
        {
            return new AddStaffScheduleRequest
            {
                Order = webRequest.Order,
                CreatedBy = webRequest.CreatedBy
            };
        }

        public static GetScheduleStaffWebResponse AsResponse(this GetStaffScheduleResponse response)
        {
            return new GetScheduleStaffWebResponse
            {
                Data = response.Data,
                Errors = response.Errors,
                IsSuccessful = response.IsSuccessful,
                Message = response.Message,
                StatusCode = response.StatusCode
            };
        }

    }
}
