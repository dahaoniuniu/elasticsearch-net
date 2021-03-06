﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Cluster.ClusterPendingTasks
{
	public class ClusterPendingTasksUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await GET("/_cluster/pending_tasks")
			.Fluent(c => c.ClusterPendingTasks())
			.Request(c => c.ClusterPendingTasks(new ClusterPendingTasksRequest()))
			.FluentAsync(c => c.ClusterPendingTasksAsync())
			.RequestAsync(c => c.ClusterPendingTasksAsync(new ClusterPendingTasksRequest()));
	}
}
