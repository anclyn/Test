using Scheduling.InfraStructure.Messaging.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduling.InfraStructure.Messaging
{
    public class Response : IResponse
    {
        private string message;
        public bool IsSuccessful { get; set; }
        public ICollection<string> Errors { get; set; }
        
        public int StatusCode { get; set; }

        public Response()
        {
            this.Errors = new List<string>();
            this.StatusCode = 1000;
            this.IsSuccessful = true;
        }


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

        public void SetError(int statusCode)
        {
            this.StatusCode = statusCode;
            this.IsSuccessful = false;
        }
    }
}
