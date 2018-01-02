using System;
using System.Linq;
using static System.IO.Path;

namespace Common.Functions.GetRelativePath
{
    public static class RelativePathGetter
    {
        public static string Relative(Uri path1, Uri path2)
            => Combine(
                paths: path1.MakeRelativeUri(path2).OriginalString.Split('/').Skip(1).ToArray())
                .Replace('\\', '/');

        public static string Relative(string path1, string path2)
            => Relative(new Uri(path1), new Uri(path2));
    }
}
