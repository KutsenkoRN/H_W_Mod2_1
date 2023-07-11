using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_2_1
{
    internal class Starter
    {
        private static readonly Logger Logger = Logger.Instance;
        private readonly Actions actions;

        public Starter()
        {
            actions = new Actions();
        }

        public void Run()
        {
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int randomNumber = random.Next(1, 4);

                switch (randomNumber)
                {
                    case 1:
                        actions.GetStart();
                        break;
                    case 2:
                        actions.GetSkipLogic();
                        break;
                    case 3:
                        Result result = actions.BreakLogic();
                        if (!result.Status)
                        {
                            Console.WriteLine($"Error occurred: {result.ErrorMessage}");
                        }
                        break;
                    default:
                        break;
                }
            }

            string allLogs = Logger.GetMessage();
            File.WriteAllText("log.txt", allLogs);
        }
    }
}
