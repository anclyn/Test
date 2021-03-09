using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduling.InfraStructure.Messaging.Interface
{
    public interface IResponse
    {
        bool IsSuccessful { get; set; }

        ICollection<string> Errors { get; set; }

        string Message { get; set; }

        int StatusCode { get; set; }

        void SetError(int statusCode);
    }
}
