using System;
using System.Collections.Generic;


//second attempt
public class Worker
{
    static void Main()
    {
        Dictionary<string, int> workerList = new Dictionary<string, int>();
        while (true)
        {
            Console.WriteLine("Enter worker name: (enter 'exit' to print register) ");
            string workerName = Console.ReadLine().Trim();

            if (workerName.ToLower() == "exit")
            {
                break;
            }

            if (string.IsNullOrEmpty(workerName))
            {
                Console.WriteLine("Wrong name. Enter correct name!");
                continue;

            }
            if (workerList.ContainsKey(workerName))
            {
                Console.WriteLine($"Worker {workerName} already exist. Enter new worker");
                continue;
            }



            int workerSalary = 0; ;
            bool isValidSalary = false;
            while (!isValidSalary)
            {
                Console.WriteLine("Enter worker salary: ");
                if (int.TryParse(Console.ReadLine(), out workerSalary))

                {
                    isValidSalary = true;
                }

                else
                {
                    Console.WriteLine("Wrong input. Enter correct salary!");

                }


            }
            workerList.Add(workerName, workerSalary);
        }      
        
          foreach (KeyValuePair<string, int> item in workerList) {
          Console.WriteLine("Worker :{0}, has salary : {1}", item.Key, item.Value);
       }
    }
}
