using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace PCLIssueHelper
{
    public class Updater
    {
        public static async void CheckUpdates(bool showErrorMsgWhenFailed = true)
        {          
            try
            {
                HttpClient client = new HttpClient();

                // 设置请求内容
                HttpRequestMessage httpRequest = new();
                httpRequest.RequestUri = new("https://api.github.com/repos/PCL-Community/PCL-Issue-Helper/releases/latest");
                httpRequest.Method = HttpMethod.Get;
                httpRequest.Headers.UserAgent.ParseAdd($"PCLIssueHelper/{Application.ProductVersion}");

                // 发送请求并等待
                var res = await client.SendAsync(httpRequest);
                if (!res.IsSuccessStatusCode)
                {
                    throw new HttpRequestException(res.StatusCode.ToString());
                }

                // 取 Json 内容
                string body;
                string name;

                using (JsonDocument json = JsonDocument.Parse(await res.Content.ReadAsStringAsync()))
                {
                    JsonElement root = json.RootElement;
                    body = root.GetProperty("body").GetString() ?? throw new JsonException("返回的 Json 有问题");
                    name = root.GetProperty("name").GetString() ?? throw new JsonException("返回的 Json 有问题");
                }

                // 取更新详情和sha256
                string[] splitStr = body.Split("## 主程序哈希值");
                string updateInfo = splitStr[0];
                string hash = splitStr[1];

                int start = hash.IndexOf('`');
                int end = hash.IndexOf('`', start + 1);

                string hashResult;
                if (start != -1 && end != -1 && start < end)
                {
                    hashResult = hash.Substring(start + 1, end - start - 1);
                }
                else
                {
                    throw new Exception("没能取到 SHA256 值（忘写了orz...），快联系 Hill233 在更新详情里加上！");
                }

                byte[] bytesSelf = await File.ReadAllBytesAsync(Application.ExecutablePath);
                byte[] hashSelf = SHA256.HashData(bytesSelf);
                string hashSelfStr = BitConverter.ToString(hashSelf).Replace("-", "").ToLower();

                if (hashResult != hashSelfStr)
                {
                    var result = MessageBox.Show($"PCL Issue Helper 有新版本可供更新。\r\n版本:{name}\r\n更新内容: \r\n{updateInfo}\r\n\r\n是否要前往 Github 查看更多详情？", $"有新版本 {name}", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        Process.Start(new ProcessStartInfo("https://github.com/PCL-Community/PCL-Issue-Helper/releases/latest") { UseShellExecute = true });
                        return;
                    }
                }

                SystemSounds.Exclamation.Play();
            }
            catch (Exception ex)
            {
                if (showErrorMsgWhenFailed) 
                {
                    MessageBox.Show($"检查更新失败！\r\n错误信息:\r\n{ex.ToString()}", "检查更新失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static async void CheckIssueUpdates()
        {
            try
            {
                HttpClient client = new HttpClient();

                // 设置请求内容
                HttpRequestMessage httpRequest = new();
                httpRequest.RequestUri = new("https://ghproxy.net/https://github.com/PCL-Community/PCL-Issue-Helper/raw/refs/heads/master/issues.sha256");
                httpRequest.Method = HttpMethod.Get;
                httpRequest.Headers.UserAgent.ParseAdd($"PCLIssueHelper/{Application.ProductVersion}");

                // 发送请求并等待
                var res = await client.SendAsync(httpRequest);
                if (!res.IsSuccessStatusCode)
                {
                    throw new HttpRequestException(res.StatusCode.ToString());
                }

                string sha256 = await res.Content.ReadAsStringAsync();

                string issuePath = Path.Combine(Directory.GetCurrentDirectory(), "issues.json");

                byte[] bytesLocal = File.ReadAllBytes(issuePath);
                byte[] hashLocal = SHA256.HashData(bytesLocal);
                string hashLocalStr = BitConverter.ToString(hashLocal).Replace("-", "").ToLower();

                if (sha256 != hashLocalStr)
                {
                    var result = MessageBox.Show("有新的 Issue 列表可供使用。\r\n是否获取？", "有新 Issue 列表", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        httpRequest.RequestUri = new("https://ghproxy.net/https://github.com/PCL-Community/PCL-Issue-Helper/raw/refs/heads/master/issues.json");

                        var resIssues = await client.SendAsync(httpRequest);
                        if (!resIssues.IsSuccessStatusCode)
                        {
                            throw new HttpRequestException(resIssues.StatusCode.ToString());
                        }

                        await File.WriteAllTextAsync(issuePath, await resIssues.Content.ReadAsStringAsync());

                        return;
                    }
                }

                SystemSounds.Exclamation.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"检查 Issue 列表失败！\r\n错误信息:\r\n{ex.ToString()}", "检查 Issue 列表失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
