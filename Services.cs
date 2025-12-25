namespace NetroCorp.Lookup;
public static class Services {
	public static string? WhatIs(string service) {
		if (string.IsNullOrWhiteSpace(service)) {
			return null;
		}
		return service.Trim().ToLowerInvariant() switch {
			"netrohost" => "NetroHost is a hosting service for everyone.",
			_ => null,
		};
	}
}
