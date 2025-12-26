namespace NetroCorp.Lookup;

public static class Website {
    public static string? WhatIs(string website) {
        if (string.IsNullOrWhiteSpace(website)) {
            return null;
        }

        return website.Trim().ToLowerInvariant() switch {
            "netrocorp.net" => "netrocorp.net is the main website of NetroCorp, As of 2026 this has gotten a major redesign (which they call v3) so check that out.",
            "gardens.wiki" => "gardens.wiki is a new alternative wiki hosting service for everyone. Escape from the clutches of services like Fandom/Wikia and use gardens.wiki!",
            "pastaya.net" => "This is pastaya's main website. Uses Rust for the website counter.",
            _ => null,
        };
    }
    public static string? TuffWhatIs(string website) {
        if (string.IsNullOrWhiteSpace(website)) {
            return null;
        }
        return website.Trim().ToLowerInvariant() switch {
            "netrocorp.net" => "MANGO MANGO NETROCORP.NET IS VERY TUFF MAIN WEBSITE OF NETROCORP",
            "gardens.wiki" => "MANGO MANGO GARDENS.WIKI IS THE TUFFEST 67 WIKI HOSTING SERVICE",
            "pastaya.net" => "MANGO MANGO PASTAYA.NET IS VERY TUFF WEBSITE MADE IN TUFF FEMBOY LANG RUST",
            _ => null,
        };
    }
}
