using System.IO;

namespace HAN_ASD_ADP.Benchmarks.Helpers;

public static class GitBenchmarkResultSaver
{
    public static void Copy(DirectoryInfo currentDirectory)
    {
        var sourcePath = Path.Combine(currentDirectory.FullName, "BenchmarkDotNet.Artifacts", "results");
        var projectRootDirectory = currentDirectory.Parent.Parent.Parent.Parent.Parent;
        string targetPath = Path.Combine(projectRootDirectory.FullName, "BenchmarkResults");
        Directory.CreateDirectory(targetPath);

        foreach (var sourceFile in Directory.GetFiles(sourcePath))
        {
            string sourceFileName = Path.GetFileName(sourceFile);
            string destFileName = Path.Combine(targetPath, sourceFileName);
            File.Copy(sourceFile, destFileName, true);
        }
    }
}