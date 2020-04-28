using System;
using System.Net.Http;
using System.Threading.Tasks;
using GrpcService1;
using Grpc.Net.Client;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.AddPost();
            Console.WriteLine("Post added");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
