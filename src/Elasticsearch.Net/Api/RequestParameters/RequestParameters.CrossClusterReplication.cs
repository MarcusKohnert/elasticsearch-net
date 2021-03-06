// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elastic.Transport;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.CrossClusterReplicationApi
{
	///<summary>Request options for DeleteAutoFollowPattern <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-delete-auto-follow-pattern.html</para></summary>
	public class DeleteAutoFollowPatternRequestParameters : RequestParameters<DeleteAutoFollowPatternRequestParameters>
	{
	}

	///<summary>Request options for CreateFollowIndex <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-follow.html</para></summary>
	public class CreateFollowIndexRequestParameters : RequestParameters<CreateFollowIndexRequestParameters>
	{
		///<summary>
		/// Sets the number of shard copies that must be active before returning. Defaults to 0. Set to `all` for all shard copies, otherwise set to
		/// any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)
		///</summary>
		public string WaitForActiveShards
		{
			get => Q<string>("wait_for_active_shards");
			set => Q("wait_for_active_shards", value);
		}
	}

	///<summary>Request options for FollowInfo <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-info.html</para></summary>
	public class FollowInfoRequestParameters : RequestParameters<FollowInfoRequestParameters>
	{
	}

	///<summary>Request options for FollowIndexStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-stats.html</para></summary>
	public class FollowIndexStatsRequestParameters : RequestParameters<FollowIndexStatsRequestParameters>
	{
	}

	///<summary>Request options for ForgetFollowerIndex <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-forget-follower.html</para></summary>
	public class ForgetFollowerIndexRequestParameters : RequestParameters<ForgetFollowerIndexRequestParameters>
	{
	}

	///<summary>Request options for GetAutoFollowPattern <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html</para></summary>
	public class GetAutoFollowPatternRequestParameters : RequestParameters<GetAutoFollowPatternRequestParameters>
	{
	}

	///<summary>Request options for PauseAutoFollowPattern <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-pause-auto-follow-pattern.html</para></summary>
	public class PauseAutoFollowPatternRequestParameters : RequestParameters<PauseAutoFollowPatternRequestParameters>
	{
	}

	///<summary>Request options for PauseFollowIndex <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-pause-follow.html</para></summary>
	public class PauseFollowIndexRequestParameters : RequestParameters<PauseFollowIndexRequestParameters>
	{
	}

	///<summary>Request options for CreateAutoFollowPattern <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-auto-follow-pattern.html</para></summary>
	public class CreateAutoFollowPatternRequestParameters : RequestParameters<CreateAutoFollowPatternRequestParameters>
	{
	}

	///<summary>Request options for ResumeAutoFollowPattern <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-resume-auto-follow-pattern.html</para></summary>
	public class ResumeAutoFollowPatternRequestParameters : RequestParameters<ResumeAutoFollowPatternRequestParameters>
	{
	}

	///<summary>Request options for ResumeFollowIndex <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-resume-follow.html</para></summary>
	public class ResumeFollowIndexRequestParameters : RequestParameters<ResumeFollowIndexRequestParameters>
	{
	}

	///<summary>Request options for Stats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-stats.html</para></summary>
	public class CcrStatsRequestParameters : RequestParameters<CcrStatsRequestParameters>
	{
	}

	///<summary>Request options for UnfollowIndex <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-unfollow.html</para></summary>
	public class UnfollowIndexRequestParameters : RequestParameters<UnfollowIndexRequestParameters>
	{
	}
}