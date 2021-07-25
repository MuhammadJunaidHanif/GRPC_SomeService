using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;

namespace SomeService.Protos
{
    public class SomeServiceImplementation : SomeServiceApi.SomeServiceApiBase
    {
        public override Task<AddNumbersResponse> AddNumbers(AddNumbersRequest request, ServerCallContext context) =>
            Task.FromResult(
                new AddNumbersResponse {
                    Sum = request.NumA + request.NumB
                }
            );

        public override Task<AddNumbersFromArrayResponse> AddNumbersFromArray(AddNumbersFromArrayRequest request, ServerCallContext context) =>
            Task.FromResult(
                new AddNumbersFromArrayResponse {
                    Sum = request.Numbers.Sum()
                }
            );
    }
}
