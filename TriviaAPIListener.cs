using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TriviaApp.Dto;
using static System.Net.WebRequestMethods;

namespace TriviaApp
{
    internal class TriviaAPIListener
    {
        private readonly HttpClient _httpClient;
        public TriviaAPIListener() { 
            _httpClient = new HttpClient();
        }

        public  async Task<Response> GetData(TriviaRequest triviaRequest)
        {            
            string call = new StringBuilder()
                .Append("https://opentdb.com/api.php?")
                .Append(triviaRequest.ToString())
                .ToString();
            Console.WriteLine(call);
            string response = await _httpClient.GetStringAsync(call);
            Response response1 = JsonSerializer.Deserialize<Response>(response) ?? throw new Exception("Not Found");
            return response1;
        }
    }
}
