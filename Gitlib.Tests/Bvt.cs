using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitLib;

namespace Gitlib.Tests
{
    [TestClass]
    public class Bvt
    {
        [TestMethod]
        public void GetIssueTest()
        {
            GitClient gitClient = new GitClient();

            var issueTask = gitClient.GetIssue("Microsoft", "Typescript", "8924");
            issueTask.Wait();

            Assert.IsNotNull(issueTask.Result);
        }

        [TestMethod]
        public void GetIssuesTest()
        {
            GitClient gitClient = new GitClient();

            var issuesTask = gitClient.GetIssues("Microsoft", "Typescript");
            issuesTask.Wait();

            Assert.IsNotNull(issuesTask.Result);
        }

        [TestMethod]
        public void GetPullTest()
        {
            GitClient gitClient = new GitClient();

            var pullTask = gitClient.GetPull("Microsoft", "Typescript", "8946");
            pullTask.Wait();

            Assert.IsNotNull(pullTask.Result);
        }

        [TestMethod]
        public void GetPullsTest()
        {
            GitClient gitClient = new GitClient();

            var pullsTask = gitClient.GetPulls("Microsoft", "TypeScript");
            pullsTask.Wait();

            Assert.IsNotNull(pullsTask.Result);
        }
    }
}

            //Console.WriteLine(issueTask.Result.title);
            //issuesTask.Result.ForEach(singleIssue => Console.WriteLine(singleIssue.title));
            //Console.WriteLine(pullTask.Result.html_url);
            //pullsTask.Result.ForEach(singlePull => Console.WriteLine(singlePull.html_url));
            //Console.ReadLine();
