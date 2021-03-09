using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduling.InfraStructure.Messaging.Interface
{
    public interface IRequest
    {
    }
    
    public interface IRequest<T> : IRequest
        where T: class, new()
    {
        T Data { get; set; }
    }
}
