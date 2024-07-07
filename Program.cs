using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentAssignments = 5;

            //Sophia 5 Assignment Marks
            Console.WriteLine("Enter the sophia1 Mark:");
            int sophia1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sophia2 Mark:");
            int sophia2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sophia3 Mark:");
            int sophia3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sophia4 Mark:");
            int sophia4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sophia5 Mark:");
            int sophia5 = Convert.ToInt32(Console.ReadLine());
            //Nicolas 5 Assignment Marks
            Console.WriteLine("Enter the nicolas1 Mark:");
            int nicolas1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the nicolas2 Mark:");
            int nicolas2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the nicolas3 Mark:");
            int nicolas3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the nicolas4 Mark:");
            int nicolas4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the nicolas5 Mark:");
            int nicolas5 = Convert.ToInt32(Console.ReadLine());
            //zahirah 5 Assignmet Marks
            Console.WriteLine("Enter the zahirah1 Mark:");
            int zahirah1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the zahirah2 Mark:");
            int zahirah2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the zahirah3 Mark:");
            int zahirah3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the zahirah4 Mark:");
            int zahirah4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the zahirah5 Mark:");
            int zahirah5 = Convert.ToInt32(Console.ReadLine());
            //jeong 5 Assignment Marks
            Console.WriteLine("Enter the jeong1 Mark:");
            int jeong1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the jeong2 Mark:");
            int jeong2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the jeong3 Mark:");
            int jeong3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the jeong4 Mark:");
            int jeong4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the jeong5" +
                " Mark:");
            int jeong5 = Convert.ToInt32(Console.ReadLine());

            int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
            decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
            decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
            decimal jeongScore = (decimal)jeongSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade");
            Console.WriteLine("Sophia :\t " + sophiaScore + "\t A");
            Console.WriteLine("Nicolas:\t " + nicolasScore + "\t B");
            Console.WriteLine("Zahirah:\t " + zahirahScore + "\t B");
            Console.WriteLine("Jeong  :\t " + jeongScore + "\t A");
        }
    }
}

