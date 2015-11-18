using com.buzzlogix.Http.Request;
using com.buzzlogix.Http.Response;
namespace com.buzzlogix.Http.Client
{
    /// <summary>
    /// Represents the contextual information of HTTP request and response
    /// </summary>
    public class HttpContext
    {
        public HttpRequest Request { get; set; }
        public HttpResponse Response { get; set; }
    }
}
