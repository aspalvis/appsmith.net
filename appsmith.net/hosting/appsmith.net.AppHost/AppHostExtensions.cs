using System.IO;

public static class AppHostExtensions
{
    public static string GetRepoRootDir()
    {
        // Assumes this file is in <repoRootDir>/hosting/appsmith.net.AppHost
        var current = Directory.GetCurrentDirectory();
        var hostingIndex = current.IndexOf(Path.Combine("hosting", "appsmith.net.AppHost"));
        if (hostingIndex >= 0)
        {
            return current.Substring(0, hostingIndex);
        }
        // Fallback: go up two directories
        return Directory.GetParent(current)?.Parent?.FullName ?? current;
    }
}
