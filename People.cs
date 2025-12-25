namespace NetroCorp.Lookup;

public static class Person {
    public static string? WhoIs(string name) {
        if (string.IsNullOrWhiteSpace(name)) {
            return null;
        }

        return name.Trim().ToLowerInvariant() switch {
            "tcg" => "TheCodingGuy is the owner of NetroCorp.",
            "papertek" => "Known member of NetroCorp. \"Leader\" of gardens.wiki.",
            "flustix" => "The person that made \"fluXis\", the rhythm game. Not in good terms with papertek.",
            _ => null,
        };
    }
    public static string? TuffWhoIs(string name) {
        if (string.IsNullOrWhiteSpace(name)) {
            return null;
        }

        return name.Trim().ToLowerInvariant() switch {
            "tcg" => "MANGO MANGO OWNER OF NETROCORP",
            "papertek" => "MANGO MANGO PAPERTEK OWNS TUFF GARDENS.WIKI",
            "flustix" => "MANGO MANGO TUFF C# DEV WHO MADE OSU!MANIA BUT ON DRUGS",
            _ => null,
        };

    }
}

