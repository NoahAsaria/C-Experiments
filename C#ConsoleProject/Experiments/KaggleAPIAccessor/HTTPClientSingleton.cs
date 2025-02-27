using System.Net.Http;

namespace HTTPClientSingletonNS {
    //Taken from https://csharpindepth.com/articles/singleton
    public sealed class HTTPClientSingleton {
        //Initialize a single lazy instance
        private static readonly Lazy<HTTPClientSingleton> lazyHTTPClient = 
            new Lazy<HTTPClientSingleton>(() => new HTTPClientSingleton());
        
        public static HTTPClientSingleton Instance { get { return lazyHTTPClient.Value; }}
        private HTTPClientSingleton() {
            
        }
        
        //public static void setBaseURI(string url) {
        //    lazyHTTPClient.base_uri = new Uri(url);
        //}
        //Trying properties: http://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
    }
}