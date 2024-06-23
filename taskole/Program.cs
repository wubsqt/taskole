using System.ComponentModel.Design;

namespace taskole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Actions.Initial();

            while (true)
            {
                Console.Write("> ");
                string? command = Console.ReadLine();
                string[] words = command.Split(" ").ToArray();

                #region Check the special Commands
                if (command == "exit")
                {
                    Actions.Exit();
                    break;
                }

                else if (command == "clear")
                {
                    Actions.ClearScreen();
                    continue;
                }

                else if (command == "")
                {
                    ExceptionsHandling.EmptyCommand();
                    continue;
                }
                #endregion

                #region The CRUD Actions is check here
                switch (words[0])
                {
                    case "add":
                        {
                            Crud.AddTask(words);
                            continue;
                        }

                    case "remove":
                        {
                            Crud.RemoveTask();
                            continue;
                        }

                    case "list":
                        {
                            Crud.GetTaskList();
                            continue;
                        }

                    default:
                        {
                            ExceptionsHandling.CommandNotValid();
                            continue;
                        }
                }
                #endregion
            }
        }
    }
}
