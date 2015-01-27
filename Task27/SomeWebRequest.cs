using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace CsharpSolutions.Exercises.Task27
{
    class SomeWebRequest
    {
        public static void PerformWebRequest()
        {
            Console.WriteLine("This performs a webrequest.");
            Console.WriteLine("Please enter a valid url (enter for default):");
            var url = Console.ReadLine();

            if (String.IsNullOrEmpty(url))
                url = "http://csharp.florian-rappl.de/samples/Books.xml";

            var time = Stopwatch.StartNew();
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();
            var stream = new StreamReader(responseStream);
            var content = stream.ReadToEnd();
            time.Stop();
            Console.WriteLine("The request has been processed in {0}ms.", time.ElapsedMilliseconds.ToString());
            Console.WriteLine("Content:");
            Console.WriteLine(content);
        }
    }
}
