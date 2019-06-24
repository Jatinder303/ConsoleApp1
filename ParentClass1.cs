using System;
using System.Collections;

namespace ConsoleApp1
{
    public interface Parent1
    {
        void languages_Level5();
        void content();
    }
    class ParentClass1 : Parent1
    {
        public void content()
        {
            Console.WriteLine(" Content of Level 5");
        }

        public void languages_Level5()
        {
            // Creating ArrayList 
            ArrayList My_list = new ArrayList();

            // Adding elements in the 
            // My_list ArrayList 
            My_list.Add("HTML");
            My_list.Add("CSS");
            My_list.Add("BootStrap");
            My_list.Add("JavaScript");
            My_list.Add("SQL");
            My_list.Add("PHP");

            Console.WriteLine("Languages taught in Level 5:");
            foreach (var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }
}

