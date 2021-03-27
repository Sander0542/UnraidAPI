using System;
using System.Threading.Tasks;
using GraphQL;
using Sander0542.UnraidAPI.Types;

namespace Sander0542.UnraidAPI.Abstractions
{
    public interface IUnraidApiClient : IDisposable
    {
        Task<GraphQLResponse<Query>> Query(GraphQLRequest request);

        Task<GraphQLResponse<Mutation>> Mutation(GraphQLRequest request);
    }
}
