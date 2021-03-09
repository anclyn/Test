using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduling.Api.Messages._Base
{
    public class WebRequest
    {
    }
    public class WebRequest<T> : WebRequest
    {
        public T Data { get; set; }
    }
}
