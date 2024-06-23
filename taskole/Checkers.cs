using System.IO;

namespace taskole
{
    public static class Checkers
    {
        public static bool IsSavingPlaceExist(string path)
        {
            if (Directory.Exists(path))
                return true;

            return false;
        }
    }
}
