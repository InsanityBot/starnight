namespace Starnight.Internal.Gateway.Commands;

using System.Text.Json.Serialization;

using Starnight.Internal.Gateway;
using Starnight.Internal.Gateway.Payloads.Serverbound;

/// <summary>
/// Gateway command to request guild members through the gateway.
/// </summary>
public sealed record DiscordRequestGuildMembersCommand : IDiscordGatewayPayload<RequestGuildMembersPayload>
{
	/// <inheritdoc/>
	[JsonPropertyName("d")]
	public required RequestGuildMembersPayload Data { get; init; }

	/// <inheritdoc/>
	[JsonPropertyName("op")]
	public DiscordGatewayOpcode Opcode { get; init; } = DiscordGatewayOpcode.RequestGuildMembers;
}