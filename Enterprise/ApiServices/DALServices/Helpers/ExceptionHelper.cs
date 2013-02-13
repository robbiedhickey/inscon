using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Enterprise.ApiServices.DALServices.Helpers
{
    public class ExceptionHelper
    {
        /// <summary>
        /// Builds a custom HTTP response message.
        /// </summary>
        /// <param name="httpStatusCode">The HTTP status code.</param>
        /// <param name="content">The content.</param>
        /// <param name="reasonPhrase">The reason phrase.</param>
        /// <returns>The response message to show</returns>
        public HttpResponseMessage BuildHttpResponseMessage(HttpStatusCode httpStatusCode, string content, string reasonPhrase)
        {
            var retValue = new HttpResponseMessage(httpStatusCode)
                {
                    Content = new StringContent(content),
                    ReasonPhrase = reasonPhrase
                };

            return retValue;
        }
    }
}