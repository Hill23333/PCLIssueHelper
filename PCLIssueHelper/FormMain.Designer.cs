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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
            检查本体更新UToolStripMenuItem = new ToolStripMenuItem();
            检查Issues列表更新IToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            关于AToolStripMenuItem = new ToolStripMenuItem();
            labelHint = new Label();
            textBox_OnlineIssue = new TextBox();
            label_OnlineIssue = new Label();
            button_OnlineIssue = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 40);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(32, 17);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "标题";
            // 
            // labelBody
            // 
            labelBody.AutoSize = true;
            labelBody.Location = new Point(12, 70);
            labelBody.Name = "labelBody";
            labelBody.Size = new Size(32, 17);
            labelBody.TabIndex = 1;
            labelBody.Text = "内容";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(50, 37);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(805, 23);
            textBoxTitle.TabIndex = 2;
            // 
            // textBoxBody
            // 
            textBoxBody.AllowDrop = true;
            textBoxBody.Location = new Point(50, 64);
            textBoxBody.Multiline = true;
            textBoxBody.Name = "textBoxBody";
            textBoxBody.ScrollBars = ScrollBars.Vertical;
            textBoxBody.Size = new Size(805, 75);
            textBoxBody.TabIndex = 3;
            // 
            // buttonGetSimilarity
            // 
            buttonGetSimilarity.Location = new Point(718, 145);
            buttonGetSimilarity.Name = "buttonGetSimilarity";
            buttonGetSimilarity.Size = new Size(137, 25);
            buttonGetSimilarity.TabIndex = 4;
            buttonGetSimilarity.Text = "对比相似度";
            buttonGetSimilarity.UseVisualStyleBackColor = true;
            buttonGetSimilarity.Click += buttonGetSimilarity_Click;
            // 
            // listViewTitle
            // 
            listViewTitle.Columns.AddRange(new ColumnHeader[] { columnHeaderIssueIdTitle, columnHeaderSimilarityTitle, columnHeaderDataTitle });
            listViewTitle.FullRowSelect = true;
            listViewTitle.Location = new Point(12, 181);
            listViewTitle.Name = "listViewTitle";
            listViewTitle.Size = new Size(413, 392);
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
            listViewBody.Location = new Point(437, 181);
            listViewBody.Name = "listViewBody";
            listViewBody.Size = new Size(418, 364);
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
            columnHeaderDataBody.Width = 600;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 快速链接LToolStripMenuItem, 帮助HToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(867, 25);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // 快速链接LToolStripMenuItem
            // 
            快速链接LToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pCL2开源仓库RToolStripMenuItem, pCL2IssuesIToolStripMenuItem, pCL2DiscussionsDToolStripMenuItem, toolStripSeparator1, 可以提交PR的IssuePToolStripMenuItem, 需要社区帮忙的IssueHToolStripMenuItem });
            快速链接LToolStripMenuItem.Name = "快速链接LToolStripMenuItem";
            快速链接LToolStripMenuItem.Size = new Size(82, 21);
            快速链接LToolStripMenuItem.Text = "快速链接(&L)";
            // 
            // pCL2开源仓库RToolStripMenuItem
            // 
            pCL2开源仓库RToolStripMenuItem.Name = "pCL2开源仓库RToolStripMenuItem";
            pCL2开源仓库RToolStripMenuItem.Size = new Size(207, 22);
            pCL2开源仓库RToolStripMenuItem.Text = "PCL2开源仓库(&R)";
            pCL2开源仓库RToolStripMenuItem.Click += pCL2开源仓库RToolStripMenuItem_Click;
            // 
            // pCL2IssuesIToolStripMenuItem
            // 
            pCL2IssuesIToolStripMenuItem.Name = "pCL2IssuesIToolStripMenuItem";
            pCL2IssuesIToolStripMenuItem.Size = new Size(207, 22);
            pCL2IssuesIToolStripMenuItem.Text = "PCL2 Issues(&I)";
            pCL2IssuesIToolStripMenuItem.Click += pCL2IssuesIToolStripMenuItem_Click;
            // 
            // pCL2DiscussionsDToolStripMenuItem
            // 
            pCL2DiscussionsDToolStripMenuItem.Name = "pCL2DiscussionsDToolStripMenuItem";
            pCL2DiscussionsDToolStripMenuItem.Size = new Size(207, 22);
            pCL2DiscussionsDToolStripMenuItem.Text = "PCL2 Discussions(&D)";
            pCL2DiscussionsDToolStripMenuItem.Click += pCL2DiscussionsDToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(204, 6);
            // 
            // 可以提交PR的IssuePToolStripMenuItem
            // 
            可以提交PR的IssuePToolStripMenuItem.Name = "可以提交PR的IssuePToolStripMenuItem";
            可以提交PR的IssuePToolStripMenuItem.Size = new Size(207, 22);
            可以提交PR的IssuePToolStripMenuItem.Text = "可以提交PR的Issue(&P)";
            可以提交PR的IssuePToolStripMenuItem.Click += 可以提交PR的IssuePToolStripMenuItem_Click;
            // 
            // 需要社区帮忙的IssueHToolStripMenuItem
            // 
            需要社区帮忙的IssueHToolStripMenuItem.Name = "需要社区帮忙的IssueHToolStripMenuItem";
            需要社区帮忙的IssueHToolStripMenuItem.Size = new Size(207, 22);
            需要社区帮忙的IssueHToolStripMenuItem.Text = "需要社区帮忙的Issue(&H)";
            需要社区帮忙的IssueHToolStripMenuItem.Click += 需要社区帮忙的IssueHToolStripMenuItem_Click;
            // 
            // 帮助HToolStripMenuItem
            // 
            帮助HToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 检查本体更新UToolStripMenuItem, 检查Issues列表更新IToolStripMenuItem, toolStripSeparator2, 关于AToolStripMenuItem });
            帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            帮助HToolStripMenuItem.Size = new Size(61, 21);
            帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 检查本体更新UToolStripMenuItem
            // 
            检查本体更新UToolStripMenuItem.Name = "检查本体更新UToolStripMenuItem";
            检查本体更新UToolStripMenuItem.Size = new Size(207, 22);
            检查本体更新UToolStripMenuItem.Text = "检查本体更新(&U)...";
            检查本体更新UToolStripMenuItem.Click += 检查本体更新UToolStripMenuItem_Click;
            // 
            // 检查Issues列表更新IToolStripMenuItem
            // 
            检查Issues列表更新IToolStripMenuItem.Name = "检查Issues列表更新IToolStripMenuItem";
            检查Issues列表更新IToolStripMenuItem.Size = new Size(207, 22);
            检查Issues列表更新IToolStripMenuItem.Text = "检查 Issue 列表更新(&I)...";
            检查Issues列表更新IToolStripMenuItem.Click += 检查Issues列表更新IToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(204, 6);
            // 
            // 关于AToolStripMenuItem
            // 
            关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            关于AToolStripMenuItem.Size = new Size(207, 22);
            关于AToolStripMenuItem.Text = "关于(&A)...";
            关于AToolStripMenuItem.Click += 关于AToolStripMenuItem_Click;
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.Location = new Point(593, 556);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(262, 17);
            labelHint.TabIndex = 8;
            labelHint.Text = "双击列表里的项目可以查看此 Issue 的详细信息";
            labelHint.TextAlign = ContentAlignment.BottomRight;
            // 
            // textBox_OnlineIssue
            // 
            textBox_OnlineIssue.Location = new Point(81, 144);
            textBox_OnlineIssue.Margin = new Padding(2);
            textBox_OnlineIssue.Name = "textBox_OnlineIssue";
            textBox_OnlineIssue.Size = new Size(97, 23);
            textBox_OnlineIssue.TabIndex = 9;
            // 
            // label_OnlineIssue
            // 
            label_OnlineIssue.AutoSize = true;
            label_OnlineIssue.Location = new Point(12, 147);
            label_OnlineIssue.Margin = new Padding(2, 0, 2, 0);
            label_OnlineIssue.Name = "label_OnlineIssue";
            label_OnlineIssue.Size = new Size(66, 17);
            label_OnlineIssue.TabIndex = 10;
            label_OnlineIssue.Text = "Issue 编号";
            // 
            // button_OnlineIssue
            // 
            button_OnlineIssue.Location = new Point(182, 144);
            button_OnlineIssue.Margin = new Padding(2);
            button_OnlineIssue.Name = "button_OnlineIssue";
            button_OnlineIssue.Size = new Size(71, 23);
            button_OnlineIssue.TabIndex = 11;
            button_OnlineIssue.Text = "获取";
            button_OnlineIssue.UseVisualStyleBackColor = true;
            button_OnlineIssue.Click += button_OnlineIssue_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip1.Location = new Point(0, 587);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(867, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(44, 17);
            toolStripStatusLabel1.Text = "${text}";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(666, 17);
            toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(142, 17);
            toolStripStatusLabel3.Text = "已载入 ${issue} 个 Issue";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 609);
            Controls.Add(statusStrip1);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PCL Issue Helper";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 检查本体更新UToolStripMenuItem;
        private ToolStripMenuItem 检查Issues列表更新IToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
}
