
using System.Text.RegularExpressions;

namespace PCLIssueHelper
{
    public static class Utils
    {
        /// <summary>
        /// 去除 issue 正文中影响判断相似度的文本。
        /// </summary>
        /// <param name="body">正文</param>
        /// <returns></returns>
        public static string BodyReplace(string body)
        {
            //去除图片
            Regex regex = new Regex(@"!\[.*?\]\((.*?)\)");
            body = regex.Replace(body, "");

            //去除"原因"的大标题
            body = body.Replace("### 原因", " ");

            //开头是不是固定格式
            if (body.StartsWith("### 检查项"))
            {
                //判断，并且直接把描述前面的全部删掉
                int index1 = body.IndexOf("### 描述");
                if (index1 != -1)
                {
                    index1 += 6;

                    //只取重现步骤前面的文本
                    int index2 = body.IndexOf("### 重现步骤", index1);
                    if (index2 != -1)
                    {
                        return body.Substring(index1, index2 - index1);
                    }
                    else
                    {
                        return body.Substring(index1);
                    }
                }
                else
                {
                    return body;
                }
            }
            return body;
        }
    }
}
