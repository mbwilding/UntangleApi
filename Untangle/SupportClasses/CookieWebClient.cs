using System.Net;

namespace Untangle.SupportClasses;

internal class CookieWebClient : WebClient
{
    private readonly CookieContainer _cookies = new();

    // ReSharper disable once UnusedMember.Global
    public CookieContainer Cookies => _cookies;

    protected override WebRequest GetWebRequest(Uri address)
    {
        WebRequest? request = base.GetWebRequest(address);

        if(request?.GetType() == typeof(HttpWebRequest))
            ((HttpWebRequest)request).CookieContainer = _cookies;

        return request!;
    }
}