using System.Collections.Concurrent;
using PCLIssueHelper.Similaries;

namespace PCLIssueHelper
{
    public class IssueSimilarityChecker
    {
        public List<Issues> _issues;

        public IssueSimilarityChecker(List<Issues> issues)
        { 
            _issues = issues;
        }

        public (IOrderedEnumerable<KeyValuePair<string, double>>, IOrderedEnumerable<KeyValuePair<string, double>>) CheckSimilarity(string title, string body)
        {
            ConcurrentDictionary<string, double> check1 = new();
            ConcurrentDictionary<string, double> check2 = new();
            var checker = new Jaccard();
            //foreach (var issue in _issues)
            //{
            //    var _body = issue.body ?? "";
            //    _body = BodyReplace(_body);

            //    var similarity1 = checker.Similarity(title, issue.title ?? "");
            //    var similarity2 = checker.Similarity(body, _body);
            //    if (similarity1 != 0)
            //    {
            //        check1.Add(issue.number.ToString() ?? "", similarity1);
            //    }
            //    if (similarity2 != 0)
            //    {
            //        check2.Add(issue.number.ToString() ?? "", similarity2);
            //    }
            //}
            Parallel.ForEach(_issues, issue =>
            {
                var _body = issue.body ?? "";
                _body = BodyReplace(_body);

                var similarity1 = checker.Similarity(title, issue.title ?? "");
                var similarity2 = checker.Similarity(body, _body);
                if (similarity1 != 0)
                {
                    //check1.Add(issue.number.ToString() ?? "", similarity1);
                    check1.AddOrUpdate(issue.number.ToString() ?? "", similarity1, (x, y) => y);
                }
                if (similarity2 != 0)
                {
                    //check2.Add(issue.number.ToString() ?? "", similarity2);
                    check2.AddOrUpdate(issue.number.ToString() ?? "", similarity2, (x, y) => y);
                }
            });
            var result1 = check1.OrderByDescending(x => x.Value);
            var result2 = check2.OrderByDescending(x => x.Value);
            return (result1, result2);
        }

        public static string BodyReplace(string body)
        {
            return body
                    .Replace("""我已在 [Issues 页面](https://github.com/Hex-Dragon/PCL2/issues?q=is%3Aissue+) 和 [常见&难检反馈及问题列表](https://github.com/Hex-Dragon/PCL2/discussions/1930) 中搜索，确认了这一建议未被提交过。""", "")
                    .Replace("""我已查看 [功能投票页面](https://github.com/Hex-Dragon/PCL2/discussions/categories/%E5%8A%9F%E8%83%BD%E6%8A%95%E7%A5%A8/)，确认了这一建议未在投票列表中。""", "")
                    .Replace("""**我所启动的游戏不是整合包，且未安装任何 Mod。** 安装 Mod 后的游戏崩溃基本不是 PCL 的原因，请 **不要** 提交反馈。你可以在论坛或社区找人求助，但这里并不是你求助的地方。\n- [X] **我已尝试使用 HMCL 启动，HMCL 没有出现问题。** 如果 HMCL 也无法启动就不是 PCL 导致的问题，请 **不要** 提交反馈。[下载 HMCL](https://hmcl.huangyuhui.net/download)""", "")
                    .Replace("""我已在 [Issues 页面](https://github.com/Hex-Dragon/PCL2/issues?q=is%3Aissue+) 和 [常见&难检反馈及问题列表](https://github.com/Hex-Dragon/PCL2/discussions/1930) 中搜索，确认了这一 Bug 未被提交过。""", "");
        }
    }
}
