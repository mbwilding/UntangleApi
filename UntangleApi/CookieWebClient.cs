using System.Net;

namespace UntangleApi;

internal class CookieWebClient : WebClient
{
    CookieContainer cookies = new CookieContainer();

    public CookieContainer Cookies => cookies;

    protected override WebRequest GetWebRequest(Uri address)
    {
        WebRequest? request = base.GetWebRequest(address);

        if(request?.GetType() == typeof(HttpWebRequest))
            ((HttpWebRequest)request).CookieContainer = cookies;

        return request!;
    }
}