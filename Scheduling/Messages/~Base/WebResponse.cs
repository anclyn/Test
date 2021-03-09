using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Scheduling.Api.Messages._Base
{
    public class WebResponse<T> : WebResponse
    {
        [JsonProperty("data")]
        public T Data { get; set; }
    }

    public class WebResponse
    {
        private string message;

        public WebResponse()
        {

        }

        [JsonProperty("isSuccessful")]
        public bool IsSuccessful { get; set; }

        [JsonProperty("errors")]
        public ICollection<string> Errors { get; set; }

        [JsonProperty("message")]
        public string Message
        {
            get
            {
                return this.message ?? string.Join(string.Empty, this.Errors);
            }
            set
            {
                this.message = value;
            }
        }

        [JsonProperty("statuscode")]
        public int StatusCode { get; set; }
    }
}
