using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> taskList = new List<string>();
        Tasks tasks = new Tasks();
        byte number;

        Console.WriteLine("\t\tVazifalar boshqarish dasturiga hush kelibsiz !!!\n");
        Console.Write("1-vazifani kiriting: ");
        string task = Console.ReadLine();
        taskList.Add(task);
        while (true)
        {
            Console.WriteLine("\t\t\nSizning vazifalar jadvalingiz:\n");
            for (int count = 0; count < taskList.Count; count++)
            {
                Console.WriteLine($"\t{count + 1}. {taskList[count]}");
            }
            Console.WriteLine("\nQanday amal bajarishni hohlaysiz !!!");
            Console.WriteLine("\n\tQo'shish - 1\n\tO'chirish - 2\n\tBelgilash - 3\n\tTugatish - 4");
            Console.Write("\nAmal raqamini kiriting: ");
            byte.TryParse(Console.ReadLine(), out number);
            if (number == 4) break;
            switch (number)
            {
                case 1:
                    tasks.Add(taskList);
                    break;
                case 2:
                    tasks.Remove(taskList);
                    break;
                case 3:
                    tasks.Mark(taskList);
                    break;
                default:
                    Console.WriteLine("bunday Tartib mavjud emas !!!\n\tQayta kiriting !!!"); Console.ReadLine();
                    break;
            }
            Console.Clear();
        }
        Console.WriteLine("\nBizning dasturdan foydalanganingiz uchun raxmat !!!");
    }
}
 class Tasks
 {
     public List<string> Add(List<string> addList)
     {
         Console.Write("Yangi vazifa kiriting: ");
         string addNewTask = Console.ReadLine();
         addList.Add(addNewTask);
         return addList;
     }
     public List<string> Remove(List<string> removeList)         
     {
         int count = 1;
         string removeTasks;
         if (removeList.Count == 1)
         {
             removeList.RemoveAt(0);
             return removeList;
         }
         Console.Write("O'chirmoqchi bo'lgan vazifalaringizni indeksini\n\",\" orqali kiriting masalan(1,2,3,...): ");
         removeTasks = Console.ReadLine();
         string[] removeTaskString  = removeTasks.Split(',');
         int[] indexEeach =new int[removeTaskString.Length];
         for (int i = 0; i < removeTaskString.Length; i++)
             indexEeach[i]=Convert.ToInt32(removeTaskString[i]);
         for (int i = 0; i < indexEeach.Length;i++)
             removeList.RemoveAt(indexEeach[i]-count++);
         return removeList;
     }
     public List<string> Mark(List<string> markList)
     {
         if(markList.Count==1)
         {
             markList[0] += " (Belgilangan)";
             return markList;
         }
         Console.Write("Belgilamoqchi bo'lgan vazifalaringizni indeksini\n\",\" orqali kiriting masalan(1,2,3,...): ");
         string markTask = Console.ReadLine();
         string[] markTaskString = markTask.Split(',');
         int[] indexEachMark = new int[markTaskString.Length];
         for (int i = 0; i < markTaskString.Length; i++)
             indexEachMark[i] = Convert.ToInt32(markTaskString[i]);
         for (int index = 0; index <indexEachMark.Length ; index++)
             markList[indexEachMark[index]-1] += " (Belgilangan)";
         return markList;
     }
 }

