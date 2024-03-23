using System.Text;
using System.Text.Json.Serialization;

namespace TriviaApp.Dto
{
    public class QuestionFromResponse
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("difficulty")]
        public string Difficulty { get; set; }
        [JsonPropertyName("question")]
        public string ContentOfQuestion {  get; set; }
        [JsonPropertyName("correct_answer")]
        public string CorrectAnswer { get; set; }
        [JsonPropertyName("incorrect_answers")]
        public List<string> IncorrectAnswers { get; set; }

        public override string ToString()
        {
            return new StringBuilder().AppendLine(ContentOfQuestion).ToString();
        }
    }
}