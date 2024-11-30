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
            menuStrip1.SuspendLayout();
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
            textBoxTitle.Size = new Size(738, 23);
            textBoxTitle.TabIndex = 2;
            // 
            // textBoxBody
            // 
            textBoxBody.Location = new Point(50, 64);
            textBoxBody.Name = "textBoxBody";
            textBoxBody.Size = new Size(738, 23);
            textBoxBody.TabIndex = 3;
            // 
            // buttonGetSimilarity
            // 
            buttonGetSimilarity.Location = new Point(650, 96);
            buttonGetSimilarity.Name = "buttonGetSimilarity";
            buttonGetSimilarity.Size = new Size(137, 25);
            buttonGetSimilarity.TabIndex = 4;
            buttonGetSimilarity.Text = "比对相似度";
            buttonGetSimilarity.UseVisualStyleBackColor = true;
            buttonGetSimilarity.Click += buttonGetSimilarity_Click;
            // 
            // listViewTitle
            // 
            listViewTitle.Columns.AddRange(new ColumnHeader[] { columnHeaderIssueIdTitle, columnHeaderSimilarityTitle, columnHeaderDataTitle });
            listViewTitle.FullRowSelect = true;
            listViewTitle.Location = new Point(12, 136);
            listViewTitle.Name = "listViewTitle";
            listViewTitle.Size = new Size(383, 330);
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
            listViewBody.Location = new Point(405, 136);
            listViewBody.Name = "listViewBody";
            listViewBody.Size = new Size(383, 330);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { 快速链接LToolStripMenuItem, 帮助HToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
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
            帮助HToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 关于AToolStripMenuItem });
            帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            帮助HToolStripMenuItem.Size = new Size(61, 21);
            帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            关于AToolStripMenuItem.Size = new Size(180, 22);
            关于AToolStripMenuItem.Text = "关于(&A)...";
            关于AToolStripMenuItem.Click += 关于AToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
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
            MaximizeBox = false;
            Name = "FormMain";
            Text = "PCL Issue相似度对比器";
            Load += Form1_Load;
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
    }
}
