using System;


//first attempt
public class Worker
{
    static void Main()
    {
        Dictionary<string, int> workerList = new Dictionary<string, int>();    

        Console.WriteLine("Enter worker name: ");
        string workerName = Console.ReadLine();
        Console.WriteLine("Enter salary: ");
        int workerSalary = int.Parse(Console.ReadLine());
        workerList.Add(workerName, workerSalary);

        
        foreach (KeyValuePair<string, int> item in workerList) {
            Console.WriteLine("Worker :{0}, has salary : {1}", item.Key, item.Value);
        }
    }
}
