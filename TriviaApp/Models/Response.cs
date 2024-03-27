using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TriviaApp.Dto
{
    internal class Response
    {
        [JsonPropertyName("response_code")]
        public int ResponseCode { get; set; }
        [JsonPropertyName("results")]
        public List<QuestionFromResponse> Questions { get; set; }
        public Response() { 
        
            List<Response> list = new List<Response>(); 
            ResponseCode = -1;
        }
        public override string ToString()
        {
            StringBuilder response = new StringBuilder();
            foreach (var item in Questions)
            {
                response.Append(item.ToString());
            }
            return response.ToString();
        }
    }
}
