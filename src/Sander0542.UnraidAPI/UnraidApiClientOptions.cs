using System;

namespace Sander0542.UnraidAPI
{
    public class UnraidApiClientOptions
    {
        /// <summary>
        /// The Unraid Server Address to be used
        /// </summary>
        public Uri ServerAddress { get; set; }
        
        public string ApiKey { get; set; }
    }
}
