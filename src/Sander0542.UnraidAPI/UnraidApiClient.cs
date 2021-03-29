using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;
using Microsoft.Extensions.Options;
using Sander0542.UnraidAPI.Abstractions;
using Sander0542.UnraidAPI.Types;

namespace Sander0542.UnraidAPI
{
    public class UnraidApiClient : IUnraidApiClient
    {
        private readonly GraphQLHttpClient _graphQlClient;
        
        public UnraidApiClient(string serverAddress, string apiKey) : this(o => {
            o.ServerAddress = serverAddress;
            o.ApiKey = apiKey;
        })
        {
        }

        public UnraidApiClient(Action<UnraidApiClientOptions> configure) : this(configure.New())
        {
        }

        public UnraidApiClient(IOptions<UnraidApiClientOptions> options) : this(options.Value)
        {
        }

        public UnraidApiClient(UnraidApiClientOptions options)
        {
            var endPoint = new Uri(new Uri(options.ServerAddress), "graphql");

            _graphQlClient = new GraphQLHttpClient(endPoint, new SystemTextJsonSerializer());
            _graphQlClient.HttpClient.DefaultRequestHeaders.Add("x-api-key", options.ApiKey);
        }

        public async Task<GraphQLResponse<Query>> Query(GraphQLRequest request)
        {
            return await _graphQlClient.SendQueryAsync<Query>(request);
        }

        public async Task<GraphQLResponse<Mutation>> Mutation(GraphQLRequest request)
        {
            return await _graphQlClient.SendMutationAsync<Mutation>(request);
        }

        public void Dispose()
        {
            _graphQlClient.Dispose();
        }
    }
}
