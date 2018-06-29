using System;
using System.Buffers;
using System.Threading.Tasks;
using ProGaudi.Tarantool.Client.Model;

namespace ProGaudi.Tarantool.Client
{
    public interface ILogicalConnection : IDisposable
    {
        Task Connect();

        bool IsConnected();

        Result<object> SendRequestWithEmptyResponse<TRequest>(TRequest request, TimeSpan? timeout = null)
            where TRequest : IRequest;

        Result<TResponse> SendRequest<TRequest, TResponse>(TRequest request, TimeSpan? timeout = null)
            where TRequest : IRequest;

        //Task<DataResponse> SendRequest<TRequest>(TRequest request, TimeSpan? timeout = null)
        //    where TRequest : IRequest;

        //Task<IMemoryOwner<byte>> SendRawRequest<TRequest>(TRequest request, TimeSpan? timeout = null)
        //    where TRequest : IRequest;

        uint PingsFailedByTimeoutCount { get; }
    }
}