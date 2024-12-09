using JiebaNet.Segmenter;

namespace PCLIssueHelper.Similaries
{
    public class Jaccard
    {
        private JiebaSegmenter _segmenter;
        public Jaccard()
        {
            _segmenter = new JiebaSegmenter();
        }
        public double Similarity(string str1, string str2)
        {
            //避免不必要运算
            if (string.IsNullOrWhiteSpace(str1) && string.IsNullOrWhiteSpace(str2))
                return 1.0;
            if (string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2))
                return 0.0;

            //分词
            var segments1 = _segmenter.Cut(str1);
            var segments2 = _segmenter.Cut(str2);

            return Similarity(segments1, segments2);
        }
        public double Similarity(IEnumerable<string> str1, IEnumerable<string> str2)
        {
            //转成HashSet去重
            var set1 = new HashSet<string>(str1);
            var set2 = new HashSet<string>(str2);

            //计算交集，并集
            var intersetion = set1.Count(s => set2.Contains(s));
            var union = set1.Count() + set2.Count() - intersetion;

            if (union == 0)
            {
                return 0;
            }

            return (double)intersetion / union;
        }
        public double Similarity(string str1, IEnumerable<string> str2)
        {
            //分词
            var segments = _segmenter.Cut(str1);

            return Similarity(segments, str2);
        }
        public double Similarity(IEnumerable<string> str1, string str2)
        {
            //分词
            var segments = _segmenter.Cut(str2);

            return Similarity(str1, segments);
        }
    }
}
