using Microsoft.AspNetCore.Mvc;
using Scheduling.Api.Messages._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduling.Api.Messages._Extension
{
    public static class ContollerExtensions
    {
        public static IActionResult CreateResponse<T>(this ControllerBase controller, T value) where T : WebResponse
        {
            var result = default(IActionResult);
            result = value.IsSuccessful ? (IActionResult)new OkObjectResult(value) : new BadRequestObjectResult(value);
            return result;
        }

        public static ActionResult<T> CreateWebResponse<T>(this ControllerBase controller, T value) where T : WebResponse
        {
            return value.IsSuccessful ? (ActionResult)new OkObjectResult(value) : new BadRequestObjectResult(value);
        }
    }
}
