using PCLIssueHelper.Issues;
using System.Diagnostics;
using System.Media;
using System.Text.Json;

namespace PCLIssueHelper
{
    public partial class FormMain : Form
    {
        public IssueSimilarityChecker checker;
        private List<Issue> _issues;
        public FormMain()
        {
            InitializeComponent();
            string json = File.ReadAllText(Directory.GetCurrentDirectory() + "\\issues.json");
            _issues = JsonSerializer.Deserialize<List<Issue>>(json) ?? new List<Issue>();

            checker = new(_issues);

            toolStripStatusLabel3.Text = (toolStripStatusLabel3.Text ?? "").Replace("${issue}", _issues.Count.ToString());
            toolStripStatusLabel1.Text = "";
#if DEBUG
#else
            Updater.CheckUpdates(false);
#endif

        }
        private async void buttonGetSimilarity_Click(object sender, EventArgs e)
        {
            buttonGetSimilarity.Enabled = false;
            button_OnlineIssue.Enabled = false;

            toolStripStatusLabel1.Text = "正在对比 Issue 相似度...";

            listViewTitle.Items.Clear();
            listViewBody.Items.Clear();

            var title = textBoxTitle.Text;
            var body = textBoxBody.Text;

            var similarity = await checker.CheckSimilarityAsync(textBoxTitle.Text, textBoxBody.Text);

            var similarityTitles = similarity.Item1;
            var similarityBodies = similarity.Item2;

            listViewTitle.BeginUpdate();
            foreach (var _title in similarityTitles)
            {
                listViewTitle.Items.Add(new ListViewItem(new string[] { _title.Key, _title.Value.ToString(), _issues.Where(x => x.number.ToString() == _title.Key).Select(x => x.title).FirstOrDefault() ?? "" }));
            }
            listViewTitle.EndUpdate();

            listViewBody.BeginUpdate();
            foreach (var _body in similarityBodies)
            {
                listViewBody.Items.Add(new ListViewItem(new string[] { _body.Key, _body.Value.ToString(), Utils.BodyReplace(_issues.Where(x => x.number.ToString() == _body.Key).Select(x => x.body).FirstOrDefault() ?? "") }));
            }
            listViewBody.EndUpdate();

            toolStripStatusLabel1.Text = "";

            SystemSounds.Exclamation.Play();

            buttonGetSimilarity.Enabled = true;
            button_OnlineIssue.Enabled = true;
        }

        private void listViewTitle_DoubleClick(object sender, EventArgs e)
        {
            if (listViewTitle.SelectedItems.Count > 0)
            {
                var selectedItem = listViewTitle.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;
                string title = selectedItem.SubItems[2].Text;
                string body = checker._issues.Where(x => x.number.ToString() == id).Select(x => x.body).FirstOrDefault() ?? "";
                FormInfo formInfo = new(id, title, body);
                formInfo.ShowDialog();
            }
        }

        private void listViewBody_DoubleClick(object sender, EventArgs e)
        {
            if (listViewBody.SelectedItems.Count > 0)
            {
                var selectedItem = listViewBody.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;
                string title = checker._issues.Where(x => x.number.ToString() == id).Select(x => x.title).FirstOrDefault() ?? "";
                string body = checker._issues.Where(x => x.number.ToString() == id).Select(x => x.body).FirstOrDefault() ?? "";
                FormInfo formInfo = new(id, title, body);
                formInfo.ShowDialog();
            }
        }

        private void pCL2开源仓库RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo($"https://github.com/Hex-Dragon/PCL2") { UseShellExecute = true });
        }

        private void pCL2IssuesIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo($"https://github.com/Hex-Dragon/PCL2/issues") { UseShellExecute = true });
        }

        private void pCL2DiscussionsDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo($"https://github.com/Hex-Dragon/PCL2/discussions") { UseShellExecute = true });
        }

        private void 可以提交PR的IssuePToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo($"https://github.com/Hex-Dragon/PCL2/issues?q=is%3Aissue+is%3Aopen+label%3A%E5%A4%84%E7%90%86%E4%B8%AD") { UseShellExecute = true });
        }

        private void 需要社区帮忙的IssueHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo($"https://github.com/Hex-Dragon/PCL2/issues?q=label%3A%E6%96%B0%E6%8F%90%E4%BA%A4%2C%E9%9C%80%E8%A6%81%E7%A4%BE%E5%8C%BA%E5%A4%8D%E7%8E%B0%2C%E9%9C%80%E8%A6%81%E7%A4%BE%E5%8C%BA%E5%B8%AE%E5%8A%A9%2C%E7%A4%BE%E5%8C%BA%E5%A4%84%E7%90%86%E4%B8%AD+") { UseShellExecute = true });
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var taskDialogPage = new TaskDialogPage();
            taskDialogPage.EnableLinks = true;
            taskDialogPage.Caption = "关于";
            taskDialogPage.Heading = "关于 PCL Issue Helper";
            taskDialogPage.Icon = TaskDialogIcon.Information;
            taskDialogPage.Text = """
                版本: ${ver}
                作者: Hill233

                PCL Issue Helper 的诞生离不开 PCL-Community 的其他成员和社区的帮助！
                
                开放源代码许可:
                <a href="https://github.com/anderscui/jieba.NET/blob/master/LICENSE">jieba.NET</a> Copyright © 2015 andersc
                <a href="https://github.com/xoofx/markdig/blob/master/license.txt">MarkDig</a> Copyright © 2018-2019, Alexandre Mutel All rights reserved.
                """.Replace("${ver}", Application.ProductVersion);

            taskDialogPage.LinkClicked += (sender, e) =>
            {
                Process.Start(new ProcessStartInfo(e.LinkHref) { UseShellExecute = true });
            };

            TaskDialog.ShowDialog(taskDialogPage);
        }

        private async void button_OnlineIssue_Click(object sender, EventArgs e)
        {
            button_OnlineIssue.Enabled = false;
            buttonGetSimilarity.Enabled = false;

            toolStripStatusLabel1.Text = "正在在线获取 Issue 内容...";

            string input = textBox_OnlineIssue.Text.Trim();
            int temp=-1;
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out temp))
            {
                toolStripStatusLabel1.Text = "输入内容不符合要求！";
            }
            else
            {
                Issue thisIssue = await Online.GetIssueAsync(temp);
                textBoxTitle.Text = thisIssue.title;
                textBoxBody.Text = Utils.BodyReplace(thisIssue.body);
                toolStripStatusLabel1.Text = "";
            }

            SystemSounds.Exclamation.Play();

            button_OnlineIssue.Enabled = true;
            buttonGetSimilarity.Enabled = true;
        }

        private void 检查本体更新UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Updater.CheckUpdates();
        }
        private void 检查Issues列表更新IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Updater.CheckIssueUpdates();
            string json = File.ReadAllText(Directory.GetCurrentDirectory() + "\\issues.json");
            _issues = JsonSerializer.Deserialize<List<Issue>>(json) ?? new List<Issue>();

        }
        public void UpdateStatusStrip1(string status)
        {
            this.Invoke(() =>
            {
                toolStripStatusLabel1.Text = status;
            });
        }
        
    }
}
