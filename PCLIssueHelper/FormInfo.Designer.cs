namespace PCLIssueHelper
{
    partial class FormInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            buttonGithub = new Button();
            webView2Markdown = new Microsoft.Web.WebView2.WinForms.WebView2();
            labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)webView2Markdown).BeginInit();
            SuspendLayout();
            // 
            // buttonGithub
            // 
            buttonGithub.Location = new Point(442, 476);
            buttonGithub.Name = "buttonGithub";
            buttonGithub.Size = new Size(99, 37);
            buttonGithub.TabIndex = 0;
            buttonGithub.Text = "转到 Github";
            buttonGithub.UseVisualStyleBackColor = true;
            buttonGithub.Click += buttonGithub_Click;
            // 
            // webView2Markdown
            // 
            webView2Markdown.AllowExternalDrop = true;
            webView2Markdown.CreationProperties = null;
            webView2Markdown.DefaultBackgroundColor = Color.White;
            webView2Markdown.Location = new Point(12, 50);
            webView2Markdown.Name = "webView2Markdown";
            webView2Markdown.Size = new Size(529, 408);
            webView2Markdown.TabIndex = 1;
            webView2Markdown.ZoomFactor = 1D;
            webView2Markdown.NavigationStarting += webView2Markdown_NavigationStarting;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(73, 27);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "{$title}";
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 525);
            Controls.Add(labelTitle);
            Controls.Add(webView2Markdown);
            Controls.Add(buttonGithub);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FormInfo";
            Text = "Issue {$issue} 的详细信息 (按 Esc 退出)";
            Load += FormInfo_Load;
            KeyDown += FormInfo_KeyDown;
            ((System.ComponentModel.ISupportInitialize)webView2Markdown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGithub;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2Markdown;
        private Label labelTitle;
    }
}