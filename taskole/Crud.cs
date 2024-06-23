using System.Text;

namespace taskole
{
    public static class Crud
    {
        public static void AddTask(string[] msg)
        {
            string path = "tasks/";
            string file = "test1.txt";
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
            catch(Exception e)
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
    }
}
