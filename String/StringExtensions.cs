namespace Grimity.String {
public static class StringExtensions {
    public static bool Falsy(this string s) {
        return string.IsNullOrEmpty(s);
    }

    public static bool Truthy(this string s) {
        return !s.Falsy();
    }
}
}