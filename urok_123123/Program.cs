using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok_123123
{
    class Program
    {

        struct Task
        {
            public string name;
            public string desc;
        }
        const byte MAX_TASKS = 2;
        static void Main()
        {
            byte taskCounter = 0;
            Task[] tasks = new Task[MAX_TASKS];
            string inputControll = "";
            do
            {
                Console.WriteLine("Menu: \n1 - Get task\n2 - Add task\n3 - Update task\n4 - Remov task\n0- Exit");
                inputControll = Console.ReadLine();
                Console.Clear();
                switch (inputControll)
           
                {
                    case "1":
                        foreach (Task item in tasks)
                        {

                        }
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "0":
                        Console.WriteLine("выход");
                        break;
                    default: Console.WriteLine("no com");
                        break;
                        

                }
            } while (taskCounter != MAX_TASKS);

            Task supertask = CreateTask();
            Console.WriteLine("Super TASK");
            ShowTask(supertask);
            Console.ReadLine();
        }

        static Task CreateTask()
        {
            Console.WriteLine("input  task name: ");
            string inputName = Console.ReadLine();
            Console.WriteLine("input task description");
            string inputDesc = Console.ReadLine();
            return  new Task { name = inputName, desc = inputDesc };
            
        }
        static void ShowTask(Task task) =>
            Console.WriteLine($"create task: \n{task.name}\n{task.desc}");
    }
 }
