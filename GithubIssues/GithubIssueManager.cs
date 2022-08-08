using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GithubIssues
{
    internal class GithubIssueManager
    {
        private static GitHubClient _gitHubClient = new GitHubClient(new ProductHeaderValue("MyhubIssues"));
        private static string _code;
        private static string _clientId;
        private static string _clientSecret;
        private static string _username;
        private static string _repositoryName;

        public enum WebBrowser
        {
            Chrome,
            Firefox,
        }

        public static string RequestLoginFor(string clientId, string clientSecret, string username, string repositoryName, WebBrowser webBrowser)
        {
            if(string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(clientSecret) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(repositoryName))
            {
                throw new ArgumentNullException("Error: Login credentials may not be null or empty");
            }
            _clientId = clientId;
            _clientSecret = clientSecret;
            _username = username;
            _repositoryName = repositoryName;

            OauthLoginRequest oauthLoginRequest = new OauthLoginRequest(clientId)
            {
                Scopes = { "public_repo" },
            };
            Uri oauthLoginUri = _gitHubClient.Oauth.GetGitHubLoginUrl(oauthLoginRequest);
            switch (webBrowser)
            {
                case WebBrowser.Chrome:
                    Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", oauthLoginUri.ToString());
                    break;
                case WebBrowser.Firefox:
                    Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", oauthLoginUri.ToString());
                    break;
                default:
                    throw new ArgumentException("Error: No such browser");
            }
            _code = GetCode();
            return oauthLoginUri.ToString();
        }

        public static async void Authorize()
        {
            OauthTokenRequest request = new OauthTokenRequest(_clientId, _clientSecret, _code);
            OauthToken oauthToken = await _gitHubClient.Oauth.CreateAccessToken(request);
            _gitHubClient.Credentials = new Credentials(oauthToken.AccessToken);
        }

        public static string GetCode()
        {
            IPAddress localIPAdress = IPAddress.Parse("127.0.0.1");
            int listenedPort = 2022;
            TcpListener tcpListenerServer;
            byte[] bytes = new byte[32];
            string data = null;
            try
            {
                tcpListenerServer = new TcpListener(localIPAdress, listenedPort);
                tcpListenerServer.Start();
                while (data == null)
                {
                    TcpClient tcpClient = tcpListenerServer.AcceptTcpClient();
                    using (NetworkStream stream = tcpClient.GetStream())
                    {
                        int i = stream.Read(bytes, 0, bytes.Length);
                        data = Encoding.ASCII.GetString(bytes, 0, i);
                        Debug.WriteLine(data);
                    }
                    tcpClient.Close();
                }
            }
            catch { MessageBox.Show("Problem z nasłuchiwaniem kodu dostępu.", "Error"); }
            return new Regex("code=(.+)").Match(data).Groups[1].Value;
        }

        public async static Task<string> CreateNewIssue(string? title, string? body)
        {
            NewIssue newIssue = new NewIssue(title)
            {
                Body = body,
            };
            await _gitHubClient.Issue.Create(_username, _repositoryName, newIssue);
            return $"Utworzono: {newIssue.Title}";
        }

        public static async Task<string> GetIssues()
        {
            IReadOnlyList<Issue> issues = await _gitHubClient.Issue.GetAllForRepository(_username, _repositoryName);
            return String.Join("\n+================+\n", issues.Select<Issue, string>(issue => { return $"> Tytuł: {issue.Title}\nTreść: {issue.Body}"; }));
        }
    }
}
