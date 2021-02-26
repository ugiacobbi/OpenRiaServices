using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace OpenRiaServices.DomainServices.Client
{
    class HttpClientHandlerFactory
    {
        private static CookieContainer SharedCookieContainer { get; }

        static HttpClientHandlerFactory()
        {
            SharedCookieContainer = new CookieContainer();
        }

        public static HttpClientHandler Create()
        {
            bool isBrowser = RuntimeInformation.IsOSPlatform(OSPlatform.Create("BROWSER"));
            return !isBrowser ? new HttpClientHandler
            {
                CookieContainer = SharedCookieContainer,
                UseCookies = true
            } : new HttpClientHandler();
        }
    }
}
