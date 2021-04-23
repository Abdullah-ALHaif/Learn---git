using System;
using System.Collections.Generic;

namespace Class0205_List
{
   
    class Program
    {
        

        public static List<string> sameGrade(int grade, List<string> name,List<int> grades)
        {
            
            List<string> results = new List<string>();
            for (int i=0;i<grades.Count;i++)
            {
                if (grade==grades[i])
                {
                    results.Add(name[i]);
                    
                }
            }
            
            return results;
        }
        static void Main(string[] args)
        {
            List<int> Num = new List<int>();
            List<string> name = new List<string>();
            List<string> results = new List<string>();
            string x = "";
            
            while (x!="x")
            {
                Console.WriteLine("Please enter the student's name: ");
                name.Add(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Please enter their grade: ");
                Num.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Clear();
                Console.WriteLine("To continue, please press 'Enter' or press 'x' to exit..");
                x = Console.ReadLine();
                Console.Clear();

            }
            
            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine("Name: " + name[i] + "\tGrade: " + Num[i]);
            }

            Console.WriteLine();

            int gradeSearch = 0;
            Console.WriteLine("Searching for a grade?");
            x = Console.ReadLine();
            if (x == "yes" || x == "Yes")
            {
                Console.WriteLine("Please Enter the grade that you are looking for: ");
                gradeSearch = Convert.ToInt32(Console.ReadLine());
                results = sameGrade(gradeSearch, name, Num);
                Console.WriteLine("The following are the students who have the same grade and their number is: " + results.Count);
                foreach (var item in results)
                {
                    Console.Write(item+"\t");
                }
                Console.WriteLine();
            }
            

        }
    }
}
