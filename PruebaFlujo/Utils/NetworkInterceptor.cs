using OpenQA.Selenium;
using System.Diagnostics;
using System.Text;

namespace PruebaFlujo.Utils
{
    public class NetworkInterceptor
    {
        public async Task LogNetworkRequests(IWebDriver driver, string url)
        {
            var interceptor = driver.Manage().Network;
            interceptor.NetworkRequestSent += OnNetworkRequestSent;
            interceptor.NetworkResponseReceived += OnNetworkResponseReceived;
            await interceptor.StartMonitoring();
            driver.Url = url;
            await interceptor.StopMonitoring();
        }

        private void OnNetworkRequestSent(object sender, NetworkRequestSentEventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Request {0}", e.RequestId).AppendLine();
            builder.AppendLine("--------------------------------");
            builder.AppendFormat("{0} {1}", e.RequestMethod, e.RequestUrl).AppendLine();
            foreach (KeyValuePair<string, string> header in e.RequestHeaders)
            {
                builder.AppendFormat("{0}: {1}", header.Key, header.Value).AppendLine();
            }
            builder.AppendLine("--------------------------------");
            builder.AppendLine();
            Debug.WriteLine(builder.ToString());
        }

        private void OnNetworkResponseReceived(object sender, NetworkResponseReceivedEventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Response {0}", e.RequestId).AppendLine();
            builder.AppendLine("--------------------------------");
            builder.AppendFormat("{0} {1}", e.ResponseStatusCode, e.ResponseUrl).AppendLine();
            foreach (KeyValuePair<string, string> header in e.ResponseHeaders)
            {
                builder.AppendFormat("{0}: {1}", header.Key, header.Value).AppendLine();
            }
            builder.AppendLine("Response Body: " + e.ResponseBody);


            if (e.ResponseResourceType == "XHR")
            {
                 builder.AppendLine("Response Body: " + e.ResponseBody);
            }
            if (e.ResponseResourceType == "Document")
            {
                //builder.AppendLine(e.ResponseBody);
            }
            else if (e.ResponseResourceType == "Script")
            {
                //builder.AppendLine("<JavaScript content>");
            }
            else if (e.ResponseResourceType == "Stylesheet")
            {
                //builder.AppendLine("<stylesheet content>");
            }
            else if (e.ResponseResourceType == "Image")
            {
                //builder.AppendLine("<image>");
            }
            else
            {
                builder.AppendFormat("Content type: {0}", e.ResponseResourceType).AppendLine();
            }

            builder.AppendLine("--------------------------------");
            Debug.WriteLine(builder.ToString());
        }
    }
}
