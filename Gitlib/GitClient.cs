using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace GitLib
{
    public class GitClient
    {
        public async Task<Issue> GetIssue(string repo, string project, string issueId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("MyAgent");
                var issueUrl = $"https://api.github.com/repos/{repo}/{project}/issues/{issueId}";
                var issueData = await client.GetAsync(issueUrl);

                if (issueData.IsSuccessStatusCode)
                {
                    var issueContent = await issueData.Content.ReadAsStringAsync();
                    Issue newIssue = JsonConvert.DeserializeObject<Issue>(issueContent);
                    return newIssue;
                }

                return null; 
            }
        }

        public async Task<List<Issue>> GetIssues(string repo, string project)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("MyAgent");
                var issueUrl = $"https://api.github.com/repos/{repo}/{project}/issues";
                var issuesData = await client.GetAsync(issueUrl);

                if (issuesData.IsSuccessStatusCode)
                {
                    var issuesContent = await issuesData.Content.ReadAsStringAsync();
                    List<Issue> newIssues = JsonConvert.DeserializeObject<List<Issue>>(issuesContent);
                    return newIssues;
                }

                return null;
            }
        }

        public async Task<Pull> GetPull(string repo, string project, string pullId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("MyAgent");
                var pullUrl = $"https://api.github.com/repos/{repo}/{project}/pulls/{pullId}";
                var pullData = await client.GetAsync(pullUrl);

                if (pullData.IsSuccessStatusCode)
                {
                    var pullContent = await pullData.Content.ReadAsStringAsync();
                    Pull newPull = JsonConvert.DeserializeObject<Pull>(pullContent);
                    return newPull;
                }

                return null;
            }
        }

        public async Task<List<Pull>> GetPulls(string repo, string project)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("MyAgent");
                var pullsUrl = $"https://api.github.com/repos/{repo}/{project}/pulls";
                var pullsData = await client.GetAsync(pullsUrl);

                if (pullsData.IsSuccessStatusCode)
                {
                    var pullsContent = await pullsData.Content.ReadAsStringAsync();
                    List<Pull> newPulls = JsonConvert.DeserializeObject<List<Pull>>(pullsContent);
                    return newPulls;
                }

                return null;
            }
        }
    }
}
