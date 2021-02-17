using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;
using ServiceContracts;

namespace TestClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var echoService = channel.CreateGrpcService<IEchoService>();

            var result = await echoService.EchoMessage(new EchoRequest() {Message = "Hello SDN"});
            
            Console.WriteLine(result.Message);
        }
    }
}
