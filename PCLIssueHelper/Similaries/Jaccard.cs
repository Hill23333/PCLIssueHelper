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
            //分词

            var segments1 = _segmenter.Cut(str1);
            var segments2 = _segmenter.Cut(str2);

            //计算交集，并集
            var intersetion = segments1.Intersect(segments2).Count();
            var union = segments1.Union(segments2).Count();

            return (double)intersetion / union;
        }
    }
}
