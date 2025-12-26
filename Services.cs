namespace NetroCorp.Lookup;
public static class Services {
    public static string? WhatIs(string service) {
        if (string.IsNullOrWhiteSpace(service)) {
            return null;
        }
        return service.Trim().ToLowerInvariant() switch {
            "netrohost" => "NetroHost is a hosting service for everyone.",
            "thecodingbot" => "TheCodingBot is a discord bot made by TheCodingGuy. It's in over a hundred servers!",
            _ => null,
        };
    }
}
