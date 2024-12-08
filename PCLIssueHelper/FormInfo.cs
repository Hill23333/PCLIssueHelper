using Markdig;
using System.Diagnostics;

namespace PCLIssueHelper
{
    public partial class FormInfo : Form
    {
        private string _id;
        private string _title;
        private string _body;
        public FormInfo(string id, string title, string body)
        {
            InitializeComponent();
            _id = id;
            _title = title;
            _body = body;
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            this.Text = this.Text.Replace("{$issue}", _id);
            labelTitle.Text = labelTitle.Text.Replace("{$title}", _title);

            var pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .Build();
            string html = Markdown.ToHtml(_body, pipeline);

            string htmlWithCss = $@"
                                       <html>
                                       <head>
                                           <style>
                                               img {{
                                                   max-width: 100%;
                                                   max-height: 100%;
                                                   object-fit: contain;
                                               }}
                                               
                                               body {{
                                                   background-color: white;
                                                   color: black;
                                               }}                                               

                                               @media (prefers-color-scheme: dark) {{
                                                   body {{
                                                       background-color: #323232;
                                                       color: white;
                                                   }}
                                        
                                                   h1, p {{
                                                       color: white;
                                                   }}
                                               }}
                                           </style>
                                       </head>
                                       <body>
                                           {html}
                                       </body>
                                       </html>";

            webView2Markdown.EnsureCoreWebView2Async(null);
            webView2Markdown.CoreWebView2InitializationCompleted += (sender, e) =>
            {
                webView2Markdown.NavigateToString(htmlWithCss);
            };
        }

        private void buttonGithub_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo($"https://github.com/Hex-Dragon/PCL2/issues/{_id}") { UseShellExecute = true });
        }


        private void FormInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void webView2Markdown_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            var url = e.Uri;
            if (url.StartsWith("http") || url.StartsWith("https"))
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                e.Cancel = true;
            }
        }
    }
}
