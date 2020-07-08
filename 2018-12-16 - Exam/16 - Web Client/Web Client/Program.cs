using System.Net;

namespace Web_Client
{

    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            client.DownloadFile("http://mysite.com/some-route", "MyFile.txt");
            client.Dispose();
        }
    }
}
