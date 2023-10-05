using IntegrationTest.Models;
using System.Net;
using System.Net.Http;

namespace IntegrationTest.ViewModels
{
    internal class HttpServiceException
    {
        private HttpStatusCode statusCode;
        private HttpContent content;
        private object p;
        private string reasonPhrase;
        private Models.HttpResponse<string> httpResponse;
        private string url;

        public HttpServiceException(HttpStatusCode statusCode, HttpContent content, object p, string reasonPhrase, Models.HttpResponse<string> httpResponse, string url)
        {
            this.statusCode = statusCode;
            this.content = content;
            this.p = p;
            this.reasonPhrase = reasonPhrase;
            this.httpResponse = httpResponse;
            this.url = url;
        }

        //public HttpServiceException(HttpStatusCode statusCode, HttpContent content, object p, string reasonPhrase, HttpResponse<string> httpResponse1, string url)
        //{
        //    this.statusCode = statusCode;
        //    this.content = content;
        //    this.p = p;
        //    this.reasonPhrase = reasonPhrase;
        //    HttpResponse = httpResponse1;
        //    this.url = url;
        //}

        public HttpResponse<string> HttpResponse { get; }
    }
}