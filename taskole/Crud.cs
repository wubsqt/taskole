using System.Text;

namespace taskole
{
    public static class Crud
    {
        public static string path = "tasks/";
        public static string file = "test1.txt";

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
                string time = $"{DateTime.Now.ToString()},";
                File.AppendAllText((path + file), time);
                File.AppendAllText((path + file), message.ToString());
                File.AppendAllText((path + file), "\n");
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
            List<string> lines = new List<string>();
            string line;

            try
            {
                using (StreamReader sr = new StreamReader(path + file))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("There is no task, create one with 'add' command and your message.");
            }

            catch (Exception e)
            {
                SetColors.Red();
                Console.WriteLine(e.Message);
                SetColors.Default();
            }

            ShowHeaderOfList();

            foreach (var l in lines)
            {
                var parts = l.Split(",");
                Console.Write(parts[0]);
                Console.Write("\t\t\t" + parts[1]);
            }
            Console.WriteLine();

            static void ShowHeaderOfList()
            {
                SetColors.Red();
                Console.Write("Date Time\t\t\t\t");
                SetColors.Cyan();
                Console.Write("Description\n");
                SetColors.Red();
                Console.Write("---------");
                SetColors.Cyan();
                Console.WriteLine("\t\t\t\t-----------");
                SetColors.Default();
            }
        }
    }
}
