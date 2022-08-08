namespace GithubIssues
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rTB_issueBody = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_issueTitle = new System.Windows.Forms.TextBox();
            this.b_listIssues = new System.Windows.Forms.Button();
            this.b_createIssue = new System.Windows.Forms.Button();
            this.cB_browser = new System.Windows.Forms.ComboBox();
            this.tB_repository = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.b_logIn = new System.Windows.Forms.Button();
            this.tB_clientSecret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_clientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rTB_output = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.rTB_issueBody);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tB_issueTitle);
            this.panel1.Controls.Add(this.b_listIssues);
            this.panel1.Controls.Add(this.b_createIssue);
            this.panel1.Controls.Add(this.cB_browser);
            this.panel1.Controls.Add(this.tB_repository);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tB_username);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.b_logIn);
            this.panel1.Controls.Add(this.tB_clientSecret);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tB_clientId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rTB_output);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(957, 573);
            this.panel1.TabIndex = 23;
            // 
            // rTB_issueBody
            // 
            this.rTB_issueBody.Location = new System.Drawing.Point(133, 217);
            this.rTB_issueBody.Margin = new System.Windows.Forms.Padding(10);
            this.rTB_issueBody.Name = "rTB_issueBody";
            this.rTB_issueBody.Size = new System.Drawing.Size(320, 287);
            this.rTB_issueBody.TabIndex = 39;
            this.rTB_issueBody.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Title:";
            // 
            // tB_issueTitle
            // 
            this.tB_issueTitle.Location = new System.Drawing.Point(133, 170);
            this.tB_issueTitle.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.tB_issueTitle.Name = "tB_issueTitle";
            this.tB_issueTitle.Size = new System.Drawing.Size(320, 27);
            this.tB_issueTitle.TabIndex = 36;
            // 
            // b_listIssues
            // 
            this.b_listIssues.Location = new System.Drawing.Point(473, 524);
            this.b_listIssues.Margin = new System.Windows.Forms.Padding(10);
            this.b_listIssues.Name = "b_listIssues";
            this.b_listIssues.Size = new System.Drawing.Size(464, 29);
            this.b_listIssues.TabIndex = 35;
            this.b_listIssues.Text = "List Issues";
            this.b_listIssues.UseVisualStyleBackColor = true;
            this.b_listIssues.Click += new System.EventHandler(this.b_listIssues_Click);
            // 
            // b_createIssue
            // 
            this.b_createIssue.Location = new System.Drawing.Point(133, 524);
            this.b_createIssue.Margin = new System.Windows.Forms.Padding(10);
            this.b_createIssue.Name = "b_createIssue";
            this.b_createIssue.Size = new System.Drawing.Size(320, 29);
            this.b_createIssue.TabIndex = 34;
            this.b_createIssue.Text = "Create Issue";
            this.b_createIssue.UseVisualStyleBackColor = true;
            this.b_createIssue.Click += new System.EventHandler(this.b_createIssue_Click);
            // 
            // cB_browser
            // 
            this.cB_browser.FormattingEnabled = true;
            this.cB_browser.Location = new System.Drawing.Point(247, 111);
            this.cB_browser.Margin = new System.Windows.Forms.Padding(10);
            this.cB_browser.Name = "cB_browser";
            this.cB_browser.Size = new System.Drawing.Size(206, 28);
            this.cB_browser.TabIndex = 33;
            this.cB_browser.Text = "Wybierz przeglądarkę";
            // 
            // tB_repository
            // 
            this.tB_repository.Location = new System.Drawing.Point(617, 64);
            this.tB_repository.Margin = new System.Windows.Forms.Padding(10);
            this.tB_repository.Name = "tB_repository";
            this.tB_repository.Size = new System.Drawing.Size(320, 27);
            this.tB_repository.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Repository name:";
            // 
            // tB_username
            // 
            this.tB_username.Location = new System.Drawing.Point(617, 17);
            this.tB_username.Margin = new System.Windows.Forms.Padding(10);
            this.tB_username.Name = "tB_username";
            this.tB_username.Size = new System.Drawing.Size(320, 27);
            this.tB_username.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Username:";
            // 
            // b_logIn
            // 
            this.b_logIn.Location = new System.Drawing.Point(133, 111);
            this.b_logIn.Margin = new System.Windows.Forms.Padding(10);
            this.b_logIn.Name = "b_logIn";
            this.b_logIn.Size = new System.Drawing.Size(94, 29);
            this.b_logIn.TabIndex = 28;
            this.b_logIn.Text = "Log in";
            this.b_logIn.UseVisualStyleBackColor = true;
            this.b_logIn.Click += new System.EventHandler(this.b_logIn_Click);
            // 
            // tB_clientSecret
            // 
            this.tB_clientSecret.Location = new System.Drawing.Point(133, 64);
            this.tB_clientSecret.Margin = new System.Windows.Forms.Padding(10);
            this.tB_clientSecret.Name = "tB_clientSecret";
            this.tB_clientSecret.Size = new System.Drawing.Size(320, 27);
            this.tB_clientSecret.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Client secret:";
            // 
            // tB_clientId
            // 
            this.tB_clientId.Location = new System.Drawing.Point(133, 17);
            this.tB_clientId.Margin = new System.Windows.Forms.Padding(10);
            this.tB_clientId.Name = "tB_clientId";
            this.tB_clientId.Size = new System.Drawing.Size(320, 27);
            this.tB_clientId.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Client Id:";
            // 
            // rTB_output
            // 
            this.rTB_output.Location = new System.Drawing.Point(473, 170);
            this.rTB_output.Margin = new System.Windows.Forms.Padding(10);
            this.rTB_output.Name = "rTB_output";
            this.rTB_output.Size = new System.Drawing.Size(464, 334);
            this.rTB_output.TabIndex = 23;
            this.rTB_output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1197, 616);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Github Issues";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private RichTextBox rTB_issueBody;
        private Label label4;
        private Label label3;
        private TextBox tB_issueTitle;
        private Button b_listIssues;
        private Button b_createIssue;
        private ComboBox cB_browser;
        private TextBox tB_repository;
        private Label label6;
        private TextBox tB_username;
        private Label label5;
        private Button b_logIn;
        private TextBox tB_clientSecret;
        private Label label2;
        private TextBox tB_clientId;
        private Label label1;
        private RichTextBox rTB_output;
    }
}