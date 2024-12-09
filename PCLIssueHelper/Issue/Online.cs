using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace PCLIssueHelper.Issue
{
    internal class Online
    {
        public const string GITHUB_API = "https://api.github.com/repos/Hex-Dragon/PCL2/";

        private static HttpResponseMessage GetRequest(string path)
        {
            HttpClient client = new();

            // 设置需要请求的内容
            HttpRequestMessage httpRequest = new();
            httpRequest.RequestUri = new Uri($"{GITHUB_API}{path}");
            httpRequest.Method = HttpMethod.Get;
            httpRequest.Headers.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36 Edg/131.0.0.0");

            // 等待返回结果
            Task<HttpResponseMessage> res = client.SendAsync(httpRequest);
            res.Wait();
            if (res.Result.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException(res.Result.StatusCode.ToString());
            }
            return res.Result;
        }

        public static Issue GetIssue(int issueNumber)
        {
            try
            {
                var httpres = GetRequest($"issues/{issueNumber.ToString()}");
                if (httpres.StatusCode == HttpStatusCode.OK)
                {
                    Task<string> content = httpres.Content.ReadAsStringAsync();
                    content.Wait();
                    Issue ires = Issue.GetFromJson(content.Result);
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
