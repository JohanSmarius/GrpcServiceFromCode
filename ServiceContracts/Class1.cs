using System;
using System.Collections.Concurrent;
using System.ServiceModel;
using System.Threading.Tasks;
using ProtoBuf;

namespace ServiceContracts
{
    [ProtoContract]
    public class EchoRequest
    {
        [ProtoMember(1)]
        public string Message { get; set; }
    }

    [ProtoContract]
    public class EchoResponse
    {
        [ProtoMember(1)]
        public string Message { get; set; }
    }

    [ServiceContract(Name = "SDN.EchoService")]
    public interface IEchoService
    {
        [OperationContract]
        ValueTask<EchoResponse> EchoMessage(EchoRequest request);
    }
}
