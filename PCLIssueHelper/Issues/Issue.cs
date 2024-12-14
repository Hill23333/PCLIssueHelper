using System.Text.Json;

namespace PCLIssueHelper.Issues
{
    public class Issue
    {
        public long number { get; set; }
        public string title { get; set; } = null!;
        public string body { get; set; } = string.Empty;

        public static Issue GetFromJson(string rawJson)
        {
            return JsonSerializer.Deserialize<Issue>(rawJson) ?? new();
        }
    }
}
