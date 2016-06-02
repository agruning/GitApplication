using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLib
{
    public class RootObject
    {
        public int id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string diff_url { get; set; }
        public string patch_url { get; set; }
        public string issue_url { get; set; }
        public string commits_url { get; set; }
        public string review_comments_url { get; set; }
        public string review_comment_url { get; set; }
        public string comments_url { get; set; }
        public string statuses_url { get; set; }
        public int number { get; set; }
        public string state { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public Assignee assignee { get; set; }
        public Milestone milestone { get; set; }
        public bool locked { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string closed_at { get; set; }
        public string merged_at { get; set; }
        public Head head { get; set; }
        public Base @base { get; set; }
        public Links _links { get; set; }
        public User3 user { get; set; }
        public string merge_commit_sha { get; set; }
        public bool merged { get; set; }
        public bool mergeable { get; set; }
        public MergedBy merged_by { get; set; }
        public int comments { get; set; }
        public int commits { get; set; }
        public int additions { get; set; }
        public int deletions { get; set; }
        public int changed_files { get; set; }
    }
}
