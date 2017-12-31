using System;

namespace Common.Functions.GetRelativePath
{
    public static class RelativePathGetter
    {
        public static string Relative(Uri path1, Uri path2)
            => path1.MakeRelativeUri(path2).OriginalString;

        public static string Relative(string path1, string path2)
            => Relative(new Uri(path1), new Uri(path2));
    }
}
