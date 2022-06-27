namespace Starnight.Internal.Rest.Resources;

using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using Microsoft.Extensions.Caching.Memory;

using Starnight.Internal.Entities.Users;

using static DiscordApiConstants;

using HttpMethodEnum = HttpMethod;

/// <summary>
/// Represents a wrapper for all requests to Discord's User rest resource.
/// </summary>
public class DiscordUserRestResource : AbstractRestResource
{
	private readonly RestClient __rest_client;

	/// <inheritdoc/>
	public DiscordUserRestResource
	(
		RestClient client,
		IMemoryCache cache
	)
		: base(cache)
		=> this.__rest_client = client;

	/// <summary>
	/// Returns the current user.
	/// </summary>
	/// <remarks>
	/// For OAuth2, this requires the <c>identify</c> scope, which will return the object without an email,
	/// and optionally the <c>email</c> scope, which will return the object with an email.
	/// </remarks>
	public async ValueTask<DiscordUser> GetCurrentUserAsync()
	{
		IRestRequest request = new RestRequest
		{
			Path = $"/{Users}/{Me}",
			Url = new($"{BaseUri}/{Users}/{Me}"),
			Method = HttpMethodEnum.Get,
			Context = new()
			{
				["endpoint"] = $"/{Users}/{Me}",
				["cache"] = this.RatelimitBucketCache,
				["exempt-from-global-limit"] = false
			}
		};

		HttpResponseMessage response = await this.__rest_client.MakeRequestAsync(request);

		return JsonSerializer.Deserialize<DiscordUser>(await response.Content.ReadAsStringAsync())!;
	}
}