using System.Collections.Concurrent;
using JiebaNet.Segmenter;
using PCLIssueHelper.Similaries;
using PCLIssueHelper.Issue;

namespace PCLIssueHelper
{
    public class IssueSimilarityChecker
    {
        public List<Issue.Issue> _issues;

        public IssueSimilarityChecker(List<Issue.Issue> issues)
        { 
            _issues = issues;
        }

        public async Task<(IOrderedEnumerable<KeyValuePair<string, double>>, IOrderedEnumerable<KeyValuePair<string, double>>)> CheckSimilarityAsync(string title, string body)
        {
            ConcurrentDictionary<string, double> check1 = new();
            ConcurrentDictionary<string, double> check2 = new();

            var checker = new Jaccard();

            var segmenter = await Task.Run(() => new JiebaSegmenter());
            var segmentsTitle = await Task.Run(() => segmenter.Cut(title));
            var segmentsBody = await Task.Run(() => segmenter.Cut(body));

            await Parallel.ForEachAsync(_issues, async (issue, cancellationToken) =>
            {
                await Task.Yield();
                
                var _body = issue.body ?? "";
                _body = Utils.BodyReplace(_body);

                var similarity1 = checker.Similarity(segmentsTitle, issue.title ?? "");
                var similarity2 = checker.Similarity(segmentsBody, _body);
                if (similarity1 != 0)
                {
                    check1.AddOrUpdate(issue.number.ToString() ?? "", similarity1, (x, y) => y);
                }
                if (similarity2 != 0)
                {
                    check2.AddOrUpdate(issue.number.ToString() ?? "", similarity2, (x, y) => y);
                }
            });

            var result1 = check1.OrderByDescending(x => x.Value);
            var result2 = check2.OrderByDescending(x => x.Value);

            return (result1, result2);
        }
    }
}
