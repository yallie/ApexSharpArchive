using Apex.Database;

namespace Apex.System
{
    public class RestResponse
    {
        public int StatusCode { get; set; }

        public RestResponse()
        {

        }

        public void AddHeader(string name, string value)
        {
            throw new global::System.NotImplementedException("RestResponse.AddHeader");
        }

        public object Clone()
        {
            throw new global::System.NotImplementedException("RestResponse.Clone");
        }
    }
}