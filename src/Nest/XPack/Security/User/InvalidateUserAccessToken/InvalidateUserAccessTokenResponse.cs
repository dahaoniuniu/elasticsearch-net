﻿using Newtonsoft.Json;

namespace Nest
{
	public interface IInvalidateUserAccessTokenResponse : IResponse
	{
		[JsonProperty("created")]
		bool Created { get; }
	}

	public class InvalidateUserAccessTokenResponse : ResponseBase, IInvalidateUserAccessTokenResponse
	{
		public bool Created { get; internal set; }
	}
}
