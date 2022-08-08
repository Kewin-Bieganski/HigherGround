using Octokit;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace GithubIssues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cB_browser.Items.AddRange(Enum.GetNames(typeof(GithubIssueManager.WebBrowser)));
        }

        private void b_logIn_Click(object sender, EventArgs e)
        {
            try
            {
                GithubIssueManager.RequestLoginFor(tB_clientId.Text, tB_clientSecret.Text, tB_username.Text, tB_repository.Text, (GithubIssueManager.WebBrowser)cB_browser.SelectedIndex);
                GithubIssueManager.Authorize();
            } catch
            {
                rTB_output.Text = "Coœ posz³o nie tak.";
            }
        }

        private async void b_createIssue_Click(object sender, EventArgs e)
        {
            try
            {
                rTB_output.Text = await GithubIssueManager.CreateNewIssue(tB_issueTitle.Text, rTB_issueBody.Text);
            }
            catch
            {
                rTB_output.Text = "Coœ posz³o nie tak.";
            }
            
        }

        private async void b_listIssues_Click(object sender, EventArgs e)
        {
            try
            {
                rTB_output.Text = await GithubIssueManager.GetIssues();
            }
            catch
            {
                rTB_output.Text = "Coœ posz³o nie tak.";
            }
        }
    }
}