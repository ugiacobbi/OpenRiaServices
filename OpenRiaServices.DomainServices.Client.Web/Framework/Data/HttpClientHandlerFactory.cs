using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace OpenRiaServices.DomainServices.Client
{
    /// <summary>
    /// The factory for creating HttpClientHandler
    /// </summary>
    public class HttpClientHandlerFactory
    {
        /// <summary>
        /// This cookie container is shared between calls for http calls except for the browser
        /// </summary>
        public static CookieContainer SharedCookieContainer { get; }

        static HttpClientHandlerFactory()
        {
            SharedCookieContainer = new CookieContainer();
        }

        /// <summary>
        /// Creates a new HttpClientHandler.
        /// </summary>
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
