namespace PCLIssueHelper
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelBody = new Label();
            textBoxTitle = new TextBox();
            textBoxBody = new TextBox();
            buttonGetSimilarity = new Button();
            listViewTitle = new ListView();
            columnHeaderIssueIdTitle = new ColumnHeader();
            columnHeaderSimilarityTitle = new ColumnHeader();
            columnHeaderDataTitle = new ColumnHeader();
            listViewBody = new ListView();
            columnHeaderIssueIdBody = new ColumnHeader();
            columnHeaderSimilarityBody = new ColumnHeader();
            columnHeaderDataBody = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            快速链接LToolStripMenuItem = new ToolStripMenuItem();
            pCL2开源仓库RToolStripMenuItem = new ToolStripMenuItem();
            pCL2IssuesIToolStripMenuItem = new ToolStripMenuItem();
            pCL2DiscussionsDToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            可以提交PR的IssuePToolStripMenuItem = new ToolStripMenuItem();
            需要社区帮忙的IssueHToolStripMenuItem = new ToolStripMenuItem();
            帮助HToolStripMenuItem = new ToolStripMenuItem();
            关于AToolStripMenuItem = new ToolStripMenuItem();
            labelHint = new Label();
            textBox_OnlineIssue = new TextBox();
            label_OnlineIssue = new Label();
            button_OnlineIssue = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(19, 56);
            labelTitle.Margin = new Padding(5, 0, 5, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(46, 24);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "标题";
            // 
            // labelBody
            // 
            labelBody.AutoSize = true;
            labelBody.Location = new Point(19, 99);
            labelBody.Margin = new Padding(5, 0, 5, 0);
            labelBody.Name = "labelBody";
            labelBody.Size = new Size(46, 24);
            labelBody.TabIndex = 1;
            labelBody.Text = "内容";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(79, 52);
            textBoxTitle.Margin = new Padding(5, 4, 5, 4);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(1262, 30);
            textBoxTitle.TabIndex = 2;
            // 
            // textBoxBody
            // 
            textBoxBody.AllowDrop = true;
            textBoxBody.Location = new Point(79, 90);
            textBoxBody.Margin = new Padding(5, 4, 5, 4);
            textBoxBody.Multiline = true;
            textBoxBody.Name = "textBoxBody";
            textBoxBody.Size = new Size(1262, 104);
            textBoxBody.TabIndex = 3;
            // 
            // buttonGetSimilarity
            // 
            buttonGetSimilarity.Location = new Point(1126, 202);
            buttonGetSimilarity.Margin = new Padding(5, 4, 5, 4);
            buttonGetSimilarity.Name = "buttonGetSimilarity";
            buttonGetSimilarity.Size = new Size(215, 35);
            buttonGetSimilarity.TabIndex = 4;
            buttonGetSimilarity.Text = "对比相似度";
            buttonGetSimilarity.UseVisualStyleBackColor = true;
            buttonGetSimilarity.Click += buttonGetSimilarity_Click;
            // 
            // listViewTitle
            // 
            listViewTitle.Columns.AddRange(new ColumnHeader[] { columnHeaderIssueIdTitle, columnHeaderSimilarityTitle, columnHeaderDataTitle });
            listViewTitle.FullRowSelect = true;
            listViewTitle.Location = new Point(19, 255);
            listViewTitle.Margin = new Padding(5, 4, 5, 4);
            listViewTitle.Name = "listViewTitle";
            listViewTitle.Size = new Size(646, 552);
            listViewTitle.TabIndex = 5;
            listViewTitle.UseCompatibleStateImageBehavior = false;
            listViewTitle.View = View.Details;
            listViewTitle.DoubleClick += listViewTitle_DoubleClick;
            // 
            // columnHeaderIssueIdTitle
            // 
            columnHeaderIssueIdTitle.Text = "IssueID";
            // 
            // columnHeaderSimilarityTitle
            // 
            columnHeaderSimilarityTitle.Text = "相似度";
            // 
            // columnHeaderDataTitle
            // 
            columnHeaderDataTitle.Text = "标题";
            columnHeaderDataTitle.Width = 250;
            // 
            // listViewBody
            // 
            listViewBody.Columns.AddRange(new ColumnHeader[] { columnHeaderIssueIdBody, columnHeaderSimilarityBody, columnHeaderDataBody });
            listViewBody.FullRowSelect = true;
            listViewBody.Location = new Point(687, 255);
            listViewBody.Margin = new Padding(5, 4, 5, 4);
            listViewBody.Name = "listViewBody";
            listViewBody.Size = new Size(654, 512);
            listViewBody.TabIndex = 6;
            listViewBody.UseCompatibleStateImageBehavior = false;
            listViewBody.View = View.Details;
            listViewBody.DoubleClick += listViewBody_DoubleClick;
            // 
            // columnHeaderIssueIdBody
            // 
            columnHeaderIssueIdBody.Text = "IssueID";
            // 
            // columnHeaderSimilarityBody
            // 
            columnHeaderSimilarityBody.Text = "相似度";
            // 
            // columnHeaderDataBody
            // 
            columnHeaderDataBody.Text = "内容";
            columnHeaderDataBody.Width = 250;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 快速链接LToolStripMenuItem, 帮助HToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1355, 34);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // 快速链接LToolStripMenuItem
            // 
            快速链接LToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pCL2开源仓库RToolStripMenuItem, pCL2IssuesIToolStripMenuItem, pCL2DiscussionsDToolStripMenuItem, toolStripSeparator1, 可以提交PR的IssuePToolStripMenuItem, 需要社区帮忙的IssueHToolStripMenuItem });
            快速链接LToolStripMenuItem.Name = "快速链接LToolStripMenuItem";
            快速链接LToolStripMenuItem.Size = new Size(119, 28);
            快速链接LToolStripMenuItem.Text = "快速链接(&L)";
            // 
            // pCL2开源仓库RToolStripMenuItem
            // 
            pCL2开源仓库RToolStripMenuItem.Name = "pCL2开源仓库RToolStripMenuItem";
            pCL2开源仓库RToolStripMenuItem.Size = new Size(304, 34);
            pCL2开源仓库RToolStripMenuItem.Text = "PCL2开源仓库(&R)";
            pCL2开源仓库RToolStripMenuItem.Click += pCL2开源仓库RToolStripMenuItem_Click;
            // 
            // pCL2IssuesIToolStripMenuItem
            // 
            pCL2IssuesIToolStripMenuItem.Name = "pCL2IssuesIToolStripMenuItem";
            pCL2IssuesIToolStripMenuItem.Size = new Size(304, 34);
            pCL2IssuesIToolStripMenuItem.Text = "PCL2 Issues(&I)";
            pCL2IssuesIToolStripMenuItem.Click += pCL2IssuesIToolStripMenuItem_Click;
            // 
            // pCL2DiscussionsDToolStripMenuItem
            // 
            pCL2DiscussionsDToolStripMenuItem.Name = "pCL2DiscussionsDToolStripMenuItem";
            pCL2DiscussionsDToolStripMenuItem.Size = new Size(304, 34);
            pCL2DiscussionsDToolStripMenuItem.Text = "PCL2 Discussions(&D)";
            pCL2DiscussionsDToolStripMenuItem.Click += pCL2DiscussionsDToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(301, 6);
            // 
            // 可以提交PR的IssuePToolStripMenuItem
            // 
            可以提交PR的IssuePToolStripMenuItem.Name = "可以提交PR的IssuePToolStripMenuItem";
            可以提交PR的IssuePToolStripMenuItem.Size = new Size(304, 34);
            可以提交PR的IssuePToolStripMenuItem.Text = "可以提交PR的Issue(&P)";
            可以提交PR的IssuePToolStripMenuItem.Click += 可以提交PR的IssuePToolStripMenuItem_Click;
            // 
            // 需要社区帮忙的IssueHToolStripMenuItem
            // 
            需要社区帮忙的IssueHToolStripMenuItem.Name = "需要社区帮忙的IssueHToolStripMenuItem";
            需要社区帮忙的IssueHToolStripMenuItem.Size = new Size(304, 34);
            需要社区帮忙的IssueHToolStripMenuItem.Text = "需要社区帮忙的Issue(&H)";
            需要社区帮忙的IssueHToolStripMenuItem.Click += 需要社区帮忙的IssueHToolStripMenuItem_Click;
            // 
            // 帮助HToolStripMenuItem
            // 
            帮助HToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 关于AToolStripMenuItem });
            帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            帮助HToolStripMenuItem.Size = new Size(88, 28);
            帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            关于AToolStripMenuItem.Size = new Size(183, 34);
            关于AToolStripMenuItem.Text = "关于(&A)...";
            关于AToolStripMenuItem.Click += 关于AToolStripMenuItem_Click;
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.Location = new Point(955, 787);
            labelHint.Margin = new Padding(5, 0, 5, 0);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(386, 24);
            labelHint.TabIndex = 8;
            labelHint.Text = "双击列表里的项目可以查看此 Issue 的详细信息";
            // 
            // textBox_OnlineIssue
            // 
            textBox_OnlineIssue.Location = new Point(116, 211);
            textBox_OnlineIssue.Name = "textBox_OnlineIssue";
            textBox_OnlineIssue.Size = new Size(150, 30);
            textBox_OnlineIssue.TabIndex = 9;
            // 
            // label_OnlineIssue
            // 
            label_OnlineIssue.AutoSize = true;
            label_OnlineIssue.Location = new Point(19, 213);
            label_OnlineIssue.Name = "label_OnlineIssue";
            label_OnlineIssue.Size = new Size(93, 24);
            label_OnlineIssue.TabIndex = 10;
            label_OnlineIssue.Text = "Issue 编号";
            // 
            // button_OnlineIssue
            // 
            button_OnlineIssue.Location = new Point(272, 210);
            button_OnlineIssue.Name = "button_OnlineIssue";
            button_OnlineIssue.Size = new Size(112, 32);
            button_OnlineIssue.TabIndex = 11;
            button_OnlineIssue.Text = "获取";
            button_OnlineIssue.UseVisualStyleBackColor = true;
            button_OnlineIssue.Click += button_OnlineIssue_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 820);
            Controls.Add(button_OnlineIssue);
            Controls.Add(label_OnlineIssue);
            Controls.Add(textBox_OnlineIssue);
            Controls.Add(labelHint);
            Controls.Add(listViewBody);
            Controls.Add(listViewTitle);
            Controls.Add(buttonGetSimilarity);
            Controls.Add(textBoxBody);
            Controls.Add(textBoxTitle);
            Controls.Add(labelBody);
            Controls.Add(labelTitle);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PCL Issue Helper";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelBody;
        private TextBox textBoxTitle;
        private TextBox textBoxBody;
        private Button buttonGetSimilarity;
        private ListView listViewTitle;
        private ColumnHeader columnHeaderIssueIdTitle;
        private ColumnHeader columnHeaderSimilarityTitle;
        private ColumnHeader columnHeaderDataTitle;
        private ListView listViewBody;
        private ColumnHeader columnHeaderIssueIdBody;
        private ColumnHeader columnHeaderSimilarityBody;
        private ColumnHeader columnHeaderDataBody;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 帮助HToolStripMenuItem;
        private ToolStripMenuItem 关于AToolStripMenuItem;
        private ToolStripMenuItem 快速链接LToolStripMenuItem;
        private ToolStripMenuItem pCL2开源仓库RToolStripMenuItem;
        private ToolStripMenuItem 可以提交PR的IssuePToolStripMenuItem;
        private ToolStripMenuItem 需要社区帮忙的IssueHToolStripMenuItem;
        private ToolStripMenuItem pCL2IssuesIToolStripMenuItem;
        private ToolStripMenuItem pCL2DiscussionsDToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Label labelHint;
        private TextBox textBox_OnlineIssue;
        private Label label_OnlineIssue;
        private Button button_OnlineIssue;
    }
}
