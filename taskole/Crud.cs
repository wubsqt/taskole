using System.Text;

namespace taskole
{
    public static class Crud
    {
        public static string path = "tasks/";
        public static string file = "test1.txt";
     
        // TODO : fix overwrite in add task 
        // TODO : make msgs beauty
        public static void AddTask(string[] msg)
        {
            StringBuilder message = new StringBuilder();
            foreach (var word in msg)
            {
                message.Append(word);
                message.Append(' ');
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(path + file))
                {
                    sw.WriteLine(message);
                }
            }
            catch (Exception e)
            {
                SetColors.Red();
                Console.WriteLine(e.ToString());
                SetColors.Default();
            }

            SetColors.Green();
            Console.WriteLine("Task was successfully added !");
            SetColors.Default();
        }

        public static void RemoveTask()
        {
            SetColors.Green();
            Console.WriteLine("Task was successfully removed ...!");
            SetColors.Default();
        }

        public static void GetTaskList()
        {
            using (StreamReader sr = new StreamReader(path + file))
            {
                var lines = sr.ReadToEnd();
                Console.WriteLine(lines);
            }
        }
    }
}
