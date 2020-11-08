// https://www.jsonutils.com/
using System;
using System.Collections.Generic;

namespace CrewNodeLauncher.API.Models
{
    class BuildHistory
    {
        public class Project
        {
            public int projectId { get; set; }
            public int accountId { get; set; }
            public string accountName { get; set; }
            public IList<object> builds { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public string repositoryType { get; set; }
            public string repositoryScm { get; set; }
            public string repositoryName { get; set; }
            public bool isPrivate { get; set; }
            public bool skipBranchesWithoutAppveyorYml { get; set; }
            public DateTime created { get; set; }
        }

        public class Build
        {
            public int buildId { get; set; }
            public IList<object> jobs { get; set; }
            public int buildNumber { get; set; }
            public string version { get; set; }
            public string message { get; set; }
            public string branch { get; set; }
            public string commitId { get; set; }
            public string authorName { get; set; }
            public string authorUsername { get; set; }
            public string committerName { get; set; }
            public string committerUsername { get; set; }
            public DateTime committed { get; set; }
            public IList<object> messages { get; set; }
            public string status { get; set; }
            public DateTime started { get; set; }
            public DateTime finished { get; set; }
            public DateTime created { get; set; }
            public DateTime updated { get; set; }
        }

        public class Item
        {
            public Project project { get; set; }
            public IList<Build> builds { get; set; }
        }
    }

    class AppComboBoxItem
    {
        public BuildHistory.Build Build { get; set; }
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    class BuildJob
    {
        public class NuGetFeed
        {
            public string id { get; set; }
            public string name { get; set; }
            public bool publishingEnabled { get; set; }
            public DateTime created { get; set; }
        }

        public class SecurityDescriptor
        {
        }

        public class Project
        {
            public int projectId { get; set; }
            public int accountId { get; set; }
            public string accountName { get; set; }
            public IList<object> builds { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public string repositoryType { get; set; }
            public string repositoryScm { get; set; }
            public string repositoryName { get; set; }
            public string repositoryBranch { get; set; }
            public bool isPrivate { get; set; }
            public bool skipBranchesWithoutAppveyorYml { get; set; }
            public NuGetFeed nuGetFeed { get; set; }
            public SecurityDescriptor securityDescriptor { get; set; }
            public DateTime created { get; set; }
            public DateTime updated { get; set; }
        }

        public class Job
        {
            public string jobId { get; set; }
            public string name { get; set; }
            public bool allowFailure { get; set; }
            public int messagesCount { get; set; }
            public int compilationMessagesCount { get; set; }
            public int compilationErrorsCount { get; set; }
            public int compilationWarningsCount { get; set; }
            public int testsCount { get; set; }
            public int passedTestsCount { get; set; }
            public int failedTestsCount { get; set; }
            public int artifactsCount { get; set; }
            public string status { get; set; }
            public DateTime started { get; set; }
            public DateTime finished { get; set; }
            public DateTime created { get; set; }
            public DateTime updated { get; set; }
        }

        public class Build
        {
            public int buildId { get; set; }
            public IList<Job> jobs { get; set; }
            public int buildNumber { get; set; }
            public string version { get; set; }
            public string message { get; set; }
            public string branch { get; set; }
            public string commitId { get; set; }
            public string authorName { get; set; }
            public string authorUsername { get; set; }
            public string committerName { get; set; }
            public string committerUsername { get; set; }
            public DateTime committed { get; set; }
            public IList<object> messages { get; set; }
            public string status { get; set; }
            public DateTime started { get; set; }
            public DateTime finished { get; set; }
            public DateTime created { get; set; }
            public DateTime updated { get; set; }
        }

        public class Item
        {
            public Project project { get; set; }
            public Build build { get; set; }
        }

    }

    class BuildArtifact
    {
        public string fileName { get; set; }
        public string type { get; set; }
        public int size { get; set; }
        public DateTime created { get; set; }
    }
}
