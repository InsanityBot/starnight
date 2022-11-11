namespace Starnight.Extensions.Caching.Shims;

using System;
using System.Threading;
using System.Threading.Tasks;

using Starnight.Internal.Rest.Payloads.Channels;

public partial class CachingChannelRestResource
{
	/// <inheritdoc/>
	public ValueTask AddGroupDMRecipientAsync
	(
		Int64 channelId,
		Int64 userId,
		AddGroupDMRecipientRequestPayload payload,
		CancellationToken ct = default
	)
	{
		return this.__underlying.AddGroupDMRecipientAsync
		(
			channelId,
			userId,
			payload,
			ct
		);
	}

	/// <inheritdoc/>
	public ValueTask<Boolean> AddToThreadAsync
	(
		Int64 threadId,
		Int64 userId,
		CancellationToken ct = default
	)
	{
		return this.__underlying.AddToThreadAsync
		(
			threadId,
			userId,
			ct
		);
	}

	/// <inheritdoc/>
	public ValueTask<Boolean> CreateReactionAsync
	(
		Int64 channelId,
		Int64 messageId,
		String emoji,
		CancellationToken ct = default
	)
	{
		return this.__underlying.CreateReactionAsync
		(
			channelId,
			messageId,
			emoji,
			ct
		);
	}

	/// <inheritdoc/>
	public ValueTask DeleteAllReactionsAsync
	(
		Int64 channelId,
		Int64 messageId,
		CancellationToken ct = default
	)
	{
		return this.__underlying.DeleteAllReactionsAsync
		(
			channelId,
			messageId,
			ct
		);
	}

	/// <inheritdoc/>
	public ValueTask<Boolean> DeleteOwnReactionAsync
	(
		Int64 channelId,
		Int64 messageId,
		String emoji,
		CancellationToken ct = default
	)
	{
		return this.__underlying.DeleteOwnReactionAsync
		(
			channelId,
			messageId,
			emoji,
			ct
		);
	}

	/// <inheritdoc/>
	public ValueTask<Boolean> DeleteUserReactionAsync
	(
		Int64 channelId,
		Int64 messageId,
		Int64 userId,
		String emoji,
		CancellationToken ct = default
	)
	{
		return this.__underlying.DeleteUserReactionAsync
		(
			channelId,
			messageId,
			userId,
			emoji,
			ct
		);
	}

	/// <inheritdoc/>
	public ValueTask<Boolean> JoinThreadAsync
	(
		Int64 threadId,
		CancellationToken ct = default
	)
	{
		return this.__underlying.JoinThreadAsync
		(
			threadId,
			ct
		);
	}

	/// <inheritdoc/>
	public ValueTask<Boolean> LeaveThreadAsync
	(
		Int64 threadId,
		CancellationToken ct = default
	)
	{
		return this.__underlying.LeaveThreadAsync
		(
			threadId,
			ct
		);
	}

	/// <inheritdoc/>
	public ValueTask RemoveGroupDMRecipientAsync
	(
		Int64 channelId,
		Int64 userId,
		CancellationToken ct = default
	)
	{
		return this.__underlying.RemoveGroupDMRecipientAsync
		(
			channelId,
			userId,
			ct
		);
	}

	/// <inheritdoc/>
	public ValueTask TriggerTypingIndicatorAsync
	(
		Int64 channelId,
		CancellationToken ct = default
	)
	{
		return this.__underlying.TriggerTypingIndicatorAsync
		(
			channelId,
			ct
		);
	}
}
