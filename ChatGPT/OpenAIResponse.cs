using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ChatGPT
{
    // Main Open AI response object
    public class OpenAIResponse
    {
        // Auto-generated
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        // Target job
        [JsonPropertyName("Object")]
        public string? Object { get; set; }
        public int created { get; set; }

        // Engine used
        public string? model { get; set; }

        // API response
        public List<Choice>? choices { get; set; }

        // Tokens used
        public Usage? usage { get; set; }
    }

    // Text response
    public class Choice
    {
        // Text response
        public string? text { get; set; }
        public int index { get; set; }
        public object? logprobs { get; set; }
        // Why generation ended
        public string? finish_reason { get; set; }
    }

    // API Token usage
    public class Usage
    {
        // Difficulty of input
        public int prompt_tokens { get; set; }
        // Difficulty of output
        public int completion_tokens { get; set; }
        public int total_tokens { get; set; }
    }
}
