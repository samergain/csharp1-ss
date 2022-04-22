using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a program that parses an URL given in the following format:
[protocol]://[server]/[resource]
The parsing extracts its parts: protocol, server and resource.
The [server] part is mandatory.
The [protocol] and [resource] parts are optional.
*/
namespace ArraysAndStrings
{
    public class StringsURLparser
    {
        public void URLparse(string url)
        {
            string protocol = url.Split("://")[0];
            string serverResource = url.Split("://")[1];
            string server = serverResource.Split("/")[0];
            string resource = serverResource.Split("/")[1];
            Console.WriteLine($"[Protocol]:{protocol}");
            Console.WriteLine($"[Server]:{server}");
            Console.WriteLine($"[Resource]:{resource}");
        }
    }
}
