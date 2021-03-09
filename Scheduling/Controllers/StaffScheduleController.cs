using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scheduling.Services;
using Scheduling.Api.Messages._Extension;
using Scheduling.Api.Messages;

namespace Scheduling.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StaffScheduleController : ControllerBase
    {
        private readonly IStaffScheduleServices _staffScheduleService;

        public StaffScheduleController(IStaffScheduleServices staffScheduleServices)
        {
            _staffScheduleService = staffScheduleServices;
        }
        /// <summary>
        /// Adding Staff Order
        /// </summary>
        /// <param name="request"></param>
        /// <returns>List of Staff Order</returns>
        [HttpPost("AddStaffOrder")]
        public async Task<IActionResult> AddStaffOrder([FromBody]AddScheduleStaffWebRequest request)
        {
            var response = await _staffScheduleService.AddStaffScheduleAsync(request.AsRequest());
            return CreatedAtAction("GetStaffOrder", null);
        }

        /// <summary>
        /// Getting list of staff order
        /// </summary>
        /// <returns>List of Staff Order</returns>
        [HttpGet]
        public async Task<IActionResult> GetStaffOrder()
        {
            var response = await _staffScheduleService.GetStaffScheduleAsync();
            var result = this.CreateResponse(response.AsResponse());

            return result;
        }
    }
}
