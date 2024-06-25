using System.Text;

namespace taskole
{
    public static class Crud
    {
        public static string path = "tasks/";
        public static string file = "test1.txt";
        public static int lineNumber = 1;

        public static void AddTask(string[] msg)
        {
            StringBuilder message = new StringBuilder();

            foreach (var word in msg)
            {
                if (word != "add")
                {
                    message.Append(word);
                    message.Append(' ');
                }
            }

            try
            {
                string time = $"{DateTime.Now.ToString()},";
                File.AppendAllText((path + file), $"{lineNumber.ToString()},");
                File.AppendAllText((path + file), $"{time}");
                File.AppendAllText((path + file), $"{message.ToString()}");
                File.AppendAllText((path + file), "\n");
            }
            catch (Exception e)
            {
                SetColors.Red();
                Console.WriteLine(e.ToString());
                SetColors.Default();
            }
            lineNumber += 1;

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
                Console.WriteLine("\t" + parts[1] + "\t\t\t" + parts[2]);
            }
            Console.WriteLine();

            static void ShowHeaderOfList()
            {
                SetColors.Red();
                Console.Write("ID\t");
                Console.Write("Date Time\t\t\t\t");
                SetColors.Cyan();
                Console.WriteLine("Description");
                SetColors.Red();
                Console.Write("--\t" + "---------");
                SetColors.Cyan();
                Console.WriteLine("\t\t\t\t-----------");
                SetColors.Default();
            }
        }
    }
}
