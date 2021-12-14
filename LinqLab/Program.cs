using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int> { 10, 2330, 112233, 10, 949, 3764, 2942};
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            Console.WriteLine("Finding the Min and Max of the nums list: ");
            int min = nums.Min();
            int max = nums.Max();

            Console.WriteLine(min);
            Console.WriteLine();
            Console.WriteLine(max);

            Console.WriteLine();
            Console.WriteLine("Find the Max value less than 10000");
            Console.WriteLine($"Answer: {nums.Where(x=>x<10000).Max()}");
            Console.WriteLine();
            Console.WriteLine("Find all values between 10 and 100: ");
            Console.WriteLine();
            List<int> betwenn10and100 = nums.Where(x => x > 10 && x < 100).ToList();
            Console.WriteLine("For each loop: ");
            foreach (int item in betwenn10and100)
            {
                Console.WriteLine(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Find all values between 100000 and 999999");
            List<int> between100000and999999 = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            Console.WriteLine("For each loop: ");
            foreach (int item in between100000and999999)
            {
                Console.WriteLine(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("All even numbers");
            Console.WriteLine($"even: {nums.Count(x => x%2==0)}");

            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("For students questions");
            Console.WriteLine();
            Console.WriteLine("All students 21 and over");
            List<Student> canDrink = students.Where(x => x.Age >= 21).ToList();
            Console.WriteLine("Final Answer: ");
            foreach (Student item in canDrink)
            {
                Console.WriteLine(item.Name); 
            }
            Console.WriteLine();
            Console.WriteLine("Find the oldest Student");
            int oldestStudent = students.Max(s => s.Age);
            Student old = students.Where(s => s.Age == oldestStudent).First();
            Console.WriteLine($"{old.Name}");
            Console.WriteLine();

            Console.WriteLine("Find the youngest student");
            int youngestStudent = students.Min(s => s.Age);
            Student young = students.Where(s => s.Age == youngestStudent).First();
            Console.WriteLine($"{young.Name}");
            Console.WriteLine();



            //Find the min value 

        }

        
    }
}
