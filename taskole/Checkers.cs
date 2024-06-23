using System.IO;

namespace taskole
{
    public static class Checkers
    {
        public static bool IsSavingPlaceExist(string path) => Directory.Exists(path) ? true : false;
    }
}
