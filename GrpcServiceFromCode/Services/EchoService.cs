using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ServiceContracts;

namespace GrpcServiceFromCode
{
    public class EchoService : IEchoService
    {
        private readonly ILogger<EchoService> _logger;

        public EchoService(ILogger<EchoService> logger)
        {
            _logger = logger;
        }

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