using System.IO;

namespace HAN_ASD_ADP.Benchmarks;

public static class BenchmarkResultSaver
{
    public static string Copy(DirectoryInfo currentDirectory)
    {
        var sourcePath = Path.Combine(currentDirectory.FullName, "BenchmarkDotNet.Artifacts", "results");
        var projectRootDirectory = currentDirectory.Parent.Parent.Parent.Parent.Parent;
        string targetPath = Path.Combine(projectRootDirectory.FullName, "BenchmarkResults");
        Directory.CreateDirectory(targetPath);

        foreach (var sourceFile in Directory.GetFiles(sourcePath))
        {
            string sourceFileName = Path.GetFileName(sourceFile);
            var destFileName = StripNamespaceFromFileName(sourceFileName);
            string destFile = Path.Combine(targetPath, destFileName);
            File.Copy(sourceFile, destFile, true);
        }
        return targetPath;
    }

    /// <summary>
    /// Turns:
    /// "HAN_ASD_ADP.Benchmarks.DynamicArray.DynamicArrayCountBenchmarks-report.md"
    /// into:
    /// "DynamicArrayCountBenchmarks-report.md"
    /// </summary>
    /// <param name="sourceFileName">Original file name</param>
    /// <returns>Shorthand file name</returns>
    private static string StripNamespaceFromFileName(string sourceFileName)
    {
        var nameParts = sourceFileName.Split('.');
        var strippedFileName = nameParts[^2] + "." + nameParts[^1];
        return strippedFileName;
    }
}