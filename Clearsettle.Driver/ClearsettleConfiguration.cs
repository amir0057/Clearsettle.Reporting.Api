using System;
using System.Collections.Generic;

namespace Clearsettle.Driver
{
    public class ClearsettleConfiguration
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ApiUrl { get; set; }

        public static ClearsettleConfiguration FromDictionary(IDictionary<string, string> config)
        {
            return new ClearsettleConfiguration
            {
                Email = config["Email"],
                Password = config["Password"],
                ApiUrl = config["ApiUrl"]
            };
        }

        public Uri BuildUrlFor(string action)
        {
            var response = new Uri(string.Format("{0}{1}", ApiUrl, action));
            return response;
        }
    }
}