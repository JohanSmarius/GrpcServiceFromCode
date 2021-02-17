using System.Threading.Tasks;
using ServiceContracts;

namespace GrpcServiceFromCode
{
    public class EchoService : IEchoService
    {
        public ValueTask<EchoResponse> EchoMessage(EchoRequest request)
        {
            var response = new EchoResponse()
            {
                Message = $"Echo {request.Message}" 
            };

            return new ValueTask<EchoResponse>(response);
        }
    }
}