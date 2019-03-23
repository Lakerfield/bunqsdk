using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lakerfield.BunqSdk.Http
{
  public class LoggingHandler : DelegatingHandler
  {
    //https://stackoverflow.com/questions/18924996/logging-request-response-messages-when-using-httpclient

    public LoggingHandler(HttpMessageHandler innerHandler)
      : base(innerHandler)
    {
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
      var now = DateTime.Now;

      using (var logFile = File.CreateText($"log-{now:yyyy-MM-dd-HHmm.ss.fff}.txt"))
      {
        logFile.WriteLine("Request:");
        logFile.WriteLine(request.ToString());
        if (request.Content != null)
        {
          logFile.WriteLine(await request.Content.ReadAsStringAsync());
        }
        logFile.WriteLine();

        HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

        logFile.WriteLine("Response:");
        logFile.WriteLine(response.ToString());
        if (response.Content != null)
        {
          logFile.WriteLine(await response.Content.ReadAsStringAsync());
        }
        logFile.WriteLine();

        return response;
      }
    }
  }
}
