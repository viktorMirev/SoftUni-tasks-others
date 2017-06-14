using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace HTTPServer
{
    public class HTTP
    {
        private const int Port = 8888;

        public static void Main()
        {
            
            var myServer = new TcpListener(IPAddress.Any, Port);
            myServer.Start();
            Console.WriteLine($"Listening on port {Port} ... ");

            while (true)
            {
                using (NetworkStream stream = myServer.AcceptTcpClient().GetStream())
                {
                    byte[] request = new byte[4096];
                    int readBytes = stream.Read(request, 0, request.Length);
                    string details = Encoding.UTF8.GetString(request, 0, readBytes);
                    Console.WriteLine(details);

                    string[] firstReqLine = details.Substring(0, details.IndexOf(Environment.NewLine)).Split();
                    string url = firstReqLine[1];
                    string header = firstReqLine[2];
                    string requestedPage = string.Empty;

                    if (url.Equals("/"))
                    {
                        requestedPage = "../../../index.html";
                    }
                    else
                    {
                        requestedPage = $"../../..{url.Substring(url.IndexOf('/'))}";

                        if (!requestedPage.EndsWith(".html"))
                        {
                            requestedPage += ".html";
                        }

                        if (!File.Exists(requestedPage))
                        {
                            requestedPage = "../../../error.html";
                        }
                        else
                        {
                            header = "HTTP/1.0 404 Not Found";
                        }
                    }

                    StringBuilder responseHeader = new StringBuilder();
                    responseHeader.Append($"{header}{Environment.NewLine}");
                    responseHeader.Append($"Accept-Ranges: bytes{Environment.NewLine}");

                    StringBuilder responseMessage = new StringBuilder();

                    using (StreamReader reader = new StreamReader(requestedPage))
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            responseMessage.Append(line);
                            line = reader.ReadLine();
                        }
                    }
                    if (requestedPage.EndsWith("info.html"))
                    {
                        responseMessage
                            .Replace("{0}", DateTime.Now.ToString("ddd, MMM d, yyyy"))
                            .Replace("{1}", Environment.ProcessorCount.ToString());
                    }

                    int contentLength = Encoding.UTF8.GetBytes(responseMessage.ToString()).Length;

                    responseHeader.Append($"ContentLength: {contentLength}{Environment.NewLine}");
                    responseHeader.Append($"Connection: close{Environment.NewLine}");
                    responseHeader.Append($"Content-Type: text/html{Environment.NewLine}");
                    responseHeader.Append(Environment.NewLine);

                    responseMessage.Insert(0, responseHeader);

                    byte[] responseBytes = Encoding.UTF8.GetBytes(responseMessage.ToString());

                    stream.Write(responseBytes, 0, responseBytes.Length);
                }
            }
        }
    }
}