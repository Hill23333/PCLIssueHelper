using System.Net;

namespace PCLIssueHelper.Issues
{
    public class Online
    {
        public const string GITHUB_API = "https://api.github.com/repos/Hex-Dragon/PCL2/";

        private static async Task<HttpResponseMessage> GetRequestAsync(string path)
        {
            HttpClient client = new();

            // 设置需要请求的内容
            HttpRequestMessage httpRequest = new();
            httpRequest.RequestUri = new Uri($"{GITHUB_API}{path}");
            httpRequest.Method = HttpMethod.Get;
            httpRequest.Headers.UserAgent.ParseAdd($"PCLIssueHelper/{Application.ProductVersion}");

            // 等待返回结果
            var res = await client.SendAsync(httpRequest);
            if (res.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException(res.StatusCode.ToString());
            }
            return res;
        }

        public static async Task<Issue> GetIssueAsync(int issueNumber)
        {
            try
            {
                var httpres = await GetRequestAsync($"issues/{issueNumber.ToString()}");
                if (httpres.StatusCode == HttpStatusCode.OK)
                {
                    string content = await httpres.Content.ReadAsStringAsync();
                    Issue ires = Issue.GetFromJson(content);
                    return ires;
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show($"获取信息失败：\n{ex.Message}");
            }
            return new ();
        }
    }
}
